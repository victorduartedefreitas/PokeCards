using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class PokemonAbility
    {
        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }
        public int Slot { get; set; }
        public NamedApiResource Ability { get; set; }
    }
}
