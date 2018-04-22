using Android.App;
using Android.Widget;
using Android.OS;
using Android.Nfc;
using Android.Views;
using System;

namespace NFCReadWriteToggle
{
    [Activity(Label = "NFCReadWriteToggle", MainLauncher = true)]
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
            tglReadWright = (ToggleButton)FindViewById(R.id.tglReadWright);
            txtTagContent = (TextView)FindViewById(R.id.txtTagContent);
            
        }

        public void tglReadWriteOnlick(View view)
        {
            txtTagContent.SetText(' ');
        }

        public string getTextFromNdefRecord(NdefRecord ndefRecord)
        {
            String tagContent = null;
            try
            {
                byte[] payload = ndefRecord.GetPayload();
                String txtEncoding = ((payload[0] & 128) == 0) ? "UTF-8" : "UTF-16";
                int languageSize = payload[0] & 0063;
                tagContent = new string(payload, languageSize + 1,
                                payload.Length - languageSize - 1, textEncoding);
            }
            catch (System.Exception e)
            {

                throw e;
            }
        }
    }
}

