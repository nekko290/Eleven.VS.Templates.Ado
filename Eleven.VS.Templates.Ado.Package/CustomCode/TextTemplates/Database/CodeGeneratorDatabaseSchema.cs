﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Eleven.VS.Templates.Ado.Package.CustomCode.TextTemplates.Database
{
    using Eleven.VS.Templates.Ado.Package.TextTemplates.Helper;
    using Eleven.VS.Templates.Ado.Dsl.Util;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Projects\Eleven.VS.Templates.Ado\Eleven.VS.Templates.Ado.Package\CustomCode\TextTemplates\Database\CodeGeneratorDatabaseSchema.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class CodeGeneratorDatabaseSchema : Eleven.VS.Templates.Ado.Dsl.Util.CodeGeneratorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("CREATE SCHEMA [");
            
            #line 8 "D:\Projects\Eleven.VS.Templates.Ado\Eleven.VS.Templates.Ado.Package\CustomCode\TextTemplates\Database\CodeGeneratorDatabaseSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DatabaseSchema.Name));
            
            #line default
            #line hidden
            this.Write("]\r\n    AUTHORIZATION [");
            
            #line 9 "D:\Projects\Eleven.VS.Templates.Ado\Eleven.VS.Templates.Ado.Package\CustomCode\TextTemplates\Database\CodeGeneratorDatabaseSchema.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DatabaseSchema.Owner));
            
            #line default
            #line hidden
            this.Write("];");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
