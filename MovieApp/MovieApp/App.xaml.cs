﻿using Xamarin.Forms;
using MovieApp.Custom;
using MovieApp.Models;
using System.Collections.Generic;

namespace MovieApp
{
    public partial class App : Application
    {
        public static List<Movie> MovieList;
        public App()
        {
            InitializeComponent();
            MovieList = new List<Movie>();//initialize it when the code runs
            MainPage = new TabLayout();
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
