using Newtonsoft.Json;

namespace PokeCards.Pokeapi.Adapter.Models.Common
{
    public class Name
    {
        [JsonProperty("name")]
        public string Text { get; set; }
        public NamedApiResource Language { get; set; }
    }
}
