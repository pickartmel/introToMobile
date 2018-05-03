using Android.App;
using Android.Widget;
using Android.OS;
using Android.Nfc;
using Poz1.NFCForms.Droid;
using Poz1.NFCForms.Abstract;
using Android.Content;

namespace NFCsample
{
    [Activity(Label = "NFCsample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        public NfcAdapter NFCdevice;
        public NfcForms x;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            NfcManager NfcManager = (NfcManager)Android.App.Application.Context.GetSystemService(Context.NfcService);
            NFCdevice = NfcManager.DefaultAdapter;

            Xamarin.Forms.DependencyService.Register<INfcForms, NfcForms>();
            x = Xamarin.Forms.DependencyService.Get<INfcForms>() as NfcForms;
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

