using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devs2Blu.ProjetosAula.OOP2Classes;

namespace Devs2Blu.ProjetosAula.AulaOOP2
{
    public partial class Form1 : Form
    {
        public List<Contato> Contatos { get; set; }
        public Form1()
        {
            InitializeComponent();
            Contatos = new List<Contato>();
        }
        #region Event
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidaForm())
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Cadastro de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Contatos.Add(new Contato(textBoxNome.Text,
                textBoxTele.Text,
                textBoxEmail.Text,
                textBoxCep.Text,
                textBoxRua.Text,
                Int32.Parse(textBoxNumero.Text),
                textBoxBairro.Text,
                textBoxCidade.Text,
                textBoxEstado.Text));
            MessageBox.Show($"Novo contato {textBoxNome.Text} cadastrado com sucesso", "Cadastro de Contatos", MessageBoxButtons.OK);
            Limpar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
            foreach(Contato contato in Contatos)
            {
                txtConsole.Text += $"Contato: {contato.Nome} \r\n";
            }
        }

        private void textBoxCep_TextChanged(object sender, EventArgs e)
        {
            if(textBoxCep.Text.Length == 8)
            {

            }
            else
            {
                textBoxEstado.Clear();
                textBoxCidade.Clear();
                textBoxBairro.Clear();
                textBoxRua.Clear();
            }
        }
        #endregion

        #region Metodos
        public void Limpar()
        {
            textBoxNome.Clear();
            textBoxEstado.Clear();
            textBoxTele.Clear();
            textBoxNumero.Clear();
            textBoxCidade.Clear();
            textBoxBairro.Clear();
            textBoxRua.Clear();
            textBoxCep.Clear();
            textBoxEmail.Clear();
        }
        public bool ValidaForm()
        {
            if (textBoxNome.Text.Equals("")) return false;
            if (textBoxEstado.Text.Equals("")) return false;
            if (textBoxTele.Text.Equals("")) return false;
            if (textBoxNumero.Text.Equals("")) return false;
            if (textBoxCidade.Text.Equals("")) return false;
            if (textBoxBairro.Text.Equals("")) return false;
            if (textBoxRua.Text.Equals("")) return false;
            if (textBoxCep.Text.Equals("")) return false;
            if (textBoxEmail.Text.Equals("")) return false;
            return true;
        }
        #endregion

        
    }
}
