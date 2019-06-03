using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class PokemonType
    {
        public int Slot { get; set; }
        public NamedApiResource Type { get; set; }
    }
}
