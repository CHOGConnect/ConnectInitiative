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

namespace SitefinityWebApp.obj.Release.Package.PackageTmp.ResourcePackages.Bootstrap4.MVC.Views.DocumentsList
{
    
    #line 3 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
    using System;
    
    #line default
    #line hidden
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
    
    #line 5 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList;
    
    #line default
    #line hidden
    
    #line 4 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/obj/Release/Package/PackageTmp/ResourcePackages/Bootstrap4/MVC/Views/DocumentsL" +
        "ist/List.DocumentsTable.cshtml")]
    public partial class List_DocumentsTable : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList.DocumentsListViewModel>
    {
        public List_DocumentsTable()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 225), Tuple.Create("\"", 248)
            
            #line 7 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
, Tuple.Create(Tuple.Create("", 233), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 233), false)
);

WriteLiteral(">\n\n    <div");

WriteLiteral(" class=\"sf-document-list sf-document-list--table\"");

WriteLiteral(">\n\n        <table");

WriteLiteral(" class=\"table\"");

WriteLiteral(">\n            <thead>\n                <tr>\n                    <td");

WriteLiteral(" scope=\"col\"");

WriteLiteral("><strong>");

            
            #line 14 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                                       Write(Html.Resource("Title"));

            
            #line default
            #line hidden
WriteLiteral("</strong></td>\n                    <td");

WriteLiteral(" scope=\"col\"");

WriteLiteral("><strong>");

            
            #line 15 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                                       Write(Html.Resource("Type"));

            
            #line default
            #line hidden
WriteLiteral("</strong></td>\n                    <td");

WriteLiteral(" scope=\"col\"");

WriteLiteral("><strong>");

            
            #line 16 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                                       Write(Html.Resource("Size"));

            
            #line default
            #line hidden
WriteLiteral("</strong></td>\n                    <td></td>\n                </tr>\n            </" +
"thead>\n");

            
            #line 20 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
             foreach (var item in Model.Items)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\n                    <th");

WriteLiteral(" scope=\"row\"");

WriteLiteral(">\n                        <span");

WriteLiteral(" class=\"sf-icon-txt\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\n                            <svg");

WriteLiteral(" class=\"sf-icon-file sf-icon-sm\"");

WriteLiteral(">\n                                <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 991), Tuple.Create("\"", 1068)
, Tuple.Create(Tuple.Create("", 1004), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap4/assets/dist/sprites/solid.svg#file")
, 1004), false)
);

WriteLiteral("></use>\n                            </svg>\n                            <span");

WriteAttribute("class", Tuple.Create(" class=\"", 1145), Tuple.Create("\"", 1222)
, Tuple.Create(Tuple.Create("", 1153), Tuple.Create("sf-icon-txt-sm", 1153), true)
, Tuple.Create(Tuple.Create(" ", 1167), Tuple.Create("sf-icon-txt-", 1168), true)
            
            #line 28 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
, Tuple.Create(Tuple.Create("", 1180), Tuple.Create<System.Object, System.Int32>(((DocumentItemViewModel)item).Extension
            
            #line default
            #line hidden
, 1180), false)
);

WriteLiteral(">");

            
            #line 28 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                                                                                                            Write(((DocumentItemViewModel)item).Extension);

            
            #line default
            #line hidden
WriteLiteral("</span>\n                        </span>\n                        <a");

WriteLiteral(" class=\"sf-title\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1349), Tuple.Create("\"", 1463)
            
            #line 30 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
, Tuple.Create(Tuple.Create("", 1356), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix)
            
            #line default
            #line hidden
, 1356), false)
);

WriteLiteral(">\n");

WriteLiteral("                            ");

            
            #line 31 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                       Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\n                        </a>\n                    </th>\n                    <td>\n" +
"");

WriteLiteral("                        ");

            
            #line 35 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                    Write(((DocumentItemViewModel)item).Extension);

            
            #line default
            #line hidden
WriteLiteral("\n                    </td>\n                    <td>\n");

WriteLiteral("                        ");

            
            #line 38 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                    Write(Math.Ceiling((double)item.Fields.TotalSize / 1024) + " KB");

            
            #line default
            #line hidden
WriteLiteral("\n                    </td>\n                    <td>\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1874), Tuple.Create("\"", 1902)
            
            #line 41 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
, Tuple.Create(Tuple.Create("", 1881), Tuple.Create<System.Object, System.Int32>(item.Fields.MediaUrl
            
            #line default
            #line hidden
, 1881), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 41 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                                                                   Write(Html.Resource("Download"));

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 41 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
                                                                                                                   Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span></a>\n                    </td>\n                </tr>\n");

            
            #line 44 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\n\n    </div>\n\n</div>\n\n");

            
            #line 51 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 53 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 58 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\DocumentsList\List.DocumentsTable.cshtml"
         
}

            
            #line default
            #line hidden
WriteLiteral("\n\n");

        }
    }
}
#pragma warning restore 1591
