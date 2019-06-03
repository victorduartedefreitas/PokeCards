using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class Genus
    {
        [JsonProperty("genus")]
        public string Text { get; set; }
        public NamedApiResource Language { get; set; }
    }
}
