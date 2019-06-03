using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class PokemonSpeciesVariety
    {
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }
        public NamedApiResource Pokemon { get; set; }
    }
}
