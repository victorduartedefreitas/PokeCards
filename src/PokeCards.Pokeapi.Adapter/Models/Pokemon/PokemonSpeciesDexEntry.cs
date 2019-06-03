using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class PokemonSpeciesDexEntry
    {
        [JsonProperty("entry_number")]
        public int EntryNumber { get; set; }
        public NamedApiResource Pokedex { get; set; }
    }
}
