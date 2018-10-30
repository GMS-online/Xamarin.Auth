using Android.Content;

#if !AZURE_MOBILE_SERVICES
namespace Xamarin.Auth.Presenters.XamarinAndroid
#else
namespace Xamarin.Auth._MobileServices.Presenters.XamarinAndroid
#endif
{
    #if XAMARIN_AUTH_INTERNAL
    internal class PlatformOAuthLoginPresenter
    #else
    public class PlatformOAuthLoginPresenter
    #endif
    {
        public void Login(Authenticator authenticator)
        {
            AuthenticationConfiguration.Context.StartActivity((Intent) authenticator.GetUI(AuthenticationConfiguration.Context));
        }
    }
}
