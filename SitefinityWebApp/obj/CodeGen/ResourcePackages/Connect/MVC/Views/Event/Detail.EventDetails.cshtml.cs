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

namespace SitefinityWebApp.ResourcePackages.Connect.MVC.Views.Event
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
    
    #line 3 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Events.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Connect/MVC/Views/Event/Detail.EventDetails.cshtml")]
    public partial class Detail_EventDetails : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentDetailsViewModel>
    {
        public Detail_EventDetails()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 230), Tuple.Create("\"", 253)
            
            #line 7 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 238), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 238), false)
);

WriteLiteral(" ");

            
            #line 7 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)Model.Item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <h3");

WriteLiteral(" class=\"sf-event-title\"");

WriteLiteral(">\r\n        <span ");

            
            #line 9 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
         Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 9 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                                                                  Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n    </h3>\r\n    <span");

WriteLiteral(" class=\"sf-event-type\"");

WriteAttribute("style", Tuple.Create(" style=\"", 542), Tuple.Create("\"", 595)
, Tuple.Create(Tuple.Create("", 550), Tuple.Create("background:", 550), true)
            
            #line 11 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create(" ", 561), Tuple.Create<System.Object, System.Int32>(Model.Item.EventCalendarColour()
            
            #line default
            #line hidden
, 562), false)
);

WriteLiteral("></span>\r\n\r\n");

            
            #line 13 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.EventDates())) 
	{

            
            #line default
            #line hidden
WriteLiteral("    <p>\r\n        <time>");

            
            #line 16 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
         Write(Model.Item.EventDates());

            
            #line default
            #line hidden
WriteLiteral("</time>\r\n    </p>\r\n");

            
            #line 18 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    \r\n");

            
            #line 20 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.City) || !string.IsNullOrEmpty(Model.Item.Fields.Country))
    {
            
            #line default
            #line hidden
WriteLiteral("<address>\r\n\r\n");

            
            #line 23 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 23 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.City) && !string.IsNullOrEmpty(Model.Item.Fields.Country))
        {
            
            
            #line default
            #line hidden
            
            #line 25 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.City);

            
            #line default
            #line hidden
WriteLiteral(" <span>,</span> ");

            
            #line 25 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                                                   
            
            #line default
            #line hidden
            
            #line 25 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                                              Write(Model.Item.Fields.Country);

            
            #line default
            #line hidden
            
            #line 25 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                                                                             

            
            #line default
            #line hidden
WriteLiteral("            <br>\r\n");

            
            #line 27 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
        }
        else
        {
            
            
            #line default
            #line hidden
            
            #line 30 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
        Write(string.IsNullOrEmpty(Model.Item.Fields.City) ? Model.Item.Fields.Country : Model.Item.Fields.City);

            
            #line default
            #line hidden
            
            #line 30 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                                                                                                                

            
            #line default
            #line hidden
WriteLiteral("             <br>\r\n");

            
            #line 32 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 34 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 34 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.Street))
        {
            
            
            #line default
            #line hidden
            
            #line 36 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.Street);

            
            #line default
            #line hidden
            
            #line 36 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                                     
        }

            
            #line default
            #line hidden
WriteLiteral("    </address>\r\n");

            
            #line 39 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    \r\n    <div>\r\n");

            
            #line 42 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 42 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactName))
        {
            
            
            #line default
            #line hidden
            
            #line 44 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.ContactName);

            
            #line default
            #line hidden
            
            #line 44 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                                          

            
            #line default
            #line hidden
WriteLiteral("            <br>\r\n");

            
            #line 46 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 48 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 48 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactPhone))
        {
            
            
            #line default
            #line hidden
            
            #line 50 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.ContactPhone);

            
            #line default
            #line hidden
            
            #line 50 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                                           

            
            #line default
            #line hidden
WriteLiteral("            <br>\r\n");

            
            #line 52 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 54 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 54 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactCell))
        {
            
            
            #line default
            #line hidden
            
            #line 56 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.ContactCell);

            
            #line default
            #line hidden
            
            #line 56 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                                          

            
            #line default
            #line hidden
WriteLiteral("            <br>\r\n");

            
            #line 58 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("            \r\n");

            
            #line 60 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 60 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactEmail))
        {

            
            #line default
            #line hidden
WriteLiteral("            <address><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2023), Tuple.Create("\"", 2070)
, Tuple.Create(Tuple.Create("", 2030), Tuple.Create("mailto:", 2030), true)
            
            #line 62 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 2037), Tuple.Create<System.Object, System.Int32>(Model.Item.Fields.ContactEmail
            
            #line default
            #line hidden
, 2037), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 62 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                                                                                   Write(Model.Item.Fields.ContactEmail);

            
            #line default
            #line hidden
WriteLiteral("</a></address>\r\n");

            
            #line 63 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 65 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 65 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactWeb))
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2240), Tuple.Create("\"", 2303)
            
            #line 67 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 2247), Tuple.Create<System.Object, System.Int32>(Html.UrlSanitize((string)Model.Item.Fields.ContactWeb)
            
            #line default
            #line hidden
, 2247), false)
, Tuple.Create(Tuple.Create("", 2302), Tuple.Create(")", 2302), true)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 67 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                                                                                          Write(Model.Item.Fields.ContactWeb);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 68 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n\r\n");

            
            #line 71 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 71 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Location))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p>\r\n\t\t\t");

WriteLiteral("\r\n");

WriteLiteral("\t\t\t");

            
            #line 75 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.Location);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t</p>\r\n");

            
            #line 77 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 79 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 79 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Description))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p>\r\n");

WriteLiteral("            ");

            
            #line 82 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </p>\r\n");

            
            #line 84 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <p>\r\n");

WriteLiteral("        ");

            
            #line 87 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
   Write(Html.CommentsCount(string.Empty, Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t</p>\r\n    \r\n");

            
            #line 90 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 90 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
     if (ViewBag.AllowCalendarExport)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div>\r\n            <span>");

            
            #line 93 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
             Write(Html.Resource("AddTo"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            <ul>\r\n                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2944), Tuple.Create("\"", 2983)
            
            #line 95 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 2951), Tuple.Create<System.Object, System.Int32>(Model.Item.GenerateOutlookUrl()
            
            #line default
            #line hidden
, 2951), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 95 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                                                                          Write(Html.Resource("OutlookEventExporterTitle"));

            
            #line default
            #line hidden
WriteLiteral("</a>,</li>\r\n                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3078), Tuple.Create("\"", 3114)
            
            #line 96 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3085), Tuple.Create<System.Object, System.Int32>(Model.Item.GenerateICalUrl()
            
            #line default
            #line hidden
, 3085), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 96 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                                                                       Write(Html.Resource("ICalEventExporterTitle"));

            
            #line default
            #line hidden
WriteLiteral("</a>,</li>\r\n                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3206), Tuple.Create("\"", 3244)
            
            #line 97 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3213), Tuple.Create<System.Object, System.Int32>(Model.Item.GenerateGoogleUrl()
            
            #line default
            #line hidden
, 3213), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 97 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                                                                         Write(Html.Resource("GoogleEventExporterTitle"));

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            </ul>\r\n        </div>\r\n");

            
            #line 100 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 102 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 102 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Summary))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p ");

            
            #line 104 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
      Write(Html.InlineEditingFieldAttributes("Summary", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 104 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                                                                Write(Html.HtmlSanitize((string)Model.Item.Fields.Summary));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 105 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 107 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 107 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Content))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p ");

            
            #line 109 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
      Write(Html.InlineEditingFieldAttributes("Content", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 109 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
                                                                Write(Html.HtmlSanitize((string)Model.Item.Fields.Content));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 110 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 112 "..\..\ResourcePackages\Connect\MVC\Views\Event\Detail.EventDetails.cshtml"
Write(Html.CommentsList(Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n</div>");

        }
    }
}
#pragma warning restore 1591
