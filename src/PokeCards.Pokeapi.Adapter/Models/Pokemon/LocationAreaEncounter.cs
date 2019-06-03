using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class LocationAreaEncounter
    {
        [JsonProperty("location_area")]
        public NamedApiResource LocationArea { get; set; }
        [JsonProperty("version_details")]
        public IList<VersionEncounterDetail> VersionDetails { get; set; }
    }
}
