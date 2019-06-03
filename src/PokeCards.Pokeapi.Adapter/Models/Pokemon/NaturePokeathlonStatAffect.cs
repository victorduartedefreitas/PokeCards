using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class NaturePokeathlonStatAffect
    {
        [JsonProperty("max_change")]
        public int MaxChange { get; set; }
        public NamedApiResource Nature { get; set; }
    }
}
