using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class TypePokemon
    {
        public int Slot { get; set; }
        public NamedApiResource Pokemon { get; set; }
    }
}
