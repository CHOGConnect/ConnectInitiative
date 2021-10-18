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

namespace SitefinityWebApp.ResourcePackages.Connect.MVC.Views.News
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
    
    #line 3 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Connect/MVC/Views/News/List.NewsList.cshtml")]
    public partial class List_NewsList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_NewsList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 213), Tuple.Create("\"", 236)
            
            #line 7 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
, Tuple.Create(Tuple.Create("", 221), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 221), false)
);

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"list-unstyled\"");

WriteLiteral(">\r\n");

            
            #line 9 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
        
            
            #line default
            #line hidden
            
            #line 9 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
         foreach (var item in Model.Items)
        {
            var navigateUrl = HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix);
            

            
            #line default
            #line hidden
WriteLiteral("            <li ");

            
            #line 13 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
           Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n\t\t\t\t<h3>\r\n\t\t\t\t\t<a ");

            
            #line 15 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
                  Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(" href=\"");

            
            #line 15 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
                                                                                 Write(navigateUrl);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 15 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
                                                                                               Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n\t\t\t\t</h3>\r\n                \r\n                <div>\r\n\t\t\t\t    <span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t    ");

            
            #line 20 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
                   Write(item.GetDateTime("PublicationDate", "MMM d, yyyy, HH:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t\t\t\t\t    ");

            
            #line 21 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
                   Write(Html.Resource("By"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t\t\t\t\t    ");

            
            #line 22 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
                   Write(DataResolver.Resolve(item.DataItem, "Author", null));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t    </span>\r\n");

WriteLiteral("                    ");

            
            #line 24 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
               Write(Html.CommentsCount((string)navigateUrl, item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n\r\n\t\t\t\t<div ");

            
            #line 27 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
                Write(Html.InlineEditingFieldAttributes("Summary", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 27 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
                                                                           Write(Html.HtmlSanitize((string)item.Fields.Summary));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n\t\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 1221), Tuple.Create("\"", 1240)
            
            #line 29 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
, Tuple.Create(Tuple.Create("", 1228), Tuple.Create<System.Object, System.Int32>(navigateUrl
            
            #line default
            #line hidden
, 1228), false)
);

WriteLiteral(">");

            
            #line 29 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
                                  Write(Html.Resource("FullStory"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n\t\t\t</li>\r\n");

            
            #line 31 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n\r\n");

            
            #line 34 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 34 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
     if (Model.ShowPager)
    {
        
            
            #line default
            #line hidden
            
            #line 36 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
   Write(Html.Action("Index", "ContentPager", new { currentPage = Model.CurrentPage,
                        totalPagesCount = Model.TotalPagesCount.Value,
                        redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate }));

            
            #line default
            #line hidden
            
            #line 38 "..\..\ResourcePackages\Connect\MVC\Views\News\List.NewsList.cshtml"
                                                                                
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
