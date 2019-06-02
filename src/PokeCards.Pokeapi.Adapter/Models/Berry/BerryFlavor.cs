using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Berry
{
    public class BerryFlavor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<BerryMap> Berries { get; set; }
        [JsonProperty("contest_type")]
        public NamedApiResource ContestType { get; set; }
        public IList<Name> Names { get; set; }
    }
}
