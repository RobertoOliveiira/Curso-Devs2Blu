﻿using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Utils
{
    public class Mocks
    {
        public List<Paciente> ListaPacientes { get; set; }
        public List<Medico> ListaMedicos { get; set; }
        public List<Recepcionista> ListaRecepcionistas { get; set; }
        public List<Fornecedor> ListaFornecedores { get; set; }

        public Mocks()
        {
            ListaPacientes = new List<Paciente>();
            ListaMedicos = new List<Medico>();
            ListaRecepcionistas = new List<Recepcionista>();
            ListaFornecedores = new List<Fornecedor>();

            CargaMock();
        }
        public void CargaMock()
        {
            CargaPacientes();
            CargaMedicos();
            CargaFornecedor();
            CargaRecepcionista();

        }

        public void CargaPacientes()
        {
            for (int i = 0; i < 10; i++)
            {
                Paciente paciente = new Paciente(i, $"Paciente {i + 1}", $"{i}23{i}56{i}891{i}", "Unimed");
                ListaPacientes.Add(paciente);
            }
        }

        public void CargaMedicos()
        {
            Random rd = new Random();
            String[] especialidades = { "Clínico Geral", "Neurologista", "Ginecologista", "Pediatra" };
            for (int i = 0; i < 4; i++)
            {
                Medico medico = new Medico(i, $"Médico {i + 1}", $"{i + rd.Next(0, 5)}23{i + rd.Next(0, 5)}56{i + rd.Next(0, 5)}891{i + rd.Next(0, 5)}", rd.Next(321, 789), especialidades[rd.Next(0, 3)]);
                ListaMedicos.Add(medico);
            }
        }
        public void CargaRecepcionista()
        {
            Random rd = new Random();
            String[] especialidades = { "Recepcionista Geral", "Recepcionista de Neurologista", "Recepcionista de Ginecologista", "Recepcionista de Pediatra" };
            for (int i = 0; i < 4; i++)
            {
                Recepcionista recepcionista = new Recepcionista(i, $"Recepcionista {i + 1}", $"{i + rd.Next(0, 5)}23{i + rd.Next(0, 5)}56{i + rd.Next(0, 5)}891{i + rd.Next(0, 5)}", especialidades[rd.Next(0, 3)]);
                ListaRecepcionistas.Add(recepcionista);
            }
        }
        public void CargaFornecedor()
        {
            Random rd = new Random();
            String[] tipoFornecedor = { "Clínico Geral", "Neurologista", "Ginecologista", "Pediatra" };
            for (int i = 0; i < 4; i++)
            {
                Fornecedor fornecedor = new Fornecedor(i, $"Fornecedor {i + 1}", $"{i + rd.Next(0, 5)}23{i + rd.Next(0, 5)}56{i + rd.Next(0, 5)}891{i + rd.Next(0, 5)}", tipoFornecedor[rd.Next(0, 3)]);
                ListaFornecedores.Add(fornecedor);
            }
        }
    }
}
