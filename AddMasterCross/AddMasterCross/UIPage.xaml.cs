using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AddMasterCross
{
    public partial class UIPage : ContentPage
    {
        public UIPage()
        {
            InitializeComponent();
        }

        public void btnAdd_Clicked(object sender, System.EventArgs e)
        {
            double dblFirstNum, dblSecondNum;
            double.TryParse(txtFirstNumber.Text, out dblFirstNum);
            double.TryParse(txtSecondNumber.Text, out dblSecondNum);
            lblDisplay.Text = (dblFirstNum + dblSecondNum).ToString();
        }

        public void btnClear_Clicked(object sender, System.EventArgs e)
        {
            txtFirstNumber.Text = string.Empty;
            txtSecondNumber.Text = string.Empty;
            lblDisplay.Text = string.Empty;
        }
    }
}
