using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Game
{
    public class VersionGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public NamedApiResource Generation { get; set; }
        [JsonProperty("move_learn_methods")]
        public IList<NamedApiResource> MoveLearnMethods { get; set; }
        public IList<NamedApiResource> Pokedexes { get; set; }
        public IList<NamedApiResource> Regions { get; set; }
        public IList<NamedApiResource> Versions { get; set; }
    }
}
