using MauiAppCadastrarEventos.Models;
using System.Linq;
using System.Diagnostics;


namespace MauiAppCadastrarEventos.Views;

public partial class CadastrarEventos : ContentPage
{
    App PropriedadesApp;
	public CadastrarEventos()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_nome_evento.ItemsSource = PropriedadesApp.lista_eventos;

        dtpck_Inicio.MinimumDate = DateTime.Now;
        dtpck_Inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 6, DateTime.Now.Day);

        dtpck_Termino.MinimumDate = dtpck_Inicio.Date.AddDays(1);
        dtpck_Termino.MaximumDate = dtpck_Inicio.Date.AddMonths(1);

        var locais = PropriedadesApp.lista_eventos
                    .Where(e => !string.IsNullOrWhiteSpace(e.LocalEvento))
                    .Select(e => e.LocalEvento)
                    .Distinct()
                    .ToList();

        pck_local_evento.ItemsSource = locais;

    }

    private async void BtnCadastrar_Clicked(object sender, EventArgs e)
    {
        try
        {
            int qtdParticipantes = (int)stp_participantes.Value;

            // Verifica se o campo está vazio ou nulo, e define 0.00 como padrão
            string valorTexto = string.IsNullOrWhiteSpace(custoParticipanteEntry.Text)
                                ? "0.00"
                                : custoParticipanteEntry.Text.Replace(",", ".");

            // Tenta converter
            double valorParticipante = double.Parse(valorTexto);

            Cadastro c = new Cadastro
            {
                EventoSelecionado = (Evento)pck_nome_evento.SelectedItem,
                DataInicio = dtpck_Inicio.Date,
                DataTermino = dtpck_Termino.Date,
                QtdParticipantes = qtdParticipantes,
                LocalEvento = (string)pck_local_evento.SelectedItem,
                ValorParticipante = valorParticipante,
            };

            await Navigation.PushAsync(new EventoCadastrado()
            {
                BindingContext = c
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", $"Erro ao cadastrar: {ex.Message}", "OK");
        }
    }

    private void dtpck_Inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_inicio = elemento.Date;

        DateTime novaDataInicio = e.NewDate;

        dtpck_Termino.MinimumDate = data_selecionada_inicio.AddDays(1);
        dtpck_Termino.MaximumDate = data_selecionada_inicio.AddMonths(1);

        // Corrige se a data de término atual estiver fora do novo intervalo
        if (dtpck_Termino.Date <= novaDataInicio)
        {
            dtpck_Termino.Date = novaDataInicio.AddDays(1);
        }
        else if (dtpck_Termino.Date > dtpck_Termino.MaximumDate)
        {
            dtpck_Termino.Date = dtpck_Termino.MaximumDate;
        }
    }
}