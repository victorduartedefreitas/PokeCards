using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class PokemonHeldItem
    {
        public NamedApiResource Item { get; set; }
        [JsonProperty("version_details")]
        public IList<PokemonHeldItemVersion> VersionDetails { get; set; }
    }
}
