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

namespace SitefinityWebApp.ResourcePackages.Connect.MVC.Views.EmailTextField
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
    
    #line 4 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Connect/MVC/Views/EmailTextField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.EmailTextField.EmailTextFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 8 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 10 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
  
    var isRequired = Model.ValidatorDefinition.Required.HasValue && Model.ValidatorDefinition.Required.Value ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 553), Tuple.Create("\"", 587)
            
            #line 15 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 561), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 561), false)
, Tuple.Create(Tuple.Create(" ", 576), Tuple.Create("form-group", 577), true)
);

WriteLiteral(" data-sf-role=\"email-text-field-container\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" data-sf-role=\"violation-restrictions\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 695), Tuple.Create("\'", 808)
, Tuple.Create(Tuple.Create("", 703), Tuple.Create("{\"maxLength\":\"", 703), true)
            
            #line 16 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
     , Tuple.Create(Tuple.Create("", 717), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MaxLength
            
            #line default
            #line hidden
, 717), false)
, Tuple.Create(Tuple.Create("", 753), Tuple.Create("\",", 753), true)
, Tuple.Create(Tuple.Create(" ", 755), Tuple.Create("\"minLength\":", 756), true)
, Tuple.Create(Tuple.Create(" ", 768), Tuple.Create("\"", 769), true)
            
            #line 16 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
                                                          , Tuple.Create(Tuple.Create("", 770), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MinLength
            
            #line default
            #line hidden
, 770), false)
, Tuple.Create(Tuple.Create("", 806), Tuple.Create("\"}", 806), true)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 872), Tuple.Create("\'", 1152)
, Tuple.Create(Tuple.Create("", 880), Tuple.Create("{\"maxLength\":\"", 880), true)
            
            #line 17 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
 , Tuple.Create(Tuple.Create("", 894), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MaxLengthViolationMessage
            
            #line default
            #line hidden
, 894), false)
, Tuple.Create(Tuple.Create("", 946), Tuple.Create("\",", 946), true)
, Tuple.Create(Tuple.Create(" ", 948), Tuple.Create("\"required\":", 949), true)
, Tuple.Create(Tuple.Create(" ", 960), Tuple.Create("\"", 961), true)
            
            #line 17 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
                                                                     , Tuple.Create(Tuple.Create("", 962), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RequiredViolationMessage
            
            #line default
            #line hidden
, 962), false)
, Tuple.Create(Tuple.Create("", 1013), Tuple.Create("\",", 1013), true)
, Tuple.Create(Tuple.Create(" ", 1015), Tuple.Create("\"invalid\":", 1016), true)
, Tuple.Create(Tuple.Create(" ", 1026), Tuple.Create("\"", 1027), true)
            
            #line 17 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
                                                                                                                                      , Tuple.Create(Tuple.Create("", 1028), Tuple.Create<System.Object, System.Int32>(Html.Resource("InvalidEntryMessage")
            
            #line default
            #line hidden
, 1028), false)
, Tuple.Create(Tuple.Create("", 1065), Tuple.Create("\",", 1065), true)
, Tuple.Create(Tuple.Create(" ", 1067), Tuple.Create("\"regularExpression\":", 1068), true)
, Tuple.Create(Tuple.Create(" ", 1088), Tuple.Create("\"", 1089), true)
            
            #line 17 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1090), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RegularExpressionViolationMessage
            
            #line default
            #line hidden
, 1090), false)
, Tuple.Create(Tuple.Create("", 1150), Tuple.Create("\"}", 1150), true)
);

WriteLiteral(" />\r\n    \r\n    <label");

WriteLiteral(" class=\"h6\"");

WriteAttribute("for", Tuple.Create(" for=\'", 1185), Tuple.Create("\'", 1214)
            
            #line 19 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1191), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Email")
            
            #line default
            #line hidden
, 1191), false)
);

WriteLiteral(">");

            
            #line 19 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
                                               Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n    <input");

WriteAttribute("id", Tuple.Create(" \r\n        id=\'", 1258), Tuple.Create("\'", 1296)
            
            #line 21 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1273), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Email")
            
            #line default
            #line hidden
, 1273), false)
);

WriteLiteral("\r\n        data-sf-role=\"email-text-field-input\"");

WriteAttribute("type", Tuple.Create("\r\n        type=\"", 1344), Tuple.Create("\"", 1394)
            
            #line 23 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1360), Tuple.Create<System.Object, System.Int32>(Model.InputType.ToHtmlInputType()
            
            #line default
            #line hidden
, 1360), false)
);

WriteLiteral("\r\n        class=\"form-control\"");

WriteAttribute("name", Tuple.Create("\r\n        name=\"", 1425), Tuple.Create("\"", 1467)
            
            #line 25 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1441), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 1441), false)
);

WriteAttribute("placeholder", Tuple.Create("\r\n        placeholder=\"", 1468), Tuple.Create("\"", 1513)
            
            #line 26 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1491), Tuple.Create<System.Object, System.Int32>(Model.PlaceholderText
            
            #line default
            #line hidden
, 1491), false)
);

WriteAttribute("value", Tuple.Create("\r\n        value=\"", 1514), Tuple.Create("\"", 1543)
            
            #line 27 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1531), Tuple.Create<System.Object, System.Int32>(Model.Value
            
            #line default
            #line hidden
, 1531), false)
);

WriteAttribute("aria-required", Tuple.Create("\r\n        aria-required=\"", 1544), Tuple.Create("\"", 1580)
            
            #line 28 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1569), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 1569), false)
);

WriteLiteral("\r\n        ");

            
            #line 29 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
   Write(Html.Raw(Model.ValidationAttributes));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 30 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 30 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
          if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("aria-describedby=\'");

            
            #line 30 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
                                                   Write(Html.UniqueId("EmailInfo"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 30 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
                                                                               Write(Html.UniqueId("EmailErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" ");

            
            #line 30 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
                                                                                                                                } else {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("aria-describedby=\'");

            
            #line 30 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
                                                                                                                                                            Write(Html.UniqueId("TextboxErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" ");

            
            #line 30 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
                                                                                                                                                                                                               } 
            
            #line default
            #line hidden
WriteLiteral(" />\r\n\r\n");

            
            #line 32 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 32 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
     if (hasDescription)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteAttribute("id", Tuple.Create(" id=\'", 1890), Tuple.Create("\'", 1922)
            
            #line 34 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1895), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("EmailInfo")
            
            #line default
            #line hidden
, 1895), false)
);

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 34 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
                                                          Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 35 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteAttribute("id", Tuple.Create(" id=\'", 1994), Tuple.Create("\'", 2034)
            
            #line 37 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1999), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("EmailErrorMessage")
            
            #line default
            #line hidden
, 1999), false)
);

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral("></div>\r\n</div>\r\n\r\n");

            
            #line 40 "..\..\ResourcePackages\Connect\MVC\Views\EmailTextField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/EmailTextField/email-text-field.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
