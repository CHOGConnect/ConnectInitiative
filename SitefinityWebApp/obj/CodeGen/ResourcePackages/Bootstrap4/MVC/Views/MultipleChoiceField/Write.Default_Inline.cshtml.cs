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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.MultipleChoiceField
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
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/MultipleChoiceField/Write.Default_Inline." +
        "cshtml")]
    public partial class Write_Default_Inline : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.MultipleChoiceField.MultipleChoiceFieldViewModel>
    {
        public Write_Default_Inline()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
  
    var fieldName = string.IsNullOrEmpty(Model.MetaField.FieldName) ? "multiple-choice-field-name" : Model.MetaField.FieldName;
    var requiredAttributes = MvcHtmlString.Create(Model.ValidationAttributes);
    var isRequired = Model.IsRequired ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n<fieldset");

WriteAttribute("class", Tuple.Create(" class=\"", 700), Tuple.Create("\"", 734)
            
            #line 14 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 708), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 708), false)
, Tuple.Create(Tuple.Create(" ", 723), Tuple.Create("form-group", 724), true)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-container\"");

WriteLiteral(">\r\n    <legend");

WriteLiteral(" class=\"h6\"");

WriteAttribute("id", Tuple.Create(" id=\'", 807), Tuple.Create("\'", 845)
            
            #line 15 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 812), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupLabel")
            
            #line default
            #line hidden
, 812), false)
);

WriteLiteral(">");

            
            #line 15 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                         Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</legend>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 938), Tuple.Create("\'", 1042)
, Tuple.Create(Tuple.Create("", 946), Tuple.Create("{", 946), true)
, Tuple.Create(Tuple.Create(" ", 947), Tuple.Create("\"required\":", 948), true)
, Tuple.Create(Tuple.Create(" ", 959), Tuple.Create("\"", 960), true)
            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
  , Tuple.Create(Tuple.Create("", 961), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 961), false)
, Tuple.Create(Tuple.Create("", 992), Tuple.Create("\",", 992), true)
, Tuple.Create(Tuple.Create(" ", 994), Tuple.Create("\"maxLength\":\"", 995), true)
            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                , Tuple.Create(Tuple.Create("", 1008), Tuple.Create<System.Object, System.Int32>(Model.MaxLengthViolationMessage
            
            #line default
            #line hidden
, 1008), false)
, Tuple.Create(Tuple.Create("", 1040), Tuple.Create("\"}", 1040), true)
);

WriteLiteral(" />\r\n    <ul");

WriteLiteral(" class=\"list-inline\"");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\'", 1075), Tuple.Create("\'", 1126)
            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1093), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupLabel")
            
            #line default
            #line hidden
, 1093), false)
);

WriteLiteral(" ");

            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                  if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                            Write(Html.UniqueId("RadioGroupInfo"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                             Write(Html.UniqueId("RadioGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                                                                     } else {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                                                                                                  Write(Html.UniqueId("RadioGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                                                                                                                                                          } 
            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        
            
            #line default
            #line hidden
            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
         foreach (var choice in Model.Choices)
        {
            string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
            bool isSelected = (!string.IsNullOrEmpty(value) && choice == value) ||
                                (string.IsNullOrEmpty(value) && !Model.IsRequired && choice == Model.MetaField.DefaultValue as string);

            var selctedAttributes = isSelected ? "checked" : string.Empty;

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral(">\r\n                <label>\r\n");

            
            #line 27 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 27 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                      
                        var val = choice;
                        if (val.Length > 255)
                        {
                            val = val.Substring(0, 255);
                        }
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n                    <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2179), Tuple.Create("\"", 2196)
            
            #line 34 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 2186), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 2186), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 2197), Tuple.Create("\"", 2209)
            
            #line 34 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 2205), Tuple.Create<System.Object, System.Int32>(val
            
            #line default
            #line hidden
, 2205), false)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" ");

            
            #line 34 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                             Write(selctedAttributes);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 34 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                Write(requiredAttributes);

            
            #line default
            #line hidden
WriteLiteral(" role=\"radio\" aria-required=\"");

            
            #line 34 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                                Write(isRequired);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");

WriteLiteral("                    ");

            
            #line 35 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
               Write(choice);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n            </li>\r\n");

            
            #line 38 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 39 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
         if (Model.HasOtherChoice)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral(">\r\n                <label>\r\n                    <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2577), Tuple.Create("\"", 2594)
            
            #line 43 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 2584), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 2584), false)
);

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-radio\"");

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" role=\"radio\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2701), Tuple.Create("\"", 2728)
            
            #line 43 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                   , Tuple.Create(Tuple.Create("", 2717), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2717), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                    ");

            
            #line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
               Write(Html.Resource("Other"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 45 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                     Write(Html.Resource("ThisChoiceWillExpandTextbox"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </label>\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-text\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2986), Tuple.Create("\"", 3013)
            
            #line 47 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                     , Tuple.Create(Tuple.Create("", 3002), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 3002), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 3014), Tuple.Create("\"", 3056)
            
            #line 47 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                              , Tuple.Create(Tuple.Create("", 3027), Tuple.Create<System.Object, System.Int32>(Html.Resource("OtherOption")
            
            #line default
            #line hidden
, 3027), false)
);

WriteLiteral(" />\r\n            </li>\r\n");

            
            #line 49 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n");

            
            #line 51 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    
            
            #line default
            #line hidden
            
            #line 51 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
     if (hasDescription)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteAttribute("id", Tuple.Create(" id=\'", 3146), Tuple.Create("\'", 3183)
            
            #line 53 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 3151), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupInfo")
            
            #line default
            #line hidden
, 3151), false)
);

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 53 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                               Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 54 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteAttribute("id", Tuple.Create(" id=\'", 3253), Tuple.Create("\'", 3298)
            
            #line 55 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 3258), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupErrorMessage")
            
            #line default
            #line hidden
, 3258), false)
);

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral("></div>\r\n</fieldset>\r\n\r\n");

            
            #line 58 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
