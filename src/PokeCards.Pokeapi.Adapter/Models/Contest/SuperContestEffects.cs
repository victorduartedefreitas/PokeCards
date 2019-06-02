using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Contest
{
    public class SuperContestEffects
    {
        public int Id { get; set; }
        public int Appeal { get; set; }
        [JsonProperty("flavor_text_entries")]
        public IList<FlavorText> FlavorTexts { get; set; }
        public IList<NamedApiResource> Moves { get; set; }
    }
}
