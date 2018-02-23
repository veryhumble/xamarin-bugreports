using System;
using Bugreports.ViewModels.List;
using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using Xamarin.Forms;

namespace Bugreports.ViewModels
{
    public class MainViewModel : Screen
    {
        private readonly INavigationService _navigationService;

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override string DisplayName => "Main";


        public void GroupedListViewIssue()
        {
            _navigationService.For<ListViewEmptyGroupViewModel>().Navigate();
        }
    }
}

