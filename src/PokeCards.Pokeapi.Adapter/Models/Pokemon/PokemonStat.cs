using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class PokemonStat
    {
        public NamedApiResource Stat { get; set; }
        public int Effort { get; set; }
        [JsonProperty("base_stat")]
        public int BaseStat { get; set; }
    }
}
