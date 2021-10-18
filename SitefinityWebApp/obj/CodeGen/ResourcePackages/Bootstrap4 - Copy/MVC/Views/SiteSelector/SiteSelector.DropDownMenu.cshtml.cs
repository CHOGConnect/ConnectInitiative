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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4___Copy.MVC.Views.SiteSelector
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
    
    #line 5 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.SiteSelector;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4 - Copy/MVC/Views/SiteSelector/SiteSelector.DropDown" +
        "Menu.cshtml")]
    public partial class SiteSelector_DropDownMenu : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.SiteSelector.SiteSelectorViewModel>
    {
        public SiteSelector_DropDownMenu()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 259), Tuple.Create("\"", 282)
            
            #line 7 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
, Tuple.Create(Tuple.Create("", 267), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 267), false)
);

WriteLiteral(">\r\n\r\n    <h3>");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
   Write(Html.Resource("Sites"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n    <label");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 11 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                      Write(Html.Resource("Sites"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n");

            
            #line 12 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
     if (SystemManager.IsDesignMode && !SystemManager.IsInlineEditingMode && !SystemManager.IsPreviewMode)
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("<select>\r\n");

            
            #line 15 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("<select onchange=\"document.location.href = this.value\">\r\n");

            
            #line 19 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 20 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
             if (!Model.IncludeCurrentSite)
            { 

            
            #line default
            #line hidden
WriteLiteral("                <option>");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                   Write(Html.Resource("SelectSite"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 23 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 25 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
            
            
            #line default
            #line hidden
            
            #line 25 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
              
                string currentSite = string.Empty;
             
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 29 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
            
            
            #line default
            #line hidden
            
            #line 29 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
             foreach (var site in Model.Sites)
            {                
                if (!Model.EachLanguageAsSeparateSite)
                {

            
            #line default
            #line hidden
WriteLiteral("                     <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1030), Tuple.Create("\"", 1047)
            
            #line 33 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
, Tuple.Create(Tuple.Create("", 1038), Tuple.Create<System.Object, System.Int32>(site.Url
            
            #line default
            #line hidden
, 1038), false)
);

WriteLiteral(" ");

            
            #line 33 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                                           Write(site.IsCurrent ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 33 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                                                                                       Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 34 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                }
                else if (Model.SiteLanguagesDisplayMode == SiteLanguagesDisplayMode.SiteNamesAndLanguages)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1288), Tuple.Create("\"", 1305)
            
            #line 37 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
, Tuple.Create(Tuple.Create("", 1296), Tuple.Create<System.Object, System.Int32>(site.Url
            
            #line default
            #line hidden
, 1296), false)
);

WriteLiteral(" ");

            
            #line 37 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                                          Write(site.IsCurrent ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 37 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                                                                                      Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 37 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                                                                                                   Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 38 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                }
                else
                {
                    if(currentSite != site.Name)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">- ");

            
            #line 43 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                                      Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral(" -</option>\r\n");

            
            #line 44 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                        currentSite = site.Name;
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1689), Tuple.Create("\"", 1706)
            
            #line 46 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
, Tuple.Create(Tuple.Create("", 1697), Tuple.Create<System.Object, System.Int32>(site.Url
            
            #line default
            #line hidden
, 1697), false)
);

WriteLiteral(" ");

            
            #line 46 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                                          Write(site.IsCurrent ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 46 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                                                                                      Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 47 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\SiteSelector\SiteSelector.DropDownMenu.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </select>\r\n   \r\n</div>");

        }
    }
}
#pragma warning restore 1591
