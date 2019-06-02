using PokeCards.Core.Views;

namespace PokeCards.Core.ViewModels
{
    public interface IViewModelBase<TView> : IViewModelBase
        where TView : IViewBase
    {
        TView CurrentView { get; }
    }
}
