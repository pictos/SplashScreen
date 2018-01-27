using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SplashScreen.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set {SetProperty(ref _isBusy , value); }
        }
        private string _msg;

        public string Msg
        {
            get { return _msg; }
            set {SetProperty(ref _msg , value); }
        }


        public async Task Carregar()
        {
            Msg = "Carregando";
            IsBusy = true;
            await Task.Delay(9000);
            IsBusy = false;
            Msg = "Finalizado Carregamento";
        }
    }
}
