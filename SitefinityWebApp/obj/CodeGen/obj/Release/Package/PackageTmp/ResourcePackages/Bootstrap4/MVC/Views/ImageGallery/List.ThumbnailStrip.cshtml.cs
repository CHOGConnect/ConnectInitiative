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
    
    #line 10 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    
    #line 4 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using System.Web.Script.Serialization;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 5 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.ImageGallery;
    
    #line default
    #line hidden
    
    #line 7 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 8 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 9 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/obj/Release/Package/PackageTmp/ResourcePackages/Bootstrap4/MVC/Views/ImageGalle" +
        "ry/List.ThumbnailStrip.cshtml")]
    public partial class List_ThumbnailStrip : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_ThumbnailStrip()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("\n");

            
            #line 13 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 14 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/ImageGallery/thumbnail-strip.js"), "bottom", true));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 16 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
  
    bool hasItems = Model.Items.Count() > 0;
    bool isBackendDesignMode = SystemManager.IsDesignMode && !SystemManager.IsPreviewMode;
    dynamic firstItem = null;

    if (hasItems && isBackendDesignMode)
    {
        firstItem = Model.Items.FirstOrDefault();
    }

    ThumbnailViewModel thumbnailViewModel = (ThumbnailViewModel)firstItem;

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteLiteral(" class=\"sf-Gallery sf-Gallery--strip\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 986), Tuple.Create("\"", 1029)
            
            #line 29 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 999), Tuple.Create<System.Object, System.Int32>(Html.Resource("ImageGallery")
            
            #line default
            #line hidden
, 999), false)
);

WriteLiteral(">\n\n");

            
            #line 31 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
 if (hasItems)
{
		if (isBackendDesignMode)
		{

            
            #line default
            #line hidden
WriteLiteral("\t<h2");

WriteLiteral(" class=\"js-Gallery-title\"");

WriteLiteral(">");

            
            #line 35 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                            Write(firstItem.DataItem.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\n");

            
            #line 36 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<p");

WriteLiteral(" class=\"js-Gallery-description\"");

WriteLiteral(">");

            
            #line 37 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                 Write(firstItem.DataItem.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 38 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<div><span");

WriteLiteral(" class=\"js-Gallery-index\"");

WriteLiteral(">1</span> of ");

            
            #line 39 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                               Write(Model.Items.Count());

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 40 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<p");

WriteLiteral(" class=\"sf-Gallery-image js-Gallery-image\"");

WriteLiteral(">\n\t\t<a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" class=\'js-Gallery-prev sf-Gallery-prev\'");

WriteAttribute("title", Tuple.Create(" title=\"", 1409), Tuple.Create("\"", 1452)
            
            #line 42 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    , Tuple.Create(Tuple.Create("", 1417), Tuple.Create<System.Object, System.Int32>(Html.Resource("GoToPreviousImage")
            
            #line default
            #line hidden
, 1417), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"carousel-control-prev-icon\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></span></a>\n\t\t<a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" class=\'js-Gallery-next sf-Gallery-next\'");

WriteAttribute("title", Tuple.Create(" title=\"", 1596), Tuple.Create("\"", 1635)
            
            #line 43 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    , Tuple.Create(Tuple.Create("", 1604), Tuple.Create<System.Object, System.Int32>(Html.Resource("GoToNextImage")
            
            #line default
            #line hidden
, 1604), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"carousel-control-next-icon\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></span></a>\n        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1721), Tuple.Create("\"", 1757)
            
            #line 44 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 1727), Tuple.Create<System.Object, System.Int32>(thumbnailViewModel.MediaUrl
            
            #line default
            #line hidden
, 1727), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 1758), Tuple.Create("\"", 1791)
            
            #line 44 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 1766), Tuple.Create<System.Object, System.Int32>(firstItem.DataItem.Title
            
            #line default
            #line hidden
, 1766), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 1792), Tuple.Create("\"", 1833)
            
            #line 44 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
         , Tuple.Create(Tuple.Create("", 1798), Tuple.Create<System.Object, System.Int32>(firstItem.DataItem.AlternativeText
            
            #line default
            #line hidden
, 1798), false)
);

WriteLiteral(" \n                  ");

            
            #line 45 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
             Write(Html.GetWidthAttributeIfExists(thumbnailViewModel.Width));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                  ");

            
            #line 46 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
             Write(Html.GetHeightAttributeIfExists(thumbnailViewModel.Height));

            
            #line default
            #line hidden
WriteLiteral(" />\n\n\t</p>\n");

            
            #line 49 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
		}
		else
		{

            
            #line default
            #line hidden
WriteLiteral("\t<h2");

WriteLiteral(" class=\"js-Gallery-title\"");

WriteLiteral(" aria-live=\"polite\"");

WriteLiteral(" aria-atomic=\"true\"");

WriteLiteral("></h2>\n");

            
            #line 53 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<p");

WriteLiteral(" class=\"js-Gallery-description\"");

WriteLiteral(" aria-live=\"polite\"");

WriteLiteral(" aria-atomic=\"true\"");

WriteLiteral("></p>\n");

            
            #line 55 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<div");

WriteLiteral(" aria-live=\"polite\"");

WriteLiteral(" aria-atomic=\"true\"");

WriteLiteral("><span");

WriteLiteral(" class=\"js-Gallery-index\"");

WriteLiteral("></span> of ");

            
            #line 56 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                                                                    Write(Model.Items.Count());

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 57 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<div");

WriteLiteral(" class=\"sf-Gallery-image js-Gallery-image\"");

WriteLiteral(">\n        <nav");

WriteLiteral(" role=\"navigation\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2362), Tuple.Create("\"", 2410)
            
            #line 59 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 2375), Tuple.Create<System.Object, System.Int32>(Html.Resource("PreviousNextImage")
            
            #line default
            #line hidden
, 2375), false)
);

WriteLiteral(">\n            <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" class=\"js-Gallery-prev sf-Gallery-prev\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2493), Tuple.Create("\"", 2536)
            
            #line 60 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
        , Tuple.Create(Tuple.Create("", 2501), Tuple.Create<System.Object, System.Int32>(Html.Resource("GoToPreviousImage")
            
            #line default
            #line hidden
, 2501), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"carousel-control-prev-icon\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></span></a>\n            <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" class=\"js-Gallery-next sf-Gallery-next\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2690), Tuple.Create("\"", 2729)
            
            #line 61 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
        , Tuple.Create(Tuple.Create("", 2698), Tuple.Create<System.Object, System.Int32>(Html.Resource("GoToNextImage")
            
            #line default
            #line hidden
, 2698), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"carousel-control-next-icon\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></span></a>\n        </nav>\n\t\t<img />\n\t</div>\n");

            
            #line 65 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
	}
}

            
            #line default
            #line hidden
WriteLiteral("\n\n\n\t<ul");

WriteLiteral(" class=\"sf-Gallery-thumbs-container list-unstyled\"");

WriteLiteral(">\n\t\t<li");

WriteLiteral(" class=\"sf-Gallery-thumbs js-Gallery-thumbs d-inline-block\"");

WriteLiteral(">\n");

            
            #line 72 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
		
            
            #line default
            #line hidden
            
            #line 72 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
          int itemIndex = 0;
            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 73 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
		
            
            #line default
            #line hidden
            
            #line 73 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
         foreach(var item in Model.Items)
		{
    var itemViewModel = (ThumbnailViewModel)item;
    

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" class=\"text-center\"");

WriteAttribute("title", Tuple.Create(" title=\"", 3136), Tuple.Create("\"", 3162)
            
            #line 77 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 3144), Tuple.Create<System.Object, System.Int32>(item.Fields.Title
            
            #line default
            #line hidden
, 3144), false)
);

WriteLiteral(" data-item=\"");

            
            #line 77 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                                                                              Write(Html.GetSerializedImage(item));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-detail-url=\"");

            
            #line 77 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                                                                                                                               Write(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix, itemIndex));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 3365), Tuple.Create("\"", 3400)
            
            #line 78 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 3371), Tuple.Create<System.Object, System.Int32>(itemViewModel.ThumbnailUrl
            
            #line default
            #line hidden
, 3371), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 3401), Tuple.Create("\"", 3435)
            
            #line 78 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 3407), Tuple.Create<System.Object, System.Int32>(item.Fields.AlternativeText
            
            #line default
            #line hidden
, 3407), false)
);

WriteLiteral(" \n                              ");

            
            #line 79 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                         Write(Html.GetWidthAttributeIfExists(itemViewModel.Width));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                              ");

            
            #line 80 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                         Write(Html.GetHeightAttributeIfExists(itemViewModel.Height));

            
            #line default
            #line hidden
WriteLiteral(" />\n\t\t\t</a>\n");

            
            #line 82 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
			itemIndex++;
		}

            
            #line default
            #line hidden
WriteLiteral("\t\t</li>\n\t</ul>\n</div>\n");

            
            #line 87 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 89 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 94 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
         
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
