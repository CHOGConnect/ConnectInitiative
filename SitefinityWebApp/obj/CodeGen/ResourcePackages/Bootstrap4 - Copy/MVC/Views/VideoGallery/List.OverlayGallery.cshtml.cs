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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4___Copy.MVC.Views.VideoGallery
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.VideoGallery;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4 - Copy/MVC/Views/VideoGallery/List.OverlayGallery.c" +
        "shtml")]
    public partial class List_OverlayGallery : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_OverlayGallery()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 8 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
Write(Html.StyleSheet(Url.WidgetContent("assets/magnific/magnific-popup.css"), "head", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
Write(Html.Script(Url.WidgetContent("assets/magnific/jquery.magnific-popup.min.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 11 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/VideoGallery/overlay-gallery.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"sf-Gallery-thumbs-container\"");

WriteLiteral(">\r\n    <ul");

WriteAttribute("class", Tuple.Create(" class=\"", 641), Tuple.Create("\"", 730)
, Tuple.Create(Tuple.Create("", 649), Tuple.Create("sf-Gallery-thumbs", 649), true)
, Tuple.Create(Tuple.Create(" ", 666), Tuple.Create("sf-Gallery-thumbs--video", 667), true)
, Tuple.Create(Tuple.Create(" ", 691), Tuple.Create("list-unstyled", 692), true)
, Tuple.Create(Tuple.Create(" ", 705), Tuple.Create("clearfix", 706), true)
            
            #line 14 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
 , Tuple.Create(Tuple.Create(" ", 714), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 715), false)
);

WriteLiteral(">\r\n    \r\n");

            
            #line 16 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
        
            
            #line default
            #line hidden
            
            #line 16 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
         for (int i = 0; i < Model.Items.Count(); i++)
        {
            var item = Model.Items.ElementAt(i);
            var title = item.Fields.Title;
            var alternativeText = System.Text.RegularExpressions.Regex.Replace(title, @"[^\w\d_-]", "");
            var videoTitleId = Html.UniqueId("VideoTitle") + "-" + i.ToString();


            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"sf-Gallery-thumb d-inline-block\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"video-link\"");

WriteAttribute("href", Tuple.Create("\r\n                    href=\"", 1186), Tuple.Create("\"", 1235)
            
            #line 25 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1214), Tuple.Create<System.Object, System.Int32>(item.Fields.MediaUrl
            
            #line default
            #line hidden
, 1214), false)
);

WriteAttribute("title", Tuple.Create("\r\n                    title=\"", 1236), Tuple.Create("\"", 1271)
            
            #line 26 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1265), Tuple.Create<System.Object, System.Int32>(title
            
            #line default
            #line hidden
, 1265), false)
);

WriteAttribute("aria-label", Tuple.Create("\r\n                   \r\n                    aria-label=\"", 1272), Tuple.Create("\"", 1384)
            
            #line 28 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1327), Tuple.Create<System.Object, System.Int32>(string.Format(Html.Resource("OpenInModalDialog"), title)
            
            #line default
            #line hidden
, 1327), false)
);

WriteLiteral(">\r\n                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1412), Tuple.Create("\"", 1465)
            
            #line 29 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1418), Tuple.Create<System.Object, System.Int32>(((VideoThumbnailViewModel)item).ThumbnailUrl
            
            #line default
            #line hidden
, 1418), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 1466), Tuple.Create("\"", 1488)
            
            #line 29 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
    , Tuple.Create(Tuple.Create("", 1472), Tuple.Create<System.Object, System.Int32>(alternativeText
            
            #line default
            #line hidden
, 1472), false)
);

WriteLiteral(" \r\n                        data-detail-url=\"");

            
            #line 30 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
                                    Write(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\"", 1641), Tuple.Create("\"", 1672)
            
            #line 30 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
                                                                                       , Tuple.Create(Tuple.Create("", 1659), Tuple.Create<System.Object, System.Int32>(videoTitleId
            
            #line default
            #line hidden
, 1659), false)
);

WriteLiteral(" />\r\n                </a>\r\n                <h3");

WriteAttribute("id", Tuple.Create(" id=\"", 1719), Tuple.Create("\"", 1737)
            
            #line 32 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1724), Tuple.Create<System.Object, System.Int32>(videoTitleId
            
            #line default
            #line hidden
, 1724), false)
);

WriteLiteral(">");

            
            #line 32 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
                                  Write(title);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n            </li>\r\n");

            
            #line 34 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"

        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</div>\r\n\r\n");

            
            #line 39 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 41 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 46 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
         
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
