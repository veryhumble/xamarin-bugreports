using System;
using Caliburn.Micro;

namespace Bugreports.ViewModels.List
{
    public class GroupedSearchResult : BindableCollection<SearchResultViewModel>, IHaveGroupHeaderVisibility
    {
        public string Name { get; set; }

        public bool HeaderVisible { get; set; } = true;

        public string GroupKey { get; set; } = string.Empty;
    }

    public class SearchResultViewModel : PropertyChangedBase
    {
        public int? Id { get; set; }

        public string Name { get; set; }
    }

    public interface IHaveGroupHeaderVisibility
    {
        bool HeaderVisible { get; set; }
    }
}
