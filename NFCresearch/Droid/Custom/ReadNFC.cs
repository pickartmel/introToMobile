using System;
using System.Text;
using Android.App;
using Android.Content;
using Android.Nfc;
using Android.OS;

namespace NFCresearch.Custom
{
    [Activity(Label = "NfcActivity")]
    public class ReadNFC : Activity
    {
        public ReadNFC()
        {

        }

        private NfcAdapter _nfcAdapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            _nfcAdapter = NfcAdapter.GetDefaultAdapter(this);
        }

        protected override void OnResume()
        {
            base.OnResume();
            if (_nfcAdapter == null)
            {
                var alert = new AlertDialog.Builder(this).Create();
                alert.SetMessage("NFC is not supported on this device.");
                alert.SetTitle("NFC Unavailable");
                alert.Show();
            }
            else
            {
                var tagDetected = new IntentFilter(NfcAdapter.ActionNdefDiscovered);
                var filters = new[] { tagDetected };
                var intent = new Intent(this, this.GetType()).AddFlags(ActivityFlags.SingleTop);
                var pendingIntent = PendingIntent.GetActivity(this, 0, intent, 0);
                _nfcAdapter.EnableForegroundDispatch(this, pendingIntent, filters, null);

            }
        }


        protected override void OnNewIntent(Intent intent)
        {
            if (intent.Action == NfcAdapter.ActionTagDiscovered)
            {
                var tag = intent.GetParcelableExtra(NfcAdapter.ExtraNdefMessages) as Tag;
                if (tag != null)
                {
                    //first get all the NdefMessage
                    var rawMessages = intent.GetParcelableArrayExtra(NfcAdapter.ExtraNdefMessages);
                    if (rawMessages != null)
                    {
                        var msg = (NdefMessage)rawMessages[0];

                        //Get NdefRecord which contains the actual data
                        var record = msg.GetRecords()[0];
                        if (record != null)
                        {
                            if (record.Tnf == NdefRecord.TnfWellKnown)
                            {
                                //get the transfered data
                                var data = Encoding.ASCII.GetString(record.GetPayload());
                            }
                        }
                    }
                }

            }
        }
    }
}