#pragma checksum "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c2021d4b495e48f63a1cb5754d335c8cf50119f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Schedule")]
    public partial class Schedule : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Schedule</h3>\r\n\r\n");
            __builder.OpenComponent<QLNVSSV.Client.Components.FilterCommon>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "style", "margin-top:20px");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, @"<thead><tr><th scope=""col"">ID</th>
            <th scope=""col"">Họ Tên</th>
            <th scope=""col"">Tên vị trí</th>
            <th scope=""col"">Chức danh</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">Số điện thoại</th>
            <th scope=""col"">Thời gian PV</th>
            <th scope=""col"">Địa điểm PV</th>
            <th scope=""col"">Ghi chú</th>
            <th scope=""col"">Hành động</th></tr></thead>
    ");
            __builder.OpenElement(7, "tbody");
            __builder.AddAttribute(8, "id", "tablebody");
#nullable restore
#line 21 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
         foreach (var item in listEmployee)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.AddAttribute(10, "id", "row_" + (
#nullable restore
#line 23 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                         item.EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(11, "td");
            __builder.AddAttribute(12, "scope", "col");
            __builder.AddContent(13, 
#nullable restore
#line 24 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                 item.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddAttribute(16, "scope", "col");
            __builder.AddContent(17, 
#nullable restore
#line 25 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                 item.EmployeeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddAttribute(20, "scope", "col");
            __builder.AddContent(21, 
#nullable restore
#line 26 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                 item.PositionName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "scope", "col");
            __builder.AddContent(25, 
#nullable restore
#line 27 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                 item.TitleName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "scope", "col");
            __builder.AddContent(29, 
#nullable restore
#line 28 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                 item.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddAttribute(32, "scope", "col");
            __builder.AddContent(33, 
#nullable restore
#line 29 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                 item.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "scope", "col");
            __builder.AddAttribute(37, "id", "trthoigian");
#nullable restore
#line 31 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                      
                        var time = DateTime.Parse("0001-01-01 00:00:00.0000000");
                        if (item.InterviewTime != time)
                        {
                            

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, 
#nullable restore
#line 35 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                             item.InterviewTime.ToString("dd/MM/yyyy hh:mm tt")

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 35 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                                                               
                        }
                    

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "scope", "col");
            __builder.AddAttribute(42, "id", "trdiadiem");
            __builder.AddContent(43, 
#nullable restore
#line 39 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                                item.InterviewAddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "scope", "col");
            __builder.AddAttribute(47, "id", "trghichu");
            __builder.AddContent(48, 
#nullable restore
#line 40 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                               item.Note

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "td");
            __builder.AddAttribute(51, "scope", "col");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                      ()=>Show(item.EmployeeId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "class", "btn btn-outline-primary");
            __builder.AddAttribute(56, "data-toggle", "modal");
            __builder.AddAttribute(57, "data-target", "#exampleModalCenter");
            __builder.AddMarkupContent(58, "\r\n                        Đặt Lịch\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n\r\n");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "modal" + " fade" + " " + (
#nullable restore
#line 52 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                        ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "style", "display:" + (
#nullable restore
#line 52 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                                    DissplayModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "id", "exampleModalCenter");
            __builder.AddAttribute(64, "tabindex", "-1");
            __builder.AddAttribute(65, "role", "dialog");
            __builder.AddAttribute(66, "aria-labelledby", "exampleModalCenterTitle");
            __builder.AddAttribute(67, "aria-hidden", "true");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(70, "role", "document");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "modal-content");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "modal-header");
            __builder.AddMarkupContent(75, "<h5 class=\"modal-title\" id=\"exampleModalLongTitle\">Modal title</h5>\r\n                ");
            __builder.OpenElement(76, "button");
            __builder.AddAttribute(77, "type", "button");
            __builder.AddAttribute(78, "class", "close");
            __builder.AddAttribute(79, "data-dismiss", "modal");
            __builder.AddAttribute(80, "aria-label", "Close");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                                                                                      Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(82, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "modal-body");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "form-group");
            __builder.AddMarkupContent(88, "<label for=\"exampleInputEmail1\">Người phỏng vấn</label>\r\n                    ");
            __builder.OpenElement(89, "select");
            __builder.AddAttribute(90, "id", "interviewer");
            __builder.AddAttribute(91, "class", "form-control form-select");
            __builder.AddAttribute(92, "aria-label", "Default select example");
            __builder.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                                                                                                          employee.InterviewerId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.InterviewerId = __value, employee.InterviewerId));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 66 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                         foreach (var item in listInterviewer)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(95, "option");
            __builder.AddAttribute(96, "class", "option_interviewer");
            __builder.AddAttribute(97, "value", 
#nullable restore
#line 68 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                                                       item.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(98, 
#nullable restore
#line 68 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                                                                         item.EmployeeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 69 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"

                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n\r\n                ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "form-group");
            __builder.AddMarkupContent(102, "<label for=\"exampleInputEmail1\">Ngày phỏng vấn</label>\r\n                    ");
            __builder.OpenElement(103, "input");
            __builder.AddAttribute(104, "id", "interviewTime");
            __builder.AddAttribute(105, "class", "form-control");
            __builder.AddAttribute(106, "type", "datetime-local");
            __builder.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                                                                                       employee.InterviewTime

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-ddTHH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.InterviewTime = __value, employee.InterviewTime, format: "yyyy-MM-ddTHH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n\r\n                ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "form-group");
            __builder.AddMarkupContent(112, "<label for=\"exampleInputEmail1\">Địa điểm</label>\r\n                    ");
            __builder.OpenElement(113, "select");
            __builder.AddAttribute(114, "id", "interviewAddress");
            __builder.AddAttribute(115, "class", "form-control form-select");
            __builder.AddAttribute(116, "aria-label", "Default select example");
            __builder.AddAttribute(117, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 81 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                                                                                                              employee.InterviewAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.InterviewAddress = __value, employee.InterviewAddress));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(119, "option");
            __builder.AddAttribute(120, "value", "HN");
            __builder.AddContent(121, "HN");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                        ");
            __builder.OpenElement(123, "option");
            __builder.AddAttribute(124, "value", "HUE");
            __builder.AddContent(125, "Hue");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n            ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "modal-footer");
            __builder.OpenElement(129, "button");
            __builder.AddAttribute(130, "type", "button");
            __builder.AddAttribute(131, "class", "btn btn-secondary");
            __builder.AddAttribute(132, "data-dismiss", "modal");
            __builder.AddAttribute(133, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                                                                               Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(134, "Close");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                ");
            __builder.OpenElement(136, "button");
            __builder.AddAttribute(137, "type", "button");
            __builder.AddAttribute(138, "class", "btn btn-primary");
            __builder.AddAttribute(139, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Pages\Schedule.razor"
                                                                         Imsposed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(140, "Tạo");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591