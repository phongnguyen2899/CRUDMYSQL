#pragma checksum "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89cba097e874b48cf97411c6ab4da6f0c82b9149"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QLNVSSV.WebApp.Pages.Pages_Approval), @"mvc.1.0.razor-page", @"/Pages/Approval.cshtml")]
namespace QLNVSSV.WebApp.Pages
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
#line 1 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\_ViewImports.cshtml"
using QLNVSSV.WebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89cba097e874b48cf97411c6ab4da6f0c82b9149", @"/Pages/Approval.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40224aefcc9319708e764aeebad0171a2fd8d47e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Approval : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
   

    a {
    }

    body {
    }

   


    a {
        text-decoration: none;
        color: #000;
    }

   

    .search {
    }

        .search input {
        }

        .search a {
        }


    .search_header {
        display: flex;
    }

        .search_header .btn_search {
            background-color: #4e92df;
            border: none;
            color: white;
            text-align: center;
            text-decoration: none;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
            height: 100%;
            margin: 0;
            padding: 10px 20px;
        }

        .search_header input:first-child {
            width: 200px;
            margin-right: 10px;
            outline: none;
            padding-left: 10px;
            border: 1px solid #4e92df;
        }

    .link_btn {
        background-color: #4e92df;
        font-size: 16px;
        color: white;
        padding: 1");
            WriteLiteral(@"0px 20px;
        border-radius: 2px;
    }

    
    

    .dowload {
    }

    .view:hover {
        color: #2e7dd6;
    }

    .form-search {
        display: flex;
    }

    .form-group {
        margin-right: 20px;
    }
</style>

<div style=""height:200px;margin-top:20px;"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89cba097e874b48cf97411c6ab4da6f0c82b91495131", async() => {
                WriteLiteral(@"
        <div class=""form-search"">
            <div class=""form-group"">
                <input type=""text"" name=""EmployeeName"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Nhập tên nhân viên"">
            </div>

            <button style=""height:38px;"" type=""submit"" class=""btn btn-success"">Tìm kiếm nâng cao</button>
        </div>
        <br />
        <div class=""form-search"">
            <div class=""form-group"">
                <label for=""exampleInputEmail1"">Vị trí</label>
                <select class=""form-control"" name=""Position"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89cba097e874b48cf97411c6ab4da6f0c82b91496038", async() => {
                    WriteLiteral("Chọn vị trí");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 103 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                     foreach (var item in Model.listPositions)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89cba097e874b48cf97411c6ab4da6f0c82b91497576", async() => {
#nullable restore
#line 105 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                                                    Write(item.PositionName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 105 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                           WriteLiteral(item.PositionId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 106 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"exampleInputPassword1\">Chức danh</label>\r\n                <select class=\"form-control\" name=\"Title\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89cba097e874b48cf97411c6ab4da6f0c82b91499944", async() => {
                    WriteLiteral("Chọn chức vụ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 113 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                     foreach (var item in Model.listTitle)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89cba097e874b48cf97411c6ab4da6f0c82b914911479", async() => {
#nullable restore
#line 115 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                                                 Write(item.TitleName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 115 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                           WriteLiteral(item.TitleId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 116 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </div>\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-success\">Tìm kiếm</button>\r\n        <button id=\"reset\" type=\"button\" class=\"btn btn-success\">Đặt lại</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

</div>


<table class=""table"">
    <thead>
        <tr>

            <th scope=""col"">ID</th>
            <th scope=""col"">Tên chức vụ</th>
            <th scope=""col"">Tên vị trí</th>
            <th scope=""col"">Tên NV</th>
            <th scope=""col"">Ngày sinh</th>
            <th scope=""col"">Địa chỉ</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">CV</th>
            <th scope=""col"">Người Giới thiệu</th>
            <th scope=""col"">Hành động</th>
        </tr>
    </thead>
    <tbody id=""tablebody"">
");
#nullable restore
#line 144 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
         foreach (var item in Model.employee)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 3584, "\"", 3608, 2);
            WriteAttributeValue("", 3589, "tr_", 3589, 3, true);
#nullable restore
#line 146 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
WriteAttributeValue("", 3592, item.EmployeeId, 3592, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <th scope=\"row\">");
#nullable restore
#line 147 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                           Write(item.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 148 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
               Write(item.TitleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 149 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
               Write(item.PositionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 150 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
               Write(item.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 151 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
               Write(item.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 152 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
               Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 153 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a href=\"http://localhost:37919/Image/\">");
#nullable restore
#line 154 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                                                       Write(item.CV);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                <td>");
#nullable restore
#line 155 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
               Write(item.PresenterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 157 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                     if (item.CV != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                         if (item.CV.Split(".").Last() == "pdf")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a title=\"Click để xem cv\"");
            BeginWriteAttribute("id", " id=\"", 4281, "\"", 4311, 2);
            WriteAttributeValue("", 4286, "bntduyet_", 4286, 9, true);
#nullable restore
#line 161 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
WriteAttributeValue("", 4295, item.EmployeeId, 4295, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 4312, "\"", 4346, 3);
            WriteAttributeValue("", 4322, "redPDF(", 4322, 7, true);
#nullable restore
#line 161 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
WriteAttributeValue("", 4329, item.EmployeeId, 4329, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4345, ")", 4345, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\" data-toggle=\"modal\" data-book-id=\"");
#nullable restore
#line 161 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                                                                                                                                                                                      Write(item.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-pdf=\"");
#nullable restore
#line 161 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                                                                                                                                                                                                                  Write(item.CV);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-target=\"#exampleModal\">XemCV</a>\r\n");
            WriteLiteral(@"                            <div id=""ModalPDF"">


                                <!-- Modal -->
                                <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                    <div class=""modal-dialog"" role=""document"">
                                        <div class=""modal-content"" style=""width:200%;height:700px"">
                                            <div class=""modal-header"">
                                                <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                    <span aria-hidden=""true"">&times;</span>
                                                </button>
                                            </div>
                                            <div id=""modal_body"" cla");
            WriteLiteral("ss=\"modal-body\">\r\n                                            </div>\r\n                                            <div class=\"modal-footer\">\r\n                                                <button type=\"button\"");
            BeginWriteAttribute("id", " id=\"", 5728, "\"", 5753, 2);
            WriteAttributeValue("", 5733, "btn_", 5733, 4, true);
#nullable restore
#line 179 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
WriteAttributeValue("", 5737, item.EmployeeId, 5737, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""updateStatus(null,1)"" class=""btn btn-outline-danger"" data-dismiss=""modal"">Loại</button>
                                                <button onclick=""updateStatus(null,2)"" type=""button"" class=""btn btn-outline-success"">Duyệt</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 186 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                        }
                        else
                        {
                            var a = item.CV.Split(".").Last();

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"btn btn-outline-primary\" title=\"Click để tải cv\"");
            BeginWriteAttribute("href", " href=\"", 6456, "\"", 6488, 2);
            WriteAttributeValue("", 6463, "Home/Dowloadfile/", 6463, 17, true);
#nullable restore
#line 190 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
WriteAttributeValue("", 6480, item.CV, 6480, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tải CV</a>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 6532, "\"", 6574, 3);
            WriteAttributeValue("", 6542, "updateStatus(", 6542, 13, true);
#nullable restore
#line 191 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
WriteAttributeValue("", 6555, item.EmployeeId, 6555, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6571, ",2)", 6571, 3, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 6575, "\"", 6605, 2);
            WriteAttributeValue("", 6580, "bntduyet_", 6580, 9, true);
#nullable restore
#line 191 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
WriteAttributeValue("", 6589, item.EmployeeId, 6589, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Duyệt</a>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 6680, "\"", 6722, 3);
            WriteAttributeValue("", 6690, "updateStatus(", 6690, 13, true);
#nullable restore
#line 192 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
WriteAttributeValue("", 6703, item.EmployeeId, 6703, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6719, ",1)", 6719, 3, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 6723, "\"", 6753, 2);
            WriteAttributeValue("", 6728, "bntduyet_", 6728, 9, true);
#nullable restore
#line 192 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
WriteAttributeValue("", 6737, item.EmployeeId, 6737, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Loại</a>\r\n");
#nullable restore
#line 193 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 193 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 198 "C:\Users\PhongNV\Documents\Phong\SSV\QLNVSSV\QLNVSSV.WebApp\Pages\Approval.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<script>

    var idtarget;
    function redPDF(id) {
        idtarget = id;
        console.log(id)
        var btn = document.getElementById(""bntduyet_""+id+"""");
        $('#modal_body').html('<iframe style=""width:100%;height:100%;"" src=""http://localhost:37919/Image/' + btn.getAttribute('data-pdf') + '"" title=""""></iframe>')
    }

    function updateStatus(id, status) {

        if (id == null) {
            var url = 'http://localhost:37919/api/Employee/UpdateStatus/' + idtarget + '/' + status + '';
        }
        else {
            var url = 'http://localhost:37919/api/Employee/UpdateStatus/' + id + '/' + status + '';
            idtarget=id
        }
        fetch(url)
            .then(response => response.json())
            .then(data => {
                console.log(data)
                var tr = document.getElementById(`tr_${idtarget}`);
                tr.style.display='none'
            })

    }

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QLNVSSV.WebApp.Pages.ApprovalModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QLNVSSV.WebApp.Pages.ApprovalModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QLNVSSV.WebApp.Pages.ApprovalModel>)PageContext?.ViewData;
        public QLNVSSV.WebApp.Pages.ApprovalModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591