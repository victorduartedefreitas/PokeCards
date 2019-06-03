using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class TypeRelations
    {
        [JsonProperty("no_damage_to")]
        public IList<NamedApiResource> NoDamageTo { get; set; }
        [JsonProperty("half_damage_to")]
        public IList<NamedApiResource> HalfDamageTo { get; set; }
        [JsonProperty("double_damage_to")]
        public IList<NamedApiResource> DoubleDamageTo { get; set; }
        [JsonProperty("no_damage_from")]
        public IList<NamedApiResource> NoDamageFrom { get; set; }
        [JsonProperty("half_damage_from")]
        public IList<NamedApiResource> HalfDamageFrom { get; set; }
        [JsonProperty("double_damage_from")]
        public IList<NamedApiResource> DoubleDamageFrom { get; set; }
    }
}
