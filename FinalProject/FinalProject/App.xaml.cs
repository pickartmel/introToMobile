using Xamarin.Forms;
using FinalProject.Views;
using FinalProject; 

namespace FinalProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //  MainPage = new WelcomePage();
            MainPage = new NavigationPage(new WelcomePage());

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
