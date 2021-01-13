using System;
using AuthenticationServices;
using sapcdc;
using sapcdc.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(LoginPage), typeof(LoginPageRenderer))]
namespace sapcdc.iOS
{
    public class LoginPageRenderer : PageRenderer, IASWebAuthenticationPresentationContextProviding
    {
        public LoginPageRenderer()
        {
            Instance = this;
        }

        public static LoginPageRenderer Instance { get; set; }
        public UIWindow GetPresentationAnchor(ASWebAuthenticationSession session)
        {
            if (View == null)
            {
                throw new Exception("View is null: Should not happen...");
            }
            return View.Window;
        }
    }
}