using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Moves
{
    public class PastMoveStatValues
    {
        public int Accuracy { get; set; }
        [JsonProperty("effect_chance")]
        public int EffectChance { get; set; }
        public int Power { get; set; }
        public int Pp { get; set; }
        [JsonProperty("effect_entries")]
        public IList<VerboseEffect> Effects { get; set; }
        public NamedApiResource Type { get; set; }
        [JsonProperty("version_group")]
        public NamedApiResource VersionGroup { get; set; }
    }
}
