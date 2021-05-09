#pragma checksum "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1159a5bbb797525da5572e4825a98ecb6e63cff"
// <auto-generated/>
#pragma warning disable 1591
namespace TruckLogs.Components.Driver
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\_Imports.razor"
using TruckLogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\_Imports.razor"
using TruckLogs.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
using Business.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Driver")]
    public partial class DriverListComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"col-5\">\r\n        <a class=\"h2\">Conductores</a>\r\n        <a type=\"button\" href=\"Driver/New\" class=\"btn btn-primary\"><span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Agregar Conductor</a>\r\n    </div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-7");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "d-flex flex-row-reverse");
            __builder.AddAttribute(9, "style", "margin-top:6px");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "input-group");
            __builder.AddAttribute(13, "style", "width:60%");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                                               searchText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchText = __value, searchText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "input-group-append");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn btn-secondary");
            __builder.AddAttribute(26, "style", "color:white");
            __builder.AddAttribute(27, "type", "submit");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                                                                                  () => SearchDriver()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Buscar");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n<hr class=\"solid\">\r\n");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "card-deck");
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 25 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
     foreach (var driver in drivers)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "card");
            __builder.AddAttribute(42, "style", "max-width: 500px; min-width: 500px; margin-top:22px");
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "card-body");
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "row");
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-4");
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.OpenElement(53, "img");
            __builder.AddAttribute(54, "src", 
#nullable restore
#line 31 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                   driver.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(55, "style", "max-height:119px; max-width:117px");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "col-8");
            __builder.AddAttribute(60, "style", "font-size:13px");
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.AddMarkupContent(62, "<b>Nombre:</b> ");
            __builder.AddContent(63, 
#nullable restore
#line 34 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                        driver.DriverName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(64, "<br>\r\n                        ");
            __builder.AddMarkupContent(65, "<b>Telefono:</b> ");
            __builder.AddContent(66, 
#nullable restore
#line 35 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                          driver.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(67, "<br>\r\n                        ");
            __builder.AddMarkupContent(68, "<b>Nup:</b> ");
            __builder.AddContent(69, 
#nullable restore
#line 36 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                     driver.Nup

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(70, "<br>\r\n                        ");
            __builder.AddMarkupContent(71, "<b>ISS:</b> ");
            __builder.AddContent(72, 
#nullable restore
#line 37 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                     driver.ISSS

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(73, "<br>\r\n                        ");
            __builder.AddMarkupContent(74, "<b>Dui:</b> ");
            __builder.AddContent(75, 
#nullable restore
#line 38 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                     driver.DUI

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(76, "<br>\r\n                        ");
            __builder.AddMarkupContent(77, "<b>Tipo de contrato:</b>");
            __builder.AddContent(78, 
#nullable restore
#line 39 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                                 driver.HiringType

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(79, "<br>\r\n                        ");
            __builder.AddMarkupContent(80, "<b>Fecha de ingreso:</b>");
            __builder.AddContent(81, 
#nullable restore
#line 40 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                                 driver.HiringDate

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(82, "<br>\r\n                        ");
            __builder.AddMarkupContent(83, "<b>Estado:</b>");
#nullable restore
#line 41 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                       switch (driver.DriverStatus)
                        {
                            case 1:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(84, "<span class=\"badge badge-success\">Activo</span><br>\r\n");
#nullable restore
#line 44 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                break;
                            case 2:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(85, "<span class=\"badge badge-secondary\">Incapacidad</span><br>\r\n");
#nullable restore
#line 46 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                break;
                            case 3:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(86, "<span class=\"badge badge-danger\">Inactivo</span><br>\r\n");
#nullable restore
#line 48 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                break;
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "d-flex flex-row-reverse");
            __builder.AddAttribute(92, "style", "margin-top:6px");
            __builder.AddMarkupContent(93, "\r\n                    ");
            __builder.OpenElement(94, "div");
            __builder.AddMarkupContent(95, "\r\n                        ");
            __builder.OpenElement(96, "a");
            __builder.AddAttribute(97, "type", "button");
            __builder.AddAttribute(98, "href", "/Driver/Edit/" + (
#nullable restore
#line 54 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                                             driver.DriverId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "class", "btn btn-primary rounded-circle");
            __builder.AddMarkupContent(100, "<span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                        ");
            __builder.OpenElement(102, "button");
            __builder.AddAttribute(103, "type", "button");
            __builder.AddAttribute(104, "class", "btn btn-secondary rounded-circle");
            __builder.OpenElement(105, "span");
            __builder.AddAttribute(106, "class", "oi oi-trash");
            __builder.AddAttribute(107, "aria-hidden", "true");
            __builder.AddAttribute(108, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                                                                                                                              () => DeleteDriver(driver)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n");
#nullable restore
#line 60 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
     if (ShowConfirmation)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(114, "        ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "style", " position: fixed; top: 0; left: 0; background-color: #0000005c; width: 100%; height: 100%;");
            __builder.AddMarkupContent(117, "\r\n            ");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "class", "modal fade show d-block");
            __builder.AddAttribute(120, "id", "exampleModal");
            __builder.AddAttribute(121, "tabindex", "-1");
            __builder.AddAttribute(122, "role", "dialog");
            __builder.AddMarkupContent(123, "\r\n                ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "modal-dialog");
            __builder.AddAttribute(126, "role", "document");
            __builder.AddMarkupContent(127, "\r\n                    ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "modal-content");
            __builder.AddMarkupContent(130, "\r\n                        ");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "class", "modal-header");
            __builder.AddMarkupContent(133, "\r\n                            ");
            __builder.AddMarkupContent(134, "<h5 class=\"modal-title\" id=\"exampleModalLabel\">Confirmacion de eliminacion</h5>\r\n                            ");
            __builder.OpenElement(135, "button");
            __builder.AddAttribute(136, "type", "button");
            __builder.AddAttribute(137, "class", "close");
            __builder.AddAttribute(138, "data-dismiss", "modal");
            __builder.AddAttribute(139, "aria-label", "Close");
            __builder.AddAttribute(140, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                              () => CancelConfirmation()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(141, "\r\n                                ");
            __builder.AddMarkupContent(142, "<span aria-hidden=\"true\">&times;</span>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                        ");
            __builder.OpenElement(145, "div");
            __builder.AddAttribute(146, "class", "modal-body");
            __builder.AddMarkupContent(147, "\r\n                            ¿Esta seguro que desea eliminar el conductor? ");
            __builder.AddContent(148, 
#nullable restore
#line 75 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                                                           driverToDelete.DriverName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(149, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                        ");
            __builder.OpenElement(151, "div");
            __builder.AddAttribute(152, "class", "modal-footer");
            __builder.AddMarkupContent(153, "\r\n                            ");
            __builder.OpenElement(154, "button");
            __builder.AddAttribute(155, "type", "button");
            __builder.AddAttribute(156, "class", "btn btn-secondary");
            __builder.AddAttribute(157, "data-dismiss", "modal");
            __builder.AddAttribute(158, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                              () => CancelConfirmation()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(159, "\r\n                                Cancel\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n                            ");
            __builder.OpenElement(161, "button");
            __builder.AddAttribute(162, "type", "button");
            __builder.AddAttribute(163, "class", "btn btn-danger");
            __builder.AddAttribute(164, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
                                              () => DeleteDriverConfirmation()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(165, "\r\n                                Delete\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n");
#nullable restore
#line 91 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverListComponent.razor"
       
    List<DriverEntity> drivers = new List<DriverEntity>();
    string viewPath, searchText;
    bool ShowConfirmation = false;
    DriverEntity driverToDelete;
    protected override async Task OnInitializedAsync()
    {
        viewPath = _configuration.GetSection("FileSetting:DriverViewPath").Value;
        LoadDrivers();

    }

    public void LoadDrivers()
    {
        drivers = _b_driver.DriverList();
        foreach (var driver in drivers)
        {
            driver.ImageUrl = $"{viewPath}{driver.ImageUrl}";
        }
    }
    public void DeleteDriver(DriverEntity driver)
    {
        ShowConfirmation = true;
        driverToDelete = driver;
    }
    public void SearchDriver()
    {
        LoadDrivers();
        string search = searchText.ToUpper();
        if(search != "" )drivers = drivers.Where(d=> d.DriverName.ToUpper().Contains(search) || d.DUI.ToUpper().Contains(search) || d.Nup.ToUpper().Contains(search) 
        || d.PhoneNumber.ToUpper().Contains(search) || d.ISSS.ToUpper().Contains(search) || d.HiringDate.ToString().ToUpper().Contains(search)).ToList();
    }
    public void CancelConfirmation()
    {
        ShowConfirmation = false;
    }
    public void DeleteDriverConfirmation()
    {
        if(driverToDelete != null)
        {
            _b_driver.DeleteDriver(driverToDelete);
            LoadDrivers();
        }
        ShowConfirmation = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _configuration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IB_Driver _b_driver { get; set; }
    }
}
#pragma warning restore 1591
