using PokeCards.Domain.Adapters;
using PokeCards.Domain.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PokeCards.Application
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage(IPokeApiAdapter pokeApiAdapter)
        {
            InitializeComponent();

            this.pokeApiAdapter = pokeApiAdapter;

            LoadPokemonList();
        }

        private async Task LoadPokemonList()
        {
            AllPokemon = new List<Pokemon>();
            for (int i = 1; i <= 151; i++)
            {
                var pkmn = await pokeApiAdapter.GetPokemon(i);
                AllPokemon.Add(pkmn);
            }

            OnPropertyChanged("AllPokemon");
        }

        IPokeApiAdapter pokeApiAdapter;

        public IList<Pokemon> AllPokemon { get; private set; }
    }
}
