using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    internal class CadastroRecepcionista : IMenuCadastro
    {
        public CadastroRecepcionista()
        {

        }
        private void ListarRecepcionistas()
        {
            Console.Clear();

            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"CPF: {recepcionista.CGCCPF}");
                Console.WriteLine($"Convenio: {recepcionista.Setor}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }

        private void CadastrarRecepcionista(Recepcionista novoRecepcionista)
        {
            Program.Mock.ListaRecepcionistas.Add(novoRecepcionista);
        }

        private void AlterarRecepcionista(Recepcionista recepcionista)
        {
            var pact = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == recepcionista.CodigoRecepcionista);
            int index = Program.Mock.ListaRecepcionistas.IndexOf(pact);
            Program.Mock.ListaRecepcionistas[index] = recepcionista;
        }

        private void ExcluirRecepcionista(Recepcionista recepcionista)
        {
            Program.Mock.ListaRecepcionistas.Remove(recepcionista);
        }

        private void ListarRecepcionistasByCodeAndName()
        {
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.Write($"| {recepcionista.CodigoRecepcionista} - {recepcionista.Nome} ");
            }
            Console.WriteLine("\n");
        }


        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("---------- Cadastro de Recepcionista ----------");
            Console.WriteLine("-   - 1 -   Lista de Recepcionista        -----");
            Console.WriteLine("-   - 2 - Cadastro de Recepcionista       -----");
            Console.WriteLine("-   - 3 -   Alterar Recepcionista         -----");
            Console.WriteLine("-   - 4 -   Excluir Recepcionista         -----");
            Console.WriteLine("-   - 0 -          Sair                   -----");
            Console.WriteLine("-----------------------------------------------");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            ListarRecepcionistas();
        }

        public void Cadastrar()
        {
            Console.Clear();
            Recepcionista recepcionista = new Recepcionista();
            Console.WriteLine("Informe o Nome do Recepcionista");
            recepcionista.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do Recepcionista");
            recepcionista.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o setor da Recepcionista");
            recepcionista.Setor = Console.ReadLine();

            Random rd = new Random();
            recepcionista.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            recepcionista.CodigoRecepcionista = Int32.Parse($"{recepcionista.Codigo}{rd.Next(100, 999)}");

            CadastrarRecepcionista(recepcionista);
        }

        public void Alterar()
        {
            Console.Clear();
            Recepcionista recepcionista;
            int codigoRecepcionista;

            Console.WriteLine("Informe o Recepcionista que Deseja Alterar:\n");
            ListarRecepcionistasByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

            recepcionista = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == codigoRecepcionista);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Informações da recepcionista: {recepcionista.Codigo}/{recepcionista.CodigoRecepcionista} | Nome: {recepcionista.Nome} | CPF: {recepcionista.CGCCPF} | Setor: {recepcionista.Setor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 Setor | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        recepcionista.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        recepcionista.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo setor:");
                        recepcionista.Setor = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;
                }

                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Dado Alterado com Sucesso!");
                }
            } while (alterar);

            AlterarRecepcionista(recepcionista);
        }

        public void Excluir()
        {
            Console.Clear();
            Recepcionista recepcionista;
            int codigoRecepcionista;

            Console.WriteLine("| Lista de Recepcionistas: ");
            ListarRecepcionistasByCodeAndName();
            Console.WriteLine("| Informe o código do recepcionista que deseja excluir: ");
            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

            recepcionista = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == codigoRecepcionista);


            ExcluirRecepcionista(recepcionista);
        }

        #endregion
    }
}
