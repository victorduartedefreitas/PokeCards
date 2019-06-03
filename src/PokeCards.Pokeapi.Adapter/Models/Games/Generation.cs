using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Games
{
    public class Generation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<NamedApiResource> Abilities { get; set; }
        public IList<Name> Names { get; set; }
        [JsonProperty("main_region")]
        public NamedApiResource MainRegion { get; set; }
        public IList<NamedApiResource> Moves { get; set; }
        [JsonProperty("pokemon_species")]
        public IList<NamedApiResource> PokemonSpecies { get; set; }
        public IList<NamedApiResource> Types { get; set; }
        [JsonProperty("version_groups")]
        public IList<NamedApiResource> VersionGroups { get; set; }
    }
}
