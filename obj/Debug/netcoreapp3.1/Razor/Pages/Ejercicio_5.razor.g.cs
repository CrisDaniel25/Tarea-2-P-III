#pragma checksum "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_5.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aad301ca21cb22fb309f4ebec08f109dfefbfc55"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_2.Pages
{
    #line hidden
    using System;
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio-5")]
    public partial class Ejercicio_5 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center\">Ejercicio #5</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"row\">\r\n        <p>Programa que acepte un numero del 1 al 100000, mostrarlo en letras. Ejemplo 90 => noventa. (En español)</p>\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "placeholder", "Introduzca un numero");
            __builder.AddAttribute(14, "type", "number");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_5.razor"
                                                                                                numero

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => numero = __value, numero, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col");
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-dark");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_5.razor"
                                                   Convert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Convertir");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "<br>\r\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col justify-content-center");
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "ul");
            __builder.AddAttribute(33, "class", "list-group");
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "list-group-item text-center");
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "p");
            __builder.AddContent(39, 
#nullable restore
#line 19 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_5.razor"
                    numero

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(40, " => ");
            __builder.AddContent(41, 
#nullable restore
#line 19 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_5.razor"
                               value_string

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_5.razor"
       
    public double numero {get; set;}
    public string value_string {get; set;}

    public void Convert() { value_string = Numero_Letra(numero); }

    public string NumeroALetras(double numberAsString)
    {         
        var entero = Math.Truncate(numberAsString);
        var res = Numero_Letra(entero);
        return res;
    }

    public string Numero_Letra(double value)
    {
        string num2Text; 
        value = Math.Truncate(value);

        if (value == 0) num2Text = "cero";
        else if (value == 1) num2Text = "uno";
        else if (value == 2) num2Text = "dos";
        else if (value == 3) num2Text = "tres";
        else if (value == 4) num2Text = "cuatro";
        else if (value == 5) num2Text = "cinco";
        else if (value == 6) num2Text = "seis";
        else if (value == 7) num2Text = "siete";
        else if (value == 8) num2Text = "ocho";
        else if (value == 9) num2Text = "nueve";
        else if (value == 10) num2Text = "diez";
        else if (value == 11) num2Text = "once";
        else if (value == 12) num2Text = "doce";
        else if (value == 13) num2Text = "trece";
        else if (value == 14) num2Text = "catorce";
        else if (value == 15) num2Text = "quince";
        else if (value < 20) num2Text = "dieci" + NumeroALetras(value - 10);
        else if (value == 20) num2Text = "veinte";
        else if (value < 30) num2Text = "veinti" + NumeroALetras(value - 20);
        else if (value == 30) num2Text = "treinta";
        else if (value == 40) num2Text = "cuarenta";
        else if (value == 50) num2Text = "cicuenta";
        else if (value == 60) num2Text = "sesenta";
        else if (value == 70) num2Text = "setenta";
        else if (value == 80) num2Text = "ochenta";
        else if (value == 90) num2Text = "noventa";
        else if (value < 100) num2Text = NumeroALetras(Math.Truncate(value / 10) * 10) + " y " + NumeroALetras(value % 10);
        else if (value == 100) num2Text = "cien";
        else if (value < 200) num2Text = "ciento " + NumeroALetras(value - 100);
        else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) num2Text = NumeroALetras(Math.Truncate(value / 100)) + "cientos";
        else if (value == 500) num2Text = "quinientos";
        else if (value == 700) num2Text = "setecientos";
        else if (value == 900) num2Text = "novecientos";
        else if (value < 1000) num2Text = NumeroALetras(Math.Truncate(value / 100) * 100) + " " + NumeroALetras(value % 100);
        else if (value == 1000) num2Text = "mil";
        else if (value < 2000) num2Text = "mil " + NumeroALetras(value % 1000);
        else if (value < 1000000)
        {
            num2Text = NumeroALetras(Math.Truncate(value / 1000)) + " mil";
            if ((value % 1000) > 0)
            {
                num2Text = num2Text + " " + NumeroALetras(value % 1000);
            }
        }
        else if (value == 1000000)
        {
            num2Text = "un millon";
        }
        else if (value < 2000000)
        {
            num2Text = "un millon " + NumeroALetras(value % 1000000);
        }
        else if (value < 1000000000000)
        {
            num2Text = NumeroALetras(Math.Truncate(value / 1000000)) + " millones ";
            if ((value - Math.Truncate(value / 1000000) * 1000000) > 0)
            {
                num2Text = num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000) * 1000000);
            }
        }
        else if (value == 1000000000000) num2Text = "un billon";
        else if (value < 2000000000000) num2Text = "un billon " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
        else
        {
            num2Text = NumeroALetras(Math.Truncate(value / 1000000000000)) + " billones";
            if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0)
            {
                num2Text = num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
        }
        
        return num2Text;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
