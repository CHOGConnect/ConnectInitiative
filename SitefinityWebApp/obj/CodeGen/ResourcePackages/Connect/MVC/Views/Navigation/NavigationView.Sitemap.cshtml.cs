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

namespace SitefinityWebApp.ResourcePackages.Connect.MVC.Views.Navigation
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
    
    #line 3 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Connect/MVC/Views/Navigation/NavigationView.Sitemap.cshtml")]
    public partial class NavigationView_Sitemap : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 22 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
public System.Web.WebPages.HelperResult RenderRootLevelNode(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 23 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <li");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-item\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        <a");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-link\"");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 749), Tuple.Create("\"", 765)

#line 25 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
, Tuple.Create(Tuple.Create("", 756), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 756), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 766), Tuple.Create("\"", 791)

#line 25 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
, Tuple.Create(Tuple.Create("", 775), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 775), false)
);

WriteLiteralTo(__razor_helper_writer, "><strong>");


#line 25 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                                 WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</strong></a>\r\n");


#line 26 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        

#line default
#line hidden

#line 26 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
         if (node.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav flex-column ml-2\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 29 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                

#line default
#line hidden

#line 29 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                 foreach (var childNode in node.ChildNodes)
                {
                    

#line default
#line hidden

#line 31 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden

#line 31 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                                        
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </ul>\r\n");


#line 34 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </li>\r\n");


#line 36 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"


#line default
#line hidden
});

#line 36 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
}
#line default
#line hidden

#line 39 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 40 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <li");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-item\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        <a");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-link\"");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1296), Tuple.Create("\"", 1312)

#line 42 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
, Tuple.Create(Tuple.Create("", 1303), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 1303), false)
);

WriteLiteralTo(__razor_helper_writer, " target =\"");


#line 42 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                        WriteTo(__razor_helper_writer, node.LinkTarget);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\">");


#line 42 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                          WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n");


#line 43 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        

#line default
#line hidden

#line 43 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
         if (node.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav flex-column ml-2\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 46 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                

#line default
#line hidden

#line 46 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                 foreach (var childNode in node.ChildNodes)
                {
                    

#line default
#line hidden

#line 48 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden

#line 48 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                                        
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </ul>\r\n");


#line 51 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </li>\r\n");


#line 53 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"


#line default
#line hidden
});

#line 53 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
}
#line default
#line hidden

        public NavigationView_Sitemap()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 268), Tuple.Create("\"", 291)
            
            #line 9 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
, Tuple.Create(Tuple.Create("", 276), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 276), false)
);

WriteLiteral(">\r\n    <nav>\r\n        ");

WriteLiteral("\r\n\r\n        <ul");

WriteLiteral(" class=\"nav nav-sitemap\"");

WriteLiteral(">\r\n");

            
            #line 14 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
            
            
            #line default
            #line hidden
            
            #line 14 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
             foreach (var node in Model.Nodes)
            {
                
            
            #line default
            #line hidden
            
            #line 16 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
           Write(RenderRootLevelNode(node));

            
            #line default
            #line hidden
            
            #line 16 "..\..\ResourcePackages\Connect\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                          ;
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n    </nav>\r\n</div>\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
