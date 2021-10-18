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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4 - Copy.MVC.Views.UsersList
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
    
    #line 3 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 8 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Models.UsersList;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 11 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity.Modules.UserProfiles;
    
    #line default
    #line hidden
    
    #line 7 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity.Security.Model;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/UsersList/List.UsersList.cshtml")]
    public partial class List_UsersList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.UsersList.UsersListViewModel>
    {
        public List_UsersList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 512), Tuple.Create("\"", 546)
            
            #line 13 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
, Tuple.Create(Tuple.Create("", 520), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 520), false)
, Tuple.Create(Tuple.Create(" ", 535), Tuple.Create("media-list", 536), true)
);

WriteLiteral(">\r\n");

            
            #line 14 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 14 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
     if (Model.ContentType == typeof(SitefinityProfile))
    {
        foreach (var item in Model.Items)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"media sf-media\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"media-left pr-2 sf-img-thmb\"");

WriteLiteral(">\r\n                    <img");

WriteLiteral(" class=\"media-object\"");

WriteAttribute("src", Tuple.Create(" src=\"", 815), Tuple.Create("\"", 879)
            
            #line 20 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
, Tuple.Create(Tuple.Create("", 821), Tuple.Create<System.Object, System.Int32>((item as SitefinityProfileItemViewModel).AvatarImageUrl
            
            #line default
            #line hidden
, 821), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 880), Tuple.Create("\"", 908)
            
            #line 20 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
                                     , Tuple.Create(Tuple.Create("", 886), Tuple.Create<System.Object, System.Int32>(item.Fields.FirstName
            
            #line default
            #line hidden
, 886), false)
);

WriteLiteral(" width=\"100\"");

WriteLiteral(" height=\"100\"");

WriteLiteral(" />\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"media-body sf-media-body\"");

WriteLiteral(">\r\n                    <h3>\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1073), Tuple.Create("\"", 1238)
            
            #line 25 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
, Tuple.Create(Tuple.Create("", 1080), Tuple.Create<System.Object, System.Int32>(UsersHelper.EncodeUrlUsername(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage), item as SitefinityProfileItemViewModel)
            
            #line default
            #line hidden
, 1080), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 26 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
                        Write(((SitefinityProfile)item.DataItem).GetUserDisplayName());

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </h3>\r\n                    <p" +
">\r\n");

WriteLiteral("                        ");

            
            #line 30 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
                   Write(Html.HtmlSanitize((((SitefinityProfileItemViewModel)item).About)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </p>\r\n                </div>\r\n\r\n            </div>\r\n");

            
            #line 35 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
        }
    }
    else
    {
        if (SystemManager.IsDesignMode)
        {
            
            
            #line default
            #line hidden
            
            #line 41 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
       Write(Html.Resource("TheSelectedTemplateCannotBeUsed"));

            
            #line default
            #line hidden
            
            #line 41 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
                                                             
        }
        else
        {
            foreach (var item in Model.Items)
            {

            
            #line default
            #line hidden
WriteLiteral("                <h3>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1868), Tuple.Create("\"", 1962)
            
            #line 48 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
, Tuple.Create(Tuple.Create("", 1875), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage)
            
            #line default
            #line hidden
, 1875), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 49 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
                   Write(UserProfilesHelper.GetUserDisplayName(item.Fields.Owner));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </a>\r\n                </h3>\r\n");

            
            #line 52 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 56 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 56 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
     if (Model.ShowPager)
    {
        
            
            #line default
            #line hidden
            
            #line 58 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
   Write(Html.Action("Index", "ContentPager", new
           {
               currentPage = Model.CurrentPage,
               totalPagesCount = Model.TotalPagesCount.Value,
               redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
           }));

            
            #line default
            #line hidden
            
            #line 63 "..\..MVC\Views\UsersList\List.UsersList.cshtml"
             
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
