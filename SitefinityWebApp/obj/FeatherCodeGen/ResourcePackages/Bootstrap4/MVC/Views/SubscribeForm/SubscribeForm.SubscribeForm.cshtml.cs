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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.SubscribeForm
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
    
    #line 4 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SubscribeForm/SubscribeForm.SubscribeForm.cshtml")]
    public partial class SubscribeForm_SubscribeForm : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.EmailCampaigns.Mvc.Models.SubscribeFormViewModel>
    {
        public SubscribeForm_SubscribeForm()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 9 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js", "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 11 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 13 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
  
	var hasValidationMessage = Html.ValidationMessageFor(m => m.Email) != null;
	var attributes = new Dictionary<string, object>()
	{
		{ "class", "form-control" },
		{ "type", "email" },
		{ "aria-required", "true" }
	};

	if (hasValidationMessage)
	{
		attributes.Add("aria-describedby", Html.UniqueId("SubscribeFormInfo") + " " + Html.UniqueId("SubscribeFormValidatonInfo"));
	}
	else
	{
		attributes.Add("aria-describedby", Html.UniqueId("SubscribeFormInfo"));
	}

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 1025), Tuple.Create("\"", 1048)
            
            #line 32 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
, Tuple.Create(Tuple.Create("", 1033), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 1033), false)
);

WriteLiteral(">\r\n");

            
            #line 33 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
	
            
            #line default
            #line hidden
            
            #line 33 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
     using (Html.BeginFormSitefinity("Subscribe", "SubscribeForm"))
	{

            
            #line default
            #line hidden
WriteLiteral("\t\t<h3>");

            
            #line 35 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
       Write(Html.Resource("Subscribe"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 36 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
	

            
            #line default
            #line hidden
WriteLiteral("\t\t<p");

WriteLiteral(" class=\"text-muted\"");

WriteAttribute("id", Tuple.Create(" id=\'", 1188), Tuple.Create("\'", 1228)
            
            #line 37 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
, Tuple.Create(Tuple.Create("", 1193), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("SubscribeFormInfo")
            
            #line default
            #line hidden
, 1193), false)
);

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t");

            
            #line 38 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
       Write(Html.Resource("SubscribeMail"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t</p>\r\n");

            
            #line 40 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
	
		if (ViewBag.IsSucceeded == true)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<div");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 44 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
           Write(Html.Resource("ThankYou"));

            
            #line default
            #line hidden
WriteLiteral(". ");

            
            #line 44 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                                       Write(Html.Resource("ThankYouMessage"));

            
            #line default
            #line hidden
WriteLiteral(" (");

            
            #line 44 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                                                                          Write(ViewBag.Email);

            
            #line default
            #line hidden
WriteLiteral(")\r\n\t\t\t</div>\r\n");

            
            #line 46 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
		}
	
		
            
            #line default
            #line hidden
            
            #line 48 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
   Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 48 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                                     
		if(!string.IsNullOrEmpty(ViewBag.Error))
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 52 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
           Write(ViewBag.Error);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t</div>\r\n");

            
            #line 54 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
		}
	
		
            
            #line default
            #line hidden
            
            #line 74 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
          
		

            
            #line default
            #line hidden
WriteLiteral("\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t");

            
            #line 77 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
       Write(Html.LabelFor(u => u.Email, Html.Resource("Email")));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\t\t\t<div");

WriteLiteral(" class=\"form-inline\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 80 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
           Write(Html.TextBoxFor(m => m.Email, attributes));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t<button");

WriteLiteral(" class=\"btn btn-primary ml-2\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" ");

            
            #line 81 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                                                               Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 81 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                                                                                                              Write(Html.Resource("ButtonSubscribe"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n\t\t\t</div>\r\n\r\n");

            
            #line 84 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
			
            
            #line default
            #line hidden
            
            #line 84 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
             if (Html.ValidationMessageFor(m => m.Email) != null)
			{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<div");

WriteAttribute("id", Tuple.Create(" id=\'", 2950), Tuple.Create("\'", 2999)
            
            #line 86 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
, Tuple.Create(Tuple.Create("", 2955), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("SubscribeFormValidatonInfo")
            
            #line default
            #line hidden
, 2955), false)
);

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"form-text\"");

WriteLiteral(">");

            
            #line 87 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                                       Write(Html.ValidationMessageFor(u => u.Email));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t\t\t</div>\r\n");

            
            #line 89 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t</div>\r\n");

            
            #line 91 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
	}

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
