using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Evolutions
{
    public class EvolutionDetail
    {
        public NamedApiResource Item { get; set; }
        public NamedApiResource Trigger { get; set; }
        public int Gender { get; set; }
        [JsonProperty("held_item")]
        public NamedApiResource HeldItem { get; set; }
        [JsonProperty("known_move")]
        public NamedApiResource KnownMove { get; set; }
        [JsonProperty("known_move_type")]
        public NamedApiResource KnownMoveType { get; set; }
        public NamedApiResource Location { get; set; }
        [JsonProperty("min_level")]
        public int MinLevel { get; set; }
        [JsonProperty("min_happiness")]
        public int MinHappiness { get; set; }
        [JsonProperty("min_beauty")]
        public int MinBeauty { get; set; }
        [JsonProperty("min_affection")]
        public int MinAffection { get; set; }
        [JsonProperty("need_overworld_rain")]
        public bool NeedsOverworldRain { get; set; }
        [JsonProperty("party_species")]
        public NamedApiResource PartySpecies { get; set; }
        [JsonProperty("party_type")]
        public NamedApiResource PartyType { get; set; }
        [JsonProperty("relative_physical_stats")]
        public int RelativePhysicalStats { get; set; }
        [JsonProperty("time_of_day")]
        public string TimeOfDay { get; set; }
        [JsonProperty("trade_species")]
        public NamedApiResource TradeSpecies { get; set; }
        [JsonProperty("turn_upside_down")]
        public bool TurnUpsideDown { get; set; }
    }
}
