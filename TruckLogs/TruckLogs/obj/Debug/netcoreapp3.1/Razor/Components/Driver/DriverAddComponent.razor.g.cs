#pragma checksum "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea7e3981b7c6d6439b8c059e1902dae0fca00189"
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
#line 2 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
using Business.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Driver/New")]
    public partial class DriverAddComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\">\r\n    <div class=\"col-5\">\r\n        <a class=\"h2\">Agregar Conductor</a>\r\n    </div>\r\n</div>\r\n<hr class=\"solid\">\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddAttribute(6, "style", "max-width: 80%; min-width:80%; margin-top:22px;margin: 0 auto;float: none;");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                              driver

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                      HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "row");
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-5");
                __builder2.AddMarkupContent(23, "\r\n                        ");
                __builder2.AddMarkupContent(24, "<label for=\"exampleFormControlFile1\">Foto conductor</label>\r\n                        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group col-12");
                __builder2.AddMarkupContent(27, "\r\n                            ");
                __builder2.OpenElement(28, "img");
                __builder2.AddAttribute(29, "src", 
#nullable restore
#line 23 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                       currentImage

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(30, "style", "max-width: 100%;margin-bottom:20px;");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                            ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(32);
                __builder2.AddAttribute(33, "style", "max-width: 100%;margin-bottom:20px;");
                __builder2.AddAttribute(34, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 24 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                                                             HandleFileSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                            ");
                __Blazor.TruckLogs.Components.Driver.DriverAddComponent.TypeInference.CreateValidationMessage_0(__builder2, 36, 37, 
#nullable restore
#line 25 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                      ()=>driver.ImageUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(38, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "col-7");
                __builder2.AddMarkupContent(43, "\r\n                        ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddMarkupContent(46, "\r\n                            ");
                __builder2.AddMarkupContent(47, "<label for=\"DriverName\">Nombre</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(48);
                __builder2.AddAttribute(49, "type", "text");
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "id", "DriverName");
                __builder2.AddAttribute(52, "placeholder", "Ingrese el nombre completo del conductor");
                __builder2.AddAttribute(53, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                                                                     driver.DriverName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => driver.DriverName = __value, driver.DriverName))));
                __builder2.AddAttribute(55, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => driver.DriverName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n                            ");
                __Blazor.TruckLogs.Components.Driver.DriverAddComponent.TypeInference.CreateValidationMessage_1(__builder2, 57, 58, 
#nullable restore
#line 32 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                      ()=>driver.DriverName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(59, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group");
                __builder2.AddMarkupContent(63, "\r\n                            ");
                __builder2.AddMarkupContent(64, "<label for=\"DriverPhoneNumber\">Telefono</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(65);
                __builder2.AddAttribute(66, "type", "text");
                __builder2.AddAttribute(67, "class", "form-control");
                __builder2.AddAttribute(68, "id", "DriverPhoneNumber");
                __builder2.AddAttribute(69, "data-mask", "0000-0000");
                __builder2.AddAttribute(70, "placeholder", "Telefono del conductor");
                __builder2.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                                                                            driver.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => driver.PhoneNumber = __value, driver.PhoneNumber))));
                __builder2.AddAttribute(73, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => driver.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n                            ");
                __Blazor.TruckLogs.Components.Driver.DriverAddComponent.TypeInference.CreateValidationMessage_2(__builder2, 75, 76, 
#nullable restore
#line 37 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                      ()=>driver.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(77, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                        ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group");
                __builder2.AddMarkupContent(81, "\r\n                            ");
                __builder2.AddMarkupContent(82, "<label for=\"DriverNUP\">Nup</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(83);
                __builder2.AddAttribute(84, "type", "number");
                __builder2.AddAttribute(85, "class", "form-control");
                __builder2.AddAttribute(86, "id", "DriverNUP");
                __builder2.AddAttribute(87, "data-mask", "000000000000");
                __builder2.AddAttribute(88, "placeholder", "Nup del conductor");
                __builder2.AddAttribute(89, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                                                                      driver.Nup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => driver.Nup = __value, driver.Nup))));
                __builder2.AddAttribute(91, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => driver.Nup));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n                            ");
                __Blazor.TruckLogs.Components.Driver.DriverAddComponent.TypeInference.CreateValidationMessage_3(__builder2, 93, 94, 
#nullable restore
#line 42 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                      ()=>driver.Nup

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(95, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                        ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-group");
                __builder2.AddMarkupContent(99, "\r\n                            ");
                __builder2.AddMarkupContent(100, "<label for=\"DriverNUP\">DUI</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(101);
                __builder2.AddAttribute(102, "type", "number");
                __builder2.AddAttribute(103, "class", "form-control");
                __builder2.AddAttribute(104, "id", "DriverDUI");
                __builder2.AddAttribute(105, "data-mask", "00000000-0");
                __builder2.AddAttribute(106, "placeholder", "DUI del conductor");
                __builder2.AddAttribute(107, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                                                                      driver.DUI

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(108, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => driver.DUI = __value, driver.DUI))));
                __builder2.AddAttribute(109, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => driver.DUI));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(110, "\r\n                            ");
                __Blazor.TruckLogs.Components.Driver.DriverAddComponent.TypeInference.CreateValidationMessage_4(__builder2, 111, 112, 
#nullable restore
#line 47 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                      ()=>driver.DUI

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(113, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                        ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "form-group");
                __builder2.AddMarkupContent(117, "\r\n                            ");
                __builder2.AddMarkupContent(118, "<label for=\"DriverISSS\">ISSS</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(119);
                __builder2.AddAttribute(120, "type", "number");
                __builder2.AddAttribute(121, "class", "form-control");
                __builder2.AddAttribute(122, "id", "DriverISSS");
                __builder2.AddAttribute(123, "placeholder", "ISSS del conductor");
                __builder2.AddAttribute(124, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                                                                       driver.ISSS

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(125, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => driver.ISSS = __value, driver.ISSS))));
                __builder2.AddAttribute(126, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => driver.ISSS));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(127, "\r\n                            ");
                __Blazor.TruckLogs.Components.Driver.DriverAddComponent.TypeInference.CreateValidationMessage_5(__builder2, 128, 129, 
#nullable restore
#line 52 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                      ()=>driver.ISSS

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(130, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n                        ");
                __builder2.OpenElement(132, "div");
                __builder2.AddAttribute(133, "class", "form-group");
                __builder2.AddMarkupContent(134, "\r\n                            ");
                __builder2.AddMarkupContent(135, "<label for=\"exampleFormControlSelect1\">Tipo de contrato</label>\r\n                            ");
                __Blazor.TruckLogs.Components.Driver.DriverAddComponent.TypeInference.CreateInputSelect_6(__builder2, 136, 137, "form-control", 138, 
#nullable restore
#line 56 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                      driver.HiringType

#line default
#line hidden
#nullable disable
                , 139, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => driver.HiringType = __value, driver.HiringType)), 140, () => driver.HiringType, 141, (__builder3) => {
                    __builder3.AddMarkupContent(142, "\r\n");
#nullable restore
#line 57 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                 foreach (string name in Enum.GetNames(typeof(DriverEntity.HiringTypeEnum)))
                                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(143, "                                    ");
                    __builder3.OpenElement(144, "option");
                    __builder3.AddAttribute(145, "value", 
#nullable restore
#line 59 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                    name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(146, 
#nullable restore
#line 59 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                           name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(147, "\r\n");
#nullable restore
#line 60 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(148, "                            ");
                }
                );
                __builder2.AddMarkupContent(149, "\r\n                            ");
                __Blazor.TruckLogs.Components.Driver.DriverAddComponent.TypeInference.CreateValidationMessage_7(__builder2, 150, 151, 
#nullable restore
#line 62 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                      ()=>driver.HiringType

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(152, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(153, "\r\n                        ");
                __builder2.OpenElement(154, "div");
                __builder2.AddAttribute(155, "class", "form-group");
                __builder2.AddMarkupContent(156, "\r\n                            ");
                __builder2.AddMarkupContent(157, "<label for=\"DriverFechaIngreso\">Fecha Ingreso</label>\r\n                            ");
                __Blazor.TruckLogs.Components.Driver.DriverAddComponent.TypeInference.CreateInputDate_8(__builder2, 158, 159, "form-control", 160, "DriverFechaIngreso", 161, 
#nullable restore
#line 66 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                                                                  driver.HiringDate

#line default
#line hidden
#nullable disable
                , 162, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => driver.HiringDate = __value, driver.HiringDate)), 163, () => driver.HiringDate);
                __builder2.AddMarkupContent(164, "\r\n                            ");
                __Blazor.TruckLogs.Components.Driver.DriverAddComponent.TypeInference.CreateValidationMessage_9(__builder2, 165, 166, 
#nullable restore
#line 67 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
                                                      ()=>driver.HiringDate

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(167, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(168, "\r\n\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(169, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(170, "\r\n                ");
                __builder2.AddMarkupContent(171, "<div class=\"d-flex flex-row-reverse\" style=\"margin-top:6px\">\r\n                    <div>\r\n                        <button type=\"submit\" class=\"btn btn-primary\">Agregar</button>\r\n                    </div>\r\n                </div>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(172, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\Manuel Rodas\source\repos\TruckLogs\TruckLogs\Components\Driver\DriverAddComponent.razor"
       
    DriverEntity driver = new DriverEntity() { HiringDate = DateTime.Now };
    string currentImage = "/Content/Images/DefaultPhoto.jpg";
    string path = Directory.GetCurrentDirectory();
    FileEntity _file = new FileEntity();
    IFileListEntry file;
    private void HandleValidSubmit()
    {
        driver.DriverStatus = 1;
        _b_file.UploadImageDriver(_file.Base64, driver.ImageUrl);
        _b_driver.CreateDriver(driver);
        NavManager.NavigateTo("/Driver");
    }
    async Task HandleFileSelected(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();
        driver.ImageUrl = "";
        if (file != null)
        {
            _file = new FileEntity();
            await _file.LoadBase64(file.Data);
            currentImage = $"data:image/png;base64, {_file.Base64}";
            driver.ImageUrl = $"{DateTime.Now.ToString("yyyyMMddHHmmss")}.png";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IB_Driver _b_driver { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IB_File _b_file { get; set; }
    }
}
namespace __Blazor.TruckLogs.Components.Driver.DriverAddComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
