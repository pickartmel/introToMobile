using System;
using System.Collections.Generic;
using TimerProForms.Custom;
using Xamarin.Forms;

namespace TimerProForms.Views
{
    public partial class TimerPage : ContentPage
    {
        TimerLogic _timerLogic;
        bool isRunning; //by default a bool is false


        public TimerPage()
        {
            InitializeComponent();
            _timerLogic = new TimerLogic();
        }

        //detect if someone navigates away and then back
        protected override void OnAppearing()
        {
            base.OnAppearing();
            lblDisplay.Text = "00:00:00";
            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;

        }


        public void btnStart_Clicked(object sender, EventArgs e)
        {
            btnStart.IsEnabled = false;
            btnStop.IsEnabled = true;
            isRunning = true;
            Device.StartTimer(TimeSpan.FromSeconds(1), ()=>{
                //timer work
                if (isRunning)
                {
                    _timerLogic.SetTickCount();
                    lblDisplay.Text = _timerLogic.GetFormattedTime();
                }
                return isRunning;
            });
        }

        public void btnStop_Clicked(object sender, EventArgs e)
        {
            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;
            isRunning = false;
        }

        public void btnRestart_Clicked(object sender, EventArgs e)
        {
            _timerLogic.Reset();
            lblDisplay.Text = _timerLogic.GetFormattedTime();

        }

    }
}
