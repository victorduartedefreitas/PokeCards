using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class Characteristic
    {
        public int Id { get; set; }

        [JsonProperty("gene_modulo")]
        public int GeneModulo { get; set; }
        [JsonProperty("possible_values")]
        public IList<int> PossibleValues { get; set; }
        [JsonProperty("highest_stat")]
        public NamedApiResource HighestStat { get; set; }
        public IList<Description> Descriptions { get; set; }
    }
}
