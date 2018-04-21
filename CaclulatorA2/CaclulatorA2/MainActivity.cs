﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using System;

namespace CaclulatorA2
{
    [Activity(Label = "CaclulatorA2", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private TextView calculatorText;

        private string[] numbers = new string[2];

        private string @operator;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            calculatorText = FindViewById<TextView>(Resource.Id.calculator_text_view);
        }

        [Java.Interop.Export("ButtonClick")]
        public void ButtonClick(View v)
        {
            Button button = (Button)v;
            if ("0123456789.".Contains(button.Text))
                AddDigitOrDecimalPoint(button.Text);
            else if ("÷×+-".Contains(button.Text))
                AddOperator(button.Text);
            else if ("=" == button.Text)
                Calculate();
            else
                Erase();

        }

        private void Erase()
        {
            throw new NotImplementedException();
        }

        private void Calculate()
        {
            throw new NotImplementedException();
        }

        private void AddOperator(string value)
        {
            throw new NotImplementedException();
        }

        private void AddDigitOrDecimalPoint(string value)
        {
            int index = @operator == null ? 0 : 1;

            if (value == "." && numbers[index].Contains("."))
                return;
            numbers[index] += value;

            UpdateCalculatorText();
        }

        private void UpdateCalculatorText()
        {
            calculatorText.Text = $"{numbers[0]} {@operator} {numbers[1]}";
        }
    }
}

