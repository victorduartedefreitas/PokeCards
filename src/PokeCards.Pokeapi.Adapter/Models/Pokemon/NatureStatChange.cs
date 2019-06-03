using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class NatureStatChange
    {
        [JsonProperty("max_change")]
        public int MaxChange { get; set; }
        [JsonProperty("pokeathlon_stat")]
        public NamedApiResource PokeathlonStat { get; set; }
    }
}
