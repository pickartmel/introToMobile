using Xamarin.Forms;
using FinalProject.Views;
using FinalProject;
using FinalProject.Custom;

namespace FinalProject
{
    public partial class App : Application
    {
        public static CalculateAge ageCalc;
        public App()
        {
            InitializeComponent();

            //  MainPage = new WelcomePage();
            MainPage = new NavigationPage(new WelcomePage());
            ageCalc = new CalculateAge();

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
