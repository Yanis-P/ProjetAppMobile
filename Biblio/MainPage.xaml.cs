using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Biblio
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

            loadDataFromAPI();

        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DescPage());
        }

        public async void loadDataFromAPI()
        {

            try
            {
                HttpClient client = new HttpClient();
                var restURL = "http://localhost:5034/Categorie";
                client.BaseAddress = new Uri(restURL);
                HttpResponseMessage response = await client.GetAsync(restURL);
                var content = await response.Content.ReadAsStringAsync();
                var Items = JsonConvert.DeserializeObject<List<Categorie>>(content);
                lv.ItemsSource = Items;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        async private void lv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Categorie c = (Categorie)lv.SelectedItem;

            BindingContext = lv.SelectedItem;
            await Navigation.PushAsync(new LivrePage(c)
            {
                BindingContext = lv.SelectedItem
            });



        }
    }
}