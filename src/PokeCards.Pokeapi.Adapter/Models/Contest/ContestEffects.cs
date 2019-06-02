using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Contest
{
    public class ContestEffects
    {
        public int Id { get; set; }
        public int Appeal { get; set; }
        public int Jam { get; set; }
        [JsonProperty("effect_entries")]
        public IList<Effect> Effects { get; set; }
        [JsonProperty("flavor_text_entries")]
        public IList<FlavorText> FlavorTexts { get; set; }
    }
}
