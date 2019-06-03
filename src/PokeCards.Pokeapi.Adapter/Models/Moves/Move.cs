using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using PokeCards.Pokeapi.Adapter.Models.Pokemon;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Moves
{
    public class Move
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Accuracy { get; set; }
        [JsonProperty("effect_chance")]
        public int EffectChance { get; set; }
        public int Pp { get; set; }
        public int Priority { get; set; }
        [JsonProperty("contest_combos")]
        public ContestComboSets ContestCombos { get; set; }
        [JsonProperty("contest_type")]
        public NamedApiResource ContestType { get; set; }
        [JsonProperty("contest_effect")]
        public ApiResource ContestEffect { get; set; }
        [JsonProperty("damage_class")]
        public NamedApiResource DamageClass { get; set; }
        [JsonProperty("effect_entries")]
        public IList<VerboseEffect> Effects { get; set; }
        [JsonProperty("EffectChanges")]
        public IList<AbilityEffectChange> EffectChanges { get; set; }
        [JsonProperty("flavor_text_entries")]
        public IList<MoveFlavorText> FlavorTexts { get; set; }
        public NamedApiResource Generation { get; set; }
        public IList<MachineVersionDetail> Machines { get; set; }
        public MoveMetaData Meta { get; set; }
        public IList<Name> Names { get; set; }
        [JsonProperty("past_values")]
        public IList<PastMoveStatValues> PastValues { get; set; }
        [JsonProperty("stat_changes")]
        public IList<MoveStatChange> StatChanges { get; set; }
        [JsonProperty("super_contest_effect")]
        public ApiResource SuperContestEffect { get; set; }
        public NamedApiResource Target { get; set; }
        public NamedApiResource Type { get; set; }
    }
}
