﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShapeAnimator.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ShapeAnimator.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number cannot be negative.
        /// </summary>
        internal static string Cannot_Be_Negative {
            get {
                return ResourceManager.GetString("Cannot Be Negative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot have more than 10 shapes!.
        /// </summary>
        internal static string cannotHaveMoreThan10Shapes {
            get {
                return ResourceManager.GetString("cannotHaveMoreThan10Shapes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must be an integer.
        /// </summary>
        internal static string Must_Be_Integer {
            get {
                return ResourceManager.GetString("Must Be Integer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must have a valid PictureBox or program will crash when attempting to draw the canvas..
        /// </summary>
        internal static string PictureBoxNullMessage {
            get {
                return ResourceManager.GetString("PictureBoxNullMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 0.
        /// </summary>
        internal static string zeroStringValue {
            get {
                return ResourceManager.GetString("zeroStringValue", resourceCulture);
            }
        }
    }
}
