#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.obj.Release.Package.PackageTmp.ResourcePackages.Bootstrap4.MVC.Views.HiddenField
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.StringResources;
    
    #line default
    #line hidden
    
    #line 4 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
    using Telerik.Sitefinity.Localization;
    
    #line default
    #line hidden
    
    #line 7 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/obj/Release/Package/PackageTmp/ResourcePackages/Bootstrap4/MVC/Views/HiddenFiel" +
        "d/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.HiddenField.HiddenFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 9 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
  
    string untitledLabel = Res.Get<FieldResources>().Untitled;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 13 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
 if (SystemManager.IsDesignMode && !SystemManager.IsPreviewMode)
{
    // Using sfHiddenField class this field is hidden in Page Editing mode and shown only when in Form Editing mode.

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"sf-fieldWrp sfHiddenField\"");

WriteLiteral(">\r\n        <label");

WriteAttribute("for", Tuple.Create(" for=\'", 660), Tuple.Create("\'", 695)
            
            #line 17 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 666), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("HiddenField")
            
            #line default
            #line hidden
, 666), false)
);

WriteLiteral(">\r\n");

            
            #line 18 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 18 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
             if (string.IsNullOrEmpty(Model.MetaField.FieldName))
            {
                
            
            #line default
            #line hidden
            
            #line 20 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
           Write(untitledLabel);

            
            #line default
            #line hidden
            
            #line 20 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
                              ;
            }
            else
            {
                
            
            #line default
            #line hidden
            
            #line 24 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
           Write(Model.MetaField.FieldName);

            
            #line default
            #line hidden
            
            #line 24 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
                                          ;
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n        </label>\r\n        <input");

WriteAttribute("id", Tuple.Create(" id=\'", 956), Tuple.Create("\'", 990)
            
            #line 28 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 961), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("HiddenField")
            
            #line default
            #line hidden
, 961), false)
);

WriteLiteral(" type=\"text\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1003), Tuple.Create("\"", 1036)
            
            #line 28 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1010), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 1010), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1037), Tuple.Create("\"", 1074)
            
            #line 28 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
                       , Tuple.Create(Tuple.Create("", 1045), Tuple.Create<System.Object, System.Int32>(Model.MetaField.DefaultValue
            
            #line default
            #line hidden
, 1045), false)
);

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(" />\r\n    </div>\r\n");

            
            #line 30 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("   <input");

WriteAttribute("id", Tuple.Create(" id=\'", 1133), Tuple.Create("\'", 1167)
            
            #line 33 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1138), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("HiddenField")
            
            #line default
            #line hidden
, 1138), false)
);

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1182), Tuple.Create("\"", 1215)
            
            #line 33 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1189), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 1189), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1216), Tuple.Create("\"", 1253)
            
            #line 33 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
                    , Tuple.Create(Tuple.Create("", 1224), Tuple.Create<System.Object, System.Int32>(Model.MetaField.DefaultValue
            
            #line default
            #line hidden
, 1224), false)
);

WriteLiteral(" /> \r\n");

            
            #line 34 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\HiddenField\Write.Default.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
