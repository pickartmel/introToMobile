using System;
using System.Collections.Generic;


using Xamarin.Forms;

namespace DistanceConverter.Views
{
    public partial class DistancePage : ContentPage
    {
        public DistancePage()
        {
            InitializeComponent();
            Title = "Distance Converter";

            ToolbarItem tbi = new ToolbarItem();
            tbi.Text = "About";

            tbi.Clicked += delegate {

                Navigation.PushAsync(new AboutPage());
            };
            this.ToolbarItems.Add(tbi);
        }
    }
}
