using Newtonsoft.Json;

namespace PokeCards.Pokeapi.Adapter.Models.Common
{
    public class Effect
    {
        [JsonProperty("effect")]
        public string Text { get; set; }
        public NamedApiResource Language { get; set; }
    }
}
