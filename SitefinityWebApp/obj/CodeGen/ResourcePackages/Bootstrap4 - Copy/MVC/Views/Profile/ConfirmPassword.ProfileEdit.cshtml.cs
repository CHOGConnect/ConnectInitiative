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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4___Copy.MVC.Views.Profile
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Utilities;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4 - Copy/MVC/Views/Profile/ConfirmPassword.ProfileEdi" +
        "t.cshtml")]
    public partial class ConfirmPassword_ProfileEdit : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.Profile.ProfileEmailEditViewModel>
    {
        public ConfirmPassword_ProfileEdit()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js", "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 11 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div>\r\n    <h3>");

            
            #line 14 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
   Write(Html.Resource("EditProfileLink"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n");

            
            #line 16 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 16 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
     if (Model.ShowProfileChangedMsg)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 18 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
                                                                       Write(Html.Resource("ChangesAreSaved"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 19 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 21 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 21 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
     if (!String.IsNullOrEmpty(ViewBag.ErrorMessage))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 23 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
                                                                      Write(ViewBag.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 24 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 26 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 26 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
     using (Html.BeginFormSitefinity("EditEmail", "EditProfileForm", FormMethod.Post, new Dictionary<string, object> { { "enctype", "multipart/form-data"},  { "role", "form" }, { "aria-label", Html.Resource("EditProfileLink") } }))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div>\r\n");

WriteLiteral("            ");

            
            #line 29 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
       Write(Html.HiddenFor(u => u.UserId));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 30 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
       Write(Html.HiddenFor(u => u.Email));

            
            #line default
            #line hidden
WriteLiteral("                     \r\n        </div>\r\n");

            
            #line 32 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
        

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteAttribute("id", Tuple.Create(" id=\'", 1343), Tuple.Create("\'", 1391)
            
            #line 33 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 1348), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("PasswordChangeDescription")
            
            #line default
            #line hidden
, 1348), false)
);

WriteLiteral(">");

            
            #line 33 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
                                                       Write(Html.Resource("PasswordEditMessage"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 34 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

            
            #line 36 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
            
            
            #line default
            #line hidden
            
            #line 36 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
              
                var passwordDescription = Html.UniqueId("PasswordChangeDescription") + " " + Html.UniqueId("PasswordChangeValidationMessage");
            
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 39 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
       Write(Html.LabelFor(u => u.Password, Html.Resource("Password")));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 40 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
       Write(Html.PasswordFor(u => u.Password, new { @class = "form-control", aria_describedby = passwordDescription}));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            <div");

WriteAttribute("id", Tuple.Create(" id=\'", 1857), Tuple.Create("\'", 1911)
            
            #line 42 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 1862), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("PasswordChangeValidationMessage")
            
            #line default
            #line hidden
, 1862), false)
);

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 43 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
           Write(Html.ValidationMessageFor(u => u.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

            
            #line 46 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
        

            
            #line default
            #line hidden
WriteLiteral("        <div>\r\n            <input");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" data-sf-role=\"profile-submit\"");

WriteLiteral(" type=\"submit\"");

WriteAttribute("value", Tuple.Create(" value=\'", 2178), Tuple.Create("\'", 2219)
            
            #line 48 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
              , Tuple.Create(Tuple.Create("", 2186), Tuple.Create<System.Object, System.Int32>(Html.Resource("EditProfileSave")
            
            #line default
            #line hidden
, 2186), false)
);

WriteLiteral(" />   \r\n        </div>\r\n");

            
            #line 50 "..\..\ResourcePackages\Bootstrap4 - Copy\MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591