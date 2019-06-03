using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Moves
{
    public class MoveMetaData
    {
        public NamedApiResource Aliment { get; set; }
        public NamedApiResource Category { get; set; }
        [JsonProperty("min_hits")]
        public int MinHits { get; set; }
        [JsonProperty("max_hits")]
        public int MaxHits { get; set; }
        [JsonProperty("min_turns")]
        public int MinTurns { get; set; }
        [JsonProperty("maxTurns")]
        public int MaxTurns { get; set; }
        public int Drain { get; set; }
        public int Healing { get; set; }
        [JsonProperty("crit_rate")]
        public int CriticalRate { get; set; }
        [JsonProperty("aliment_chance")]
        public int AlimentChance { get; set; }
        [JsonProperty("flinch_chance")]
        public int FlinchChance { get; set; }
        [JsonProperty("stat_chance")]
        public int StatChance { get; set; }
    }
}
