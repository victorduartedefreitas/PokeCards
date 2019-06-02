using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Encounter
{
    public class EncounterConditionValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public NamedApiResource Condition { get; set; }
        public IList<Name> Names { get; set; }
    }
}
