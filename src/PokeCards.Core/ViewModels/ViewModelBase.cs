using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace PokeCards.Core.ViewModels
{
    public abstract class ViewModelBase : BindableBase, IViewModelBase, INavigatedAware, INavigatedAwareAsync, IConfirmNavigation, IConfirmNavigationAsync, IDestructible, IApplicationLifecycleAware, INavigationPageOptions
    {
        #region Constructors

        public ViewModelBase()
            : base()
        {
            navigationService = ResolveDependency<INavigationService>(Prism.PrismApplicationBase.NavigationServiceName);
            pageDialogService = ResolveDependency<IPageDialogService>();
        }

        #endregion

        #region Fields

        private bool _isBusy;
        private List<string> _changedProperties = new List<string>();
        private readonly INavigationService navigationService;
        private readonly IPageDialogService pageDialogService;

        #endregion

        #region Properties & Events

        public bool IsBusy
        {
            get => _isBusy;
            set { SetProperty(ref _isBusy, value); }
        }

        public IReadOnlyCollection<string> ChangedProperties
        {
            get => _changedProperties;
        }

        public bool HasChanged => ChangedProperties.Count > 0;

        public virtual bool ClearNavigationStackOnNavigation => false;

        #endregion

        #region Virtual Methods

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public async virtual Task OnNavigatedToAsync(INavigationParameters parameters)
        {
            await Task.FromResult(default(object));
        }

        public virtual bool CanNavigate(INavigationParameters parameters)
        {
            return true;
        }

        public async virtual Task<bool> CanNavigateAsync(INavigationParameters parameters)
        {
            return await Task.FromResult(true);
        }

        public virtual void Destroy()
        {
        }

        public virtual void OnResume()
        {
        }

        public virtual void OnSleep()
        {
        }

        #endregion

        #region Protected Methods

        protected T ResolveDependency<T>()
        {
            return ResolveDependency<T>(string.Empty);
        }

        protected T ResolveDependency<T>(string name)
        {
            if (string.IsNullOrEmpty(name))
                return (T)Prism.PrismApplicationBase.Current.Container.Resolve(typeof(T));
            else
                return (T)Prism.PrismApplicationBase.Current.Container.Resolve(typeof(T), name);
        }

        protected override bool SetProperty<T>(ref T storage, T value, Action onChanged, [CallerMemberName] string propertyName = null)
        {
            var setResult = base.SetProperty(ref storage, value, onChanged, propertyName);

            if (setResult && !_changedProperties.Contains(propertyName))
                _changedProperties.Add(propertyName);

            return setResult;
        }

        protected override bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            var setResult = base.SetProperty(ref storage, value, propertyName);

            if (setResult && !_changedProperties.Contains(propertyName))
                _changedProperties.Add(propertyName);

            return setResult;
        }

        protected async Task<INavigationResult> GoBackAsync()
        {
            return await navigationService.GoBackAsync();
        }

        protected async Task<INavigationResult> GoBackAsync(INavigationParameters parameters)
        {
            return await navigationService.GoBackAsync(parameters);
        }

        protected async Task<INavigationResult> NavigateAsync(Uri uri)
        {
            return await navigationService.NavigateAsync(uri);
        }

        protected async Task<INavigationResult> NavigateAsync(Uri uri, INavigationParameters parameters)
        {
            return await navigationService.NavigateAsync(uri, parameters);
        }

        protected async Task<INavigationResult> NavigateAsync(string name)
        {
            return await navigationService.NavigateAsync(name);
        }

        protected async Task<INavigationResult> NavigateAsync(string name, INavigationParameters parameters)
        {
            return await navigationService.NavigateAsync(name, parameters);
        }

        protected async Task<string> DisplayActionSheetAsync(string title, string cancelButton, string destroyButton, params string[] otherButtons)
        {
            return await pageDialogService.DisplayActionSheetAsync(title, cancelButton, destroyButton, otherButtons);
        }

        protected async Task DisplayActionSheetAsync(string title, params IActionSheetButton[] buttons)
        {
            await pageDialogService.DisplayActionSheetAsync(title, buttons);
        }

        protected async Task<bool> DisplayAlertAsync(string title, string message, string acceptButton, string cancelButton)
        {
            return await pageDialogService.DisplayAlertAsync(title, message, acceptButton, cancelButton);
        }

        protected async Task DisplayAlertAsync(string title, string message, string cancelButton)
        {
            await pageDialogService.DisplayAlertAsync(title, message, cancelButton);
        }

        #endregion
    }
}
