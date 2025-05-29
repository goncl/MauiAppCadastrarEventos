using System.Globalization;

namespace MauiAppCadastrarEventos.Models
{
    public class Cadastro
    {
        public Evento EventoSelecionado { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public int QtdParticipantes { get; set; }

        public string LocalEvento { get; set; }

        public double ValorParticipnate { get; set; }

        public int Duracao 
        { 
            get => DataTermino.Subtract(DataInicio).Days;
        }

        public double ValorTotal
        {
            get
            {
                double total = QtdParticipantes * ValorParticipnate * Duracao;
                return total;
            }
        }
    }
}
