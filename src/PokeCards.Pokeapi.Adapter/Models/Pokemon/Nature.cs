using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class Nature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("decreased_stat")]
        public NamedApiResource DecreasedStat { get; set; }
        [JsonProperty("increased_stat")]
        public NamedApiResource IncreasedStat { get; set; }
        [JsonProperty("hates_flavor")]
        public NamedApiResource HatesFlavor { get; set; }
        [JsonProperty("likes_flavor")]
        public NamedApiResource LikesFlavor { get; set; }
        [JsonProperty("pokeathlon_stat_changes")]
        public IList<NatureStatChange> PokeathlonStatChanges { get; set; }
        [JsonProperty("move_battle_style_preferences")]
        public IList<MoveBattleStylePreference> MoveBattleStylePreferences { get; set; }
        public IList<Name> Names { get; set; }
    }
}
