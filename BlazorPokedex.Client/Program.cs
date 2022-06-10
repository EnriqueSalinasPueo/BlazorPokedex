using BlazorPokedex.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorPokedex.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            // Modificamos en los servicios la direccion sobre Uri del httpClient para poder inyectar en nuesta capa services
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://pokeapi.co/api/v2/") });

            builder.Services.AddScoped<IPokeApiClient, PokeApiClient>();


            await builder.Build().RunAsync();
        }
    }
}
