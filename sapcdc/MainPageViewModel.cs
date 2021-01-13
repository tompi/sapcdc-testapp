using System;
using System.Threading.Tasks;
using AsyncAwaitBestPractices.MVVM;
using Xamarin.Essentials;

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
                
                var authResult = await WebAuthenticator.AuthenticateAsync(
                    new Uri(
                        "https://fidm.eu1.gigya.com/oidc/op/v1.0/3_sIqZ_dwxuvxSn1GVtYhwVWcVU3JT3OLiXGKKFZo5aRZTHGhIn3NpoKTp20StKb9m/authorize?client_id=Y1WerR7Xg10827k6OairGlIw&scope=profile+email+openid+fed_liveborn_dev&nonce=12312412&redirect_uri=https://id-dev.laerdal.com/redirect&response_type=id_token"),
                    new Uri("https://id-dev.laerdal.com/redirect"));

                Token = authResult?.IdToken;
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