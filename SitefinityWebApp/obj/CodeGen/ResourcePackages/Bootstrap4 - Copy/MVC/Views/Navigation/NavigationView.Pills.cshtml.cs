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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4 - Copy/MVC/Views/Navigation/NavigationView.Pills.cs" +
        "html")]
    public partial class NavigationView_Pills : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 26 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
public System.Web.WebPages.HelperResult RenderRootLevelNode(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 27 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
 
    if (node.ChildNodes.Count > 0)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-item dropdown\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1044), Tuple.Create("\"", 1092)
, Tuple.Create(Tuple.Create("", 1052), Tuple.Create("nav-link", 1052), true)
, Tuple.Create(Tuple.Create(" ", 1060), Tuple.Create("dropdown-toggle", 1061), true)

#line 31 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 1076), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 1077), false)
);

WriteLiteralTo(__razor_helper_writer, " data-toggle=\"dropdown\"");

WriteLiteralTo(__razor_helper_writer, " href=\"#\"");

WriteLiteralTo(__razor_helper_writer, " role=\"button\"");

WriteLiteralTo(__razor_helper_writer, " aria-haspopup=\"true\"");

WriteLiteralTo(__razor_helper_writer, " aria-expanded=\"false\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 31 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                                                                                                           WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-menu\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 33 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(node));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </div>\r\n        </li>\r\n");


#line 36 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
    }
    else
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-item\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1394), Tuple.Create("\"", 1426)
, Tuple.Create(Tuple.Create("", 1402), Tuple.Create("nav-link", 1402), true)

#line 40 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 1410), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 1411), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1427), Tuple.Create("\"", 1443)

#line 40 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1434), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 1434), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 1444), Tuple.Create("\"", 1469)

#line 40 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1453), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 1453), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 40 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                                             WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n        </li>\r\n");


#line 42 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
    }


#line default
#line hidden
});

#line 43 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
}
#line default
#line hidden

#line 46 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 47 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
 
    foreach (var childNode in node.ChildNodes)
    {
        if(childNode.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-submenu\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1802), Tuple.Create("\"", 1844)
, Tuple.Create(Tuple.Create("", 1810), Tuple.Create("dropdown-item", 1810), true)

#line 53 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 1823), Tuple.Create<System.Object, System.Int32>(GetClass(childNode)

#line default
#line hidden
, 1824), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1845), Tuple.Create("\"", 1866)

#line 53 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1852), Tuple.Create<System.Object, System.Int32>(childNode.Url

#line default
#line hidden
, 1852), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 1867), Tuple.Create("\"", 1897)

#line 53 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
            , Tuple.Create(Tuple.Create("", 1876), Tuple.Create<System.Object, System.Int32>(childNode.LinkTarget

#line default
#line hidden
, 1876), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                    ");


#line 54 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, childNode.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                    <span");

WriteLiteralTo(__razor_helper_writer, " class=\"right-caret\"");

WriteLiteralTo(__razor_helper_writer, "></span>\r\n                </a>\r\n                <div");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-menu\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                    ");


#line 58 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </div>\r\n            </div>\r\n");


#line 61 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 2213), Tuple.Create("\"", 2255)
, Tuple.Create(Tuple.Create("", 2221), Tuple.Create("dropdown-item", 2221), true)

#line 64 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 2234), Tuple.Create<System.Object, System.Int32>(GetClass(childNode)

#line default
#line hidden
, 2235), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 2256), Tuple.Create("\"", 2277)

#line 64 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 2263), Tuple.Create<System.Object, System.Int32>(childNode.Url

#line default
#line hidden
, 2263), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 2278), Tuple.Create("\"", 2308)

#line 64 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
        , Tuple.Create(Tuple.Create("", 2287), Tuple.Create<System.Object, System.Int32>(childNode.LinkTarget

#line default
#line hidden
, 2287), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 64 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                                                                 WriteTo(__razor_helper_writer, childNode.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n");


#line 65 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
        }
    }


#line default
#line hidden
});

#line 67 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
}
#line default
#line hidden

#line 70 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
public System.Web.WebPages.HelperResult GetClass(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 71 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
 

    if (node.IsCurrentlyOpened)
    {
        

#line default
#line hidden

#line 75 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 75 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                           ;
    }
    else if (node.HasChildOpen)
    {
        

#line default
#line hidden

#line 79 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 79 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                           ;
    }


#line default
#line hidden
});

#line 81 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
}
#line default
#line hidden

        public NavigationView_Pills()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 8 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
Write(Html.Script(Url.Content("~/ResourcePackages/Bootstrap4/assets/dist/js/popper.min.js"), "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
Write(Html.Script(Url.Content("~/ResourcePackages/Bootstrap4/assets/dist/js/bootstrap.min.js"), "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 520), Tuple.Create("\"", 543)
            
            #line 12 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 528), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 528), false)
);

WriteLiteral(">\r\n    <nav>\r\n        ");

WriteLiteral("\r\n\r\n        <ul");

WriteLiteral(" class=\"nav nav-pills\"");

WriteLiteral(">\r\n");

            
            #line 17 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
            
            
            #line default
            #line hidden
            
            #line 17 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
             foreach (var node in Model.Nodes)
            {
                
            
            #line default
            #line hidden
            
            #line 19 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
           Write(RenderRootLevelNode(node));

            
            #line default
            #line hidden
            
            #line 19 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                          ;
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n    </nav>\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 83 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Navigation\NavigationView.Pills.cshtml"
Write(Html.Script(Url.WidgetContent("MVC/Scripts/Navigation/pills.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
