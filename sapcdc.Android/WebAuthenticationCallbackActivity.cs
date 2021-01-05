using Android.App;
using Android.Content.PM;

namespace sapcdc.Droid
{
    [Activity(NoHistory = true, LaunchMode = LaunchMode.SingleTop, Name= "com.laerdal.mylaerdal.WebAuthenticationCallbackActivity")]
    [IntentFilter(new[] { Android.Content.Intent.ActionView },
        Categories = new[] { Android.Content.Intent.CategoryDefault, Android.Content.Intent.CategoryBrowsable },
        DataScheme = "https://id-dev.laerdal.com/redirect")]
    public class WebAuthenticationCallbackActivity : Xamarin.Essentials.WebAuthenticatorCallbackActivity
    {
        protected override void OnResume()
        {
            base.OnResume();
            
            Xamarin.Essentials.Platform.OnResume();
        }
        
    }
}