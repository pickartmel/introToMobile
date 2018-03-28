using System;
using Xamarin.Forms;
using MovieApp.Views;


namespace MovieApp.Custom
{
    public class TabLayout:TabbedPage
    {
        public TabLayout()
        {
            Children.Add(new AddPage(){Title="Add Movie", Icon="add"});
            Children.Add(new FindPage(){Title="Find Movie", Icon="find"});
        }
    }
}
