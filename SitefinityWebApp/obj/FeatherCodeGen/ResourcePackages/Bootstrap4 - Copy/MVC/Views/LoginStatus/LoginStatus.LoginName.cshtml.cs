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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4 - Copy.MVC.Views.LoginStatus
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
    
    #line 3 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
    using Telerik.Sitefinity.Mvc.Proxy;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LoginStatus/LoginStatus.LoginName.cshtml")]
    public partial class LoginStatus_LoginName : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginStatus.LoginStatusViewModel>
    {
        public LoginStatus_LoginName()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
  
var SignOutUrl = string.Concat(Url.Action("SignOut"),string.Format("?{0}={1}", MvcControllerProxy.ControllerKey, ViewData[MvcControllerProxy.ControllerKey]));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 395), Tuple.Create("\"", 418)
            
            #line 11 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 403), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 403), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" data-sf-role=\"sf-logged-in-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n        <span>");

            
            #line 13 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
         Write(Html.Resource("LoggedAs"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 548), Tuple.Create("\"", 585)
            
            #line 14 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 555), Tuple.Create<System.Object, System.Int32>(Model.ProfilePageUrl ?? "#"
            
            #line default
            #line hidden
, 555), false)
);

WriteLiteral(" data-sf-role=\"sf-logged-in-name\"");

WriteLiteral(" class=\"mr-2\"");

WriteLiteral("></a>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 649), Tuple.Create("\"", 667)
            
            #line 15 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 656), Tuple.Create<System.Object, System.Int32>(SignOutUrl
            
            #line default
            #line hidden
, 656), false)
);

WriteLiteral(">");

            
            #line 15 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
                         Write(Html.Resource("Logout"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" data-sf-role=\"sf-logged-out-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 790), Tuple.Create("\"", 825)
            
            #line 19 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 797), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl ?? "#"
            
            #line default
            #line hidden
, 797), false)
);

WriteLiteral(" class=\"mr-2\"");

WriteLiteral(">");

            
            #line 19 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
                                                       Write(Html.Resource("Login"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 879), Tuple.Create("\"", 921)
            
            #line 20 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 886), Tuple.Create<System.Object, System.Int32>(Model.RegistrationPageUrl ?? "#"
            
            #line default
            #line hidden
, 886), false)
);

WriteLiteral(">");

            
            #line 20 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
                                                 Write(Html.Resource("RegisterNow"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </div>\r\n</div>\r\n\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-status-json-endpoint-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1043), Tuple.Create("\"", 1074)
            
            #line 24 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1051), Tuple.Create<System.Object, System.Int32>(Model.StatusServiceUrl
            
            #line default
            #line hidden
, 1051), false)
);

WriteLiteral("/>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-logout-redirect-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1137), Tuple.Create("\"", 1165)
            
            #line 25 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1145), Tuple.Create<System.Object, System.Int32>(Model.LogoutPageUrl
            
            #line default
            #line hidden
, 1145), false)
);

WriteLiteral("/>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-is-design-mode-value\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1229), Tuple.Create("\"", 1269)
            
            #line 26 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1237), Tuple.Create<System.Object, System.Int32>(ViewBag.IsDesignMode.ToString()
            
            #line default
            #line hidden
, 1237), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-allow-windows-sts-login\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1337), Tuple.Create("\"", 1383)
            
            #line 27 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1345), Tuple.Create<System.Object, System.Int32>(Model.AllowWindowsStsLogin.ToString()
            
            #line default
            #line hidden
, 1345), false)
);

WriteLiteral(" />\r\n\r\n");

            
            #line 29 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/LoginStatus/login-status.js"), "bottom", true));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
