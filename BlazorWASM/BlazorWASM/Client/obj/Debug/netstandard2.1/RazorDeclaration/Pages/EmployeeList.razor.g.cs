// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 10 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\Pages\EmployeeList.razor"
using BlazorWASM.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeList")]
    public partial class EmployeeList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\Blazor\employees\BlazorWASM\BlazorWASM\Client\Pages\EmployeeList.razor"
       
    EmployeeInfo[] empList;
    protected override async Task OnInitializedAsync()
    {
        await LoadData();
    }
    protected async Task LoadData()
    {
        empList = await Http.GetJsonAsync<EmployeeInfo[]>("http://localhost:53164/api/EmployeeInfoes");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
