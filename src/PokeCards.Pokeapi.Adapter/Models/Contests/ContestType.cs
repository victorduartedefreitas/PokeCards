using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Contests
{
    public class ContestType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("berry_flavor")]
        public NamedApiResource BerryFlavor { get; set; }
        public IList<ContestName> Names { get; set; }
    }
}
