using MauiAppCadastrarEventos.Models;

namespace MauiAppCadastrarEventos
{
    public partial class App : Application
    {
        public List<Evento> lista_eventos = new List<Evento>
        {
            new Evento()
            {
                NomeEvento = "Evento de Tecnologia",
                LocalEvento = "Expo Center Norte",
            },

            new Evento()
            {
                NomeEvento = "Corrida de rua",
                LocalEvento = "Parque Villa-Lobos",
            },

            new Evento()
            {
                NomeEvento = "Palestra Inteligência Artificial",
                LocalEvento = "Google for Startups Campus",
            },

            new Evento()
            {
                NomeEvento = "Feira Sobre Profissões",
                LocalEvento = "Centro Cultural São Paulo",
            },

            new Evento()
            {
                NomeEvento = "Festival cultural",
                LocalEvento = "Itaú Cultural",
            },

            new Evento()
            {
                NomeEvento = "Exposição de Arte",
                LocalEvento = "MASP – Museu de Arte de SP",
            },

            new Evento()
            {
                NomeEvento = "Evento Mudanças Climáticas",
                LocalEvento = "USP – Universidade de São Paulo",
            },

            new Evento()
            {
                NomeEvento = "Desenvolvimento de Games 2D",
                LocalEvento = "WeWork Faria Lima",
            },

            new Evento()
            {
                NomeEvento = "Palestra Sobre UX/UI Design",
                LocalEvento = "InovaBra Habitat",
            },

            new Evento()
            {
                NomeEvento = "Feira de Robótica Educacional",
                LocalEvento = "Parque Ibirapuera",
            },


        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.CadastrarEventos());

        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 700;

            return window;
        }

    }
}
