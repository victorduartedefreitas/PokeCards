using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;

namespace PokeCards.Pokeapi.Adapter.Models.Moves
{
    public class ContestComboDetail
    {
        [JsonProperty("use_before")]
        public NamedApiResource UseBefore { get; set; }
        [JsonProperty("use_after")]
        public NamedApiResource UseAfter { get; set; }
    }
}
