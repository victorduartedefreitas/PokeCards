using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class MoveBattleStylePreference
    {
        [JsonProperty("low_hp_preference")]
        public int LowHpPreference { get; set; }
        [JsonProperty("high_hp_preference")]
        public int HighHpPreference { get; set; }
        [JsonProperty("move_battle_style")]
        public NamedApiResource MoveBattleStyle { get; set; }
    }
}
