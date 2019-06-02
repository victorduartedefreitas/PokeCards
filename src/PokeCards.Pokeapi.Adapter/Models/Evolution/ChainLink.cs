using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Evolution
{
    public class ChainLink
    {
        [JsonProperty("is_baby")]
        public bool IsBaby { get; set; }
        public NamedApiResource Species { get; set; }
        [JsonProperty("evolution_details")]
        public IList<EvolutionDetail> EvolutionDetails { get; set; }
        [JsonProperty("evolves_to")]
        public IList<ChainLink> EvolvesTo { get; set; }
    }
}
