using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Games
{
    public class PokemonEntry
    {
        public int EntryNumber { get; set; }
        [JsonProperty("pokemon_species")]
        public IList<NamedApiResource> PokemonSpecies { get; set; }
    }
}
