using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class PokemonShape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("awesome_names")]
        public IList<AwesomeName> AwesomeNames { get; set; }
        public IList<Name> Names { get; set; }
        [JsonProperty("pokemon_species")]
        public IList<PokemonSpecies> PokemonSpecies { get; set; }
    }
}
