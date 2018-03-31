using System.Net.Http;
using Xamarin.Forms;
using System;
using Marathon.Data;
using Newtonsoft.Json;

namespace Marathon
{
    public partial class MarathonPage : ContentPage

    {
        RaceColletction RaceObject;

        public MarathonPage()
        {
            InitializeComponent();
        }
        //grab marathon info - want to wait until after its initilized

        protected override void OnAppearing()
        {
            base.OnAppearing();
            FillPicker();
        }
        protected void FillPicker()
        {
            //need a client
            var client = new HttpClient();
            //needs a base address
            client.BaseAddress = new Uri("http://itweb.fvtc.edu/wetzel/marathon/");
            var response = client.GetAsync("races/").Result;
            var wsJson = response.Content.ReadAsStringAsync().Result;

            RaceObject = JsonConvert.DeserializeObject<RaceColletction>(wsJson);

            if(RaceObject != null)
            {
                RacePicker.Items.Clear();
                foreach (Race CurrentRace in RaceObject.races)
                {
                    RacePicker.Items.Add(CurrentRace.race_name);
                }
            }
        }

        void Race_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var SelectedRace = ((Xamarin.Forms.Picker)sender).SelectedIndex;
            var RaceID = RaceObject.races[SelectedRace].id;


            var client = new HttpClient();
            client.BaseAddress = new Uri("http://itweb.fvtc.edu/wetzel/marathon/");
            var response = client.GetAsync("results/" + RaceID).Result;
            var wsJson = response.Content.ReadAsStringAsync().Result;


            var ResultObject = JsonConvert.DeserializeObject<ResultsCollection>(wsJson);

            var CellTemplate = new DataTemplate(typeof(TextCell));
            CellTemplate.SetBinding(TextCell.TextProperty, "name");
            CellTemplate.SetBinding(TextCell.DetailProperty, "detail");
            ResultListView.ItemTemplate = CellTemplate;
            ResultListView.ItemsSource = ResultObject.results;
        }
    }
}
