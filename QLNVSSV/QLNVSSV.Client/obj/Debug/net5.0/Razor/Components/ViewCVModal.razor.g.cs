#pragma checksum "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\ViewCVModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e24318e9ee8cc3694c0222d9d9715797fca508f0"
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
    public partial class ViewCVModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " fade" + " " + (
#nullable restore
#line 4 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\ViewCVModal.razor"
                        ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "style", "display:" + (
#nullable restore
#line 4 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\ViewCVModal.razor"
                                                    DissplayModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "id", "exampleModalCenter");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddAttribute(6, "aria-labelledby", "exampleModalCenterTitle");
            __builder.AddAttribute(7, "aria-hidden", "true");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "style", "max-width:50% !important");
            __builder.AddAttribute(10, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(11, "role", "document");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-content");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-header");
            __builder.AddMarkupContent(16, "<h5 class=\"modal-title\" id=\"exampleModalLongTitle\">Modal title</h5>\r\n                ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "close");
            __builder.AddAttribute(20, "data-dismiss", "modal");
            __builder.AddAttribute(21, "aria-label", "Close");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\ViewCVModal.razor"
                                                                                                      Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "modal-body");
            __builder.OpenElement(27, "iframe");
            __builder.AddAttribute(28, "style", "width:100%;height:100%;");
            __builder.AddAttribute(29, "src", "http://localhost:37919/Image/" + (
#nullable restore
#line 14 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\ViewCVModal.razor"
                                                                                           Cv

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "title");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "modal-footer");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "class", "btn btn-outline-danger");
            __builder.AddAttribute(37, "data-dismiss", "modal");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\ViewCVModal.razor"
                                                                                                    ()=>UpdateStatus(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(39, "Loại");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "type", "button");
            __builder.AddAttribute(43, "class", "btn btn-outline-primary");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\ViewCVModal.razor"
                                                                                ()=>UpdateStatus(2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(45, "Duyệt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\PhongNV\Desktop\CRUDMYSQL\QLNVSSV\QLNVSSV.Client\Components\ViewCVModal.razor"
       

    [Parameter]
    public int EmployeeId { get; set; }

    public string ModalClass { get; set; }

    public string DissplayModal { get; set; } = "none";

    private string Cv { get; set; }


    [Parameter]
    public EventCallback Reload { get; set; }

    public void Open()
    {
        DissplayModal = "block;";
        ModalClass = "show";
        StateHasChanged();
    }
    public void Close()
    {
        DissplayModal = "none";
        ModalClass = "";
        StateHasChanged();
    }
    public async Task Show(string cv)
    {
        Console.WriteLine(cv);
        Cv = cv;
        Open();
    }

    public async Task UpdateStatus(int status)
    {
        string url = $"http://localhost:37919/api/Employee/UpdateStatus/{EmployeeId}/{status}";
        using (var client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
            }
        }
        Close();
        Reload.InvokeAsync();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591