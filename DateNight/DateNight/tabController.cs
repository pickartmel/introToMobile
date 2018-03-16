using System;
using Xamarin.Forms;
using DateNight.Views;
namespace DateNight
{
    public class tabController : TabbedPage
    {
        public tabController()
        {
            Children.Add(new CoffeePage(){Title = "Coffee",Icon = "CoffeeTab.png"});
            Children.Add(new DinnerPage(){ Title = "Dinner", Icon = "DinnerTab.png" });
            Children.Add(new MoviePage(){ Title = "Movie", Icon = "MovieTab.png" });
            Children.Add(new CostPage(){ Title = "Cost", Icon = "CostTab.png" });
        }
    }
}
