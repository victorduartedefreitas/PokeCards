using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Item
{
    public class ItemFlingEffect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("effect_entries")]
        public IList<Effect> Effects { get; set; }
        public IList<NamedApiResource> Items { get; set; }
    }
}
