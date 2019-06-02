using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Berry
{
    public class Berry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("growth_time")]
        public int GrowthTime { get; set; }
        [JsonProperty("max_harvest")]
        public int MaxHarvest { get; set; }
        [JsonProperty("natural_gift_power")]
        public int NaturalGiftPower { get; set; }
        public int Size { get; set; }
        public int Smoothness { get; set; }
        [JsonProperty("soil_dryness")]
        public int SoilDryness { get; set; }
        public NamedApiResource Firmness { get; set; }
        public IList<BerryFlavorMap> Flavors { get; set; }
        public NamedApiResource Item { get; set; }
        [JsonProperty("natural_gift_type")]
        public NamedApiResource NaturalGiftType { get; set; }
    }
}
