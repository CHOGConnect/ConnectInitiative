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
    
    #line 4 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/obj/Release/Package/PackageTmp/ResourcePackages/Bootstrap4/MVC/Views/LanguageSe" +
        "lector/LanguageSelector.LanguageLinks.cshtml")]
    public partial class LanguageSelector_LanguageLinks : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.LanguageSelector.LanguageSelectorViewModel>
    {

#line 26 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
public System.Web.WebPages.HelperResult GetClass(string culture)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 27 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
 
    if (Model.CurrentLanguage == culture)
    {
        

#line default
#line hidden

#line 30 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("selected"));


#line default
#line hidden

#line 30 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                             ;
    }


#line default
#line hidden
});

#line 32 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
}
#line default
#line hidden

        public LanguageSelector_LanguageLinks()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 231), Tuple.Create("\"", 254)
            
            #line 7 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
, Tuple.Create(Tuple.Create("", 239), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 239), false)
);

WriteLiteral(">\n    <ul");

WriteLiteral(" class=\"sf-lang-selector list-inline\"");

WriteLiteral(">\n");

            
            #line 9 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
        
            
            #line default
            #line hidden
            
            #line 9 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
         foreach (var language in Model.Languages)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral(">\n");

            
            #line 12 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                
            
            #line default
            #line hidden
            
            #line 12 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                 if (SystemManager.IsDesignMode)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" onclick=\"return false;\"");

WriteAttribute("class", Tuple.Create(" class=\"", 527), Tuple.Create("\"", 562)
            
            #line 14 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
, Tuple.Create(Tuple.Create("", 535), Tuple.Create<System.Object, System.Int32>(GetClass(language.Culture)
            
            #line default
            #line hidden
, 535), false)
);

WriteLiteral(">");

            
            #line 14 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                                                                                      Write(language.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 15 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("\t                <a");

WriteLiteral(" href=\"\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 674), Tuple.Create("\"", 728)
, Tuple.Create(Tuple.Create("", 684), Tuple.Create("openLink(\'", 684), true)
            
            #line 18 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
, Tuple.Create(Tuple.Create("", 694), Tuple.Create<System.Object, System.Int32>(language.Culture
            
            #line default
            #line hidden
, 694), false)
, Tuple.Create(Tuple.Create("", 711), Tuple.Create("\');", 711), true)
, Tuple.Create(Tuple.Create(" ", 714), Tuple.Create("return", 715), true)
, Tuple.Create(Tuple.Create(" ", 721), Tuple.Create("false;", 722), true)
);

WriteAttribute("class", Tuple.Create(" class=\"", 729), Tuple.Create("\"", 764)
            
            #line 18 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
              , Tuple.Create(Tuple.Create("", 737), Tuple.Create<System.Object, System.Int32>(GetClass(language.Culture)
            
            #line default
            #line hidden
, 737), false)
);

WriteLiteral(">");

            
            #line 18 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                                                                                                                     Write(language.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 19 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </li>\n");

            
            #line 21 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\n</div>\n\n");

WriteLiteral("\n");

WriteLiteral("\n");

            
            #line 34 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/LanguageSelector/language-selector.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
