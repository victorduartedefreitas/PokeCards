using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("base_experience")]
        public int BaseExperience { get; set; }
        public int Height { get; set; }
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }
        public int Order { get; set; }
        public int Weight { get; set; }
        public IList<PokemonAbility> Abilities { get; set; }
        public IList<NamedApiResource> Forms { get; set; }
        [JsonProperty("game_indices")]
        public IList<VersionGameIndex> GameIndices { get; set; }
        [JsonProperty("held_items")]
        public IList<PokemonHeldItem> HeldItems { get; set; }
        [JsonProperty("location_area_encounters")]
        public string LocationAreaEncounters { get; set; }
        public IList<PokemonMove> Moves { get; set; }
        public PokemonSprites Sprites { get; set; }
        public NamedApiResource Species { get; set; }
        public IList<PokemonStat> Stats { get; set; }
        public IList<PokemonType> Types { get; set; }
    }
}
