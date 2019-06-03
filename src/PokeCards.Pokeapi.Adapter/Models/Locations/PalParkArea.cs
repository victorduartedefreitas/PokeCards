using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Locations
{
    public class PalParkArea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Name> Names { get; set; }
        [JsonProperty("pokemon_encounters")]
        public IList<PalParkEncounterSpecies> PokemonEncounters { get; set; }
    }
}
