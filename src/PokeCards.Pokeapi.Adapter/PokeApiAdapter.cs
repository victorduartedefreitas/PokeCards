using PokeCards.Domain.Adapters;
using PokeCards.Domain.Models;
using System;
using System.Threading.Tasks;

namespace PokeCards.Pokeapi.Adapter
{
    internal class PokeApiAdapter : IPokeApiAdapter
    {
        #region Fields

        private readonly IPokeApi pokeApi;

        #endregion

        #region Constructors

        public PokeApiAdapter(IPokeApi pokeApi)
        {
            this.pokeApi = pokeApi ?? throw new ArgumentNullException(nameof(pokeApi));
        }

        #endregion

        #region Public Methods

        public async Task GetBerry(int id)
        {
            try
            {
                var berry = await pokeApi.GetBerryAsync(id);
            }
            catch (Exception ex)
            {

            }
        }

        public async Task<Pokemon> GetPokemon(int id)
        {
            try
            {
                var pkmn = await pokeApi.GetPokemonAsync(id);
                return new Pokemon()
                {
                    Name = pkmn.Name.ToUpper(),
                    Image = new Uri(pkmn.Sprites.FrontDefault)
                };
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #endregion
    }
}
