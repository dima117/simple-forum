using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using SimpleForum.Domain.Dto;
using SimpleForum.Domain.Model;

namespace SimpleForum.Domain
{
	public class SimpleForumDbContext : DbContext
	{
		public SimpleForumDbContext()
			: base("SimpleForum.MainDB")
		{
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{

			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


		}

		public DbSet<User> Users { get; set; }
		public DbSet<Reply> Replies { get; set; }
		public DbSet<Topic> Topics { get; set; }
		public DbSet<Section> Sections { get; set; }

		public List<SectionDto> GetSections()
		{
			var sections = Sections
						.OrderBy(s => s.SortOrder)
						.Select(s => new SectionDto
						{
							Id = s.Id,
							Title = s.Title,
							Description = s.Description,
							TopicCount = s.Topics.Count,
							ReplyCount = s.Topics.Sum(t => t.Replies.Count),
							LastReply = s.Topics
								.SelectMany(t => t.Replies)
								.OrderByDescending(r => r.Created)
								.Select(r =>
									new ReplyDto
									{
										Created = r.Created,
										AuthorId = r.AuthorId,
										AuthorDisplayName = r.Author.DisplayName,
										TopicId = r.TopicId,
										TopicSubject = r.Topic.Subject
									})
								.FirstOrDefault()
						})
						.ToList();

			return sections;
		}

		public List<TopicDto> GetTopics(Guid sectionId)
		{
			var topics = Topics
				.Where(t => t.SectionId == sectionId)
				.Select(t => new TopicDto
				{
					Id = t.Id,
					Subject = t.Subject,
					Created = t.Created,
					AuthorId = t.AuthorId,
					AuthorDisplayName = t.Author.DisplayName,
					ReplyCount = t.Replies.Count,
					LastReply = t.Replies
						.OrderByDescending(r => r.Created)
						.Select(r =>
							new ReplyDto
							{
								Created = r.Created,
								AuthorId = r.AuthorId,
								AuthorDisplayName = r.Author.DisplayName,
								TopicId = r.TopicId,
								TopicSubject = r.Topic.Subject
							})
						.FirstOrDefault()
				})
				.ToList();

			var sortedTopics = topics
				.OrderByDescending(t => t.SortOrder)
				.ToList();

			return sortedTopics;
		}
	}
}
