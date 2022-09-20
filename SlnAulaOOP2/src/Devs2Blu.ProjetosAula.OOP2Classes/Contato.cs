using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP2Classes
{
    public class Contato
    {
        public String Nome { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String CEP { get; set; }
        public String Rua { get; set; }
        public int Numero { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }

        public Contato()
        {

        }
        public Contato(String nome, String phone, String email, String cep, String rua, int numero , String bairro, String cidade, String estado)
        {
            this.Nome = nome;
            this.Phone = phone; 
            this.Email = email;
            this.CEP = cep;
            this.Rua = rua;
            this.Bairro = bairro;
            this.Numero = numero;
            this.Cidade = cidade;   
            this.Estado = estado;

        }
    }
}
