using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Aula6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            do
            {
                Console.WriteLine("informe o codigo para entrar em um exercicio:");
                Console.WriteLine("1 - Exercicio 1");
                Console.WriteLine("2 - Exercicio 2");
                Console.WriteLine("3 - Exercicio 3");
                Console.WriteLine("4 - Exercicio 4");
                Console.WriteLine("5 - Exercicio 5");
                Console.WriteLine("6 - Exercicio 6");
                Console.WriteLine("7 - Exercicio 7");
                Console.WriteLine("0 - Para sair");
                Int32.TryParse(Console.ReadLine(), out codigo);
                switch (codigo)
                {
                    case 1: Exercicio1();
                        Console.WriteLine("----------------------------------------------------------------");
                        break;
                    case 2: Exercicio2();
                        Console.WriteLine("----------------------------------------------------------------");
                        break;
                    case 3: Exercicio3();
                        Console.WriteLine("----------------------------------------------------------------");
                        break;
                    case 4:
                        Exercicio4();
                        Console.WriteLine("----------------------------------------------------------------");
                        break;
                    case 5:
                        Exercicio5();
                        Console.WriteLine("----------------------------------------------------------------");
                        break;
                    case 6:
                        Exercicio6();
                        Console.WriteLine("----------------------------------------------------------------");
                        break;
                    case 7:
                        Exercicio7();
                        Console.WriteLine("----------------------------------------------------------------");
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            } while (codigo > 0);
        }

        static void Exercicio1()
        {
            int valor = 0;
            while(valor != 100)
            {
                if(valor %2 == 0)
                {
                    Console.Write(valor + ", ");
                }
                valor++;
            }
        }

        static void Exercicio2()
        {
            int valor = 0;
            while (valor != 100)
            {
                if (valor % 2 != 0)
                {
                    Console.Write(valor+ ", ");
                }
                valor++;
            }
        }

        static void Exercicio3()
        {
            int valor = 0;
            Console.WriteLine("Informe um valor:");
            Int32.TryParse(Console.ReadLine(), out int valInformado);
            String impares ="", pares= "";
            while (valor != valInformado)
            {
                if (valor % 2 != 0)
                {
                    impares += (valor + ", "); 
                }
                else
                {
                    pares += (valor + ", ");
                }
                valor++;
                if (valor == 50)
                {
                    impares += "\n";
                    pares += "\n";
                }
            }
            Console.WriteLine("Valores pares são:");
            Console.WriteLine(pares);
            Console.WriteLine("");
            Console.WriteLine("Valores impares são:");
            Console.WriteLine(impares);
        }
        static void Exercicio4()
        {
            Console.WriteLine("Informe quanto alunos tem na classe:");
            Int32.TryParse(Console.ReadLine().Trim(), out int quantidade);
            int aux = 0, notaTotal = 0;
            while(aux != quantidade)
            {
                aux++;
                Console.WriteLine("Informe a nota do "+ aux+"° aluno:");
                Int32.TryParse(Console.ReadLine().Trim(), out int nota);
                notaTotal += nota;
            }

            Console.WriteLine("A media da sala é: " + notaTotal/quantidade);

        }
        static void Exercicio5()
        {
            int valor = 0;
            String linha ="", coluna = "";
            while(valor != 20)
            {
                linha += valor + ", ";
                coluna += valor + "\n";
                valor++;
            }

            Console.WriteLine("Valores em linha: \n" + linha );
            Console.WriteLine("Valores em coluna:\n " + coluna);
        }

        static void Exercicio6()
        {
            int valor = 1000;

            while (valor != 1999)
            {
                if(valor %11 == 5)
                {
                    Console.WriteLine(valor);
                }
                valor ++;
            }
        }

        static void Exercicio7()
        {
            Random rand = new Random();
            int valor = rand.Next(1,20);
            int repetir = 3;
            while(repetir != 0)
            {
                Console.WriteLine("Voce possui "+ repetir+" chances para acertar qual o numero:");
                Int32.TryParse(Console.ReadLine(), out int tentativa);
                if(tentativa == valor)
                {
                    Console.WriteLine("Parabens você acertou!");
                    break;
                }
                else
                {
                    Console.WriteLine("Erroooooouuu");
                }
                repetir--;
            }
            Console.WriteLine("O numero era: "+ valor);
        }
    }

}
