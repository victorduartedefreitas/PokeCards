using PokeCards.Pokeapi.Adapter.Models;
using PokeCards.Pokeapi.Adapter.Models.Berries;
using PokeCards.Pokeapi.Adapter.Models.Contests;
using PokeCards.Pokeapi.Adapter.Models.Encounters;
using PokeCards.Pokeapi.Adapter.Models.Evolutions;
using PokeCards.Pokeapi.Adapter.Models.Games;
using PokeCards.Pokeapi.Adapter.Models.Items;
using PokeCards.Pokeapi.Adapter.Models.Locations;
using PokeCards.Pokeapi.Adapter.Models.Machines;
using PokeCards.Pokeapi.Adapter.Models.Moves;
using PokeCards.Pokeapi.Adapter.Models.Pokemon;
using Refit;
using System.Threading.Tasks;

namespace PokeCards.Pokeapi.Adapter
{
    internal interface IPokeApi
    {
        [Get("/{name}/")]
        Task<GenericResource> GetGenericResourceAsync([AliasAs("name")]string resourceName, [Query]int limit, [Query]int offset);

        [Get("/berry/{id}")]
        Task<Berry> GetBerryAsync(int id);
        [Get("/berry/{name}")]
        Task<Berry> GetBerryAsync(string name);

        [Get("/berry-firmness/{id}")]
        Task<BerryFirmness> GetBerryFirmnessAsync(int id);
        [Get("/berry-firmness/{name}")]
        Task<BerryFirmness> GetBerryFirmnessAsync(string name);

        [Get("/berry-flavor/{id}")]
        Task<BerryFlavor> GetBerryFlavorAsync(int id);
        [Get("/berry-flavor/{name}")]
        Task<BerryFlavor> GetBerryFlavorAsync(string name);

        [Get("/contest-type/{id}")]
        Task<ContestType> GetContestTypeAsync(int id);
        [Get("/contest-type/{name}")]
        Task<ContestType> GetContestTypeAsync(string name);

        [Get("/contest-effect/{id}")]
        Task<ContestEffects> GetContestEffectAsync(int id);

        [Get("/super-contest-effect/{id}")]
        Task<SuperContestEffects> GetSuperContestEffectAsync(int id);

        [Get("/encounter-method/{id}")]
        Task<EncounterMethod> GetEncounterMethodAsync(int id);
        [Get("/encounter-method/{name}")]
        Task<EncounterMethod> GetEncounterMethodAsync(string name);

        [Get("/encounter-condition/{id}")]
        Task<EncounterCondition> GetEncounterConditionAsync(int id);
        [Get("/encounter-condition/{name}")]
        Task<EncounterCondition> GetEncounterConditionAsync(string name);

        [Get("/encounter-condition-value/{id}")]
        Task<EncounterConditionValue> GetEncounterConditionValueAsync(int id);
        [Get("/encounter-condition-value/{name}")]
        Task<EncounterConditionValue> GetEncounterConditionValueAsync(string name);

        [Get("/evolution-chain/{id}")]
        Task<EvolutionChain> GetEvolutionChainAsync(int id);

        [Get("/evolution-trigger/{id}")]
        Task<EvolutionTrigger> GetEvolutionTriggerAsync(int id);
        [Get("/evolution-trigger/{name}")]
        Task<EvolutionTrigger> GetEvolutionTriggerAsync(string name);

        [Get("/generation/{id}")]
        Task<Generation> GetGameGenerationAsync(int id);
        [Get("/generation/{name}")]
        Task<Generation> GetGameGenerationAsync(string name);

        [Get("/pokedex/{id}")]
        Task<Pokedex> GetPokedexAsync(int id);
        [Get("/pokedex/{name}")]
        Task<Pokedex> GetPokedexAsync(string name);

        [Get("/version/{id}")]
        Task<GameVersion> GetGameVersionAsync(int id);
        [Get("/version/{name}")]
        Task<GameVersion> GetGameVersionAsync(string name);

        [Get("/version-group/{id}")]
        Task<VersionGroup> GetGameVersionGroupAsync(int id);
        [Get("/version-group/{name}")]
        Task<VersionGroup> GetGameVersionGroupAsync(string name);

        [Get("/item/{id}")]
        Task<Item> GetItemAsync(int id);
        [Get("/item/{name}")]
        Task<Item> GetItemAsync(string name);

        [Get("/item-attribute/{id}")]
        Task<ItemAttribute> GetItemAttributeAsync(int id);
        [Get("/item-attribute/{name}")]
        Task<ItemAttribute> GetItemAttributeAsync(string name);

        [Get("/item-category/{id}")]
        Task<ItemCategory> GetItemCategoryAsync(int id);
        [Get("/item-category/{name}")]
        Task<ItemCategory> GetItemCategoryAsync(string name);

        [Get("/item-fling-effect/{id}")]
        Task<ItemFlingEffect> GetItemFlingEffectAsync(int id);
        [Get("/item-fling-effect/{name}")]
        Task<ItemFlingEffect> GetItemFlingEffectAsync(string name);

        [Get("/item-pocket/{id}")]
        Task<ItemPocket> GetItemPocketAsync(int id);
        [Get("/item-pocket/{name}")]
        Task<ItemPocket> GetItemPocketAsync(string name);

        [Get("/location/{id}")]
        Task<Location> GetLocationAsync(int id);
        [Get("/location/{name}")]
        Task<Location> GetLocationAsync(string name);

        [Get("/location-area/{id}")]
        Task<LocationArea> GetLocationAreaAsync(int id);
        [Get("/location-area/{name}")]
        Task<LocationArea> GetLocationAreaAsync(string name);

        [Get("/pal-park-area/{id}")]
        Task<PalParkArea> GetPalParkAreaAsync(int id);
        [Get("/pal-park-area/{name}")]
        Task<PalParkArea> GetPalParkAreaAsync(string name);

        [Get("/region/{id}")]
        Task<Region> GetRegionAsync(int id);
        [Get("/region/{name}")]
        Task<Region> GetRegionAsync(string name);

        [Get("/machine/{id}")]
        Task<Machine> GetMachineAsync(int id);

        [Get("/move/{id}")]
        Task<Move> GetMoveAsync(int id);
        [Get("/move/{name}")]
        Task<Move> GetMoveAsync(string name);

        [Get("/move-ailment/{id}")]
        Task<MoveAilment> GetMoveAilmentAsync(int id);
        [Get("/move-ailment/{name}")]
        Task<MoveAilment> GetMoveAilmentAsync(string name);

        [Get("/move-battle-style/{id}")]
        Task<MoveBattleStyle> GetMoveBattleStyleAsync(int id);
        [Get("/move-battle-style/{name}")]
        Task<MoveBattleStyle> GetMoveBattleStyleAsync(string name);

        [Get("/move-category/{id}")]
        Task<MoveCategory> GetMoveCategoryAsync(int id);
        [Get("/move-category/{name}")]
        Task<MoveCategory> GetMoveCategoryAsync(string name);

        [Get("/move-damage-class/{id}")]
        Task<MoveDamageClass> GetMoveDamageClassAsync(int id);
        [Get("/move-damage-class/{name}")]
        Task<MoveDamageClass> GetMoveDamageClassAsync(string name);

        [Get("/move-learn-method/{id}")]
        Task<MoveLearnMethod> GetMoveLearnMethodAsync(int id);
        [Get("/move-learn-method/{name}")]
        Task<MoveLearnMethod> GetMoveLearnMethodAsync(string name);

        [Get("/move-target/{id}")]
        Task<MoveTarget> GetMoveTargetAsync(int id);
        [Get("/move-target/{name}")]
        Task<MoveTarget> GetMoveTargetAsync(string name);

        [Get("/ability/{id}")]
        Task<Ability> GetAbilityAsync(int id);
        [Get("/ability/{name}")]
        Task<Ability> GetAbilityAsync(string name);

        [Get("/characteristic/{id}")]
        Task<Characteristic> GetCharacteristicAsync(int id);

        [Get("/egg-group/{id}")]
        Task<EggGroup> GetEggGroupAsync(int id);
        [Get("/egg-group/{name}")]
        Task<EggGroup> GetEggGroupAsync(string name);

        [Get("/gender/{id}")]
        Task<Gender> GetGenderAsync(int id);
        [Get("/gender/{name}")]
        Task<Gender> GetGenderAsync(string name);

        [Get("/growth-rate/{id}")]
        Task<GrowthRate> GetGrowthRateAsync(int id);
        [Get("/growth-rate/{name}")]
        Task<GrowthRate> GetGrowthRateAsync(string name);

        [Get("/nature/{id}")]
        Task<Nature> GetNatureAsync(int id);
        [Get("/nature/{name}")]
        Task<Nature> GetNatureAsync(string name);

        [Get("/pokeathlon-stat/{id}")]
        Task<PokeathlonStat> GetPokeathlonStatAsync(int id);
        [Get("/pokeathlon-stat/{name}")]
        Task<PokeathlonStat> GetPokeathlonStatAsync(string name);

        [Get("/pokemon/{id}")]
        Task<Pokemon> GetPokemonAsync(int id);
        [Get("/pokemon/{name}")]
        Task<Pokemon> GetPokemonAsync(string name);

        [Get("/pokemon-color/{id}")]
        Task<PokemonColor> GetPokemonColorAsync(int id);
        [Get("/pokemon-color/{name}")]
        Task<PokemonColor> GetPokemonColorAsync(string name);

        [Get("/pokemon-form/{id}")]
        Task<PokemonForm> GetPokemonFormAsync(int id);
        [Get("/pokemon-form/{name}")]
        Task<PokemonForm> GetPokemonFormAsync(string name);

        [Get("/pokemon-habitat/{id}")]
        Task<PokemonHabitat> GetPokemonHabitatAsync(int id);
        [Get("/pokemon-habitat/{name}")]
        Task<PokemonHabitat> GetPokemonHabitatAsync(string name);

        [Get("/pokemon-shape/{id}")]
        Task<PokemonShape> GetPokemonShapeAsync(int id);
        [Get("/pokemon-shape/{name}")]
        Task<PokemonShape> GetPokemonShapeAsync(string name);

        [Get("/pokemon-species/{id}")]
        Task<PokemonSpecies> GetPokemonSpeciesAsync(int id);
        [Get("/pokemon-species/{name}")]
        Task<PokemonSpecies> GetPokemonSpeciesAsync(string name);

        [Get("/stat/{id}")]
        Task<Stat> GetStatAsync(int id);
        [Get("/stat/{name}")]
        Task<Stat> GetStatAsync(string name);

        [Get("/type/{id}")]
        Task<PkmnType> GetTypeAsync(int id);
        [Get("/type/{name}")]
        Task<PkmnType> GetTypeAsync(string name);
    }
}
