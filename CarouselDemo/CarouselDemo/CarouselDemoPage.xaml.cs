using Xamarin.Forms;
using System;

namespace CarouselDemo
{
    public partial class CarouselDemoPage : CarouselPage
    {
        public CarouselDemoPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Device.StartTimer(TimeSpan.FromMilliseconds(200),() =>
            {
                this.CurrentPage = this.Children[1];
                return false;
            });

            Device.StartTimer(TimeSpan.FromMilliseconds(1000), () =>
            {
                this.CurrentPage = this.Children[0];
                return false;
            });

        }
    }
}
