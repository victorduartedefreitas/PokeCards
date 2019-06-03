using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("pokemon_species_details")]
        public IList<PokemonSpeciesGender> PokemonSpeciesDetails { get; set; }
        [JsonProperty("required_for_evolution")]
        public IList<NamedApiResource> RequiredForEvolution { get; set; }
    }
}
