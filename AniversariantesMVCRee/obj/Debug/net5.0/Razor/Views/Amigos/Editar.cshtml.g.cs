#pragma checksum "C:\Users\AntonioEduardoSilvei\source\repos\AniversariantesMVCRee\AniversariantesMVCRee\Views\Amigos\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29a8c3f1d48a9e2417336445a689b3f8de163d83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Amigos_Editar), @"mvc.1.0.view", @"/Views/Amigos/Editar.cshtml")]
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
#line 1 "C:\Users\AntonioEduardoSilvei\source\repos\AniversariantesMVCRee\AniversariantesMVCRee\Views\_ViewImports.cshtml"
using AniversariantesMVCRee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AntonioEduardoSilvei\source\repos\AniversariantesMVCRee\AniversariantesMVCRee\Views\_ViewImports.cshtml"
using AniversariantesMVCRee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29a8c3f1d48a9e2417336445a689b3f8de163d83", @"/Views/Amigos/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4106f244c04a3443adb7adfbabb4c25e9793d87", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Amigos_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Amigo>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Amigos/Editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2 style=\"font-weight: bold\">Editar Amigo </h2>\r\n<div class=\"container-md\" id=\"container-md\" style=\"padding-top:15px\"> \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29a8c3f1d48a9e2417336445a689b3f8de163d834171", async() => {
                WriteLiteral(" \r\n\r\n<div class=\"mb-3\">\r\n  <label  for=\"exampleFormControlInput1\" class=\"form-label\">Id </label>\r\n  <input id=\"id\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 304, "\"", 321, 1);
#nullable restore
#line 8 "C:\Users\AntonioEduardoSilvei\source\repos\AniversariantesMVCRee\AniversariantesMVCRee\Views\Amigos\Editar.cshtml"
WriteAttributeValue("", 312, Model.Id, 312, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control form-control-lg\" type=\"text\" placeholder=\"Id\" aria-label=\".form-control-lg example\">\r\n</div>\r\n<div class=\"mb-3\">\r\n  <label  for=\"exampleFormControlInput1\" class=\"form-label\">Nome </label>\r\n  <input id=\"nome\" name=\"nome\"");
                BeginWriteAttribute("value", " value=\"", 562, "\"", 581, 1);
#nullable restore
#line 12 "C:\Users\AntonioEduardoSilvei\source\repos\AniversariantesMVCRee\AniversariantesMVCRee\Views\Amigos\Editar.cshtml"
WriteAttributeValue("", 570, Model.Nome, 570, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control form-control-lg\" type=\"text\" placeholder=\"Nome\" aria-label=\".form-control-lg example\">\r\n</div>\r\n<div class=\"mb-3\">\r\n  <label class=\"form-label\">Sobrenome</label>\r\n  <input id=\"sobrenome\" name=\"sobrenome\"");
                BeginWriteAttribute("value", " value=\"", 806, "\"", 830, 1);
#nullable restore
#line 16 "C:\Users\AntonioEduardoSilvei\source\repos\AniversariantesMVCRee\AniversariantesMVCRee\Views\Amigos\Editar.cshtml"
WriteAttributeValue("", 814, Model.Sobrenome, 814, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control form-control-lg"" type=""text"" placeholder=""Sobrenome"" aria-label="".form-control-lg example"">
</div>
<div class=""mb-3"" style=""padding-bottom:40px;"">
  <label class=""form-label"">Nascimento </label>
  <input id=""nascimento"" name=""nascimento""");
                BeginWriteAttribute("value", " value=\"", 1093, "\"", 1118, 1);
#nullable restore
#line 20 "C:\Users\AntonioEduardoSilvei\source\repos\AniversariantesMVCRee\AniversariantesMVCRee\Views\Amigos\Editar.cshtml"
WriteAttributeValue("", 1101, Model.Nascimento, 1101, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control form-control-lg"" type=""date"" placeholder=""Nascimento"" aria-label="".form-control-lg example"">
</div>

<td style=""padding-top:30px""> <input type=""submit"" class=""btn btn-primary"" style=""width:100%;height:50px;"" value=""Cadastrar""/></td>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Amigo> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
