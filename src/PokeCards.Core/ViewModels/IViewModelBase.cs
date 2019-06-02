using System.Collections.Generic;

namespace PokeCards.Core.ViewModels
{
    public interface IViewModelBase
    {
        bool IsBusy { get; set; }
        bool HasChanged { get; }
        IReadOnlyCollection<string> ChangedProperties { get; }
    }
}
