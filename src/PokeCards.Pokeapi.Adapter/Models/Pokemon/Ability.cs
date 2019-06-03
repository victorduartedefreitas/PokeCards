using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("is_main_series")]
        public bool IsMainSeries { get; set; }
        public NamedApiResource Generation { get; set; }
        public IList<Name> Names { get; set; }
        [JsonProperty("effect_entries")]
        public IList<VerboseEffect> Effects { get; set; }
        [JsonProperty("effect_changes")]
        public IList<AbilityEffectChange> EffectChanges { get; set; }
        [JsonProperty("flavor_text_entries")]
        public IList<AbilityFlavorText> FlavorTexts { get; set; }
        public IList<AbilityPokemon> Pokemon { get; set; }
    }
}
