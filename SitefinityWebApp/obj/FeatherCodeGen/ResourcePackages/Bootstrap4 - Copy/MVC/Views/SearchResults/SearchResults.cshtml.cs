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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4 - Copy.MVC.Views.SearchResults
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
    
    #line 3 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Frontend.Search.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 7 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Libraries.Model;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Modules.Libraries;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 8 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Web;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SearchResults/SearchResults.cshtml")]
    public partial class SearchResults : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Search.Mvc.Models.ISearchResultsModel>
    {
        public SearchResults()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 350), Tuple.Create("\"", 374)
            
            #line 10 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 358), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 359), false)
);

WriteLiteral(">\r\n\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-lg-8\"");

WriteLiteral(">\r\n");

            
            #line 14 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 14 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             if (@Model.Results.TotalCount > 0)
            {
                if (ViewBag.IsFilteredbyPermission)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h1");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 18 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                      Write(Html.HtmlSanitize(Model.ResultText));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n");

            
            #line 19 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h1");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 22 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                      Write(Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 22 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                Write(Html.HtmlSanitize(Model.ResultText));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n");

            
            #line 23 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <h1");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 27 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                  Write(Html.Resource("No"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 27 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                       Write(Html.HtmlSanitize(Model.ResultText));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n");

            
            #line 28 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n        <div");

WriteLiteral(" class=\"col-lg-4\"");

WriteLiteral(">\r\n");

            
            #line 31 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 31 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             if (Model.AllowSorting && @Model.Results.TotalCount > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <label>\r\n");

WriteLiteral("                    ");

            
            #line 34 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
               Write(Html.Resource("SortBy"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <select");

WriteLiteral(" class=\"userSortDropdown\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1315), Tuple.Create("\"", 1353)
            
            #line 35 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1323), Tuple.Create<System.Object, System.Int32>(Html.Resource("SortDropdown")
            
            #line default
            #line hidden
, 1323), false)
);

WriteLiteral(">\r\n                    <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1384), Tuple.Create("\"", 1417)
            
            #line 36 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1392), Tuple.Create<System.Object, System.Int32>(OrderByOptions.Relevance
            
            #line default
            #line hidden
, 1392), false)
);

WriteLiteral(" ");

            
            #line 36 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                          Write(Model.OrderBy == OrderByOptions.Relevance ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 36 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                                 Write(Html.Resource("Relevance"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                    <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1556), Tuple.Create("\"", 1586)
            
            #line 37 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1564), Tuple.Create<System.Object, System.Int32>(OrderByOptions.Newest
            
            #line default
            #line hidden
, 1564), false)
);

WriteLiteral(" ");

            
            #line 37 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                       Write(Model.OrderBy == OrderByOptions.Newest ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 37 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                           Write(Html.Resource("NewestFirst"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                    <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1724), Tuple.Create("\"", 1754)
            
            #line 38 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1732), Tuple.Create<System.Object, System.Int32>(OrderByOptions.Oldest
            
            #line default
            #line hidden
, 1732), false)
);

WriteLiteral(" ");

            
            #line 38 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                       Write(Model.OrderBy == OrderByOptions.Oldest ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 38 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                           Write(Html.Resource("OldestFirst"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                </select>\r\n            </label>\r\n");

            
            #line 41 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n\r\n");

            
            #line 45 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 45 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
     if (Model.Languages.Length > 1)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div>\r\n            <span>");

            
            #line 48 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             Write(Html.Resource("ChangeResultsLanguageLabel"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n");

            
            #line 49 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 49 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             for (var i = 0; i < Model.Languages.Length; i++)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2183), Tuple.Create("\"", 2266)
            
            #line 51 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2190), Tuple.Create<System.Object, System.Int32>(String.Format(ViewBag.LanguageSearchUrlTemplate, Model.Languages[i].Name)
            
            #line default
            #line hidden
, 2190), false)
);

WriteLiteral(">");

            
            #line 51 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                  Write(Model.Languages[i].DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 52 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                if (i < Model.Languages.Length - 2)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span>, </span>\r\n");

            
            #line 55 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }
                else if (i == Model.Languages.Length - 2)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span> ");

            
            #line 58 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                      Write(Html.Resource("OrLabel"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n");

            
            #line 59 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

            
            #line 62 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"sf-search-results media-list\"");

WriteLiteral(">\r\n");

            
            #line 65 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
        
            
            #line default
            #line hidden
            
            #line 65 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
         foreach (var item in Model.Results.Data)
        {
            var hasLink = item.GetValue("Link") != null && !String.IsNullOrEmpty(item.GetValue("Link").ToString());

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"media sf-media\"");

WriteLiteral(">\r\n\r\n");

            
            #line 70 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 70 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                 if (((Telerik.Sitefinity.Services.Search.Model.Document)item).ItemType.ToString() == typeof(Telerik.Sitefinity.Libraries.Model.Image).ToString())
                {


            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"media-left pr-2 sf-img-thmb\"");

WriteLiteral(">\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3177), Tuple.Create("\"", 3206)
            
            #line 74 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3184), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 3184), false)
);

WriteLiteral(">\r\n                            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 3242), Tuple.Create("\"", 3270)
            
            #line 75 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3248), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 3248), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 3271), Tuple.Create("\"", 3300)
            
            #line 75 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3277), Tuple.Create<System.Object, System.Int32>(item.GetValue("Title")
            
            #line default
            #line hidden
, 3277), false)
);

WriteLiteral(" width=\"120\"");

WriteLiteral(" />\r\n                        </a>\r\n                    </div>\r\n");

            
            #line 78 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }

                else if (((Telerik.Sitefinity.Services.Search.Model.Document)item).ItemType.ToString() == typeof(Telerik.Sitefinity.Libraries.Model.Video).ToString())
                {
                    LibrariesManager librariesManager = LibrariesManager.GetManager();
                    var videoTmbId = new Guid((string)item.GetValue("Id"));
                    Video video = librariesManager.GetVideo(videoTmbId);
                    if (video != null)
                    {
                        var thumbUrl = video.ThumbnailUrl;


            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"media-left pr-2\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"sf-video-thmb\"");

WriteLiteral(">\r\n\r\n                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4096), Tuple.Create("\"", 4125)
            
            #line 92 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4103), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 4103), false)
);

WriteLiteral(">\r\n                                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 4169), Tuple.Create("\"", 4184)
            
            #line 93 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4175), Tuple.Create<System.Object, System.Int32>(thumbUrl
            
            #line default
            #line hidden
, 4175), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 4185), Tuple.Create("\"", 4214)
            
            #line 93 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4191), Tuple.Create<System.Object, System.Int32>(item.GetValue("Title")
            
            #line default
            #line hidden
, 4191), false)
);

WriteLiteral(" width=\"120\"");

WriteLiteral(" />\r\n\r\n                                    <div");

WriteLiteral(" class=\"sf-icon-play\"");

WriteLiteral("></div>\r\n\r\n                                </a>\r\n                            </di" +
"v>\r\n                        </div>\r\n");

            
            #line 100 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                    }

                }

                else
                {

                }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                <div");

WriteLiteral(" class=\"media-body sf-media-body\"");

WriteLiteral(">\r\n\r\n                    <h3>\r\n");

            
            #line 113 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 113 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                         if (hasLink)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4704), Tuple.Create("\"", 4733)
            
            #line 115 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4711), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 4711), false)
);

WriteLiteral(">");

            
            #line 115 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                        Write(item.GetValue("Title"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 116 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                        }
                        else
                        {
                            
            
            #line default
            #line hidden
            
            #line 119 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                       Write(item.GetValue("Title"));

            
            #line default
            #line hidden
            
            #line 119 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                   
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </h3>\r\n\r\n                    <p>");

            
            #line 123 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                  Write(Html.HtmlSanitize((string)item.GetValue("HighLighterResult")));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 124 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 124 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                     if (hasLink)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5132), Tuple.Create("\"", 5161)
            
            #line 126 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 5139), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 5139), false)
);

WriteLiteral(">");

            
            #line 126 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                    Write(item.GetValue("Link"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 127 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </div>\r\n");

            
            #line 130 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n");

            
            #line 134 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 134 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
     if (Model.DisplayMode == ListDisplayMode.Paging && Model.TotalPagesCount != null && Model.TotalPagesCount > 1)
    {
        if (ViewBag.IsFilteredbyPermission)
        {

            
            #line default
            #line hidden
WriteLiteral("            <ul");

WriteLiteral(" class=\"pagination\"");

WriteLiteral(">\r\n");

            
            #line 139 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 139 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                 if (Model.CurrentPage > 1)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" class=\"page-item\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" class=\"page-link\"");

WriteAttribute("href", Tuple.Create(" href=\'", 5654), Tuple.Create("\'", 5731)
            
            #line 142 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 5661), Tuple.Create<System.Object, System.Int32>(string.Format(ViewBag.RedirectPageUrlTemplate, Model.CurrentPage - 1)
            
            #line default
            #line hidden
, 5661), false)
);

WriteLiteral(">");

            
            #line 142 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                      Write(Html.Resource("Prev"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </li>\r\n");

            
            #line 144 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 145 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                 if (Model.CurrentPage < @Model.TotalPagesCount)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" class=\"page-item\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" class=\"page-link\"");

WriteAttribute("href", Tuple.Create(" href=\'", 5980), Tuple.Create("\'", 6057)
            
            #line 148 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 5987), Tuple.Create<System.Object, System.Int32>(string.Format(ViewBag.RedirectPageUrlTemplate, Model.CurrentPage + 1)
            
            #line default
            #line hidden
, 5987), false)
);

WriteLiteral(">");

            
            #line 148 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                      Write(Html.Resource("Next"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </li>\r\n");

            
            #line 150 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n");

            
            #line 152 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
        }
        else
        {
            if (Model.CurrentPage == Model.TotalPagesCount)
            {

            
            #line default
            #line hidden
WriteLiteral("                <em");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 157 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                   Write((Model.ItemsPerPage * Model.TotalPagesCount) - Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" of ");

            
            #line 157 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                Write(Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" results</em>\r\n");

            
            #line 158 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <em");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 161 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                  Write(Model.ItemsPerPage);

            
            #line default
            #line hidden
WriteLiteral(" of ");

            
            #line 161 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                         Write(Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" results</em>\r\n");

            
            #line 162 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            }


            
            #line default
            #line hidden
WriteLiteral("            <div>\r\n");

WriteLiteral("                ");

            
            #line 165 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
           Write(Html.Action("Index", "ContentPager", new
                {
                    currentPage = Model.CurrentPage,
                    totalPagesCount = Model.TotalPagesCount,
                    redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
                }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 172 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResOrderBy\"");

WriteAttribute("value", Tuple.Create(" value=\'", 6992), Tuple.Create("\'", 7034)
            
            #line 175 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7000), Tuple.Create<System.Object, System.Int32>(Request.QueryStringGet("orderBy")
            
            #line default
            #line hidden
, 7000), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResLanguage\"");

WriteAttribute("value", Tuple.Create(" value=\'", 7097), Tuple.Create("\'", 7140)
            
            #line 176 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7105), Tuple.Create<System.Object, System.Int32>(Request.QueryStringGet("language")
            
            #line default
            #line hidden
, 7105), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResIndexCatalogue\"");

WriteAttribute("value", Tuple.Create(" value=\'", 7209), Tuple.Create("\'", 7258)
            
            #line 177 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7217), Tuple.Create<System.Object, System.Int32>(Request.QueryStringGet("indexCatalogue")
            
            #line default
            #line hidden
, 7217), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResQuery\"");

WriteAttribute("value", Tuple.Create(" value=\'", 7318), Tuple.Create("\'", 7364)
            
            #line 178 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7326), Tuple.Create<System.Object, System.Int32>(Request.QueryStringGet("searchQuery")
            
            #line default
            #line hidden
, 7326), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResWordsMode\"");

WriteAttribute("value", Tuple.Create(" value=\'", 7428), Tuple.Create("\'", 7472)
            
            #line 179 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7436), Tuple.Create<System.Object, System.Int32>(Request.QueryStringGet("wordsMode")
            
            #line default
            #line hidden
, 7436), false)
);

WriteLiteral(" />\r\n\r\n</div>\r\n\r\n");

            
            #line 183 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SearchResults/Search-results.js"), "bottom", throwException: false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
