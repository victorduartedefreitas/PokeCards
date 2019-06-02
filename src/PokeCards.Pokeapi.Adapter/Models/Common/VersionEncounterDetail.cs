using Newtonsoft.Json;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Common
{
    public class VersionEncounterDetail
    {
        public NamedApiResource Version { get; set; }
        [JsonProperty("max_chance")]
        public int MaxChance { get; set; }
        [JsonProperty("encounter_details")]
        public IList<Encounter> EncounterDetails { get; set; }
    }
}
