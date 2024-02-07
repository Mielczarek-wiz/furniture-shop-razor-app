using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MielczarekFurniture.UI.Services;
using MielczarekFurniture.UI.Services.Contracts;

namespace MielczarekFurniture.UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7188/") });
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IProducerService, ProducerService>();
            await builder.Build().RunAsync();
        }
    }
}