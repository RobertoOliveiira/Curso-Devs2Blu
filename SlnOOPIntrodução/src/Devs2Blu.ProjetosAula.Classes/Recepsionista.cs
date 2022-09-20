using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Classes
{
    internal class Recepcionista : Pessoa
    {
        public int NumeroCracha { get; set; }

        public string AgendarConsulta()
        {
            return $"Consulta Agendada";
        }
    }
}
