namespace MauiAppCadastrarEventos.Views;

public partial class CadastrarEventos : ContentPage
{
	public CadastrarEventos()
	{
		InitializeComponent();
	}

    private async void BtnCadastrar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EventoCadastrado());
    }

}