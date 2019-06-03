using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Moves
{
    public class MoveFlavorText
    {
        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }
        public NamedApiResource Language { get; set; }
        [JsonProperty("version_group")]
        public NamedApiResource VersionGroup { get; set; }
    }
}
