using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class NaturePokeathlonStatAffectSets
    {
        public IList<NaturePokeathlonStatAffect> Increase { get; set; }
        public IList<NaturePokeathlonStatAffect> Decrease { get; set; }
    }
}
