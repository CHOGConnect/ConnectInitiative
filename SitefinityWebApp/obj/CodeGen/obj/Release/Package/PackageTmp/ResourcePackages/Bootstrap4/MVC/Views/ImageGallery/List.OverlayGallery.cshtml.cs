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

namespace SitefinityWebApp.obj.Release.Package.PackageTmp.ResourcePackages.Bootstrap4.MVC.Views.ImageGallery
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
    
    #line 3 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 5 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.ImageGallery;
    
    #line default
    #line hidden
    
    #line 4 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/obj/Release/Package/PackageTmp/ResourcePackages/Bootstrap4/MVC/Views/ImageGalle" +
        "ry/List.OverlayGallery.cshtml")]
    public partial class List_OverlayGallery : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_OverlayGallery()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 9 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 11 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
Write(Html.StyleSheet(Url.WidgetContent("assets/magnific/magnific-popup.css"), "head", true));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 12 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
Write(Html.Script(Url.WidgetContent("assets/magnific/jquery.magnific-popup.min.js"), "bottom", true));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 13 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/ImageGallery/overlay-gallery.js"), "bottom", true));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteLiteral(" class=\"sf-Gallery-thumbs-container\"");

WriteLiteral(">\n  <ul");

WriteAttribute("class", Tuple.Create(" class=\"", 677), Tuple.Create("\"", 732)
, Tuple.Create(Tuple.Create("", 685), Tuple.Create("sf-Gallery-thumbs", 685), true)
, Tuple.Create(Tuple.Create(" ", 702), Tuple.Create("list-unstyled", 703), true)
            
            #line 16 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create(" ", 716), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 717), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 733), Tuple.Create("\"", 776)
            
            #line 16 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 746), Tuple.Create<System.Object, System.Int32>(Html.Resource("ImageGallery")
            
            #line default
            #line hidden
, 746), false)
);

WriteLiteral(">\n");

            
            #line 17 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
    
            
            #line default
            #line hidden
            
            #line 17 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
      int itemIndex = 0;
            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 18 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
    
            
            #line default
            #line hidden
            
            #line 18 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
     foreach (var item in Model.Items)
    {
        var thumbnailViewModel = (ThumbnailViewModel)item;

            
            #line default
            #line hidden
WriteLiteral("        <li");

WriteLiteral(" class=\"d-inline-block\"");

WriteLiteral(">\n            <a");

WriteLiteral(" class=\"text-center image-link\"");

WriteAttribute("href", Tuple.Create("\n               href=\"", 990), Tuple.Create("\"", 1042)
            
            #line 23 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1012), Tuple.Create<System.Object, System.Int32>(thumbnailViewModel.MediaUrl
            
            #line default
            #line hidden
, 1012), false)
);

WriteAttribute("title", Tuple.Create("\n               title=\"", 1043), Tuple.Create("\"", 1084)
            
            #line 24 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1066), Tuple.Create<System.Object, System.Int32>(item.Fields.Title
            
            #line default
            #line hidden
, 1066), false)
);

WriteAttribute("aria-label", Tuple.Create("\n               aria-label=\"", 1085), Tuple.Create("\"", 1182)
            
            #line 25 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1113), Tuple.Create<System.Object, System.Int32>(string.Format(Html.Resource("OpenInModalDialog"), item.Fields.Title)
            
            #line default
            #line hidden
, 1113), false)
);

WriteLiteral(">\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1205), Tuple.Create("\"", 1245)
            
            #line 26 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1211), Tuple.Create<System.Object, System.Int32>(thumbnailViewModel.ThumbnailUrl
            
            #line default
            #line hidden
, 1211), false)
);

WriteLiteral("\n                     data-detail-url=\"");

            
            #line 27 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
                                 Write(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix, itemIndex));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("alt", Tuple.Create("\n                     alt=\"", 1404), Tuple.Create("\"", 1459)
            
            #line 28 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1431), Tuple.Create<System.Object, System.Int32>(item.Fields.AlternativeText
            
            #line default
            #line hidden
, 1431), false)
);

WriteLiteral("\n                     ");

            
            #line 29 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
                Write(Html.GetWidthAttributeIfExists(thumbnailViewModel.Width));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                     ");

            
            #line 30 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
                Write(Html.GetHeightAttributeIfExists(thumbnailViewModel.Height));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 30 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
                                                                            Write(Html.GetDetailsImageWidthAttributeIfExists(thumbnailViewModel.DetailsImageWidth));

            
            #line default
            #line hidden
WriteLiteral(" />\n            </a>\n        </li>\n");

            
            #line 33 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
        itemIndex++;
    }

            
            #line default
            #line hidden
WriteLiteral("  </ul>\n</div>\n\n");

            
            #line 38 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 40 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 45 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
         
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
