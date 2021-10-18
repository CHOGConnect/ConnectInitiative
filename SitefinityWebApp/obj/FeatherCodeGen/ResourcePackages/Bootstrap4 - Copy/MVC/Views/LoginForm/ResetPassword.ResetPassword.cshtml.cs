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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4 - Copy.MVC.Views.LoginForm
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
    
    #line 4 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LoginForm/ResetPassword.ResetPassword.cshtml")]
    public partial class ResetPassword_ResetPassword : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginForm.ResetPasswordViewModel>
    {
        public ResetPassword_ResetPassword()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 217), Tuple.Create("\"", 240)
            
            #line 7 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
, Tuple.Create(Tuple.Create("", 225), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 225), false)
);

WriteLiteral(">\r\n\r\n    <h3>");

            
            #line 9 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
   Write(Html.Resource("ResetPasswordHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n");

            
            #line 11 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    
            
            #line default
            #line hidden
            
            #line 11 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
     if (Model.ResetComplete)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3>");

            
            #line 13 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
       Write(Html.Resource("ResetPasswordSuccess"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

WriteLiteral("        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 405), Tuple.Create("\"", 431)
            
            #line 14 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
, Tuple.Create(Tuple.Create("", 412), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 412), false)
);

WriteLiteral(">");

            
            #line 14 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
                                 Write(Html.Resource("ResetPasswordBackToLogin"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 15 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    }
    else if (Model.RequiresQuestionAndAnswer && string.IsNullOrEmpty(Model.ResetPasswordQuestion))
    {    

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 18 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
                                                                      Write(Html.Resource("CannotResetPasswordError"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 19 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <form");

WriteAttribute("action", Tuple.Create(" action=\"", 761), Tuple.Create("\"", 813)
            
            #line 22 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
, Tuple.Create(Tuple.Create("", 770), Tuple.Create<System.Object, System.Int32>(Url.Action("ResetPassword", "LoginForm")
            
            #line default
            #line hidden
, 770), false)
);

WriteLiteral(" method=\"post\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 23 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
       Write(Model.Error);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 24 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
       Write(Html.HiddenFor(u => u.SecurityToken));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 26 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
            
            
            #line default
            #line hidden
            
            #line 26 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
             if (Model.RequiresQuestionAndAnswer)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 29 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
               Write(Html.LabelFor(u => u.ResetPasswordAnswer, Model.ResetPasswordQuestion));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 30 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
               Write(Html.TextBoxFor(u => u.ResetPasswordAnswer, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 32 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 35 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
           Write(Html.LabelFor(u => u.NewPassword, Html.Resource("ResetPasswordNewPassword")));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 36 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
           Write(Html.TextBoxFor(u => u.NewPassword, new { @class = "form-control", @type = "password" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 40 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
           Write(Html.LabelFor(u => u.RepeatNewPassword, Html.Resource("ResetPasswordRepeatNewPassword")));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 41 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
           Write(Html.TextBoxFor(u => u.RepeatNewPassword, new { @class = "form-control", @type = "password" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n\r\n            <input");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" type=\"submit\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1868), Tuple.Create("\'", 1917)
            
            #line 44 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
, Tuple.Create(Tuple.Create("", 1876), Tuple.Create<System.Object, System.Int32>(Html.Resource("ResetPasswordSaveButton")
            
            #line default
            #line hidden
, 1876), false)
);

WriteLiteral(" ");

            
            #line 44 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
                                                                                                       Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(" />      \r\n        </form>\r\n");

            
            #line 46 "..\..MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
