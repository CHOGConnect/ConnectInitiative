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

namespace SitefinityWebApp.obj.Release.Package.PackageTmp.ResourcePackages.Bootstrap4.MVC.Views.LoginForm
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    
    #line 3 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using System.Linq.Expressions;
    
    #line default
    #line hidden
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
    
    #line 8 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginForm;
    
    #line default
    #line hidden
    
    #line 5 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 7 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 4 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    #line 9 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Web;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/obj/Release/Package/PackageTmp/ResourcePackages/Bootstrap4/MVC/Views/LoginForm/" +
        "LoginForm.LoginForm.cshtml")]
    public partial class LoginForm_LoginForm : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginForm.LoginFormViewModel>
    {

#line 94 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
public System.Web.WebPages.HelperResult FormGroupPanel(string label, Expression<Func<LoginFormViewModel, string>> expression, string descId, string inputType = "text", string classValue = null, IDictionary<string, object> additionalAttributes = null)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 95 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
 
    var hasValidationMessage = Html.ValidationMessageFor(expression) != null;
    var attributes = new Dictionary<string, object>();
    var cls = "form-control";

    if (classValue != null)
    {
        cls += " " + classValue;
    }

    attributes.Add("class", cls);

    if (hasValidationMessage)
    {
        attributes.Add("aria-describedby", Html.UniqueId(descId));
    }
    if (additionalAttributes != null)
    {
        attributes = attributes.Concat(additionalAttributes).ToDictionary(x => x.Key, x => x.Value);
    }



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"form-group\"");

WriteLiteralTo(__razor_helper_writer, ">\n\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 118 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.LabelFor(expression, Html.Resource(label)));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n\n");


#line 120 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
        

#line default
#line hidden

#line 120 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
         switch (inputType)
        {
            case "text":
                

#line default
#line hidden

#line 123 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.TextBoxFor(expression, attributes));


#line default
#line hidden

#line 123 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                        ;
                break;

            case "textarea":
                

#line default
#line hidden

#line 127 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.TextAreaFor(expression, attributes));


#line default
#line hidden

#line 127 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                         ;
                break;

            case "password":
                

#line default
#line hidden

#line 131 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.PasswordFor(expression, attributes));


#line default
#line hidden

#line 131 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                         ;
                break;

            default:
                break;
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n");


#line 138 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
        

#line default
#line hidden

#line 138 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
         if (hasValidationMessage)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\'", 5542), Tuple.Create("\'", 5569)

#line 140 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 5547), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(descId)

#line default
#line hidden
, 5547), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"text-danger\"");

WriteLiteralTo(__razor_helper_writer, " role=\"alert\"");

WriteLiteralTo(__razor_helper_writer, " aria-live=\"assertive\"");

WriteLiteralTo(__razor_helper_writer, ">\n                <span");

WriteLiteralTo(__razor_helper_writer, " class=\"form-text\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 141 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
          WriteTo(__razor_helper_writer, Html.ValidationMessageFor(expression));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\n            </div>\n");


#line 143 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </div>\n");


#line 145 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"


#line default
#line hidden
});

#line 145 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
}
#line default
#line hidden

        public LoginForm_LoginForm()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("\n");

            
            #line 12 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 13 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js", "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 14 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 16 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
  
    var hasExternalProviders = Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0;
    var rowClass = hasExternalProviders ? "row" : "";
    var colClass = hasExternalProviders ? "col-lg-6" : "";

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 871), Tuple.Create("\"", 898)
            
            #line 22 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 879), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 879), false)
, Tuple.Create(Tuple.Create(" ", 894), Tuple.Create("m-0", 895), true)
);

WriteLiteral(">\n");

            
            #line 23 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
     using (Html.BeginFormSitefinity(@Request.Url.Query, null, null, FormMethod.Post, new Dictionary<string, object> { { "role", "form" } }, true))
    {
        
            
            #line default
            #line hidden
            
            #line 25 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
   Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 25 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                     ;
            

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1119), Tuple.Create("\"", 1136)
            
            #line 27 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 1127), Tuple.Create<System.Object, System.Int32>(rowClass
            
            #line default
            #line hidden
, 1127), false)
);

WriteLiteral(">\n            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1155), Tuple.Create("\"", 1172)
            
            #line 28 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 1163), Tuple.Create<System.Object, System.Int32>(colClass
            
            #line default
            #line hidden
, 1163), false)
);

WriteLiteral(">\n                <h3>");

            
            #line 29 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
               Write(Html.Resource("LoginFormLogInLegendHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n\n");

            
            #line 31 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 31 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if ((!string.IsNullOrEmpty(Request.QueryStringGet("err")) && ViewBag.ControllerId.Equals(Request.QueryStringGet("sf_login_cntrl_id"))) || Model.LoginError)
                {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 33 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                                              Write(Html.Resource("IncorrectCredentialsMessage"));

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 34 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                ");

            
            #line 36 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
           Write(FormGroupPanel("UserName", u => u.UserName, "LoginUserName", "text", null, new Dictionary<string, object>() { { "aria-required", "true" } }));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

WriteLiteral("                ");

            
            #line 38 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
           Write(FormGroupPanel("Password", u => u.Password, "LoginPassword", "password", null, new Dictionary<string, object>() { { "aria-required", "true" } }));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 40 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 40 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if (Model.ShowRememberMe || Model.ShowForgotPasswordLink)
                {
                    var isPulledRight = Model.ShowRememberMe ? "col-lg-6" : "col-lg-12";


            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group row\"");

WriteLiteral(">\n");

            
            #line 45 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 45 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                         if (Model.ShowRememberMe)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"checkbox col-lg-6 m-0\"");

WriteLiteral(">\n                                <label>\n");

WriteLiteral("                                    ");

            
            #line 49 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                               Write(Html.CheckBoxFor(u => u.RememberMe));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                                    ");

            
            #line 50 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                               Write(Html.Resource("RememberMe"));

            
            #line default
            #line hidden
WriteLiteral("\n                                </label>\n                            </div>\n");

            
            #line 53 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 54 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                     if (Model.ShowForgotPasswordLink)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 2671), Tuple.Create("\"", 2712)
, Tuple.Create(Tuple.Create("", 2679), Tuple.Create("text-lg-right", 2679), true)
, Tuple.Create(Tuple.Create(" ", 2692), Tuple.Create("pr-4", 2693), true)
            
            #line 56 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create(" ", 2697), Tuple.Create<System.Object, System.Int32>(isPulledRight
            
            #line default
            #line hidden
, 2698), false)
);

WriteLiteral(">\n");

WriteLiteral("                            ");

            
            #line 57 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                       Write(Html.ActionLink(Html.Resource("ForgottenPasword"), "ForgotPassword"));

            
            #line default
            #line hidden
WriteLiteral("\n                        </div>\n");

            
            #line 59 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    </div>                \n");

            
            #line 61 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" ");

            
            #line 64 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                              Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 64 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                                                                             Write(Html.Resource("LoginFormLogInButton"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n                </div>\n\n");

            
            #line 67 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 67 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if (Model.ShowRegistrationLink)
                {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"sf-registration-link\"");

WriteLiteral(">\n                <div>");

            
            #line 70 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                Write(Html.Resource("NotRegisteredYet"));

            
            #line default
            #line hidden
WriteLiteral("</div>\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3349), Tuple.Create("\"", 3378)
            
            #line 71 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 3356), Tuple.Create<System.Object, System.Int32>(Model.RegisterPageUrl
            
            #line default
            #line hidden
, 3356), false)
);

WriteLiteral(">");

            
            #line 71 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                            Write(Html.Resource("LoginFormRegisterNow"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n            </div>\n");

            
            #line 73 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\n            \n");

            
            #line 76 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            
            
            #line default
            #line hidden
            
            #line 76 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
             if (Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-lg-6\"");

WriteLiteral(">                \n                    <h3>");

            
            #line 79 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                   Write(Html.Resource("UseAccountIn"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n\n");

            
            #line 81 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 81 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                     foreach (var provider in Model.ExternalProviders)
                    { 
                        var classToBeAdd = "btn btn-lg btn-block border " + @provider.Value;                 
                        
            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"mb-1\"");

WriteLiteral(">\n");

WriteLiteral("                            ");

            
            #line 85 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                       Write(Html.ActionLink(provider.Key, "LoginExternalProvider", new { model = provider.Key }, new { @class = classToBeAdd }));

            
            #line default
            #line hidden
WriteLiteral("\n                        </div>\n");

            
            #line 87 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\n");

            
            #line 89 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\n");

            
            #line 91 "..\..\obj\Release\Package\PackageTmp\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n");

        }
    }
}
#pragma warning restore 1591
