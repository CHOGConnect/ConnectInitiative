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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4___Copy.MVC.Views.Navigation
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4 - Copy/MVC/Views/Navigation/NavigationView.Horizont" +
        "al.cshtml")]
    public partial class NavigationView_Horizontal : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 32 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
public System.Web.WebPages.HelperResult RenderRootLevelNode(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 33 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
 
    if (node.ChildNodes.Count > 0)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1536), Tuple.Create("\"", 1577)
, Tuple.Create(Tuple.Create("", 1544), Tuple.Create("nav-item", 1544), true)
, Tuple.Create(Tuple.Create(" ", 1552), Tuple.Create("dropdown", 1553), true)

#line 36 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create(" ", 1561), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 1562), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n            <a");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-link dropdown-toggle\"");

WriteLiteralTo(__razor_helper_writer, " href=\"#\"");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\'", 1637), Tuple.Create("\'", 1682)

#line 37 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 1642), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("navbarDropdownMenuLink")

#line default
#line hidden
, 1642), false)
);

WriteLiteralTo(__razor_helper_writer, " data-toggle=\"dropdown\"");

WriteLiteralTo(__razor_helper_writer, " aria-haspopup=\"true\"");

WriteLiteralTo(__razor_helper_writer, " aria-expanded=\"false\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 37 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                                                                                                                           WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n            <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-menu\"");

WriteAttributeTo(__razor_helper_writer, "aria-labelledby", Tuple.Create(" aria-labelledby=\'", 1804), Tuple.Create("\'", 1862)

#line 38 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 1822), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("navbarDropdownMenuLink")

#line default
#line hidden
, 1822), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 39 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(node));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </ul>\r\n        </li>\r\n");


#line 42 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
    }
    else
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1984), Tuple.Create("\"", 2016)
, Tuple.Create(Tuple.Create("", 1992), Tuple.Create("nav-item", 1992), true)

#line 45 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create(" ", 2000), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 2001), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n            <a");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-link\"");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 2051), Tuple.Create("\"", 2067)

#line 46 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 2058), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 2058), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 2068), Tuple.Create("\"", 2093)

#line 46 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 2077), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 2077), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 46 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                             WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n        </li>\r\n");


#line 48 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
    }


#line default
#line hidden
});

#line 49 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
}
#line default
#line hidden

#line 52 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 53 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
 
    foreach (var childNode in node.ChildNodes)
    {
        if(childNode.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <li");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-submenu\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 2425), Tuple.Create("\"", 2467)
, Tuple.Create(Tuple.Create("", 2433), Tuple.Create("dropdown-item", 2433), true)

#line 59 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create(" ", 2446), Tuple.Create<System.Object, System.Int32>(GetClass(childNode)

#line default
#line hidden
, 2447), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 2468), Tuple.Create("\"", 2489)

#line 59 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 2475), Tuple.Create<System.Object, System.Int32>(childNode.Url

#line default
#line hidden
, 2475), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 2490), Tuple.Create("\"", 2520)

#line 59 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
            , Tuple.Create(Tuple.Create("", 2499), Tuple.Create<System.Object, System.Int32>(childNode.LinkTarget

#line default
#line hidden
, 2499), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                    ");


#line 60 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
WriteTo(__razor_helper_writer, childNode.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                    <span");

WriteLiteralTo(__razor_helper_writer, " class=\"right-caret\"");

WriteLiteralTo(__razor_helper_writer, "></span>\r\n                </a>\r\n                <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-menu\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                    ");


#line 64 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </ul>\r\n            </li>\r\n");


#line 67 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <li>\r\n                <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 2855), Tuple.Create("\"", 2897)
, Tuple.Create(Tuple.Create("", 2863), Tuple.Create("dropdown-item", 2863), true)

#line 71 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create(" ", 2876), Tuple.Create<System.Object, System.Int32>(GetClass(childNode)

#line default
#line hidden
, 2877), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 2898), Tuple.Create("\"", 2919)

#line 71 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 2905), Tuple.Create<System.Object, System.Int32>(childNode.Url

#line default
#line hidden
, 2905), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 2920), Tuple.Create("\"", 2950)

#line 71 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
            , Tuple.Create(Tuple.Create("", 2929), Tuple.Create<System.Object, System.Int32>(childNode.LinkTarget

#line default
#line hidden
, 2929), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 71 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                                                                     WriteTo(__razor_helper_writer, childNode.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n            </li>\r\n");


#line 73 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
        }
    }


#line default
#line hidden
});

#line 75 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
}
#line default
#line hidden

#line 78 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
public System.Web.WebPages.HelperResult GetClass(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 79 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
 

    if (node.IsCurrentlyOpened)
    {
        

#line default
#line hidden

#line 83 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("active"));


#line default
#line hidden

#line 83 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                    ;
    }
    else if (node.HasChildOpen)
    {
        

#line default
#line hidden

#line 87 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("active"));


#line default
#line hidden

#line 87 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                    ;
    }


#line default
#line hidden
});

#line 89 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
}
#line default
#line hidden

        public NavigationView_Horizontal()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 8 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
Write(Html.Script(Url.Content("~/ResourcePackages/Bootstrap4/assets/dist/js/popper.min.js"), "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
Write(Html.Script(Url.Content("~/ResourcePackages/Bootstrap4/assets/dist/js/bootstrap.min.js"), "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 520), Tuple.Create("\"", 543)
            
            #line 12 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 528), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 528), false)
);

WriteLiteral(">\r\n    <nav");

WriteLiteral(" class=\"navbar navbar-expand-md navbar-light bg-light\"");

WriteLiteral(">\r\n        ");

WriteLiteral("\r\n\r\n        <a");

WriteLiteral(" class=\"navbar-brand\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Navbar</a>\r\n        <button");

WriteLiteral(" class=\"navbar-toggler\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\'#");

            
            #line 17 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                                                                     Write(Html.UniqueId("navbar"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteAttribute("aria-controls", Tuple.Create(" aria-controls=\'", 865), Tuple.Create("\'", 905)
            
            #line 17 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                                    , Tuple.Create(Tuple.Create("", 881), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("navbar")
            
            #line default
            #line hidden
, 881), false)
);

WriteLiteral(" aria-expanded=\"false\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 928), Tuple.Create("\"", 975)
            
            #line 17 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                                                                                                , Tuple.Create(Tuple.Create("", 941), Tuple.Create<System.Object, System.Int32>(Html.Resource("ToggleNavigation")
            
            #line default
            #line hidden
, 941), false)
);

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"navbar-toggler-icon\"");

WriteLiteral("></span>\r\n        </button>\r\n        <div");

WriteLiteral(" class=\"collapse navbar-collapse\"");

WriteAttribute("id", Tuple.Create(" id=\'", 1098), Tuple.Create("\'", 1127)
            
            #line 20 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 1103), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("navbar")
            
            #line default
            #line hidden
, 1103), false)
);

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"navbar-nav flex-wrap\"");

WriteLiteral(">\r\n");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                
            
            #line default
            #line hidden
            
            #line 22 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                 foreach (var node in Model.Nodes)
                {
                    
            
            #line default
            #line hidden
            
            #line 24 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
               Write(RenderRootLevelNode(node));

            
            #line default
            #line hidden
            
            #line 24 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                              ;
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n        </div>\r\n    </nav>\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
