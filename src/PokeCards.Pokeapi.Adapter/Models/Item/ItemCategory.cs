using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Item
{
    public class ItemCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<NamedApiResource> Items { get; set; }
        public IList<Name> Names { get; set; }
        public NamedApiResource Pocket { get; set; }
    }
}
