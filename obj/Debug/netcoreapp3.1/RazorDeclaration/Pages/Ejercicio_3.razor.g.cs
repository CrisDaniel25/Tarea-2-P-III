#pragma checksum "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_3.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0f36b708e7183f7c0bb089bdb6ffefd8fcc6e72"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea_2.Pages
{
    #line hidden
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
#nullable restore
#line 3 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_3.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_3.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio-3")]
    public partial class Ejercicio_3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_3.razor"
        
    public string cedula {get; set;}
    public long ced {get; set;}
    public string result {get; set;}

    public void Verified() 
    {
        result = Validation(cedula);
    }

    public string Validation(string cedula)
    {
        var res = "";

        try
        {            
            ced = Convert.ToInt64(cedula);
            if(cedula.Length == 11)
            {
                
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
    //res = "No es una cédula dominicada valida";
    //res = "Es una cédula dominicana valida";  

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
