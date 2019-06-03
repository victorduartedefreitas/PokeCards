using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class Stat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }
        [JsonProperty("is_battle_only")]
        public bool IsBattleOnly { get; set; }
        [JsonProperty("affecting_moves")]
        public IList<MoveStatAffectSets> AffectingMoves { get; set; }
        [JsonProperty("affecting_natures")]
        public IList<NatureStatAffectSets> AffectingNatures { get; set; }
        public ApiResource Characteristics { get; set; }
        [JsonProperty("move_damage_class")]
        public NamedApiResource MoveDamageClass { get; set; }
        public IList<Name> Names { get; set; }
    }
}
