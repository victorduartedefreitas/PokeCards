using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class NatureStatAffectSets
    {
        public IList<NamedApiResource> Increase { get; set; }
        public IList<NamedApiResource> Decrease { get; set; }
    }
}
