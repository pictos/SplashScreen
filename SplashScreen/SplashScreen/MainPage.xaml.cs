using SplashScreen.ViewModel;
using Xamarin.Forms;

namespace SplashScreen
{
    public partial class MainPage : ContentPage
	{
        MainViewModel Vm = new MainViewModel();
		public MainPage()
		{
			InitializeComponent();
            BindingContext = Vm;
            
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Vm.Carregar();
        }
    }
}
