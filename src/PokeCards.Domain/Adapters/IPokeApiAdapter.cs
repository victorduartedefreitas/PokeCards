using PokeCards.Domain.Models;
using System.Threading.Tasks;

namespace PokeCards.Domain.Adapters
{
    public interface IPokeApiAdapter
    {
        Task GetBerry(int id);
        Task<Pokemon> GetPokemon(int id);
    }
}
