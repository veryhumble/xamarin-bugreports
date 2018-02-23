using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace Bugreports.ViewModels.List
{
    public class ListViewEmptyGroupViewModel : Screen
    {
        private readonly GroupedSearchResult _loadingItemGroup;
        private readonly GroupedSearchResult _searchResultGroup;

        public ListViewEmptyGroupViewModel()
        {
            
            _loadingItemGroup = new GroupedSearchResult {HeaderVisible = false};
            _searchResultGroup = new GroupedSearchResult {HeaderVisible = false};
            
            FillLoadingItemsIntoGroup(_loadingItemGroup, 7);

            SearchResults.Add(_loadingItemGroup);
            SearchResults.Add(_searchResultGroup);
        }

        public override string DisplayName => "ListView Empty Group Issue";

        protected override async void OnInitialize()
        {
            _searchResultGroup.Clear();

            await Task.Delay(200);
            var searchResults = new List<SearchResultViewModel>();
            for (int i = 0; i < 20; i++)
            {
                searchResults.Add(new SearchResultViewModel
                {
                    Name = $"Search Result {i}"
                });
            }


            _searchResultGroup.AddRange(searchResults);
            _loadingItemGroup.Clear();
        }

        private static void FillLoadingItemsIntoGroup(GroupedSearchResult loadingItemGroup, int recordOverviewNumberOfLoadingItems)
        {
            var itemList = new List<SearchResultViewModel>();
            for (int i = 0; i < recordOverviewNumberOfLoadingItems; i++)
            {
                itemList.Add(new SearchResultViewModel
                {
                    Name = $"Loading Item {i}"
                });
            }

            loadingItemGroup.AddRange(itemList);
        }

        public BindableCollection<GroupedSearchResult> SearchResults { get; set; } = new BindableCollection<GroupedSearchResult>();
    }
}