using PokeCards.Domain.Adapters;
using PokeCards.Pokeapi.Adapter;
using Refit;
using System;
using System.Net.Http;

namespace Prism.Ioc
{
    public static class PokeApiAdapterContainerRegistryExtensions
    {
        public static IContainerRegistry AddPokeApiAdapters(this IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IPokeApiAdapter, PokeApiAdapter>();
            containerRegistry.RegisterInstance(CreatePokeApiInstance());

            return containerRegistry;
        }

        private static IPokeApi CreatePokeApiInstance()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://pokeapi.co/api/v2");

            return RestService.For<IPokeApi>(httpClient);
        }
    }
}
