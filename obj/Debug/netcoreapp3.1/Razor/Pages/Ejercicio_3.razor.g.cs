#pragma checksum "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_3.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "899f262ccf706e7dad5ba97d314c9f616dd43aa3"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_2.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using Tarea_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\crist\Desktop\Programacion III\Tarea_2\_Imports.razor"
using Tarea_2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_3.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio-3")]
    public partial class Ejercicio_3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center\">Ejercicio #3</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"row\">\r\n        <p>Programa que acepte un numero de una cedula dominicana y determine si es valida. (sin usar api).</p>\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "placeholder", "Introduzca una cedula");
            __builder.AddAttribute(14, "type", "text");
            __builder.AddAttribute(15, "maxlength", "11");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_3.razor"
                                                                                               cedula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cedula = __value, cedula));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-dark");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_3.razor"
                                                   Verified

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Verificar");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "<br>\r\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col justify-content-center");
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "ul");
            __builder.AddAttribute(34, "class", "list-group");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "list-group-item text-center");
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "p");
            __builder.AddContent(40, 
#nullable restore
#line 20 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_3.razor"
                    result

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_3.razor"
        
    public string cedula {get; set;}
    public string result {get; set;}

    public void Verified() 
    {
        result = Validation(cedula);
    }

    public string Validation(string cedula)
    {
        int[] digitos = new int[11];
        const int x1 = 1, x2 = 2;
        int digitoMultiplicado = 0, Result = 0;
        int comparacion = 0;
        var res = "";

        try
        {            
            if(cedula.Length == 11)
            {
                for (int index = 0; index < 11; index++)
                {
                    digitos[index] = Convert.ToInt32(cedula.Substring(index, 1));
                }

                for (int index = 9; index >= 0; index--)
                {
                    if (index % 2 == 0)
                    {
                        digitoMultiplicado = digitos[index] * x1;
                        if (digitoMultiplicado < 10)
                        {
                            Result = Result + digitoMultiplicado;
                        }
                        else
                        {
                            for (int index_ = 0; index_ < 2; index_++)
                            {
                                var cut = Convert.ToString(digitoMultiplicado);
                                Result = Result + Convert.ToInt32(cut.Substring(index_, 1));
                            }
                        }                       
                    }
                    else
                    {
                        digitoMultiplicado = digitos[index] * x2;
                        if (digitoMultiplicado < 10)
                        {
                            Result = Result + digitoMultiplicado;
                        }
                        else
                        {
                            for (int index_ = 0; index_ < 2; index_++)
                            {
                                var cut = Convert.ToString(digitoMultiplicado);
                                Result = Result + Convert.ToInt32(cut.Substring(index_, 1));
                            }
                        } 
                    }
                }

                if(Result >= 0 && Result <= 9)
                {
                    comparacion = 10 - Result;
                    res = Comparation(digitos[10], comparacion);
                }
                else if(Result >= 10 && Result <= 19)
                {
                    comparacion = 20 - Result;
                    res = Comparation(digitos[10], comparacion);
                }
                else if(Result >= 20 && Result <= 29)
                {
                    comparacion = 30 - Result;
                    res = Comparation(digitos[10], comparacion);
                }
                else if(Result >= 30 && Result <= 39)
                {
                    comparacion = 40 - Result;
                    res = Comparation(digitos[10], comparacion);
                }
                else if(Result >= 40 && Result <= 49)
                {
                    comparacion = 50 - Result;
                    Console.WriteLine(digitos[10] + " " + Result + " " + comparacion);
                    res = Comparation(digitos[10], comparacion);
                }
                else if(Result >= 50 && Result <= 59)
                {
                    comparacion = 60 - Result;
                    res = Comparation(digitos[10], comparacion);
                }
                else if(Result >= 60 && Result <= 69)
                {
                    comparacion = 70 - Result;
                    res = Comparation(digitos[10], comparacion);
                }
                else if(Result >= 70 && Result <= 79)
                {
                    comparacion = 80 - Result;
                    res = Comparation(digitos[10], comparacion);
                }
                else if(Result >= 80 && Result <= 89)
                {
                    comparacion = 90 - Result;
                    res = Comparation(digitos[10], comparacion);
                }
                else if(Result >= 90 && Result <= 99)
                {
                    comparacion = 100 - Result;
                    res = Comparation(digitos[10], comparacion);
                }
                
            }
            else 
            {
                res = "Le falta el digitos para ser una cédula dominicana";
            }
        }
        catch (System.Exception)
        {            
            res = "No se pudo validar de ninguna manera esta cédula";
        }

        return res;
    }

    public string Comparation(int digitoVerificador, int digitoComparativo)
    {
        var res = "";

        if(digitoVerificador == digitoComparativo)
        {
            res = "Es una cédula dominicana valida";
        }
        else
        {
            res = "No es una cédula dominicada valida";
        }
        return res;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
