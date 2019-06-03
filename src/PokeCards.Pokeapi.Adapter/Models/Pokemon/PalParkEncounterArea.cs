using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class PalParkEncounterArea
    {
        [JsonProperty("base_score")]
        public int BaseScore { get; set; }
        public int Rate { get; set; }
        public NamedApiResource Area { get; set; }
    }
}
