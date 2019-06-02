using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models
{
    public class Resource
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public IList<NamedApiResource> Results { get; set; }
    }
}
