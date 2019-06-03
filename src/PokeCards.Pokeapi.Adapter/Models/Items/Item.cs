using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Items
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        [JsonProperty("fling_power")]
        public int FlingPower { get; set; }
        [JsonProperty("fling_effect")]
        public NamedApiResource FlingEffect { get; set; }
        public IList<NamedApiResource> Attributes { get; set; }
        public ItemCategory Category { get; set; }
        [JsonProperty("effect_entries")]
        public IList<VerboseEffect> Effects { get; set; }
        [JsonProperty("flavor_text_entries")]
        public IList<VersionGroupFlavorText> FlavorTexts { get; set; }
        public IList<GenerationGameIndex> GameIndices { get; set; }
        public IList<Name> Names { get; set; }
        public ItemSprites Sprites { get; set; }
        [JsonProperty("held_by_pokemon")]
        public IList<ItemHolderPokemon> HeldByPokemon { get; set; }
        [JsonProperty("baby_trigger_for")]
        public ApiResource BabyTriggerFor { get; set; }
        public IList<MachineVersionDetail> Machines { get; set; }
    }
}
