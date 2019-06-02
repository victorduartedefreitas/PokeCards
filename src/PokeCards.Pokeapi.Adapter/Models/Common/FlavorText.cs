using Newtonsoft.Json;

namespace PokeCards.Pokeapi.Adapter.Models.Common
{
    public class FlavorText
    {
        [JsonProperty("flavor_text")]
        public string Text { get; set; }
        public NamedApiResource Language { get; set; }
    }
}
