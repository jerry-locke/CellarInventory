#pragma checksum "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/Home/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "934bdf6340760fbda95d872b95b8351f66e41f02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Delete), @"mvc.1.0.view", @"/Views/Home/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Delete.cshtml", typeof(AspNetCore.Views_Home_Delete))]
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
#line 1 "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/_ViewImports.cshtml"
using CellarInventoryWeb;

#line default
#line hidden
#line 2 "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/_ViewImports.cshtml"
using CellarInventoryWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"934bdf6340760fbda95d872b95b8351f66e41f02", @"/Views/Home/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6211d7fabc417c9ab32abfb27ae3264bc7f4f3da", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CellarInventoryWeb.Inventory>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(36, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/Home/Delete.cshtml"
  
    ViewBag.Title = "Delete To-do";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(124, 150, true);
            WriteLiteral("\n<h2>Delete this record</h2>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(275, 48, false);
#line 15 "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/Home/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Manufacturer));

#line default
#line hidden
            EndContext();
            BeginContext(323, 41, true);
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
            EndContext();
            BeginContext(365, 44, false);
#line 19 "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/Home/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Manufacturer));

#line default
#line hidden
            EndContext();
            BeginContext(409, 41, true);
            WriteLiteral("\n        </dd>\n\n        <dt>\n            ");
            EndContext();
            BeginContext(451, 44, false);
#line 23 "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/Home/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(495, 41, true);
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
            EndContext();
            BeginContext(537, 40, false);
#line 27 "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/Home/Delete.cshtml"
       Write(Html.DisplayFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(577, 41, true);
            WriteLiteral("\n        </dd>\n\n        <dt>\n            ");
            EndContext();
            BeginContext(619, 44, false);
#line 31 "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/Home/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemType));

#line default
#line hidden
            EndContext();
            BeginContext(663, 41, true);
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
            EndContext();
            BeginContext(705, 40, false);
#line 35 "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/Home/Delete.cshtml"
       Write(Html.DisplayFor(model => model.ItemType));

#line default
#line hidden
            EndContext();
            BeginContext(745, 41, true);
            WriteLiteral("\n        </dd>\n\n        <dt>\n            ");
            EndContext();
            BeginContext(787, 40, false);
#line 39 "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/Home/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(827, 41, true);
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
            EndContext();
            BeginContext(869, 36, false);
#line 43 "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/Home/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(905, 41, true);
            WriteLiteral("\n        </dd>\n\n        <dt>\n            ");
            EndContext();
            BeginContext(947, 44, false);
#line 47 "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/Home/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(991, 41, true);
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
            EndContext();
            BeginContext(1033, 40, false);
#line 51 "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/Home/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 26, true);
            WriteLiteral("\n        </dd>\n    </dl>\n\n");
            EndContext();
#line 55 "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/Home/Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(1144, 23, false);
#line 57 "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/Home/Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1169, 133, true);
            WriteLiteral("        <div class=\"form-actions no-color\">\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\n            ");
            EndContext();
            BeginContext(1302, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5b52cf266d14fd5b32f7c7f4605259b", async() => {
                BeginContext(1324, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1340, 16, true);
            WriteLiteral("\n        </div>\n");
            EndContext();
#line 63 "/mnt/c/source/CellarInventory/CellarInventoryWeb/Views/Home/Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(1362, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CellarInventoryWeb.Inventory> Html { get; private set; }
    }
}
#pragma warning restore 1591
