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

namespace SitefinityWebApp.obj.Release.Package.PackageTmp.ResourcePackages.Bootstrap4.MVC.Views.Breadcrumb
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
    
    #line 3 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/obj/Release/Package/PackageTmp/ResourcePackages/Bootstrap4/MVC/Views/Breadcrumb" +
        "/Breadcrumb.cshtml")]
    public partial class Breadcrumb : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.Breadcrumb.BreadcrumbViewModel>
    {
        public Breadcrumb()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 142), Tuple.Create("\"", 165)
            
            #line 5 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
, Tuple.Create(Tuple.Create("", 150), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 150), false)
);

WriteLiteral(">\n    <nav");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 176), Tuple.Create("\"", 229)
            
            #line 6 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
, Tuple.Create(Tuple.Create("", 189), Tuple.Create<System.Object, System.Int32>(Html.Resource("BreadcrumbShowFullPath")
            
            #line default
            #line hidden
, 189), false)
);

WriteLiteral(">\n        <ol");

WriteLiteral(" class=\"sf-breadscrumb breadcrumb\"");

WriteLiteral(">\n");

            
            #line 8 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
            
            
            #line default
            #line hidden
            
            #line 8 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
             for (int i = 0; i < Model.SiteMapNodes.Count; i++)
            {
                var node = Model.SiteMapNodes[i];

                if (i == Model.SiteMapNodes.Count - 1 && Model.ShowCurrentPageInTheEnd)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" class=\"breadcrumb-item active\"");

WriteLiteral(" aria-current=\"page\"");

WriteLiteral(">");

            
            #line 14 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
                                                                      Write(node.Title);

            
            #line default
            #line hidden
WriteLiteral("</li>\n");

            
            #line 15 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" class=\"breadcrumb-item\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 713), Tuple.Create("\"", 729)
            
            #line 18 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
, Tuple.Create(Tuple.Create("", 720), Tuple.Create<System.Object, System.Int32>(node.Url
            
            #line default
            #line hidden
, 720), false)
);

WriteLiteral(">");

            
            #line 18 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
                                                               Write(node.Title);

            
            #line default
            #line hidden
WriteLiteral(" </a></li>\n");

            
            #line 19 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </ol>\n    </nav>\n</div>");

        }
    }
}
#pragma warning restore 1591
