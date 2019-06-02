using Newtonsoft.Json;

namespace PokeCards.Pokeapi.Adapter.Models.Common
{
    public class VersionGameIndex
    {
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }
        public NamedApiResource Version { get; set; }
    }
}
