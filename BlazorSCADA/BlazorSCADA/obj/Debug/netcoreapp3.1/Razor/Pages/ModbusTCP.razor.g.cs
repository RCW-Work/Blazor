#pragma checksum "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a9fa67c31f3cc16463a2c35818b040099e699c4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSCADA.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using BlazorSCADA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\_Imports.razor"
using BlazorSCADA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
using BlazorSCADA.ModbusTCP;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/modbus")]
    public partial class ModbusTCP : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ModbusTCP Server</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "table");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddMarkupContent(5, "<thead>\r\n            <tr>\r\n                <th>SlaveIP</th>\r\n                <th>PortNumber</th>\r\n                <th>BTN</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "class", "text-black-50");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                        slaveIP

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => slaveIP = __value, slaveIP));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "class", "text-black-50");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                        portNum

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => portNum = __value, portNum));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "class", 
#nullable restore
#line 23 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                 btnCalss

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "value", "Connect");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                                                     ()=>Connect()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "button");
            __builder.AddAttribute(32, "class", "btn-dark");
            __builder.AddAttribute(33, "value", "Disconnect");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                                                       ()=>disConnect()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "label");
            __builder.AddContent(40, "Error Message ");
            __builder.AddContent(41, 
#nullable restore
#line 28 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                          ErrMsg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "<br>\r\n    <br>\r\n    ");
            __builder.OpenElement(43, "td");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "class", "text-black-50");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                            dataNumbers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dataNumbers = __value, dataNumbers));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n\r\n");
            __builder.OpenElement(50, "div");
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 35 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
     if (MBmaster == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "        ");
            __builder.AddMarkupContent(53, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 38 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "        ");
            __builder.OpenElement(55, "div");
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "button");
            __builder.AddAttribute(59, "class", "btn-danger");
            __builder.AddAttribute(60, "value", "Polling");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                                              ()=>PollingData()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "button");
            __builder.AddAttribute(65, "class", "btn-danger");
            __builder.AddAttribute(66, "value", "StopPolling");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                                                  ()=>StopPolling()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "<br>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.OpenElement(70, "div");
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "table");
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.AddMarkupContent(74, @"<thead class=""table-dark"" align=""center"">
                    <tr>
                        <th width=""100px"">Index</th>
                        <th width=""100px"">Data</th>
                        <th width=""100px"">Index</th>
                        <th width=""100px"">Data</th>
                        <th width=""100px"">Index</th>
                        <th width=""100px"">Data</th>
                        <th width=""100px"">Index</th>
                        <th width=""100px"">Data</th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(75, "tbody");
            __builder.AddMarkupContent(76, "\r\n\r\n");
#nullable restore
#line 61 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                     foreach (var mbData in mbDataList)
                    {
                        if (mbData.Address / tRow == 0)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(77, "                            ");
            __builder.OpenElement(78, "tr");
            __builder.AddMarkupContent(79, "\r\n                                ");
            __builder.OpenElement(80, "td");
            __builder.AddContent(81, 
#nullable restore
#line 66 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                     mbData.Address

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(82, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                                ");
            __builder.OpenElement(84, "td");
            __builder.AddMarkupContent(85, "\r\n                                    ");
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "type", "text");
            __builder.AddAttribute(88, "name", 
#nullable restore
#line 68 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                              mbData.Address

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(89, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 70 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                        (KeyboardEventArgs e)=>onKeyPressHandler(e,mbDataList[mbData.Address])

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onfocus", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 71 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                     ()=> { mbData.isFocus = true; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 72 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                    ()=>onBlurHandler(mbDataList[mbData.Address])

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                                                      mbDataList[mbData.Address].inputData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mbDataList[mbData.Address].inputData = __value, mbDataList[mbData.Address].inputData));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                                ");
            __builder.OpenElement(96, "td");
            __builder.AddContent(97, 
#nullable restore
#line 74 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                      mbData.Address + tRow * 1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                                ");
            __builder.OpenElement(99, "td");
            __builder.AddMarkupContent(100, "\r\n                                    ");
            __builder.OpenElement(101, "input");
            __builder.AddAttribute(102, "type", "text");
            __builder.AddAttribute(103, "name", 
#nullable restore
#line 76 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                              mbData.Address

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(104, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 78 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                        (KeyboardEventArgs e)=>onKeyPressHandler(e,mbDataList[mbData.Address+tRow * 1 ])

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "onfocus", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 79 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                     ()=> { mbDataList[mbData.Address+tRow * 1].isFocus = true; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(106, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 80 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                    ()=>onBlurHandler(mbDataList[mbData.Address+tRow * 1 ])

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                                                      mbDataList[mbData.Address+tRow * 1].inputData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mbDataList[mbData.Address+tRow * 1].inputData = __value, mbDataList[mbData.Address+tRow * 1].inputData));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                                ");
            __builder.OpenElement(111, "td");
            __builder.AddContent(112, 
#nullable restore
#line 82 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                      mbData.Address + tRow * 2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                                ");
            __builder.OpenElement(114, "td");
            __builder.AddMarkupContent(115, "\r\n                                    ");
            __builder.OpenElement(116, "input");
            __builder.AddAttribute(117, "type", "text");
            __builder.AddAttribute(118, "name", 
#nullable restore
#line 84 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                              mbData.Address

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(119, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 86 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                        (KeyboardEventArgs e)=>onKeyPressHandler(e,mbDataList[mbData.Address+ tRow * 2])

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(120, "onfocus", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 87 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                     ()=> { mbDataList[mbData.Address+tRow * 2].isFocus = true; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 88 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                    ()=>onBlurHandler(mbDataList[mbData.Address+ tRow * 2])

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(122, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 84 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                                                      mbDataList[mbData.Address+ tRow * 2].inputData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(123, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mbDataList[mbData.Address+ tRow * 2].inputData = __value, mbDataList[mbData.Address+ tRow * 2].inputData));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                                ");
            __builder.OpenElement(126, "td");
            __builder.AddContent(127, 
#nullable restore
#line 90 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                      mbData.Address + tRow * 3 

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n                                ");
            __builder.OpenElement(129, "td");
            __builder.AddMarkupContent(130, "\r\n                                    ");
            __builder.OpenElement(131, "input");
            __builder.AddAttribute(132, "type", "text");
            __builder.AddAttribute(133, "name", 
#nullable restore
#line 92 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                              mbData.Address

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(134, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 94 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                        (KeyboardEventArgs e)=>onKeyPressHandler(e,mbDataList[mbData.Address+ tRow * 3])

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(135, "onfocus", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 95 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                     ()=> { mbDataList[mbData.Address+tRow * 3].isFocus = true; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(136, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 96 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                    ()=>onBlurHandler(mbDataList[mbData.Address+ tRow * 3])

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(137, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 92 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                                                                                      mbDataList[mbData.Address+ tRow * 3].inputData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(138, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mbDataList[mbData.Address+ tRow * 3].inputData = __value, mbDataList[mbData.Address+ tRow * 3].inputData));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n");
#nullable restore
#line 99 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(142, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n");
#nullable restore
#line 104 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "D:\GitHub_Workspace\Blazor\BlazorSCADA\BlazorSCADA\Pages\ModbusTCP.razor"
       
    public ushort dataNumbers = 32;                     //Data Numbers
    public int tRow = 8;                                //Table Row
    public ushort dataNumberMax = 1024;                 //Max Data Buffer
    public string slaveIP = "127.0.0.1";                //default
    public ushort portNum = 502;                        //default
    private ModbusService Service;                      //Service
    private ModbusService.Server MBmaster;              //Modebus Master/Server
    private byte[] rcvData8 = new byte[2048];           //rcvRawData
    private ushort[] rcvData16 = new ushort[1024];      //rcvRawData to uint16

    private bool isPolling = false;                     //polling flag
    string ErrMsg;                                      //Error Message

    public string[] btnValue = new string[10];
    public string btnCalss = "btn-danger";

    public List<ModbusData> mbDataList { get; set; } = new List<ModbusData>();



    protected override void OnInitialized()
    {
    }
    private void initModbusDataList(ushort dataNumber)
    {

        mbDataList = new List<ModbusData>()
        {
            //new ModbusData { Address = 0, revData=0, inputData=0 },
            //new ModbusData { Address = 1, revData=0, inputData=0 }
        };

        for (UInt16 i = 0; i < dataNumberMax; i++)
        {
            mbDataList.Add(new ModbusData { Address = i, revData = 0, inputData = 0,isFocus=false});
        }
        tRow = dataNumber / 4 + 1;
    }

    public static void ByteToU16Rev(byte[] input, ushort[] output, int index, int number)
    {
        for (int i = index; i < number; i += 2)
        {
            output[i >> 1] = (ushort)(input[i] << 8 | input[i + 1]);
        }
    }

    private void MBmaster_OnException(ushort id, byte unit, byte function, byte exception)
    {
        string exc = "Modbus says error: ";
        switch (exception)
        {
            case ModbusService.Server.excIllegalFunction: exc += "Illegal function!"; break;
            case ModbusService.Server.excIllegalDataAdr: exc += "Illegal data adress!"; break;
            case ModbusService.Server.excIllegalDataVal: exc += "Illegal data value!"; break;
            case ModbusService.Server.excSlaveDeviceFailure: exc += "Slave device failure!"; break;
            case ModbusService.Server.excAck: exc += "Acknoledge!"; break;
            case ModbusService.Server.excGatePathUnavailable: exc += "Gateway path unavailbale!"; break;
            case ModbusService.Server.excExceptionTimeout: exc += "Slave timed out!"; break;
            case ModbusService.Server.excExceptionConnectionLost: exc += "Connection is lost!"; break;
            case ModbusService.Server.excExceptionNotConnected: exc += "Not connected!"; break;
        }
        ErrMsg = exc;
    }

    private void MBmaster_OnResponseData(ushort ID, byte unit, byte function, byte[] values)
    {
        // ------------------------------------------------------------------------
        // Identify requested data
        switch (ID)
        {
            case 1:
                rcvData8 = values;
                break;
            case 2:
                rcvData8 = values;
                break;
            case 3:
                rcvData8 = values;
                break;
            case 4:
                rcvData8 = values;
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
        //MBmaster = new ModbusService.Server("127.0.0.1", 502,true);
        MBmaster = new ModbusService.Server();
        MBmaster.connect(slaveIP, portNum, true);
        if (MBmaster.connected == false)
        {
            ErrMsg = "connect fail";
            return;
        }
        MBmaster.OnResponseData += new ModbusService.Server.ResponseData(MBmaster_OnResponseData);
        MBmaster.OnException += new ModbusService.Server.ExceptionData(MBmaster_OnException);
        btnCalss = "btn-dark";
        initModbusDataList(dataNumbers);
    }
    private void disConnect()
    {
        if (MBmaster != null)
        {
            MBmaster.disconnect();
        }
    }

    async Task GetData(ushort startAddress, ushort numInputs)
    {
        if (MBmaster.connected == true)
        {
            MBmaster.ReadHoldingRegister(3, 0, startAddress, numInputs);
            ByteToU16Rev(rcvData8, rcvData16, 0, numInputs*2);
            await Task.Delay(10);
            StateHasChanged();
        }
    }
    async Task updataValue(ModbusData input)
    {
        await GetData(0, dataNumbers);
        input.inputData = rcvData16[input.Address];
        await Task.Delay(100);
        StateHasChanged();
    }
    async Task updataAllValue(List<ModbusData> inputList)
    {
        await GetData(0, dataNumbers);
        foreach (var input in inputList)
        {
            if (input.isFocus == false)
                input.inputData = rcvData16[input.Address];
        }
        await Task.Delay(100);
        StateHasChanged();
    }
    async Task onBlurHandler(ModbusData input)
    {
        input.isFocus = false;
        await updataValue(input);
    }

    async Task PollingData()
    {
        isPolling = true;
        await GetData(0, dataNumbers);
        await updataAllValue(mbDataList);
        while (isPolling)
        {
            await GetData(0, dataNumbers);
            await updataAllValue(mbDataList);
            await Task.Delay(100);
            StateHasChanged();
        }

    }

    async Task StopPolling()
    {
        isPolling = false;
        await Task.Delay(100);
    }


    async Task WriteData(ushort startAddress, int Data)
    {
        byte[] Value = new byte[2];
        Value[0] = Convert.ToByte((Data >> 8) & 0xFF);
        Value[1] = Convert.ToByte(Data & 0xFF);
        MBmaster.WriteSingleRegister(6, 0, startAddress, Value);
        await Task.Delay(100);
        StateHasChanged();
    }

    async Task onKeyPressHandler(KeyboardEventArgs e, ModbusData input)
    {
        if (e.Code == "Enter" | e.Code == "NumpadEnter")
        {
            byte[] Value = new byte[2];
            Value[0] = Convert.ToByte((input.inputData >> 8) & 0xFF);
            Value[1] = Convert.ToByte(input.inputData & 0xFF);
            MBmaster.intWriteSingleRegister(6, 0, input.Address, Value);
            await Task.Delay(100);
            StateHasChanged();
        }
    }





#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
