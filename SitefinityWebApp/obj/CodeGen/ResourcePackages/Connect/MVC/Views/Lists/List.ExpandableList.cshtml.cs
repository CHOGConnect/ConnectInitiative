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

namespace SitefinityWebApp.ResourcePackages.Connect.MVC.Views.Lists
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
    
    #line 5 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
    using Telerik.Sitefinity.Frontend.Lists.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Connect/MVC/Views/Lists/List.ExpandableList.cshtml")]
    public partial class List_ExpandableList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_ExpandableList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 221), Tuple.Create("\"", 244)
            
            #line 7 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
, Tuple.Create(Tuple.Create("", 229), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 229), false)
);

WriteLiteral(" data-sf-role=\"lists\"");

WriteLiteral(">\r\n\r\n    <div");

WriteLiteral(" class=\"sf-list sf-list--expandable clearfix\"");

WriteLiteral(">\r\n    \r\n        <div");

WriteLiteral(" class=\"sf-list-expand\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"expandAll\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(">");

            
            #line 12 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
                                                          Write(Html.Resource("ExpandAll"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"collapseAll\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">");

            
            #line 13 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
                                                                                  Write(Html.Resource("CollapseAll"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"sf-list-item\"");

WriteLiteral(">\r\n");

            
            #line 17 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 17 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
             foreach (var item in Model.Items)
            {

            
            #line default
            #line hidden
WriteLiteral("                <h3 ");

            
            #line 19 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
               Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 19 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
                                                                                                                   Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 20 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
               Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h3>\r\n");

            
            #line 22 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"

                foreach (var listItem in ((ListViewModel)item).ListItemViewModel.Items)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div ");

            
            #line 25 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
                    Write(Html.InlineEditingAttributes(Model.ProviderName, ((ListViewModel)item).ListItemViewModel.ContentType.FullName, (Guid)listItem.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                        <a\r\n                            href=\"javascript:void(" +
"0)\"\r\n");

WriteLiteral("                            ");

            
            #line 28 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
                       Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            data-sf-role=\"toggleLink\"\r\n                        " +
"    role=\"button\"\r\n                            data-toggle=\"collapse\"\r\n         " +
"                   data-target=\"#");

            
            #line 32 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
                                     Write(listItem.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            aria-expanded=\"false\"\r\n                           " +
" aria-controls=\"");

            
            #line 34 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
                                      Write(listItem.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <svg");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                                <use");

WriteLiteral(" class=\"sf-icon-right\"");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 1835), Tuple.Create("\"", 1919)
, Tuple.Create(Tuple.Create("", 1848), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap4/assets/dist/sprites/solid.svg#angle-right")
, 1848), false)
);

WriteLiteral("></use>\r\n                                <use");

WriteLiteral(" class=\"sf-icon-down\"");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 1986), Tuple.Create("\"", 2069)
, Tuple.Create(Tuple.Create("", 1999), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap4/assets/dist/sprites/solid.svg#angle-down")
, 1999), false)
);

WriteLiteral(" style=\"display:none\"");

WriteLiteral("></use>\r\n                            </svg>\r\n");

WriteLiteral("                            ");

            
            #line 39 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
                       Write(listItem.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                        <div ");

            
            #line 41 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
                        Write(Html.InlineEditingFieldAttributes("Content", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(" style=\"display:none;\" class=\"sf-list-content collapse multi-collapse\" id=\'");

            
            #line 41 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
                                                                                                                                                            Write(listItem.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\'>\r\n");

WriteLiteral("                            ");

            
            #line 42 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
                       Write(Html.HtmlSanitize((string)listItem.Fields.Content));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");

            
            #line 45 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");

            
            #line 51 "..\..\ResourcePackages\Connect\MVC\Views\Lists\List.ExpandableList.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Lists/lists.js"), "bottom", throwException: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
