using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Locations
{
    public class EncounterMethodRate
    {
        [JsonProperty("encounter_method")]
        public NamedApiResource EncounterMethod { get; set; }
        [JsonProperty("version_details")]
        public IList<EncounterVersionDetails> VersionDetails { get; set; }
    }
}
