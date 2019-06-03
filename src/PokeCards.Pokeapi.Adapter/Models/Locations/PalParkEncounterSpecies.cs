using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Locations
{
    public class PalParkEncounterSpecies
    {
        [JsonProperty("base_score")]
        public int BaseScore { get; set; }
        public int Rate { get; set; }
        [JsonProperty("pokemon_species")]
        public NamedApiResource PokemonSpecies { get; set; }
    }
}
