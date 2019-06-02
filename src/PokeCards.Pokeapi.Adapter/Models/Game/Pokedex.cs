using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Game
{
    public class Pokedex
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("is_main_series")]
        public bool IsMainSeries { get; set; }
        public IList<Description> Descriptions { get; set; }
        public IList<Name> Names { get; set; }
        public IList<PokemonEntry> PokemonEntries { get; set; }
        public NamedApiResource Region { get; set; }
        [JsonProperty("version_groups")]
        public IList<NamedApiResource> VersionGroups { get; set; }
    }
}
