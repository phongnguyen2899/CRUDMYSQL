#pragma checksum "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d099979b039e72e5ee7da2cf4a0766a27861b39"
// <auto-generated/>
#pragma warning disable 1591
namespace QLNVSSV.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/approval")]
    public partial class Approval : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Approval</h3>\r\n    ");
            __builder.OpenComponent<QLNVSSV.Client.Components.Filter>(1);
            __builder.AddAttribute(2, "Reload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<QLNVSSV.Models.ViewModel.ApprovalFillterViewModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<QLNVSSV.Models.ViewModel.ApprovalFillterViewModel>(this, 
#nullable restore
#line 5 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                                              ReloadData

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddAttribute(6, "style", "margin-top:20px");
            __builder.AddMarkupContent(7, @"<thead><tr><th scope=""col"">ID</th>
            <th scope=""col"">Tên chức vụ</th>
            <th scope=""col"">Tên vị trí</th>
            <th scope=""col"">Tên NV</th>
            <th scope=""col"">Ngày sinh</th>
            <th scope=""col"">Địa chỉ</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">CV</th>
            <th scope=""col"">Người Giới thiệu</th>
            <th scope=""col"">Hành động</th></tr></thead>
    ");
            __builder.OpenElement(8, "tbody");
            __builder.AddAttribute(9, "id", "tablebody");
#nullable restore
#line 24 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
         foreach (var item in listEmployee)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.AddAttribute(11, "id", "tr_" + (
#nullable restore
#line 26 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                        item.EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(12, "th");
            __builder.AddAttribute(13, "scope", "row");
            __builder.AddContent(14, 
#nullable restore
#line 27 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                                 item.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 28 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                     item.TitleName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 29 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                     item.PositionName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 30 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                     item.EmployeeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 31 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                     item.DateOfBirth

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 32 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                     item.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 33 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                     item.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.OpenElement(35, "a");
            __builder.AddAttribute(36, "href", "http://localhost:37919/Image/");
            __builder.AddContent(37, 
#nullable restore
#line 34 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                                                             item.CV

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 35 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                     item.PresenterName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "td");
#nullable restore
#line 37 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                     if (item.CV != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                         if (item.CV.Split(".").Last() == "pdf")
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "title", "Click để xem cv");
            __builder.AddAttribute(45, "id", "bntduyet_" + (
#nullable restore
#line 41 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                                                                     item.EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                                                                                                ()=> { viewCVModal.Show(item.CV);eID = item.EmployeeId; }   

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "class", "btn btn-outline-primary");
            __builder.AddAttribute(48, "data-toggle", "modal");
            __builder.AddAttribute(49, "data-book-id", 
#nullable restore
#line 41 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                                                                                                                                                                                                                                 item.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(50, "data-pdf", 
#nullable restore
#line 41 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                                                                                                                                                                                                                                                             item.CV

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(51, "data-target", "#exampleModal");
            __builder.AddContent(52, "XemCV");
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"

                        }
                        else
                        {
                            var a = item.CV.Split(".").Last();

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "a");
            __builder.AddAttribute(54, "class", "btn btn-outline-primary");
            __builder.AddAttribute(55, "title", "Click để tải cv");
            __builder.AddAttribute(56, "href", "http://localhost:37919/api/Employee/Dowloadfile/" + (
#nullable restore
#line 47 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                                                                                                                                              item.CV

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(57, "Tải CV");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                            ");
            __builder.OpenElement(59, "a");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                                         async()=> { await UpdateStatus(item.EmployeeId, 2); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "id", "bntduyet_" + (
#nullable restore
#line 48 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                                                                                                              item.EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "class", "btn btn-outline-success");
            __builder.AddMarkupContent(63, "Duyệt");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                            ");
            __builder.OpenElement(65, "a");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                                         async()=> { await UpdateStatus(item.EmployeeId, 1); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "id", "bntduyet_" + (
#nullable restore
#line 49 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                                                                                                              item.EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "class", "btn btn-outline-danger");
            __builder.AddMarkupContent(69, "Loại");
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                         
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
            __builder.OpenComponent<QLNVSSV.Client.Components.ViewCVModal>(71);
            __builder.AddAttribute(72, "EmployeeId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 58 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                                                   eID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "Reload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 58 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                                                                Reload

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(74, (__value) => {
#nullable restore
#line 58 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Approval.razor"
                                                                              viewCVModal = (QLNVSSV.Client.Components.ViewCVModal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591