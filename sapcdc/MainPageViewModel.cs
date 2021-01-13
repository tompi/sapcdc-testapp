using System;
using System.Threading.Tasks;
using AsyncAwaitBestPractices.MVVM;
using sapcdc.AuthMethods;
using Xamarin.Forms;

namespace sapcdc
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel()
        {
            AuthenticateCommand = new AsyncCommand(Authenticate);
        }

        private async Task Authenticate()
        {
            try
            {
                IAuthenticate authenticator;
                //authenticator = new AuthMethods.WebAuthenticator();
                authenticator = DependencyService.Get<INativeAuthenticate>();

                Token = await authenticator.GetToken();
            }
            catch (Exception e)
            {
                Token = e.Message;
            }
        }

        public AsyncCommand AuthenticateCommand { get; }

        public string Token { get => Get(""); set => Set(value); }
    }
}