using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using System;

namespace AddMasterA
{
    [Activity(Label = "AddMasterA", MainLauncher = true)]
    public class MainActivity : Activity
    {
        TextView txtDisplay;
        EditText txtFirst;
        EditText txtSecond;

        
        


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            txtDisplay = FindViewById<TextView>(Resource.Id.txtDisplay);
            txtFirst = FindViewById<EditText>(Resource.Id.txtFirst);
            txtSecond = FindViewById<EditText>(Resource.Id.txtSecond);




            //click handler
           // 
           


        }

        [Java.Interop.Export("ButtonClick")]
        protected void BtnAddClicked (View view)
        {
            Button button = (Button)view;
            string firstNumber = txtFirst.Text;

            string secondNumber = txtSecond.Text;

           // FindViewById<Button>(Resource.Id.btnAdd).Click += (o, e) =>

            txtDisplay.Text = (firstNumber) + (secondNumber).ToString();

        }
    }
}

