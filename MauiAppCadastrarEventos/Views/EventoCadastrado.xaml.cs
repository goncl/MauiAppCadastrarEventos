namespace MauiAppCadastrarEventos.Views;

public partial class EventoCadastrado : ContentPage
{
	public EventoCadastrado()
	{
		InitializeComponent();
	}

    private async void Btn_voltar_Clicked(object sender, EventArgs e)
    {
		try
		{
			await Navigation.PopAsync();

		}catch (Exception ex)
		{
            await DisplayAlert("OPS", ex.Message, "OK");
        }
    }
}