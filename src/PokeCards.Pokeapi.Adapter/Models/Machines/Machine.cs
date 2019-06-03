using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Machines
{
    public class Machine
    {
        public int Id { get; set; }
        public NamedApiResource Item { get; set; }
        public NamedApiResource Move { get; set; }
        [JsonProperty("version_group")]
        public NamedApiResource VersionGroup { get; set; }
    }
}