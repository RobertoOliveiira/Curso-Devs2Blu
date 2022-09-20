using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula3.ProjetoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            Console.WriteLine("---------------------Programa 2------------------------");
            Exercicio2();

            



        }
        static void Exercicio1()
        {
            int primeiroValor, segundoValor = 0;
            Console.WriteLine("Primeiro valor:");
            string aux = Console.ReadLine();
            Int32.TryParse(aux, out primeiroValor);

            Console.WriteLine("Segundo valor:");
            aux = Console.ReadLine();
            Int32.TryParse(aux, out segundoValor);

            if (primeiroValor > segundoValor)
            {
                Console.WriteLine(primeiroValor);
            }else if(segundoValor > primeiroValor)
            {
                Console.WriteLine(segundoValor);
            }
            else
            {
                Console.WriteLine("Números são iguais");
            }
        }

        static void Exercicio2()
        {
            int primeiroValor, segundoValor, terceiroValor, quartoValor = 0;
            Console.WriteLine("Primeiro valor:");
            string aux = Console.ReadLine();
            Int32.TryParse(aux, out primeiroValor);

            Console.WriteLine("Segundo valor:");
            aux = Console.ReadLine();
            Int32.TryParse(aux, out segundoValor);

            Console.WriteLine("Terceiro valor:");
            aux = Console.ReadLine();
            Int32.TryParse(aux, out terceiroValor);

            Console.WriteLine("Quarto valor:");
            aux = Console.ReadLine();
            Int32.TryParse(aux, out quartoValor);
            int valorAuxiliar = primeiroValor;

            if(valorAuxiliar> segundoValor)
            {
                valorAuxiliar = segundoValor;   
            }
            if(valorAuxiliar > terceiroValor)
            {
                valorAuxiliar = terceiroValor;
            }
            if(valorAuxiliar > quartoValor)
            {
                valorAuxiliar = quartoValor;
            }

            Console.WriteLine("Maior valor é " + valorAuxiliar);
        }
    }
}
