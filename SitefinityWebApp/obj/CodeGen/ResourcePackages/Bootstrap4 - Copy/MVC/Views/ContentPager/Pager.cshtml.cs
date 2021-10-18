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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4___Copy.MVC.Views.ContentPager
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4 - Copy/MVC/Views/ContentPager/Pager.cshtml")]
    public partial class Pager : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Helpers.ViewModels.PagerViewModel>
    {
        public Pager()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<nav");

WriteLiteral(" role=\"navigation\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 149), Tuple.Create("\"", 190)
            
            #line 5 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
, Tuple.Create(Tuple.Create("", 162), Tuple.Create<System.Object, System.Int32>(Html.Resource("Pagination")
            
            #line default
            #line hidden
, 162), false)
);

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"pagination\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
        
            
            #line default
            #line hidden
            
            #line 7 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
         if (Model.PreviousNode != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"page-item\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"page-link\"");

WriteAttribute("href", Tuple.Create(" href=\"", 348), Tuple.Create("\"", 427)
            
            #line 10 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
, Tuple.Create(Tuple.Create("", 355), Tuple.Create<System.Object, System.Int32>(String.Format(Model.RedirectUrlTemplate, Model.PreviousNode.PageNumber)
            
            #line default
            #line hidden
, 355), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 428), Tuple.Create("\"", 475)
            
            #line 10 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
                                                  , Tuple.Create(Tuple.Create("", 441), Tuple.Create<System.Object, System.Int32>(Html.Resource("GoToPreviousPage")
            
            #line default
            #line hidden
, 441), false)
);

WriteLiteral(">\r\n                    <span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&laquo;</span>\r\n                </a>\r\n            </li>\r\n");

            
            #line 14 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 15 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
         foreach (var page in Model.PagerNodes.OrderBy(x => x.PageNumber))
        {
            if (Model.CurrentPage == page.PageNumber)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" class=\"active page-item\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"page-link\"");

WriteLiteral(" aria-current=\"true\"");

WriteAttribute("href", Tuple.Create(" href=\"", 856), Tuple.Create("\"", 921)
            
            #line 20 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
, Tuple.Create(Tuple.Create("", 863), Tuple.Create<System.Object, System.Int32>(String.Format(Model.RedirectUrlTemplate, page.PageNumber)
            
            #line default
            #line hidden
, 863), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 922), Tuple.Create("\"", 974)
            
            #line 20 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
                                                            , Tuple.Create(Tuple.Create("", 935), Tuple.Create<System.Object, System.Int32>(Html.Resource("Page")
            
            #line default
            #line hidden
, 935), false)
            
            #line 20 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
                                                                                  , Tuple.Create(Tuple.Create(" ", 957), Tuple.Create<System.Object, System.Int32>(page.PageNumber
            
            #line default
            #line hidden
, 958), false)
);

WriteLiteral(">");

            
            #line 20 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
                                                                                                                                                                               Write(page.PageNumber);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </li>\r\n");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" class=\"page-item\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"page-link\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1149), Tuple.Create("\"", 1214)
            
            #line 26 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
, Tuple.Create(Tuple.Create("", 1156), Tuple.Create<System.Object, System.Int32>(String.Format(Model.RedirectUrlTemplate, page.PageNumber)
            
            #line default
            #line hidden
, 1156), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1215), Tuple.Create("\"", 1271)
            
            #line 26 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
                                       , Tuple.Create(Tuple.Create("", 1228), Tuple.Create<System.Object, System.Int32>(Html.Resource("GoToPage")
            
            #line default
            #line hidden
, 1228), false)
            
            #line 26 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
                                                                 , Tuple.Create(Tuple.Create(" ", 1254), Tuple.Create<System.Object, System.Int32>(page.PageNumber
            
            #line default
            #line hidden
, 1255), false)
);

WriteLiteral(">");

            
            #line 26 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
                                                                                                                                                               Write(page.PageNumber);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </li>\r\n");

            
            #line 28 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
            }
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 30 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
         if (Model.NextNode != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"page-item\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"page-link\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1465), Tuple.Create("\"", 1540)
            
            #line 33 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
, Tuple.Create(Tuple.Create("", 1472), Tuple.Create<System.Object, System.Int32>(String.Format(Model.RedirectUrlTemplate, Model.NextNode.PageNumber)
            
            #line default
            #line hidden
, 1472), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1541), Tuple.Create("\"", 1584)
            
            #line 33 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
                                             , Tuple.Create(Tuple.Create("", 1554), Tuple.Create<System.Object, System.Int32>(Html.Resource("GoToNextPage")
            
            #line default
            #line hidden
, 1554), false)
);

WriteLiteral(">\r\n                    <span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&raquo;</span>\r\n                </a>\r\n            </li>\r\n");

            
            #line 37 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\ContentPager\Pager.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</nav>");

        }
    }
}
#pragma warning restore 1591
