#pragma checksum "D:\PRN211\Lab3\Lab3\Views\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35ec0408695f9e67c524b8b2c18c414a05f961da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Index), @"mvc.1.0.view", @"/Views/Index.cshtml")]
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
#line 4 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
using Lab3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35ec0408695f9e67c524b8b2c18c414a05f961da", @"/Views/Index.cshtml")]
    #nullable restore
    public class Views_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    #nullable disable
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
            WriteLiteral("\r\n<!doctype html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35ec0408695f9e67c524b8b2c18c414a05f961da2839", async() => {
                WriteLiteral("\r\n    <style>\r\n        .active {\r\n            background-color: aquamarine;\r\n        }\r\n\r\n        ul {\r\n            list-style: none;\r\n        }\r\n    </style>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35ec0408695f9e67c524b8b2c18c414a05f961da3981", async() => {
                WriteLiteral("\r\n    <div class=\"left\" style=\"float:left; width:30%;\">\r\n        <h1>List of Employees</h1>\r\n        <ul>\r\n            <li><a href=\"/Home/List\">All Employees</a></li>\r\n");
#nullable restore
#line 25 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
             foreach (Employee e in ViewBag.Employees)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li><a");
                BeginWriteAttribute("href", " href=\"", 632, "\"", 663, 2);
                WriteAttributeValue("", 639, "/Home/List/", 639, 11, true);
#nullable restore
#line 27 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
WriteAttributeValue("", 650, e.EmployeeId, 650, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 27 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
                                                  Write(e.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n");
#nullable restore
#line 28 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </ul>\r\n    </div>\r\n    <div class=\"right\" style=\"float:right; width:70%;\">\r\n        <h1>List of Order</h1>\r\n\r\n");
#nullable restore
#line 35 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
         if (ViewBag.Orders == null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>List Empty</p>\r\n");
#nullable restore
#line 38 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <table border=\"1\">\r\n                <tr>\r\n                    <th>OrderId</th>\r\n                    <th>Customer</th>\r\n                    <th>Employee</th>\r\n                    <th>OrderDate</th>\r\n                </tr>\r\n");
#nullable restore
#line 48 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
                 foreach (Order o in ViewBag.Orders)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 51 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
                       Write(o.OrderId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 52 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
                         foreach (Customer c in ViewBag.Customers)
                        {
                            if (c.CustomerId == o.CustomerId)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>");
#nullable restore
#line 56 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
                               Write(c.CompanyName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 57 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
                         foreach (Employee e in ViewBag.Employees)
                        {
                            if (e.EmployeeId == o.EmployeeId)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>");
#nullable restore
#line 63 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
                               Write(e.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 64 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <td>");
#nullable restore
#line 67 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
                       Write(o.OrderDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 69 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n");
#nullable restore
#line 71 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\r\n");
#nullable restore
#line 73 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
             if ((int)ViewData["CurrentPage"] > 1)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a");
                BeginWriteAttribute("href", " href=\"", 2148, "\"", 2228, 4);
                WriteAttributeValue("", 2155, "/Home/List/", 2155, 11, true);
#nullable restore
#line 75 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
WriteAttributeValue("", 2166, ViewData["CurrentEmployee"], 2166, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2194, "/", 2194, 1, true);
#nullable restore
#line 75 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
WriteAttributeValue("", 2195, (int)ViewData["CurrentPage"]-1, 2195, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Next</a>\r\n");
#nullable restore
#line 76 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
             for (int i = 1; i < (int)ViewData["TotalPage"]; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a");
                BeginWriteAttribute("class", " class=\'", 2355, "\'", 2418, 1);
#nullable restore
#line 79 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
WriteAttributeValue("", 2363, (int)ViewData["CurrentPage"]==i?"active":"nonactive", 2363, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\'", 2419, "\'", 2468, 4);
                WriteAttributeValue("", 2426, "/Home/List/", 2426, 11, true);
#nullable restore
#line 79 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
WriteAttributeValue("", 2437, ViewData["CurrentEmployee"], 2437, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2465, "/", 2465, 1, true);
#nullable restore
#line 79 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
WriteAttributeValue("", 2466, i, 2466, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    ");
#nullable restore
#line 80 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </a>\r\n");
#nullable restore
#line 82 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
             if ((ViewData["CurrentPage"]) != ViewData["TotalPage"])
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a");
                BeginWriteAttribute("href", " href=\"", 2636, "\"", 2716, 4);
                WriteAttributeValue("", 2643, "/Home/List/", 2643, 11, true);
#nullable restore
#line 85 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
WriteAttributeValue("", 2654, ViewData["CurrentEmployee"], 2654, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2682, "/", 2682, 1, true);
#nullable restore
#line 85 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
WriteAttributeValue("", 2683, (int)ViewData["CurrentPage"]+1, 2683, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Previous</a>\r\n");
#nullable restore
#line 86 "D:\PRN211\Lab3\Lab3\Views\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
