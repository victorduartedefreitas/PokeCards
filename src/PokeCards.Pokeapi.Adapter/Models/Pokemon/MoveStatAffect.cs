using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class MoveStatAffect
    {
        public int Change { get; set; }
        public NamedApiResource Move { get; set; }
    }
}
