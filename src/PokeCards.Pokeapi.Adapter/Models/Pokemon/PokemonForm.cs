using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class PokemonForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        [JsonProperty("form_order")]
        public int FormOrder { get; set; }
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }
        [JsonProperty("is_battle_only")]
        public bool IsBattleOnly { get; set; }
        [JsonProperty("is_mega")]
        public bool IsMega { get; set; }
        [JsonProperty("form_name")]
        public string FormName { get; set; }
        public PokemonFormSprites Sprites { get; set; }
        [JsonProperty("version_group")]
        public NamedApiResource VersionGroup { get; set; }
        public IList<Name> Names { get; set; }
        [JsonProperty("form_names")]
        public IList<Name> FormNames { get; set; }
    }
}
