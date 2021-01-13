using System;
using System.Threading.Tasks;

namespace sapcdc.AuthMethods
{
    public class WebAuthenticator : IAuthenticate
    {
        public async Task<string> GetToken()
        {
            var authResult = await Xamarin.Essentials.WebAuthenticator.AuthenticateAsync(
                new Uri(Constants.Url),
                new Uri(Constants.CallbackUrl));

            return authResult?.IdToken;
        }
    }
}