#pragma checksum "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\Contributions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68ef7928bdadae4969b54b6e110d40e89e4c78e5"
// <auto-generated/>
#pragma warning disable 1591
namespace AlMadrasa.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using AlMadrasa.Client;
    using AlMadrasa.Client.Shared;
    using AlMadrasa.Client.Pages;
    using AlMadrasa.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/contributiondata")]
    public class Contributions : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Contributions</h1>\n\n");
            builder.AddMarkupContent(1, "<p>This component contains the monthly Contributions of all student.</p>\n\n");
#line 9 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\Contributions.cshtml"
 if (forecasts == null)
{

#line default
#line hidden
            builder.AddContent(2, "    ");
            builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\n");
#line 12 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\Contributions.cshtml"
}
else
{

#line default
#line hidden
            builder.AddContent(4, "    ");
            builder.OpenElement(5, "table");
            builder.AddAttribute(6, "class", "table");
            builder.AddContent(7, "\n        ");
            builder.AddMarkupContent(8, "<thead>\n            <tr>\n                <th>Date</th>\n                <th>Temp. (C)</th>\n                <th>Temp. (F)</th>\n                <th>Summary</th>\n            </tr>\n        </thead>\n        ");
            builder.OpenElement(9, "tbody");
            builder.AddContent(10, "\n");
#line 25 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\Contributions.cshtml"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
            builder.AddContent(11, "                ");
            builder.OpenElement(12, "tr");
            builder.AddContent(13, "\n                    ");
            builder.OpenElement(14, "td");
            builder.AddContent(15, forecast.Date.ToShortDateString());
            builder.CloseElement();
            builder.AddContent(16, "\n                    ");
            builder.OpenElement(17, "td");
            builder.AddContent(18, forecast.TemperatureC);
            builder.CloseElement();
            builder.AddContent(19, "\n                    ");
            builder.OpenElement(20, "td");
            builder.AddContent(21, forecast.TemperatureF);
            builder.CloseElement();
            builder.AddContent(22, "\n                    ");
            builder.OpenElement(23, "td");
            builder.AddContent(24, forecast.Summary);
            builder.CloseElement();
            builder.AddContent(25, "\n                ");
            builder.CloseElement();
            builder.AddContent(26, "\n");
#line 33 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\Contributions.cshtml"
            }

#line default
#line hidden
            builder.AddContent(27, "        ");
            builder.CloseElement();
            builder.AddContent(28, "\n    ");
            builder.CloseElement();
            builder.AddContent(29, "\n");
#line 36 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\Contributions.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 38 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\Contributions.cshtml"
            
    WeatherForecast[] forecasts;

    protected override async Task OnInitAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("api/SampleData/WeatherForecasts");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591