using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Evolutions
{
    public class EvolutionTrigger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Name> Names { get; set; }
        [JsonProperty("pokemon_species")]
        public IList<NamedApiResource> PokemonSpecies { get; set; }
    }
}
