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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4___Copy.MVC.Views.LoginForm
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
    
    #line 4 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4 - Copy/MVC/Views/LoginForm/ForgotPassword.Forgotten" +
        "Password.cshtml")]
    public partial class ForgotPassword_ForgottenPassword : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginForm.ForgotPasswordViewModel>
    {
        public ForgotPassword_ForgottenPassword()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 218), Tuple.Create("\"", 241)
            
            #line 7 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 226), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 226), false)
);

WriteLiteral(">\r\n\r\n    <h3>");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
   Write(Html.Resource("ForgotPasswordHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n");

            
            #line 11 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
     if (Model.EmailSent)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteAttribute("id", Tuple.Create(" id=\'", 346), Tuple.Create("\'", 398)
            
            #line 13 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 351), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("ForgotPasswordRequestSentInfo")
            
            #line default
            #line hidden
, 351), false)
);

WriteLiteral(">");

            
            #line 13 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                           Write(Html.Resource("ForgotPasswordRequestSent"));

            
            #line default
            #line hidden
WriteLiteral(" <i>");

            
            #line 13 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                                                                          Write(Html.Encode(Model.Email));

            
            #line default
            #line hidden
WriteLiteral("</i></p>\r\n");

            
            #line 14 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteAttribute("id", Tuple.Create(" id=\'", 494), Tuple.Create("\'", 553)
            
            #line 15 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 499), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("ForgotPasswordRequestSentUseLinkInfo")
            
            #line default
            #line hidden
, 499), false)
);

WriteLiteral(">");

            
            #line 15 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                                  Write(Html.Resource("ForgotPasswordRequestSentUseLink"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 16 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"

        var forgottenPasswordDescription = Html.UniqueId("ForgotPasswordRequestSentInfo") + " " + Html.UniqueId("ForgotPasswordRequestSentUseLinkInfo");

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 777), Tuple.Create("\"", 803)
            
            #line 18 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 784), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 784), false)
);

WriteLiteral(" class=\"btn btn-secondary\"");

WriteAttribute("aria-describedby", Tuple.Create(" aria-describedby=\"", 830), Tuple.Create("\"", 878)
            
            #line 18 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
   , Tuple.Create(Tuple.Create("", 849), Tuple.Create<System.Object, System.Int32>(forgottenPasswordDescription
            
            #line default
            #line hidden
, 849), false)
);

WriteLiteral(">");

            
            #line 18 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                                                                            Write(Html.Resource("ForgotPasswordBackToLogin"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 19 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
    }
    else
    {
        using (Html.BeginForm("SendPasswordResetEmail", "LoginForm"))
        {

            
            #line default
            #line hidden
WriteLiteral("            <p");

WriteAttribute("id", Tuple.Create(" id=\'", 1049), Tuple.Create("\'", 1098)
            
            #line 24 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
, Tuple.Create(Tuple.Create("", 1054), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("EnterLoginEmailAddressInfo")
            
            #line default
            #line hidden
, 1054), false)
);

WriteLiteral(">");

            
            #line 24 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                            Write(Html.Resource("EnterLoginEmailAddress"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 25 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 27 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
           Write(Html.LabelFor(u => u.Email, Html.Resource("ForgotPasswordEmail")));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 28 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
           Write(Html.TextBoxFor(u => u.Email, new { @class = "form-control", aria_describedby = Html.UniqueId("EnterLoginEmailAddressInfo") }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 30 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" ");

            
            #line 31 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                      Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 31 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
                                                                                                     Write(Html.Resource("ForgotPasswordSendButton"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 32 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\LoginForm\ForgotPassword.ForgottenPassword.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
