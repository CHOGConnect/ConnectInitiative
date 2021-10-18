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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4 - Copy.MVC.Views.SearchBox
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
    
    #line 5 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SearchBox/SearchBox.cshtml")]
    public partial class SearchBox : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Search.Mvc.Models.ISearchBoxModel>
    {
        public SearchBox()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
  
    var searchTextBoxId = Guid.NewGuid();
    var searchButtonId = Guid.NewGuid();

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(!String.IsNullOrEmpty(Model.CssClass) ?
        Html.Raw(String.Format("<div class=\"{0} form-inline\">", HttpUtility.HtmlAttributeEncode(Model.CssClass))) :
        Html.Raw("<div class=\"form-inline\">"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"form-group sf-search-input-wrapper\"");

WriteLiteral(" role=\"search\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"search\"");

WriteAttribute("title", Tuple.Create(" title=\"", 592), Tuple.Create("\"", 629)
            
            #line 14 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 600), Tuple.Create<System.Object, System.Int32>(Html.Resource("SearchInput")
            
            #line default
            #line hidden
, 600), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 630), Tuple.Create("\"", 665)
            
            #line 14 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 644), Tuple.Create<System.Object, System.Int32>(Model.BackgroundHint
            
            #line default
            #line hidden
, 644), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 666), Tuple.Create("\"", 687)
            
            #line 14 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                        , Tuple.Create(Tuple.Create("", 671), Tuple.Create<System.Object, System.Int32>(searchTextBoxId
            
            #line default
            #line hidden
, 671), false)
);

WriteLiteral(" class=\"form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 709), Tuple.Create("\"", 739)
            
            #line 14 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                                                                       , Tuple.Create(Tuple.Create("", 717), Tuple.Create<System.Object, System.Int32>(ViewBag.SearchQuery
            
            #line default
            #line hidden
, 717), false)
);

WriteLiteral(" aria-autocomplete=\"both\"");

WriteAttribute("aria-describedby", Tuple.Create(" aria-describedby=\'", 765), Tuple.Create("\'", 812)
            
            #line 14 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                                                                                                                                         , Tuple.Create(Tuple.Create("", 784), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("SearchInfo")
            
            #line default
            #line hidden
, 784), false)
);

WriteLiteral(" />\r\n    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary ml-2\"");

WriteAttribute("id", Tuple.Create(" id=\"", 872), Tuple.Create("\"", 894)
            
            #line 15 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 877), Tuple.Create<System.Object, System.Int32>(searchButtonId
            
            #line default
            #line hidden
, 877), false)
);

WriteLiteral(" ");

            
            #line 15 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                                                                          Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 15 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                                                                                                                         Write(Html.Resource("SearchLabel"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n    <span");

WriteAttribute("id", Tuple.Create(" id=\'", 993), Tuple.Create("\'", 1026)
            
            #line 16 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 998), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("SearchInfo")
            
            #line default
            #line hidden
, 998), false)
);

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" hidden>When autocomplete results are available use up and down arrows to review " +
"and enter to select.</span>\r\n</div>\r\n\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"resultsUrl\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1212), Tuple.Create("\"", 1239)
            
            #line 19 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1220), Tuple.Create<System.Object, System.Int32>(Model.ResultsUrl
            
            #line default
            #line hidden
, 1220), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"indexCatalogue\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1295), Tuple.Create("\"", 1326)
            
            #line 20 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1303), Tuple.Create<System.Object, System.Int32>(Model.IndexCatalogue
            
            #line default
            #line hidden
, 1303), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"wordsMode\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1377), Tuple.Create("\"", 1414)
            
            #line 21 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1385), Tuple.Create<System.Object, System.Int32>(Model.WordsMode.ToString()
            
            #line default
            #line hidden
, 1385), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"disableSuggestions\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1474), Tuple.Create("\'", 1532)
            
            #line 22 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1482), Tuple.Create<System.Object, System.Int32>(Model.DisableSuggestions ? ("true") : ("false")
            
            #line default
            #line hidden
, 1482), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"minSuggestionLength\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1593), Tuple.Create("\"", 1629)
            
            #line 23 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1601), Tuple.Create<System.Object, System.Int32>(Model.MinSuggestionLength
            
            #line default
            #line hidden
, 1601), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionFields\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1687), Tuple.Create("\"", 1720)
            
            #line 24 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1695), Tuple.Create<System.Object, System.Int32>(Model.SuggestionFields
            
            #line default
            #line hidden
, 1695), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"language\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1770), Tuple.Create("\"", 1795)
            
            #line 25 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1778), Tuple.Create<System.Object, System.Int32>(Model.Language
            
            #line default
            #line hidden
, 1778), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"siteId\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1843), Tuple.Create("\"", 1897)
            
            #line 26 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1851), Tuple.Create<System.Object, System.Int32>(SystemManager.CurrentContext.CurrentSite.Id
            
            #line default
            #line hidden
, 1851), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionsRoute\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1955), Tuple.Create("\"", 1988)
            
            #line 27 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1963), Tuple.Create<System.Object, System.Int32>(Model.SuggestionsRoute
            
            #line default
            #line hidden
, 1963), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchTextBoxId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 2045), Tuple.Create("\'", 2088)
            
            #line 28 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 2053), Tuple.Create<System.Object, System.Int32>("#" + searchTextBoxId.ToString()
            
            #line default
            #line hidden
, 2053), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchButtonId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 2144), Tuple.Create("\'", 2186)
            
            #line 29 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 2152), Tuple.Create<System.Object, System.Int32>("#" + searchButtonId.ToString()
            
            #line default
            #line hidden
, 2152), false)
);

WriteLiteral(" />\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

            
            #line 33 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 34 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(ScriptRef.JQueryUI, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 35 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SearchBox/Search-box.js"), "bottom", true));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
