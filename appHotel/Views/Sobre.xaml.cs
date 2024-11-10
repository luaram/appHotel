namespace appHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}
	private async void BotaoInicial(object sender, EventArgs e)
	{
		await Navigation.PushAsync (new ContratacaodaHospedagem ());
	}
}