#pragma checksum "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\Filter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edd4ecae853e51dc376c7c246cc78501ee0c1634"
// <auto-generated/>
#pragma warning disable 1591
namespace QLNVSSV.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\_Imports.razor"
using QLNVSSV.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\_Imports.razor"
using QLNVSSV.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class Filter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>


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
        padding: 10px 20px;
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

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "height:200px;margin-top:20px;");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 81 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\Filter.razor"
                     model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 81 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\Filter.razor"
                                      ()=> { FilterAction(model); }

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-search");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.OpenElement(11, "input");
                __builder2.AddAttribute(12, "type", "text");
                __builder2.AddAttribute(13, "name", "EmployeeName");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "id", "exampleInputEmail1");
                __builder2.AddAttribute(16, "aria-describedby", "emailHelp");
                __builder2.AddAttribute(17, "placeholder", "Nhập tên nhân viên");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 84 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\Filter.razor"
                                    model.EmployeeName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.EmployeeName = __value, model.EmployeeName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n\r\n            ");
                __builder2.AddMarkupContent(21, "<button style=\"height:38px;\" type=\"submit\" class=\"btn btn-success\">Tìm kiếm nâng cao</button>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-search");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "<label for=\"exampleInputEmail1\">Vị trí</label>\r\n                ");
                __builder2.OpenElement(28, "select");
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "name", "Position");
                __builder2.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\Filter.razor"
                                                                    model.Position

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.Position = __value, model.Position));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(33, "option");
                __builder2.AddAttribute(34, "value", "0");
                __builder2.AddMarkupContent(35, "Chọn vị trí");
                __builder2.CloseElement();
#nullable restore
#line 95 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\Filter.razor"
                     foreach (var item in listPosition)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(36, "option");
                __builder2.AddAttribute(37, "value", 
#nullable restore
#line 97 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\Filter.razor"
                                        item.PositionId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(38, 
#nullable restore
#line 97 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\Filter.razor"
                                                          item.PositionName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 98 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\Filter.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "<label for=\"exampleInputPassword1\">Chức danh</label>\r\n                ");
                __builder2.OpenElement(43, "select");
                __builder2.AddAttribute(44, "class", "form-control");
                __builder2.AddAttribute(45, "name", "Title");
                __builder2.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 103 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\Filter.razor"
                                                                 model.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.Title = __value, model.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(48, "option");
                __builder2.AddAttribute(49, "value", "0");
                __builder2.AddMarkupContent(50, "Chọn chức vụ");
                __builder2.CloseElement();
#nullable restore
#line 105 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\Filter.razor"
                     foreach (var item in listTitle)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(51, "option");
                __builder2.AddAttribute(52, "value", 
#nullable restore
#line 107 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\Filter.razor"
                                        item.TitleId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(53, 
#nullable restore
#line 107 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\Filter.razor"
                                                       item.TitleName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 108 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\Filter.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.AddMarkupContent(55, "<button type=\"submit\" class=\"btn btn-success\">Tìm kiếm</button>\r\n        ");
                __builder2.AddMarkupContent(56, "<button id=\"reset\" type=\"button\" class=\"btn btn-success\">Đặt lại</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
