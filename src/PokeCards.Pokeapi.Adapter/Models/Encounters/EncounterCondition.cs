using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Encounters
{
    public class EncounterCondition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<NamedApiResource> Values { get; set; }
        public IList<Name> Names { get; set; }
    }
}
