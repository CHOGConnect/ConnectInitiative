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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4 - Copy.MVC.Views.HierarchicalTaxonomy
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
    
    #line 3 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/HierarchicalTaxonomy/HierarchicalTaxonomy.CategoriesList.cshtml")]
    public partial class HierarchicalTaxonomy_CategoriesList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Taxonomies.Mvc.Models.TaxonomyViewModel>
    {
        public HierarchicalTaxonomy_CategoriesList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<ul");

WriteAttribute("class", Tuple.Create(" class=\"", 132), Tuple.Create("\"", 169)
            
            #line 5 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
, Tuple.Create(Tuple.Create("", 140), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 140), false)
, Tuple.Create(Tuple.Create(" ", 155), Tuple.Create("list-unstyled", 156), true)
);

WriteLiteral(">\r\n");

            
            #line 6 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 6 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
     foreach (var taxon in Model.Taxa)
    {

            
            #line default
            #line hidden
WriteLiteral("        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 248), Tuple.Create("\"", 265)
            
            #line 9 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
, Tuple.Create(Tuple.Create("", 255), Tuple.Create<System.Object, System.Int32>(taxon.Url
            
            #line default
            #line hidden
, 255), false)
);

WriteLiteral(">");

            
            #line 9 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
                            Write(taxon.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n\r\n");

            
            #line 11 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 11 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
             if (Model.ShowItemCount)
            {

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 13 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
                                    Write(Html.HtmlSanitize(string.Format("({0})", taxon.Count)));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 14 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </li>\r\n");

            
            #line 16 "..\..MVC\Views\HierarchicalTaxonomy\HierarchicalTaxonomy.CategoriesList.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n");

        }
    }
}
#pragma warning restore 1591
