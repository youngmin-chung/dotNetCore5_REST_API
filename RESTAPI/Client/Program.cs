using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RESTAPI.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDQyMTI4QDMxMzkyZTMxMmUzMGRuZm5HZW5nNkJqbUJINXFTU3RnNjByV3FNdXpLTmduNVd5VEZsTGhYdk09;NDQyMTI5QDMxMzkyZTMxMmUzMGZ3SWxkTWN5WVJuYTJIMkQrdk1Ud3phV29LcXZyMlNrcEpqNEhBd09xMWM9;NDQyMTMwQDMxMzkyZTMxMmUzMGlnKzBMSWpUbkp5bU5DUnBlVzZsOFhKR3FPOVBnd3pNcU90NUhwWDA1T2s9;NDQyMTMxQDMxMzkyZTMxMmUzMEpxWHpTODZjUEtGdDhCcnE1TCtBcDJaUmI5MUxiMFZsSEJxb1Z6cFpxaTA9;NDQyMTMyQDMxMzkyZTMxMmUzMEJSMGdoMlFpakQ5WjhGYnRGQ2Q5bUMvNWJzWHFuNisweHFseWhLTHQ3aU09;NDQyMTMzQDMxMzkyZTMxMmUzMEFrSyszaVlvQnlza0dSZjZRTythQ0NPUk9SdC9sTkg5RjBoUEg4Qlc5TWM9;NDQyMTM0QDMxMzkyZTMxMmUzMFRKMW8vUXpTU2JabHFNSE9YeGJNQ2JTM3dhdm45eTJUeGx5aGJUM0xydTA9;NDQyMTM1QDMxMzkyZTMxMmUzMGR5T3N3d1dMbDhCT3ljMXNGVHU1Tnlxbnc5Q21wRVdrbUFnNmNWd2dUVjA9;NDQyMTM2QDMxMzkyZTMxMmUzMEx0b1BFQUp6VTc0UDkxVkJ2M0RQSXpxYTFLS28vN3N3ZnRVK2RtVm84UlE9;NDQyMTM3QDMxMzkyZTMxMmUzMGE5T2ovOE84SFJaektDbmYrVmxLN3M5S2FWU1lrRlNFbjh6ZHo3TkNEV2c9");


            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            // register the Syncfusion Blazor Service
            builder.Services.AddSyncfusionBlazor();

            await builder.Build().RunAsync();
        }
    }
}
