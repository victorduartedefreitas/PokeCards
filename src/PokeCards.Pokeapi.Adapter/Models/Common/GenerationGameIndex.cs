using Newtonsoft.Json;

namespace PokeCards.Pokeapi.Adapter.Models.Common
{
    public class GenerationGameIndex
    {
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }
        public NamedApiResource Generation { get; set; }
    }
}
