﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace XamarinDot
{
    [Activity(Label = "XamarinDot", MainLauncher = true)]
    public class MainActivity : Activity
    {
        TextView txtNumber;
        int number; 

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            txtNumber = FindViewById<TextView>(Resource.Id.txtNumber);

            //button click handler - increment
            FindViewById<Button>(Resource.Id.btnIncrement).Click += (o, e) =>
            txtNumber.Text = (++number).ToString();

            //button click handler - deincrement
            FindViewById<Button>(Resource.Id.btnDecrement).Click += (o, e)  =>
            txtNumber.Text = (--number).ToString();



        }
    }
}

