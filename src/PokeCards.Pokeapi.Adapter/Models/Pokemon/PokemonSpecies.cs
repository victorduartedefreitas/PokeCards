using Newtonsoft.Json;
using PokeCards.Pokeapi.Adapter.Models.Common;
using System.Collections.Generic;

namespace PokeCards.Pokeapi.Adapter.Models.Pokemon
{
    public class PokemonSpecies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        [JsonProperty("gender_rate")]
        public int GenderRate { get; set; }
        [JsonProperty("capture_rate")]
        public int CaptureRate { get; set; }
        [JsonProperty("base_happiness")]
        public int BaseHappiness { get; set; }
        [JsonProperty("is_baby")]
        public bool IsBaby { get; set; }
        [JsonProperty("hatch_counter")]
        public int HatchCounter { get; set; }
        [JsonProperty("has_gender_differences")]
        public bool HasGenderDifferences { get; set; }
        [JsonProperty("forms_switchable")]
        public bool FormsSwitchable { get; set; }
        [JsonProperty("growth_rate")]
        public NamedApiResource GrowthRate { get; set; }
        [JsonProperty("pokedex_numbers")]
        public IList<PokemonSpeciesDexEntry> PokedexNumbers { get; set; }
        [JsonProperty("egg_groups")]
        public IList<NamedApiResource> EggGroups { get; set; }
        public NamedApiResource Color { get; set; }
        public NamedApiResource Shape { get; set; }
        [JsonProperty("evolves_from_species")]
        public NamedApiResource EvolvesFromSpecies { get; set; }
        [JsonProperty("evolution_chain")]
        public ApiResource EvolutionChain { get; set; }
        public NamedApiResource Habitat { get; set; }
        public NamedApiResource Generation { get; set; }
        public IList<Name> Names { get; set; }
        [JsonProperty("pal_park_encounter_area")]
        public IList<PalParkEncounterArea> PalParkEncounterArea { get; set; }
        [JsonProperty("flavor_text_entries")]
        public IList<FlavorText> FlavorTexts { get; set; }
        [JsonProperty("form_description")]
        public IList<Description> FormDescriptions { get; set; }
        public IList<Genus> Genera { get; set; }
        public IList<PokemonSpeciesVariety> Varieties { get; set; }
    }
}
