using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Moves
{
    public class MoveStatChange
    {
        public int Change { get; set; }
        public NamedApiResource Stat { get; set; }
    }
}
