using DotaCounterPicker.Blazor;
using DotaCounterPicker.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new DotaClient("https://localhost:7123/", new HttpClient()));


await builder.Build().RunAsync();
