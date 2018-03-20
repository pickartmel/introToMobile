using System;
using Xamarin.Forms;
using PlatoClalculator.Views;
namespace PlatoClalculator
{
    public class TabController : TabbedPage
    {
        public TabController()
        {
            Children.Add(new ManPage() { Title = "Man", Icon = "man1.png" });
            Children.Add(new WomenPage(){Title = "Woman",Icon="woman1.png"});
        }
    }
}
