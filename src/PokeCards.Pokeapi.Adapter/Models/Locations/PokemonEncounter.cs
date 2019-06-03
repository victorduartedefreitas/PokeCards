using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Locations
{
    public class PokemonEncounter
    {
        public NamedApiResource Pokemon { get; set; }
        [JsonProperty("version_details")]
        public IList<VersionEncounterDetail> VersionDetails { get; set; }
    }
}
