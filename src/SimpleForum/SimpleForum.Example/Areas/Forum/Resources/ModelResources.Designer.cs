﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleForum.Web.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ModelResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ModelResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SimpleForum.Web.Resources.ModelResources", typeof(ModelResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forum.
        /// </summary>
        public static string Forum {
            get {
                return ResourceManager.GetString("Forum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email address.
        /// </summary>
        public static string LoginEmail {
            get {
                return ResourceManager.GetString("LoginEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password.
        /// </summary>
        public static string LoginPassword {
            get {
                return ResourceManager.GetString("LoginPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remember me.
        /// </summary>
        public static string LoginRememberMe {
            get {
                return ResourceManager.GetString("LoginRememberMe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm your password.
        /// </summary>
        public static string RegistrationConfirmPassword {
            get {
                return ResourceManager.GetString("RegistrationConfirmPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Display name.
        /// </summary>
        public static string RegistrationDisplayName {
            get {
                return ResourceManager.GetString("RegistrationDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email.
        /// </summary>
        public static string RegistrationEmail {
            get {
                return ResourceManager.GetString("RegistrationEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password.
        /// </summary>
        public static string RegistrationPassword {
            get {
                return ResourceManager.GetString("RegistrationPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password and it confirmation do not match.
        /// </summary>
        public static string RegistrationPasswordMismatch {
            get {
                return ResourceManager.GetString("RegistrationPasswordMismatch", resourceCulture);
            }
        }
    }
}