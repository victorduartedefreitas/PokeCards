using Newtonsoft.Json;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Common
{
    public class Encounter
    {
        [JsonProperty("min_level")]
        public int MinLevel { get; set; }
        [JsonProperty("max_level")]
        public int MaxLevel { get; set; }
        [JsonProperty("condition_values")]
        public IList<NamedApiResource> ConditionValues { get; set; }
        public int Chance { get; set; }
        public NamedApiResource Method { get; set; }
    }
}
