using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class AwesomeName
    {
        [JsonProperty("awesome_name")]
        public string Name { get; set; }
        public NamedApiResource Language { get; set; }
    }
}
