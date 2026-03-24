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
                var restUrlCat = "http://localhost:5034/Categorie";
                client.BaseAddress = new Uri(restUrlCat);
                HttpResponseMessage response = await client.GetAsync(restUrlCat);
                var contentCat = await response.Content.ReadAsStringAsync();
                var Items = JsonConvert.DeserializeObject<List<Categorie>>(contentCat);

              
                /*var restUrlLivre = "http://localhost:5034/Livre";
                client.BaseAddress = new Uri(restUrlLivre);
                HttpResponseMessage responseLivre = await client.GetAsync(restUrlLivre);
                var contentLivre = await responseLivre.Content.ReadAsStringAsync();
                var ItemsLivre = JsonConvert.DeserializeObject<List<Livre>>(contentLivre);
                */
                lv.ItemsSource = Items;

                //ItemsLivre = ItemsLivre.Count(livre).ToList();
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