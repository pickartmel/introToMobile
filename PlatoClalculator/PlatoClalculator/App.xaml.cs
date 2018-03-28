using Xamarin.Forms;
using PlatoClalculator.Custom;
namespace PlatoClalculator
{
    public partial class App : Application
    {
        //public static CalcSpouseAge calcSpouse;
        public App()
        {
            InitializeComponent();

            MainPage = new TabController();
           // calcSpouse = new CalcSpouseAge();
            //calcMan =  new PlatoClalculatorPage();
            //calcWomen = new PlatoClalculator();
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
