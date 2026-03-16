using Newtonsoft.Json;

namespace Biblio
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            loadDataFromAPI();

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

    }
}