#pragma checksum "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b685b55ae87692199f22b431064fae2238050e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ActionItems_Index), @"mvc.1.0.view", @"/Views/ActionItems/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ActionItems/Index.cshtml", typeof(AspNetCore.Views_ActionItems_Index))]
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
#line 1 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\_ViewImports.cshtml"
using endoREG_MVC;

#line default
#line hidden
#line 2 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\_ViewImports.cshtml"
using endoREG_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b685b55ae87692199f22b431064fae2238050e6", @"/Views/ActionItems/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87bd2f2b09b9eb67c2a5491892094736a9bac653", @"/Views/_ViewImports.cshtml")]
    public class Views_ActionItems_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<endoREG_MVC.Models.ActionItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("font-weight-bold text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("align-middle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(94, 625, true);
            WriteLiteral(@"<link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">
<br />
<br />
<br />
<center>
    <a href=""https://localhost:44386/Home/Privacy""><img src=""https://drive.google.com/uc?export=view&id=1NDRmWEdVnftt5IaGAzu6Q9tBXaUSeAF0"" style=""width: 280px; max-width: 100%; height: auto"" title=""Click for the endoREG (nucCORE) Privacy Policy."" class=""text-center"" /></a>
    <br />
    <br />
    <h1 class=""text-center font-weight-bold"" style=""color: black"">Compliance Plan Action Items</h1>
    <br />
    <br />
</center>
<p class="""" style=""vertical-align: middle; font-size: 14.5pt"">
    ");
            EndContext();
            BeginContext(719, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b685b55ae87692199f22b431064fae2238050e66362", async() => {
                BeginContext(777, 65, true);
                WriteLiteral("<i class=\"material-icons tiny\">add_box</i> Create New Action Item");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(846, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
            BeginContext(854, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b685b55ae87692199f22b431064fae2238050e67885", async() => {
                BeginContext(860, 174, true);
                WriteLiteral("\r\n    <input type=\"text\" name=\"searchQuery\" placeholder=\"Search Action Items...\" class=\"text-center\">\r\n    <button class=\"btn btn-dark\" type=\"submit\"><b>Search</b></button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1041, 300, true);
            WriteLiteral(@"
<br />
<table id=""myTable"" class=""table border border-primary"">
    <thead class=""table border border-primary"">
        <tr class=""text-center border border-primary"">
            <th class=""align-middle border border-secondary"" style=""vertical-align: middle; font-size: 10pt"">
                ");
            EndContext();
            BeginContext(1342, 44, false);
#line 30 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 148, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"align-middle border border-secondary\" style=\"vertical-align: middle; font-size: 11pt\">\r\n                ");
            EndContext();
            BeginContext(1535, 48, false);
#line 33 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateAssigned));

#line default
#line hidden
            EndContext();
            BeginContext(1583, 148, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"align-middle border border-secondary\" style=\"vertical-align: middle; font-size: 11pt\">\r\n                ");
            EndContext();
            BeginContext(1732, 50, false);
#line 36 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CompliancePlan));

#line default
#line hidden
            EndContext();
            BeginContext(1782, 153, true);
            WriteLiteral(" Name\r\n            </th>\r\n            <th class=\"align-middle border border-secondary\" style=\"vertical-align: middle; font-size: 11pt\">\r\n                ");
            EndContext();
            BeginContext(1936, 41, false);
#line 39 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1977, 148, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"align-middle border border-secondary\" style=\"vertical-align: middle; font-size: 11pt\">\r\n                ");
            EndContext();
            BeginContext(2126, 47, false);
#line 42 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2173, 148, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"align-middle border border-secondary\" style=\"vertical-align: middle; font-size: 11pt\">\r\n                ");
            EndContext();
            BeginContext(2322, 51, false);
#line 45 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ActionItemImage));

#line default
#line hidden
            EndContext();
            BeginContext(2373, 148, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"align-middle border border-secondary\" style=\"vertical-align: middle; font-size: 11pt\">\r\n                ");
            EndContext();
            BeginContext(2522, 44, false);
#line 48 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(2566, 148, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"align-middle border border-secondary\" style=\"vertical-align: middle; font-size: 11pt\">\r\n                ");
            EndContext();
            BeginContext(2715, 50, false);
#line 51 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DaysToComplete));

#line default
#line hidden
            EndContext();
            BeginContext(2765, 148, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"align-middle border border-secondary\" style=\"vertical-align: middle; font-size: 11pt\">\r\n                ");
            EndContext();
            BeginContext(2914, 42, false);
#line 54 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(2956, 159, true);
            WriteLiteral(" (Priority)\r\n            </th>\r\n            <th class=\"align-middle border border-secondary\" style=\"vertical-align: middle; font-size: 11pt\">\r\n                ");
            EndContext();
            BeginContext(3116, 44, false);
#line 57 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Complete));

#line default
#line hidden
            EndContext();
            BeginContext(3160, 182, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"align-middle border border-secondary\" style=\"vertical-align: middle; font-size: 11pt\">\r\n                View / Update\r\n            </th>\r\n");
            EndContext();
            BeginContext(3450, 78, true);
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody class=\"table border border-primary\">\r\n");
            EndContext();
#line 68 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(3577, 162, true);
            WriteLiteral("            <tr class=\"text-center\">\r\n                <td class=\"align-middle border-right\" style=\"vertical-align: middle; font-size: 14pt\">\r\n                    ");
            EndContext();
            BeginContext(3740, 43, false);
#line 72 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(3783, 166, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"align-middle border-right font-weight-bold\" style=\"vertical-align: middle; font-size: 11pt\">\r\n                    ");
            EndContext();
            BeginContext(3950, 47, false);
#line 75 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateAssigned));

#line default
#line hidden
            EndContext();
            BeginContext(3997, 149, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"align-middle border-right\" style=\"vertical-align: middle; font-size: 10pt\">\r\n                    ");
            EndContext();
            BeginContext(4147, 55, false);
#line 78 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CompliancePlan.Label));

#line default
#line hidden
            EndContext();
            BeginContext(4202, 155, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"align-middle border-right medium\" style=\"vertical-align: middle; font-size: 9pt\">\r\n                    ");
            EndContext();
            BeginContext(4358, 40, false);
#line 81 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(4398, 166, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"align-middle border-right medium blockquote\" style=\"vertical-align: middle; font-size: 8pt\">\r\n                    ");
            EndContext();
            BeginContext(4565, 46, false);
#line 84 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(4611, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 86 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
                 if (item.ActionItemImage != null)
                {

#line default
#line hidden
            BeginContext(4707, 84, true);
            WriteLiteral("                    <td class=\"align-middle border-right\">\r\n                        ");
            EndContext();
            BeginContext(4791, 255, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b685b55ae87692199f22b431064fae2238050e618706", async() => {
                BeginContext(4870, 4, true);
                WriteLiteral("<img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4874, "\"", 4950, 2);
                WriteAttributeValue("", 4880, "data:image;base64,", 4880, 18, true);
#line 89 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
WriteAttributeValue("", 4898, System.Convert.ToBase64String(item.ActionItemImage), 4898, 52, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4951, 91, true);
                WriteLiteral(" width=\"100\" height=\"125\" class=\"align-middle grayscale\" style=\"filter: grayscale(100%)\" />");
                EndContext();
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
#line 89 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
                                                  WriteLiteral(item.ActionItemId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5046, 29, true);
            WriteLiteral("\r\n\r\n                    </td>");
            EndContext();
#line 91 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
                         }

#line default
#line hidden
            BeginContext(5078, 124, true);
            WriteLiteral("                <td class=\"align-middle border-right\" style=\"vertical-align: middle; font-size: 12pt\">\r\n                    ");
            EndContext();
            BeginContext(5203, 43, false);
#line 93 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
            EndContext();
            BeginContext(5246, 166, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"align-middle border-right font-weight-bold\" style=\"vertical-align: middle; font-size: 16pt\">\r\n                    ");
            EndContext();
            BeginContext(5413, 49, false);
#line 96 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DaysToComplete));

#line default
#line hidden
            EndContext();
            BeginContext(5462, 149, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"align-middle border-right\" style=\"vertical-align: middle; font-size: 12pt\">\r\n                    ");
            EndContext();
            BeginContext(5612, 41, false);
#line 99 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(5653, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(5808, 76, true);
            WriteLiteral("                <td class=\"align-middle border-right\">\r\n                    ");
            EndContext();
            BeginContext(5885, 43, false);
#line 105 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Complete));

#line default
#line hidden
            EndContext();
            BeginContext(5928, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(6075, 141, true);
            WriteLiteral("                <td class=\"align-middle text-black-50 font-weight-bold\" style=\"vertical-align: middle; font-size: 7pt\">\r\n                    ");
            EndContext();
            BeginContext(6216, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b685b55ae87692199f22b431064fae2238050e624492", async() => {
                BeginContext(6306, 49, true);
                WriteLiteral("<i class=\"material-icons tiny\">edit</i><br />Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 111 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
                                           WriteLiteral(item.ActionItemId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6359, 56, true);
            WriteLiteral("<br />\r\n                    <br />\r\n                    ");
            EndContext();
            BeginContext(6415, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b685b55ae87692199f22b431064fae2238050e627026", async() => {
                BeginContext(6508, 55, true);
                WriteLiteral("<i class=\"material-icons tiny\">details</i><br />Details");
                EndContext();
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
#line 113 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
                                              WriteLiteral(item.ActionItemId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6567, 56, true);
            WriteLiteral("<br />\r\n                    <br />\r\n                    ");
            EndContext();
            BeginContext(6623, 149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b685b55ae87692199f22b431064fae2238050e629569", async() => {
                BeginContext(6715, 53, true);
                WriteLiteral("<i class=\"material-icons tiny\">delete</i><br />Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 115 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
                                             WriteLiteral(item.ActionItemId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6772, 50, true);
            WriteLiteral("<br />\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 118 "C:\Users\Newforce\workspace\endoREG-MVC\endoREG-MVC\Views\ActionItems\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(6833, 26, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<endoREG_MVC.Models.ActionItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
