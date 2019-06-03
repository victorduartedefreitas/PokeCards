using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class PokeathlonStat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Name> Names { get; set; }
        [JsonProperty("affecting_natures")]
        public IList<NaturePokeathlonStatAffectSets> AffectingNatures { get; set; }
    }
}
