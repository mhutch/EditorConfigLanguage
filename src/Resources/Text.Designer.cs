﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EditorConfig.Resources {
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
    internal class Text {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Text() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EditorConfig.Resources.Text", typeof(Text).Assembly);
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
        ///   Looks up a localized string similar to An .editorconfig file already exist in this location.
        /// </summary>
        internal static string EditorConfigFileAlreadyExist {
            get {
                return ResourceManager.GetString("EditorConfigFileAlreadyExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Format document.
        /// </summary>
        internal static string FormatDocument {
            get {
                return ResourceManager.GetString("FormatDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; is not a valid value for the &quot;{1}&quot; property&quot;.
        /// </summary>
        internal static string InvalidValue {
            get {
                return ResourceManager.GetString("InvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File character encoding, NOTE: if visual studio thinks your file is ascii it will always save it as us-ascii.
        /// </summary>
        internal static string KeywordCharset {
            get {
                return ResourceManager.GetString("KeywordCharset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Line ending file format (Unix, DOS, Mac).
        /// </summary>
        internal static string KeywordEndOfLine {
            get {
                return ResourceManager.GetString("KeywordEndOfLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A whole number defining the number of columns used for each indentation level and the width of soft tabs (when supported). When set to tab, the value of tab_width (if specified) will be used.
        /// </summary>
        internal static string KeywordIndentSize {
            get {
                return ResourceManager.GetString("KeywordIndentSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Indentation Style.
        /// </summary>
        internal static string KeywordIndentStyle {
            get {
                return ResourceManager.GetString("KeywordIndentStyle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Denotes whether file should end with a newline.
        /// </summary>
        internal static string KeywordInsertFinalNewline {
            get {
                return ResourceManager.GetString("KeywordInsertFinalNewline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Special property that should be specified at the top of the file outside of any sections. Set to “true” to stop .editorconfig files search on current file..
        /// </summary>
        internal static string KeywordRoot {
            get {
                return ResourceManager.GetString("KeywordRoot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A whole number defining the number of columns used to represent a tab character. This defaults to the value of indent_size and doesn&apos;t usually need to be specified..
        /// </summary>
        internal static string KeywordTabWidth {
            get {
                return ResourceManager.GetString("KeywordTabWidth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Denotes whether whitespace is allowed at the end of lines.
        /// </summary>
        internal static string KeywordTrimTrailingWhitespace {
            get {
                return ResourceManager.GetString("KeywordTrimTrailingWhitespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported by Visual Studio.
        /// </summary>
        internal static string NotSupportedByVS {
            get {
                return ResourceManager.GetString("NotSupportedByVS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Violations are marked with a red squiggle in the editor and appear under Errors in the Error List.
        /// </summary>
        internal static string SeverityError {
            get {
                return ResourceManager.GetString("SeverityError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Has no editor treatment and does not appear in Error List but affects code generation.
        /// </summary>
        internal static string SeverityNone {
            get {
                return ResourceManager.GetString("SeverityNone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Violations are dotted in the editor and appear under Messages in Error List.
        /// </summary>
        internal static string SeveritySuggestion {
            get {
                return ResourceManager.GetString("SeveritySuggestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Violations are marked with a green squiggle in the editor and appear under Warnings in the Error List.
        /// </summary>
        internal static string SeverityWarning {
            get {
                return ResourceManager.GetString("SeverityWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The keyword &quot;{0}&quot; is unknown.
        /// </summary>
        internal static string ValidateUnknownKeyword {
            get {
                return ResourceManager.GetString("ValidateUnknownKeyword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property has already been defined in this section.
        /// </summary>
        internal static string ValidationDuplicateProperty {
            get {
                return ResourceManager.GetString("ValidationDuplicateProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A section with the value &quot;{0}&quot; has already been defined.
        /// </summary>
        internal static string ValidationDuplicateSection {
            get {
                return ResourceManager.GetString("ValidationDuplicateSection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Values must not end with a {0}.
        /// </summary>
        internal static string ValidationInvalidEndChar {
            get {
                return ResourceManager.GetString("ValidationInvalidEndChar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Severity is invalid. Must be one of these values: {0}.
        /// </summary>
        internal static string ValidationInvalidSeverity {
            get {
                return ResourceManager.GetString("ValidationInvalidSeverity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A severity must be specified. Example: true:warning.
        /// </summary>
        internal static string ValidationMissingSeverity {
            get {
                return ResourceManager.GetString("ValidationMissingSeverity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Root&quot; is only allowed in the beginning of the document.
        /// </summary>
        internal static string ValidationRootInSection {
            get {
                return ResourceManager.GetString("ValidationRootInSection", resourceCulture);
            }
        }
    }
}
