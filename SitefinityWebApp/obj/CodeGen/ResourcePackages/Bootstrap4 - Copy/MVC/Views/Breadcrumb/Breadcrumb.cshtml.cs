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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4___Copy.MVC.Views.Breadcrumb
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4 - Copy/MVC/Views/Breadcrumb/Breadcrumb.cshtml")]
    public partial class Breadcrumb : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.Breadcrumb.BreadcrumbViewModel>
    {
        public Breadcrumb()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 146), Tuple.Create("\"", 169)
            
            #line 5 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
, Tuple.Create(Tuple.Create("", 154), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 154), false)
);

WriteLiteral(">\r\n    <nav");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 181), Tuple.Create("\"", 234)
            
            #line 6 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
, Tuple.Create(Tuple.Create("", 194), Tuple.Create<System.Object, System.Int32>(Html.Resource("BreadcrumbShowFullPath")
            
            #line default
            #line hidden
, 194), false)
);

WriteLiteral(">\r\n        <ol");

WriteLiteral(" class=\"sf-breadscrumb breadcrumb\"");

WriteLiteral(">\r\n");

            
            #line 8 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
            
            
            #line default
            #line hidden
            
            #line 8 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
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

            
            #line 14 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
                                                                      Write(node.Title);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 15 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" class=\"breadcrumb-item\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 730), Tuple.Create("\"", 746)
            
            #line 18 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
, Tuple.Create(Tuple.Create("", 737), Tuple.Create<System.Object, System.Int32>(node.Url
            
            #line default
            #line hidden
, 737), false)
);

WriteLiteral(">");

            
            #line 18 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
                                                               Write(node.Title);

            
            #line default
            #line hidden
WriteLiteral(" </a></li>\r\n");

            
            #line 19 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Breadcrumb\Breadcrumb.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </ol>\r\n    </nav>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
