namespace Biblio;

public partial class DescPage : ContentPage
{
	public DescPage()
	{
		InitializeComponent();
	}

    async private void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}