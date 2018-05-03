using Xamarin.Forms;
using Android.App;

namespace NFCsample
{
    class App : Xamarin.Forms.Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new NFCPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}