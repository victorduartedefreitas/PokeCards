using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class AbilityEffectChange
    {
        [JsonProperty("effect_entries")]
        public IList<Effect> Effects { get; set; }
        [JsonProperty("version_group")]
        public NamedApiResource VersionGroup { get; set; }
    }
}
