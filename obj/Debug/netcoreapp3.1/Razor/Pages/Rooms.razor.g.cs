#pragma checksum "D:\AllProjects\BlazorHotel\BlazorHotel\Pages\Rooms.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd81c1b103355eafdbe2212eee2bf75a3592e70b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorHotel.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\AllProjects\BlazorHotel\BlazorHotel\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AllProjects\BlazorHotel\BlazorHotel\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AllProjects\BlazorHotel\BlazorHotel\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\AllProjects\BlazorHotel\BlazorHotel\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\AllProjects\BlazorHotel\BlazorHotel\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\AllProjects\BlazorHotel\BlazorHotel\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\AllProjects\BlazorHotel\BlazorHotel\_Imports.razor"
using BlazorHotel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\AllProjects\BlazorHotel\BlazorHotel\_Imports.razor"
using BlazorHotel.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AllProjects\BlazorHotel\BlazorHotel\Pages\Rooms.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AllProjects\BlazorHotel\BlazorHotel\Pages\Rooms.razor"
using BlazorHotel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\AllProjects\BlazorHotel\BlazorHotel\Pages\Rooms.razor"
using BlazorHotel.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/rooms")]
    public partial class Rooms : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 8 "D:\AllProjects\BlazorHotel\BlazorHotel\Pages\Rooms.razor"
     foreach (var room in HotelService.GetRooms())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-image");
            __builder.AddAttribute(9, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 11 "D:\AllProjects\BlazorHotel\BlazorHotel\Pages\Rooms.razor"
                                                                   room.img

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-text");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "class", "date");
            __builder.AddContent(17, 
#nullable restore
#line 14 "D:\AllProjects\BlazorHotel\BlazorHotel\Pages\Rooms.razor"
                                    DateTime.Now.ToString("MM-dd-yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "h2");
            __builder.AddContent(20, 
#nullable restore
#line 15 "D:\AllProjects\BlazorHotel\BlazorHotel\Pages\Rooms.razor"
                     room.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "p");
            __builder.AddContent(23, 
#nullable restore
#line 16 "D:\AllProjects\BlazorHotel\BlazorHotel\Pages\Rooms.razor"
                    room.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.AddMarkupContent(26, @"<div class=""card-stats"">
                <div class=""stat"">
                    <div class=""value"">4<sup>m</sup></div>
                    <div class=""type"">read</div>
                </div>
                <div class=""stat border"">
                    <div class=""value"">5123</div>
                    <div class=""type"">views</div>
                </div>
                <div class=""stat"">
                    <div class=""value"">32</div>
                    <div class=""type"">comments</div>
                </div>
            </div>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 33 "D:\AllProjects\BlazorHotel\BlazorHotel\Pages\Rooms.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\AllProjects\BlazorHotel\BlazorHotel\Pages\Rooms.razor"
       
    void SelectProduct(string roomid)
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HotelRoomService HotelService { get; set; }
    }
}
#pragma warning restore 1591
