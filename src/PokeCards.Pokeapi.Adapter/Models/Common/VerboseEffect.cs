using Newtonsoft.Json;

namespace PokeCards.Pokeapi.Adapter.Models.Common
{
    public class VerboseEffect
    {
        public string Effect { get; set; }
        [JsonProperty("short_effect")]
        public string ShortEffect { get; set; }
        public NamedApiResource Language { get; set; }
    }
}
