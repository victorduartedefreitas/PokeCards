using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Berries
{
    public class BerryMap
    {
        public int Potency { get; set; }
        public NamedApiResource Berry { get; set; }
    }
}
