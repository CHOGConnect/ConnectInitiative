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

namespace SitefinityWebApp.obj.Release.Package.PackageTmp.ResourcePackages.Bootstrap4.MVC.Views.LanguageSelector
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
    
    #line 3 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 4 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/obj/Release/Package/PackageTmp/ResourcePackages/Bootstrap4/MVC/Views/LanguageSe" +
        "lector/LanguageSelector.DropDownMenu.cshtml")]
    public partial class LanguageSelector_DropDownMenu : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.LanguageSelector.LanguageSelectorViewModel>
    {
        public LanguageSelector_DropDownMenu()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 231), Tuple.Create("\"", 271)
            
            #line 7 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
, Tuple.Create(Tuple.Create("", 239), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 239), false)
, Tuple.Create(Tuple.Create(" ", 254), Tuple.Create("sf-lang-selector", 255), true)
);

WriteLiteral(">\n    <label>\n");

WriteLiteral("        ");

            
            #line 9 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
   Write(Html.Resource("Language"));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 10 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
        
            
            #line default
            #line hidden
            
            #line 10 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
         if (SystemManager.IsDesignMode)
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("<select>\n");

            
            #line 13 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("<select onChange=\"openLink(value)\">\n");

            
            #line 17 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 19 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
             if (!Model.IncludeCurrentLanguage)
            {

            
            #line default
            #line hidden
WriteLiteral("                <option");

WriteLiteral(" value=\"\"");

WriteLiteral(" selected=\"selected\"");

WriteLiteral(">");

            
            #line 21 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
                                                Write(Html.Resource("SelectLanguageDropDownOption"));

            
            #line default
            #line hidden
WriteLiteral("</option>\n");

            
            #line 22 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 24 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
            
            
            #line default
            #line hidden
            
            #line 24 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
             foreach (var language in Model.Languages)
            {

            
            #line default
            #line hidden
WriteLiteral("                <option");

WriteAttribute("value", Tuple.Create(" value=\"", 767), Tuple.Create("\"", 792)
            
            #line 26 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
, Tuple.Create(Tuple.Create("", 775), Tuple.Create<System.Object, System.Int32>(language.Culture
            
            #line default
            #line hidden
, 775), false)
);

WriteLiteral(" ");

            
            #line 26 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
                                              Write(language.Culture == Model.CurrentLanguage ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 26 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
                                                                                                                     Write(language.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</option>\n");

            
            #line 27 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </select>\n    </label>\n</div>\n\n");

            
            #line 32 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.DropDownMenu.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/LanguageSelector/language-selector.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
