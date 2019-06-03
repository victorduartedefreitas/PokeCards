using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Items
{
    public class ItemAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<NamedApiResource> Items { get; set; }
        public IList<Name> Names { get; set; }
        public IList<Description> Descriptions { get; set; }
    }
}
