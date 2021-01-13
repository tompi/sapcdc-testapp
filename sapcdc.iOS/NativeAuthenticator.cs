using System;
using System.Threading.Tasks;
using AuthenticationServices;
using Foundation;
using sapcdc.AuthMethods;
using Xamarin.Forms;

[assembly: Dependency(typeof(sapcdc.iOS.NativeAuthenticator))]
namespace sapcdc.iOS
{
    public class NativeAuthenticator : INativeAuthenticate
    {
        public NativeAuthenticator()
        {
        }

        public Task<string> GetToken()
        {
            var url = new NSUrl(Constants.Url);
            var taskCompletionSource = new TaskCompletionSource<string>();
            void CompletionHandler(NSUrl callbackurl, NSError error)
            {
                var urlParts = callbackurl.Fragment;
                taskCompletionSource.SetResult(urlParts);
            }
            var session = new ASWebAuthenticationSession(url, null, CompletionHandler);
            session.PresentationContextProvider = LoginPageRenderer.Instance;
            session.Start();
            return taskCompletionSource.Task;
        }

    }
}
