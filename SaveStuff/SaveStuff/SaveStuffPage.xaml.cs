using Xamarin.Forms;

namespace SaveStuff
{
    public partial class SaveStuffPage : ContentPage
    {
        public SaveStuffPage()
        {
            InitializeComponent();
        }

        void Save_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.Properties["UserName"] = txtUserName.Text;
        }

        void Read_Clicked(object sender, System.EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey("UserName"))
            {
                txtUserName.Text = Application.Current.Properties["UserName"].ToString();
            }

        }

        void Clear_Clicked(object sender, System.EventArgs e)
        {
            txtUserName.Text = string.Empty;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Read_Clicked(null,null);

        }
    }
}
