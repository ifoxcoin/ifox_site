#pragma checksum "C:\Projects\GIT\ifox_site\ifox_site\Views\Contact\EmailMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85334172a3353afa64563be1ee83f87c60334b50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_EmailMessage), @"mvc.1.0.view", @"/Views/Contact/EmailMessage.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Projects\GIT\ifox_site\ifox_site\Views\_ViewImports.cshtml"
using ifox_site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\GIT\ifox_site\ifox_site\Views\_ViewImports.cshtml"
using ifox_site.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85334172a3353afa64563be1ee83f87c60334b50", @"/Views/Contact/EmailMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f4f248abf9c5116e4c08271e9f3de8947ac59c", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_EmailMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ifox_site.Models.SendMailViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projects\GIT\ifox_site\ifox_site\Views\Contact\EmailMessage.cshtml"
  
    ViewBag.Title = "EmailMessage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85334172a3353afa64563be1ee83f87c60334b503447", async() => {
                WriteLiteral("\r\n    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width\">\r\n    <title></title>\r\n    <style></style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85334172a3353afa64563be1ee83f87c60334b504607", async() => {
                WriteLiteral(@"
    <div id=""email"" style=""width:600px;"">

        <h1 style=""text-align:center; font-family:arial,helvetica,sans-serif; color:steelblue"">Contact Information</h1>


        <table style=""font-family:arial,helvetica,sans-serif;""  role=""presentation"" border=""0"" cellspacing=""10"" >
            <tr>
                <td style=""color:royalblue"" width=""10%""><b>Name : </b></td>
                <td >");
#nullable restore
#line 24 "C:\Projects\GIT\ifox_site\ifox_site\Views\Contact\EmailMessage.cshtml"
                Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <td style=\"color:royalblue\"  width=\"10%\"><b>Email :  </b></td>\r\n                <td>");
#nullable restore
#line 29 "C:\Projects\GIT\ifox_site\ifox_site\Views\Contact\EmailMessage.cshtml"
               Write(Model.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n\r\n\r\n            <tr>\r\n                <td style=\"color:royalblue\"  width=\"10%\"><b>Contact :  </b></td>\r\n                <td>");
#nullable restore
#line 35 "C:\Projects\GIT\ifox_site\ifox_site\Views\Contact\EmailMessage.cshtml"
               Write(Model.Contact);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n\r\n\r\n            <tr>\r\n                <td style=\"color:royalblue\"  width=\"10%\"><b>Subject :  </b></td>\r\n                <td>");
#nullable restore
#line 41 "C:\Projects\GIT\ifox_site\ifox_site\Views\Contact\EmailMessage.cshtml"
               Write(Model.Subject);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <td valign=\"top\" style=\"color:royalblue\"  width=\"10%\"><b> Message:  </b></td>\r\n                <td>");
#nullable restore
#line 46 "C:\Projects\GIT\ifox_site\ifox_site\Views\Contact\EmailMessage.cshtml"
               Write(Model.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n\r\n        </table>\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ifox_site.Models.SendMailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591