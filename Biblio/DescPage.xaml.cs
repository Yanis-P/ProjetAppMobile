using Newtonsoft.Json;

namespace Biblio;

public partial class DescPage : ContentPage
{
	public DescPage()
	{
		InitializeComponent();
	}

    async private void LogIn(object sender, EventArgs e)
    {
        HttpClient client = new HttpClient();
        var restURL = "http://localhost:5034/LogIn?pseudo=" + logIn.Text + "&pass=" + mdp.Text;
        client.BaseAddress = new Uri(restURL);
        HttpResponseMessage response = await client.GetAsync(restURL);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            if (Convert.ToBoolean(content))
            {
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Alerte", "Connexion user refusée", "Cancel");
            }
        }

        else
        {
            await DisplayAlert("Alerte", "Pas de connexion avec l'API", "Cancel");
        }

    }
}