using Newtonsoft.Json;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Items
{
    public class ItemHolderPokemon
    {
        public string Pokemon { get; set; }
        [JsonProperty("version_details")]
        public IList<ItemHolderPokemonVersionDetail> VersionDetails { get; set; }
    }
}
