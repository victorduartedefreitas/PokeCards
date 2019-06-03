using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class PokemonMoveVersion
    {
        [JsonProperty("move_learned_method")]
        public NamedApiResource MoveLearnedMethod { get; set; }
        [JsonProperty("version_group")]
        public NamedApiResource VersionGroup { get; set; }
        [JsonProperty("level_learned_at")]
        public int LevelLearnedAt { get; set; }
    }
}
