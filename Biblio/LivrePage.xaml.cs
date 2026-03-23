using Newtonsoft.Json;

namespace Biblio;

public partial class LivrePage : ContentPage
{
	public LivrePage()
	{
		InitializeComponent();

        loadDataFromAPI();

    }

    public async void loadDataFromAPI()
    {

        try
        {
            HttpClient client = new HttpClient();
            var restURL = "http://localhost:5034/Livres";
            client.BaseAddress = new Uri(restURL);
            HttpResponseMessage response = await client.GetAsync(restURL);
            var content = await response.Content.ReadAsStringAsync();
            var Items = JsonConvert.DeserializeObject<List<Categorie>>(content);
            livres.ItemsSource = Items;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

        async private void livres_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Livre l = (Livre)livres.SelectedItem;

        await DisplayAlert("Alerte", "Nom: " + c.Name, "OK");
    }
}