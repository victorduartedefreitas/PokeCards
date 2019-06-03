using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Locations
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public NamedApiResource Region { get; set; }
        public IList<Name> Names { get; set; }
        [JsonProperty("game_indices")]
        public IList<GenerationGameIndex> GameIndices { get; set; }
        public IList<NamedApiResource> Areas { get; set; }
    }
}
