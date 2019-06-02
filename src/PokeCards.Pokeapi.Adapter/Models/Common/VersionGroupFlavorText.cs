using Newtonsoft.Json;

namespace PokeCards.Pokeapi.Adapter.Models.Common
{
    public class VersionGroupFlavorText
    {
        public string Text { get; set; }
        public NamedApiResource Language { get; set; }
        [JsonProperty("version_group")]
        public NamedApiResource VersionGroup { get; set; }
    }
}
