using GandiClient.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GandiClient
{
    public static class ServiceBuilderExtension
    {
        public static IServiceCollection AddGandiClient(this IServiceCollection serviceDescriptors, string apiKey)
        {
            serviceDescriptors
                   .AddTransient<IDomain, Domain>();

            serviceDescriptors
                   .AddHttpClient("gandiClient", x =>
                   {
                       x.BaseAddress = new Uri("https://api.gandi.net/v5");
                       x.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Apikey", apiKey);
                   })
                   .AddTypedClient<IDomain>()
                   .AddTypedClient<ILiveDNS>()
                   .AddTypedClient<IEmail>()
                   .AddTypedClient<IBilling>()
                   .AddTypedClient<IOrganisation>();

            return serviceDescriptors;
        }
    }
}
