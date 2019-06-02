using PokeCards.Core.Views;

namespace PokeCards.Core.ViewModels
{
    public abstract class ViewModelBase<TView> : ViewModelBase, IViewModelBase<TView>
        where TView : IViewBase
    {
        #region Constructors

        public ViewModelBase(TView view)
            : base()
        {
            CurrentView = view;
        }

        #endregion

        #region Properties

        public TView CurrentView
        {
            get;
        }

        #endregion
    }
}
