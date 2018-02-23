using Bugreports.ViewModels;
using Bugreports.ViewModels.List;
using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Bugreports
{
    public partial class App : FormsApplication
    {
        private readonly SimpleContainer _container;

        public App(SimpleContainer container)
        {
            _container = container;
            
            container.PerRequest<ListViewEmptyGroupViewModel>();
            container.PerRequest<MainViewModel>();
            
            InitializeComponent();

            DisplayRootView<Views.MainView>();
        }

        protected override void PrepareViewFirst(NavigationPage navigationPage)
        {
            var navigationService = new NavigationPageAdapter(navigationPage);
            _container.Instance<INavigationService>(navigationService);

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
