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

namespace SitefinityWebApp.ResourcePackages.Connect.MVC.Views.Card
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
    
    #line 3 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Connect/MVC/Views/Card/Card.cshtml")]
    public partial class Card : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Card.Mvc.Models.Card.CardViewModel>
    {
        public Card()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 128), Tuple.Create("\"", 151)
            
            #line 5 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
, Tuple.Create(Tuple.Create("", 136), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 136), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"card\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
        
            
            #line default
            #line hidden
            
            #line 7 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
         if (!string.IsNullOrEmpty(Model.SelectedSizeUrl))
        {

            
            #line default
            #line hidden
WriteLiteral("            <img");

WriteLiteral(" class=\"card-img-top\"");

WriteAttribute("src", Tuple.Create(" src=\"", 287), Tuple.Create("\"", 315)
            
            #line 9 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
, Tuple.Create(Tuple.Create("", 293), Tuple.Create<System.Object, System.Int32>(Model.SelectedSizeUrl
            
            #line default
            #line hidden
, 293), false)
);

WriteAttribute("title", Tuple.Create("  title=\"", 316), Tuple.Create("\"", 342)
            
            #line 9 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
, Tuple.Create(Tuple.Create("", 325), Tuple.Create<System.Object, System.Int32>(Model.ImageTitle
            
            #line default
            #line hidden
, 325), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 343), Tuple.Create("\"", 376)
            
            #line 9 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
                    , Tuple.Create(Tuple.Create("", 349), Tuple.Create<System.Object, System.Int32>(Model.ImageAlternativeText
            
            #line default
            #line hidden
, 349), false)
);

WriteLiteral("/>\r\n");

            
            #line 10 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"card-body\"");

WriteLiteral(">\r\n");

            
            #line 12 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
            
            
            #line default
            #line hidden
            
            #line 12 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
             if (!string.IsNullOrEmpty(Model.Heading))
            {   

            
            #line default
            #line hidden
WriteLiteral("                <h5");

WriteLiteral(" class=\"card-title\"");

WriteLiteral(">");

            
            #line 14 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
                                  Write(Html.HtmlSanitize(Model.Heading));

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n");

            
            #line 15 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 16 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
             if (!string.IsNullOrEmpty(Model.Description))
            {

            
            #line default
            #line hidden
WriteLiteral("                <p");

WriteLiteral(" class=\"card-text\"");

WriteLiteral(">");

            
            #line 18 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
                                Write(Html.HtmlSanitize(Model.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 19 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 20 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
             if (!string.IsNullOrEmpty(Model.ActionName))
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" class=\"btn btn-primary\"");

WriteAttribute("href", Tuple.Create(" href=\"", 879), Tuple.Create("\"", 920)
            
            #line 22 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
, Tuple.Create(Tuple.Create("", 886), Tuple.Create<System.Object, System.Int32>(Html.UrlSanitize(Model.ActionUrl)
            
            #line default
            #line hidden
, 886), false)
);

WriteLiteral(">");

            
            #line 22 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
                                                                                Write(Model.ActionName);

            
            #line default
            #line hidden
WriteLiteral(" </a>\r\n");

            
            #line 23 "..\..\ResourcePackages\Connect\MVC\Views\Card\Card.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
