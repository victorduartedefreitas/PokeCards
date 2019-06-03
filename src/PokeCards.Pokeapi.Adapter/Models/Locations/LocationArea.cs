using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Locations
{
    public class LocationArea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }
        [JsonProperty("encounter_method_rates")]
        public IList<EncounterMethodRate> EncounterMethodRates { get; set; }
        public NamedApiResource Location { get; set; }
        public IList<Name> Names { get; set; }
        [JsonProperty("pokemon_encounters")]
        public IList<PokemonEncounter> PokemonEncounters { get; set; }
    }
}
