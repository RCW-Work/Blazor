#pragma checksum "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d7adcbd0f0c198074ed951cd842437897265294"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
using BlazorSCADA.ModbusTCP;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ModbusTCP")]
    public partial class ModbusTCP : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "D:\GitHub-Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
       

    public string rcvData;
    private byte[] data = new byte[1024];
    string ErrorMsg;

    private ModbusServerService MBmaster;
    private ModbusMaster tempMaster;

    private void MBmaster_OnException(ushort id, byte unit, byte function, byte exception)
    {
        string exc = "Modbus says error: ";
        switch (exception)
        {
            case ModbusServerService.excIllegalFunction: exc += "Illegal function!"; break;
            case ModbusServerService.excIllegalDataAdr: exc += "Illegal data adress!"; break;
            case ModbusServerService.excIllegalDataVal: exc += "Illegal data value!"; break;
            case ModbusServerService.excSlaveDeviceFailure: exc += "Slave device failure!"; break;
            case ModbusServerService.excAck: exc += "Acknoledge!"; break;
            case ModbusServerService.excGatePathUnavailable: exc += "Gateway path unavailbale!"; break;
            case ModbusServerService.excExceptionTimeout: exc += "Slave timed out!"; break;
            case ModbusServerService.excExceptionConnectionLost: exc += "Connection is lost!"; break;
            case ModbusServerService.excExceptionNotConnected: exc += "Not connected!"; break;
        }
        ErrorMsg = exc;
    }

    private void MBmaster_OnResponseData(ushort ID, byte unit, byte function, byte[] values)
    {
        // ------------------------------------------------------------------------
        // Identify requested data
        switch (ID)
        {
            case 1:
                data = values;
                break;
            case 2:
                data = values;
                break;
            case 3:
                data = values;
                break;
            case 4:
                data = values;
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
        }
    }


    private void Connect()
    {
        MBmaster = new ModbusServerService("127.0.0.1", 502, true);
        MBmaster.OnResponseData += new ModbusServerService.ResponseData(MBmaster_OnResponseData);
        MBmaster.OnException += new ModbusServerService.ExceptionData(MBmaster_OnException);
    }

    private void GetData()
    {

        MBmaster.ReadHoldingRegister(3, 2, 1, 20);
        rcvData = data[0].ToString();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591