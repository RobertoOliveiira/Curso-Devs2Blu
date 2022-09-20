using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio5();
        }
        static void Exercicio1(){
            string fruta;

            Console.WriteLine("Qual fruta voce deseja:");
            Console.WriteLine("Maçã");
            Console.WriteLine("kiwi");
            Console.WriteLine("Melancia");
            fruta = Console.ReadLine();

            switch (fruta.ToUpper())
            {
                case "MAÇÃ":
                    Console.WriteLine("Não vendemos esta fruta aqui");
                    break;
                case "KIWI":
                    Console.WriteLine("Estamos com escassez de kiwis");
                    break;
                case "MELANCIA":
                    Console.WriteLine("Aqui está, são 3 reais o quilo");
                    break;

                default:
                    Console.WriteLine("fruta invalida");
                    break;
            }
        }
        static void Exercicio2()
        {
            string modelo;

            Console.WriteLine("Qual modelo voce deseja:");
            Console.WriteLine("- Hatch");
            Console.WriteLine("- Sedans");
            Console.WriteLine("- MotocicletaS");
            Console.WriteLine("- Caminhonetes");
            Console.WriteLine("");
            modelo = Console.ReadLine();

            switch (modelo.ToUpper())
            {
                case "HACTH":
                    Console.WriteLine("Compra efetuada com sucesso");
                    break;
                case "SEDANS":
                case "MOTOCICLETAS":
                case "CAMINHONETAS":
                    Console.WriteLine("Tem certeza que não prefere este modelo ?");
                    break;

                default:
                    Console.WriteLine("Não trabalhamos com este tipo de automóvel aqui");
                    break;
            }
        }

        static void Exercicio3()
        {
            string operaçao, aux;
            int valor1, valor2;

            Console.WriteLine("Qual operação voce deseja:");
            operaçao = Console.ReadLine();

            Console.WriteLine("Qual o primeiro valor");
            aux = Console.ReadLine();
            Int32.TryParse(aux, out valor1);

            Console.WriteLine("Qual o segundo valor");
            aux = Console.ReadLine();
            Int32.TryParse(aux, out valor2);

            switch (operaçao)
            {
                case ("+"):
                    Console.WriteLine(valor1 + valor2);
                    break;

                case ("-"):
                    Console.WriteLine(valor1 - valor2);
                    break;

                case ("/"):
                    Console.WriteLine(valor1 / valor2);
                    break;

                case ("*"):
                    Console.WriteLine(valor1 * valor2);
                    break;
            }

        }

        static void Exercicio4()
        {
            string tipo;

            Console.WriteLine("Qual tipo de produto voce deseja:");
            Console.WriteLine("Produtos não pereciveis");
            Console.WriteLine("Frutas");
            Console.WriteLine("Bebidas");
            tipo = Console.ReadLine();

            switch (tipo.ToLower())
            {
                case "produtos não pereciveis":
                    Console.WriteLine("arroz, feijão, café");
                    break;
                case "frutas":
                    Console.WriteLine("manga, banana, maçã");
                    break;
                case "bebidas":
                    Console.WriteLine("leite, sucos, refrigerantes");
                    break;

                default:
                    Console.WriteLine("Código invalido");
                    break;
            }
        }

        static void Exercicio5()
        {
            int valor, ptJogador, ptComputador;
            string aux;
            Random rand = new Random();
            int numeroAleatorio = rand.Next(1, 20);

            Console.WriteLine("Digite um numero para nosso jogo");
            aux = Console.ReadLine();
            Int32.TryParse(aux, out valor);

            valor += numeroAleatorio;

            /*switch (valor)
            {
                case 1:
                case 2:
                case 3: 
                case 4: 
                case 5:
                case 6:
                    Console.WriteLine("Você ganhou 1 ponto");
                    ptJogador = 1;
                    break;
                case 7:
                    Console.WriteLine("Você ganhou 10 pontos");
                    ptJogador = 10;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    Console.WriteLine("Você ganhou 5 pontos");
                    ptJogador = 5;
                    break;
                case 14:
                    Console.WriteLine("Você ganhou 20 pontos");
                    ptJogador = 20;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    Console.WriteLine("Você ganhou 6 pontos");
                    ptJogador = 6;
                    break;
                case 21:
                    Console.WriteLine("Você ganhou 30 pontos");
                    ptJogador = 30;
                    break;
                default:
                    Console.WriteLine("Você passou dos 21 e perdeu!!");
                    ptJogador = 0;
                    break;
            }*/

            switch (valor)
            {
                case int i when (i <= 6):
                    Console.WriteLine("Você ganhou 1 ponto");
                    ptJogador = 1;
                    break;
                case 7:
                    Console.WriteLine("Você ganhou 10 pontos");
                    ptJogador = 10;
                    break;
                case int i when (i >= 8 && i <= 13):
                    Console.WriteLine("Você ganhou 5 pontos");
                    ptJogador = 5;
                    break;
                case 14:
                    Console.WriteLine("Você ganhou 20 pontos");
                    ptJogador = 20;
                    break;
                case int i when (i >= 15 && i <= 20):
                    Console.WriteLine("Você ganhou 6 pontos");
                    ptJogador = 6;
                    break;
                case 21:
                    Console.WriteLine("Você ganhou 30 pontos");
                    ptJogador = 30;
                    break;
                default:
                    Console.WriteLine("Você passou dos 21 e perdeu!!");
                    ptJogador = 0;
                    break;

            }

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Round do computador");
            int valorComputador = rand.Next(1, 21);

            valorComputador += numeroAleatorio;

            /*switch (valorComputador)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Computador ganhou 1 ponto");
                    ptComputador = 1;
                    break;
                case 7:
                    Console.WriteLine("Computador ganhou 10 pontos");
                    ptComputador = 10;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    Console.WriteLine("Computador ganhou 5 pontos");
                    ptComputador = 5;
                    break;
                case 14:
                    Console.WriteLine("Computador ganhou 20 pontos");
                    ptComputador = 20;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    Console.WriteLine("Computador ganhou 6 pontos");
                    ptComputador = 6;
                    break;
                case 21:
                    Console.WriteLine("Computador ganhou 30 pontos");
                    ptComputador = 30;
                    break;
                default:
                    Console.WriteLine("Computador passou dos 21 e perdeu!!");
                    ptComputador = 0;
                    break;
            }*/

            switch (valorComputador)
            {
                case int i when (i <= 7):
                    Console.WriteLine("Computador ganhou 1 ponto");
                    ptComputador = 1;
                    break;
                case 7:
                    Console.WriteLine("Computador ganhou 10 pontos");
                    ptComputador = 10;
                    break;
                case int i when (i >= 8 && i <= 13):
                    Console.WriteLine("Computador ganhou 5 pontos");
                    ptComputador = 5;
                    break;
                case 14:
                    Console.WriteLine("Computador ganhou 20 pontos");
                    ptComputador = 20;
                    break;
                case int i when (i >= 15 && i <= 20):
                    Console.WriteLine("Computador ganhou 6 pontos");
                    ptComputador = 6;
                    break;
                case 21:
                    Console.WriteLine("Computador ganhou 30 pontos");
                    ptComputador = 30;
                    break;
                default:
                    Console.WriteLine("Computador passou dos 21 e perdeu!!");
                    ptComputador = 0;
                    break;

            }

            Console.WriteLine("");
            if(ptJogador > ptComputador)
            {
                Console.WriteLine("Você venceu!!!!!");
            }
            else if(ptComputador > ptJogador)
            {
                Console.WriteLine("Computador Venceu");
            }
            else
            {
                Console.WriteLine("Os dois empataram");
            }

        }

    }
}
