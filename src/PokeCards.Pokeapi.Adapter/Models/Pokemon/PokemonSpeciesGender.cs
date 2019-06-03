using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class PokemonSpeciesGender
    {
        public int Rate { get; set; }
        [JsonProperty("pokemon_species")]
        public NamedApiResource PokemonSpecies { get; set; }
    }
}
