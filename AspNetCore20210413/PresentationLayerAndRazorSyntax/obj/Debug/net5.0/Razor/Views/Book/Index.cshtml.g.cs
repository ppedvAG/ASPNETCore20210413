#pragma checksum "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "391e41932e9b0e1bbcd79f498e5344cf36352409"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
#line 1 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\_ViewImports.cshtml"
using PresentationLayerAndRazorSyntax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\_ViewImports.cshtml"
using PresentationLayerAndRazorSyntax.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
using DependencySampleLib.GoodSample;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"391e41932e9b0e1bbcd79f498e5344cf36352409", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82d67a363e16b9b400fc02cf00a3af05035008e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n<h1>Zeige den ersten Datensatz der Liste</h1>\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
Write(Model.First().Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n<br />\r\n");
#nullable restore
#line 13 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
Write(Model.First().Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n<br />\r\n");
#nullable restore
#line 15 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
Write(Model.First().Descripton);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n<br />\r\n");
#nullable restore
#line 17 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
Write(Model.First().Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n<br />\r\n\r\n\r\n");
#nullable restore
#line 21 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
 foreach (Book currentBook in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>ID: ");
#nullable restore
#line 23 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
      Write(currentBook.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Titel: ");
#nullable restore
#line 24 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
         Write(currentBook.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Beschreibung: ");
#nullable restore
#line 25 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
                Write(currentBook.Descripton);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Autor: ");
#nullable restore
#line 26 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
         Write(currentBook.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 27 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"

    if (currentBook.Autor == "Steven King")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p> Bitte eine FSK16 Pr??fung </p>\r\n");
#nullable restore
#line 31 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n");
#nullable restore
#line 34 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 37 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
 if (DateTime.IsLeapYear(2016))
{
    int abc = 123;

    abc = 456;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 43 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
  Write(abc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("    <p>Ist ein schaltjahr</p>\r\n");
#nullable restore
#line 46 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>ist kein schaltjahr</p>\r\n");
#nullable restore
#line 50 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("style", " style=\'", 782, "\'", 868, 1);
#nullable restore
#line 52 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
WriteAttributeValue("", 790, Model.First().Id == 1 ? "background-color:yellow":"background-color:orange", 790, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Car-Color</div>\r\n\r\n\r\n\r\n//lokaler C#-Block\r\n");
#nullable restore
#line 57 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
  
    void RenderName(string name)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Name: <strong>");
#nullable restore
#line 60 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
                    Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n");
#nullable restore
#line 61 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
    }

    RenderName("Mahatma Gandhi");
    RenderName("Martin Luther King, Jr.");

    int value = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 69 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
 switch (value)
{
    case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>The value is 1!</p>\r\n");
#nullable restore
#line 73 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
        RenderName("Haribo");
        break;
    case 1337:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Your number is 1337!</p>\r\n");
#nullable restore
#line 77 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
        break;
    default:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Your number wasn\'t 1 or 1337.</p>\r\n");
#nullable restore
#line 80 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
        break;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 86 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        Email: <input type=\"email\" id=\"Email\"");
            BeginWriteAttribute("value", " value=\"", 1497, "\"", 1505, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <button>Register</button>\r\n    </div>\r\n");
#nullable restore
#line 92 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 95 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
Write(MockCar.Brandt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 97 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
Write(MockCar.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 99 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
Write(MockCar.ConstructYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 101 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
 try
{

}
catch (Exception ex)
{

}
finally
{

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\'h1\').text(\'Hallo liebe Teilnehmer\');\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <!-- Spalten (Columns) werden definiert -->\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 138 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 141 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripton));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 144 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 150 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n\r\n                    ");
#nullable restore
#line 155 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 158 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Descripton));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 161 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <!-- ASP.NET Core ASP Tag-Helper -->\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "391e41932e9b0e1bbcd79f498e5344cf3635240916374", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 165 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "391e41932e9b0e1bbcd79f498e5344cf3635240918581", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 166 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "391e41932e9b0e1bbcd79f498e5344cf3635240920794", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 167 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 170 "C:\Aktueller Kurs\ASPNETCore20210413\AspNetCore20210413\PresentationLayerAndRazorSyntax\Views\Book\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICar MockCar { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
