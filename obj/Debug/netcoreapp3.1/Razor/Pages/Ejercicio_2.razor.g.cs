#pragma checksum "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48afd76099a5c2bfa67654e849dbe9407f056749"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio-2")]
    public partial class Ejercicio_2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center\">Ejercicio #2</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n   ");
            __builder.AddMarkupContent(4, "<div class=\"row\">\r\n      <p>Programa que muestre todos los datos de un usuario de random users: https://randomuser.me/api/?results=1.</p>\r\n   </div>\r\n   ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col justify-content-center");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "list-group");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "li");
            __builder.AddAttribute(12, "class", "list-group-item text-center");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "p");
            __builder.AddContent(15, 
#nullable restore
#line 11 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_2.razor"
                    users

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n   ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "<br>\r\n   ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col justify-content-center");
            __builder.AddMarkupContent(22, "\r\n      ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-dark");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_2.razor"
                                             Reload

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Recargar");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n   ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\crist\Desktop\Programacion III\Tarea_2\Pages\Ejercicio_2.razor"
       
   string reqUrl => $"https://randomuser.me/api/?results=1";
   public string users {get; set;}

   protected override async Task OnInitializedAsync()
   {
      await Reload();
   }

   public async Task Reload()
   {
      HttpClient http = new HttpClient();
      var response = await http.GetAsync(reqUrl);

      if (response.IsSuccessStatusCode)
      {
         users = await response.Content.ReadAsStringAsync();
      }
   }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
