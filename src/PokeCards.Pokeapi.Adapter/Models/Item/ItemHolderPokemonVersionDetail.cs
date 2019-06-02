using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Item
{
    public class ItemHolderPokemonVersionDetail
    {
        public string Rarity { get; set; }
        public NamedApiResource Version { get; set; }
    }
}
