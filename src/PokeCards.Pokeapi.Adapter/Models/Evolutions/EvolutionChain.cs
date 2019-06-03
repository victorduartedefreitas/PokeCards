using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Evolutions
{
    public class EvolutionChain
    {
        public int Id { get; set; }
        [JsonProperty("baby_trigger_item")]
        public NamedApiResource BabyTriggerItem { get; set; }
        public ChainLink Chain { get; set; }
    }
}
