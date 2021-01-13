using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace sapcdc
{
    public partial class MainPage
    {
        public MainPage()
        {
            On<iOS>().SetUseSafeArea(true);
            BindingContext = new MainPageViewModel();
            InitializeComponent();
        }
    }
}
