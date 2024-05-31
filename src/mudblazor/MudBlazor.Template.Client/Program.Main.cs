using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace MudBlazor.Template.Client;

class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        #if (IndividualLocalAuth)
        builder.Services.AddAuthorizationCore();
        builder.Services.AddCascadingAuthenticationState();
        builder.Services.AddAuthenticationStateDeserialization();

        #endif
        await builder.Build().RunAsync();
    }
}
