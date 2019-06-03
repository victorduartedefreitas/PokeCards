using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Moves
{
    public class MoveLearnMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Description> Descriptions { get; set; }
        public IList<Name> Names { get; set; }
        [JsonProperty("version_groups")]
        public IList<NamedApiResource> VersionGroups { get; set; }
    }
}
