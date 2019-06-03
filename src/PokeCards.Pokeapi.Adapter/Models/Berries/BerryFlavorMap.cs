using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Berries
{
    public class BerryFlavorMap
    {
        public int Potency { get; set; }
        public NamedApiResource Flavor { get; set; }
    }
}
