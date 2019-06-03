using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Moves
{
    public class MoveCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<NamedApiResource> Moves { get; set; }
        public IList<Description> Descriptions { get; set; }
    }
}
