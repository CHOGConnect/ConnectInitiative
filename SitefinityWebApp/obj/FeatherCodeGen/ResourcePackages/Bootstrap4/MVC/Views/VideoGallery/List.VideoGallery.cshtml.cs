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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.VideoGallery
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
    
    #line 3 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.VideoGallery;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/VideoGallery/List.VideoGallery.cshtml")]
    public partial class List_VideoGallery : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_VideoGallery()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"sf-Gallery-thumbs-container\"");

WriteLiteral(">\r\n    <ul");

WriteAttribute("class", Tuple.Create(" class=\"", 308), Tuple.Create("\"", 397)
            
            #line 9 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
, Tuple.Create(Tuple.Create("", 316), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 316), false)
, Tuple.Create(Tuple.Create(" ", 331), Tuple.Create("sf-Gallery-thumbs", 332), true)
, Tuple.Create(Tuple.Create(" ", 349), Tuple.Create("sf-Gallery-thumbs--video", 350), true)
, Tuple.Create(Tuple.Create(" ", 374), Tuple.Create("list-unstyled", 375), true)
, Tuple.Create(Tuple.Create(" ", 388), Tuple.Create("clearfix", 389), true)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 398), Tuple.Create("\"", 441)
            
            #line 9 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
                               , Tuple.Create(Tuple.Create("", 411), Tuple.Create<System.Object, System.Int32>(Html.Resource("VideoGallery")
            
            #line default
            #line hidden
, 411), false)
);

WriteLiteral(">\r\n\r\n");

            
            #line 11 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
        
            
            #line default
            #line hidden
            
            #line 11 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
         for (int i = 0; i < Model.Items.Count(); i++)
        {
            var item = Model.Items.ElementAt(i);
            var itemIndex = (Model.CurrentPage - 1) * ViewBag.ItemsPerPage + i + 1;
            var detailPageUrl = ViewBag.OpenInSamePage ? HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix, itemIndex) :
                HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix);
            var videoTitleId = Html.UniqueId("VideoTitle") + "-" + i.ToString();


            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"sf-Gallery-thumb d-inline-block\"");

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1112), Tuple.Create("\"", 1133)
            
            #line 20 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1119), Tuple.Create<System.Object, System.Int32>(detailPageUrl
            
            #line default
            #line hidden
, 1119), false)
);

WriteAttribute("title", Tuple.Create("\r\n                   title=\"", 1134), Tuple.Create("\"", 1276)
, Tuple.Create(Tuple.Create("", 1162), Tuple.Create("Go", 1162), true)
, Tuple.Create(Tuple.Create(" ", 1164), Tuple.Create("to", 1165), true)
, Tuple.Create(Tuple.Create(" ", 1167), Tuple.Create("video", 1168), true)
            
            #line 21 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
, Tuple.Create(Tuple.Create(" ", 1173), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(item.Fields.Description) ? item.Fields.Title : item.Fields.Description
            
            #line default
            #line hidden
, 1174), false)
, Tuple.Create(Tuple.Create(" ", 1268), Tuple.Create("details", 1269), true)
);

WriteLiteral(">\r\n                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1304), Tuple.Create("\"", 1357)
            
            #line 22 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1310), Tuple.Create<System.Object, System.Int32>(((VideoThumbnailViewModel)item).ThumbnailUrl
            
            #line default
            #line hidden
, 1310), false)
);

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\"", 1358), Tuple.Create("\"", 1389)
            
            #line 22 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
                , Tuple.Create(Tuple.Create("", 1376), Tuple.Create<System.Object, System.Int32>(videoTitleId
            
            #line default
            #line hidden
, 1376), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\'", 1390), Tuple.Create("\'", 1478)
            
            #line 22 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
                                    , Tuple.Create(Tuple.Create("", 1396), Tuple.Create<System.Object, System.Int32>(System.Text.RegularExpressions.Regex.Replace(item.Fields.Title, @"[^\w\d_-]", "")
            
            #line default
            #line hidden
, 1396), false)
);

WriteLiteral(" />\r\n                </a>\r\n                <h3");

WriteAttribute("id", Tuple.Create(" id=\"", 1525), Tuple.Create("\"", 1543)
            
            #line 24 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1530), Tuple.Create<System.Object, System.Int32>(videoTitleId
            
            #line default
            #line hidden
, 1530), false)
);

WriteLiteral(">");

            
            #line 24 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
                                  Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n            </li>\r\n");

            
            #line 26 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n    </ul>\r\n</div>\r\n");

            
            #line 30 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
        
            
            #line default
            #line hidden
            
            #line 30 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
         if (Model.ShowPager)
        {
            
            
            #line default
            #line hidden
            
            #line 32 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
       Write(Html.Action("Index", "ContentPager", new
               {
                   currentPage = Model.CurrentPage,
                   totalPagesCount = Model.TotalPagesCount.Value,
                   redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
               }));

            
            #line default
            #line hidden
            
            #line 37 "..\..MVC\Views\VideoGallery\List.VideoGallery.cshtml"
                 
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
