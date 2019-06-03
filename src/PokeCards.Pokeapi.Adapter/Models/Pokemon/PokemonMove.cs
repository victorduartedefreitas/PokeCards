using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class PokemonMove
    {
        public NamedApiResource Move { get; set; }
        [JsonProperty("version_group_details")]
        public IList<PokemonMoveVersion> VersionGroupDetails { get; set; }
    }
}
