#pragma checksum "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\Pratice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e163fab897ba7be432de5feca715ca9e90ca112"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSCADA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using BlazorSCADA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using BlazorSCADA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\Pratice.razor"
using BlazorSCADA.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/testpage")]
    public partial class Pratice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>pratice</h3>\r\n");
            __builder.OpenComponent<BlazorSCADA.Components.Test>(1);
            __builder.AddAttribute(2, "IncrementAmount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\Pratice.razor"
                       1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "cbOnclick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\Pratice.razor"
                                     (MouseEventArgs e)=>testFunction(e)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "cbTest", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 4 "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\Pratice.razor"
                                                                                  testCallback

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\Pratice.razor"
       
    public void testFunction(MouseEventArgs e)
    {
        string test = e.ClientX.ToString();
    }

    public void testCallback()
    {
        5.ToString();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591