using Android.App;
using Android.Widget;
using Android.OS;
using Android.Nfc;
using Android.Views;
using System;


namespace NFConmyown
{
    [Activity(Label = "NFConmyown", MainLauncher = true)]
    public class MainActivity : Activity
    {
        NfcAdapter nfcAdapter;
        ToggleButton tglReadWright;
        TextView txtTagContent;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            nfcAdapter = NfcAdapter.GetDefaultAdapter(this);
            tglReadWright = (ToggleButton)FindViewById(r.id.tglReadWright);
            txtTagContent = (TextView)FindViewById(R.id.txtTagContent);
            //test
        }

        public void tglReadWriteOnlick(View view)
        {
            txtTagContent.SetText(' ');
        }


    }
}

