using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class MoveStatAffectSets
    {
        public IList<MoveStatAffect> Increase { get; set; }
        public IList<MoveStatAffect> Decrease { get; set; }
    }
}
