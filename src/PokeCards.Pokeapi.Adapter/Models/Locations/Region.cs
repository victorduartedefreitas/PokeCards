using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Locations
{
    public class Region
    {
        public int Id { get; set; }
        public IList<NamedApiResource> Locations { get; set; }
        public string Name { get; set; }
        public IList<Name> Names { get; set; }
        [JsonProperty("main_generation")]
        public NamedApiResource MainGeneration { get; set; }
        public IList<NamedApiResource> Pokedexes { get; set; }
        [JsonProperty("version_groups")]
        public IList<NamedApiResource> VersionGroups { get; set; }
    }
}
