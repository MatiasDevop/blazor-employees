#pragma checksum "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\Pages\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cf97babf8e77f5477d8e023115f83980de46005"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWASM.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\_Imports.razor"
using BlazorWASM.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\_Imports.razor"
using BlazorWASM.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\Pages\EditEmployee.razor"
using BlazorWASM.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee/{id}")]
    public partial class EditEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2> Edit Employee</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label for=\"EmployeeName\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "for", "EmployeeName");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\Pages\EditEmployee.razor"
                                                                       emp.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.Name = __value, emp.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<label for=\"Designation\" class=\"control-label\">Designation</label>\r\n                ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "for", "Designation");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\Pages\EditEmployee.razor"
                                                                      emp.Designation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.Designation = __value, emp.Designation));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.AddMarkupContent(34, "<label for=\"Department\" class=\"control-label\">Department</label>\r\n                ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "for", "Department");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\Pages\EditEmployee.razor"
                                                                     emp.Deparment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.Deparment = __value, emp.Deparment));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "row");
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col-md-4");
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group");
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "class", "btn btn-primary");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\Pages\EditEmployee.razor"
                                                                        UpdateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "value", "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "type", "button");
            __builder.AddAttribute(61, "class", "btn");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\Pages\EditEmployee.razor"
                                                            Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\Pages\EditEmployee.razor"
       
    [Parameter]
    public string id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        emp = await Http.GetJsonAsync<EmployeeInfo>("http://localhost:8083/api/EmployeeInfoes/" + id);
    }

    EmployeeInfo emp = new EmployeeInfo();
    protected async Task UpdateEmployee()
    {
        await Http.PutJsonAsync("http://localhost:8083/api/EmployeeInfoes/" + id, emp);
        NavigationManager.NavigateTo("employeeList");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("employeeList");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
