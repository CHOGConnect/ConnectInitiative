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

namespace SitefinityWebApp.ResourcePackages.Connect.MVC.Views.Image
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
    
    #line 2 "..\..MVC\Views\Image\Image.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 1 "..\..MVC\Views\Image\Image.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Image/Image.cshtml")]
    public partial class Image : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.Image.ImageViewModel>
    {

#line 5 "..\..MVC\Views\Image\Image.cshtml"
public System.Web.WebPages.HelperResult ImageTag()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 6 "..\..MVC\Views\Image\Image.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <img");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 210), Tuple.Create("\"", 233)

#line 7 "..\..MVC\Views\Image\Image.cshtml"
, Tuple.Create(Tuple.Create("", 218), Tuple.Create<System.Object, System.Int32>(Model.CssClass

#line default
#line hidden
, 218), false)
);

WriteAttributeTo(__razor_helper_writer, "src", Tuple.Create(" src=\"", 234), Tuple.Create("\"", 262)

#line 7 "..\..MVC\Views\Image\Image.cshtml"
, Tuple.Create(Tuple.Create("", 240), Tuple.Create<System.Object, System.Int32>(Model.SelectedSizeUrl

#line default
#line hidden
, 240), false)
);

WriteAttributeTo(__razor_helper_writer, "title", Tuple.Create(" title=\"", 263), Tuple.Create("\"", 283)

#line 7 "..\..MVC\Views\Image\Image.cshtml"
, Tuple.Create(Tuple.Create("", 271), Tuple.Create<System.Object, System.Int32>(Model.Title

#line default
#line hidden
, 271), false)
);

WriteAttributeTo(__razor_helper_writer, "alt", Tuple.Create(" alt=\"", 284), Tuple.Create("\"", 331)

#line 7 "..\..MVC\Views\Image\Image.cshtml"
         , Tuple.Create(Tuple.Create("", 290), Tuple.Create<System.Object, System.Int32>(Html.HtmlSanitize(Model.AlternativeText)

#line default
#line hidden
, 290), false)
);

WriteLiteralTo(__razor_helper_writer, "\r\n         ");


#line 8 "..\..MVC\Views\Image\Image.cshtml"
WriteTo(__razor_helper_writer, Html.GetWidthAttributeForVectorGraphics(Model.CustomSize, Model.Item.DataItem));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "         ");


#line 9 "..\..MVC\Views\Image\Image.cshtml"
WriteTo(__razor_helper_writer, Html.GetHeightAttributeForVectorGraphics(Model.CustomSize, Model.Item.DataItem));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " />\r\n");


#line 10 "..\..MVC\Views\Image\Image.cshtml"


#line default
#line hidden
});

#line 10 "..\..MVC\Views\Image\Image.cshtml"
}
#line default
#line hidden

        public Image()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 12 "..\..MVC\Views\Image\Image.cshtml"
 if (string.IsNullOrEmpty(Model.LinkedContentUrl))
{
    
            
            #line default
            #line hidden
            
            #line 14 "..\..MVC\Views\Image\Image.cshtml"
Write(ImageTag());

            
            #line default
            #line hidden
            
            #line 14 "..\..MVC\Views\Image\Image.cshtml"
               
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 613), Tuple.Create("\"", 643)
            
            #line 18 "..\..MVC\Views\Image\Image.cshtml"
, Tuple.Create(Tuple.Create("", 620), Tuple.Create<System.Object, System.Int32>(Model.LinkedContentUrl
            
            #line default
            #line hidden
, 620), false)
);

WriteLiteral(" title=\"Open image in original size\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 19 "..\..MVC\Views\Image\Image.cshtml"
   Write(ImageTag());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </a>\r\n");

            
            #line 21 "..\..MVC\Views\Image\Image.cshtml"
}
            
            #line default
            #line hidden
WriteLiteral(" ");

        }
    }
}
#pragma warning restore 1591
