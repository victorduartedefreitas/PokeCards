using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("damage_relations")]
        public TypeRelations DamageRelations { get; set; }
        [JsonProperty("game_indices")]
        public IList<GenerationGameIndex> GameIndices { get; set; }
        public NamedApiResource Generation { get; set; }
        [JsonProperty("move_damage_class")]
        public NamedApiResource MoveDamageClass { get; set; }
        public IList<Name> Names { get; set; }
        public IList<TypePokemon> Pokemon { get; set; }
        public IList<NamedApiResource> Moves { get; set; }
    }
}
