#pragma checksum "C:\Users\MrSpV\Desktop\Proiect Final NET\Proiect\PhotoRazor\Pages\Photos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3935a5d70bf38397526caba4519932adee95af93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PhotoRazor.Pages.Photos.Pages_Photos_Index), @"mvc.1.0.razor-page", @"/Pages/Photos/Index.cshtml")]
namespace PhotoRazor.Pages.Photos
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
#line 1 "C:\Users\MrSpV\Desktop\Proiect Final NET\Proiect\PhotoRazor\Pages\_ViewImports.cshtml"
using PhotoRazor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3935a5d70bf38397526caba4519932adee95af93", @"/Pages/Photos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64fbc313ea2e7a1467fd4f6fac41ef8774e4f97a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Photos_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\MrSpV\Desktop\Proiect Final NET\Proiect\PhotoRazor\Pages\Photos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Afisare Media</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3935a5d70bf38397526caba4519932adee95af933455", async() => {
                WriteLiteral("<button type=\"button\">Search</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Id\r\n            </th>\r\n            <th>\r\n                Media\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\MrSpV\Desktop\Proiect Final NET\Proiect\PhotoRazor\Pages\Photos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Photos[0].Path));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\MrSpV\Desktop\Proiect Final NET\Proiect\PhotoRazor\Pages\Photos\Index.cshtml"
         foreach (var item in Model.Photos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr style=\"font-size:small\">\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\MrSpV\Desktop\Proiect Final NET\Proiect\PhotoRazor\Pages\Photos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 33 "C:\Users\MrSpV\Desktop\Proiect Final NET\Proiect\PhotoRazor\Pages\Photos\Index.cshtml"
             if (item.Path.Contains(".mp4"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    <video width=\"300\" height=\"300\" controls>\r\n                        <source");
            BeginWriteAttribute("src", " src=\"", 856, "\"", 885, 1);
#nullable restore
#line 37 "C:\Users\MrSpV\Desktop\Proiect Final NET\Proiect\PhotoRazor\Pages\Photos\Index.cshtml"
WriteAttributeValue("", 862, Url.Content(item.Path), 862, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"video/mp4\">\r\n                        Your browser does not support the video tag.\r\n                    </video>\r\n                </td>\r\n");
#nullable restore
#line 41 "C:\Users\MrSpV\Desktop\Proiect Final NET\Proiect\PhotoRazor\Pages\Photos\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1123, "\"", 1152, 1);
#nullable restore
#line 45 "C:\Users\MrSpV\Desktop\Proiect Final NET\Proiect\PhotoRazor\Pages\Photos\Index.cshtml"
WriteAttributeValue("", 1129, Url.Content(item.Path), 1129, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\">\r\n\r\n                </td>\r\n");
#nullable restore
#line 48 "C:\Users\MrSpV\Desktop\Proiect Final NET\Proiect\PhotoRazor\Pages\Photos\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\MrSpV\Desktop\Proiect Final NET\Proiect\PhotoRazor\Pages\Photos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Path));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\MrSpV\Desktop\Proiect Final NET\Proiect\PhotoRazor\Pages\Photos\Index.cshtml"
        
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhotoRazor.PhotosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PhotoRazor.PhotosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PhotoRazor.PhotosModel>)PageContext?.ViewData;
        public PhotoRazor.PhotosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
