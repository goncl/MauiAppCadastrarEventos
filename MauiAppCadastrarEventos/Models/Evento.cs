using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppCadastrarEventos.Models
{
    public class Evento
    {
        public string NomeEvento { get; set; }

        public int NumeroParticipantes { get; set; }

        public string LocalEvento { get; set; }

        public double ValorParticipante { get; set; }
    }
}
