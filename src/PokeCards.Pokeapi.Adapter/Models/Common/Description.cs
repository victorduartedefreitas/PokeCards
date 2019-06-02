using Newtonsoft.Json;

namespace PokeCards.Pokeapi.Adapter.Models.Common
{
    public class Description
    {
        [JsonProperty("description")]
        public string Text { get; set; }
        public NamedApiResource Language { get; set; }
    }
}
