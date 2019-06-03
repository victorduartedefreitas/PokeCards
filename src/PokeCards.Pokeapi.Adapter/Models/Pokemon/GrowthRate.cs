using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class GrowthRate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Formula { get; set; }
        public IList<Description> Descriptions { get; set; }
        public IList<GrowthRateExperienceLevel> Levels { get; set; }
        [JsonProperty("pokemon_species")]
        public IList<NamedApiResource> PokemonSpecies { get; set; }
    }
}
