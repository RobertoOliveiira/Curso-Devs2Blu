using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    public partial class Form1 : Form
    {
        public MySqlConnection Conn { get; set; }
        public ConvenioRepository ConvenioRepository = new ConvenioRepository();
        public PessoaRepository PessoaRepository = new PessoaRepository();
        public EnderecoRepository EnderecoRepository = new EnderecoRepository();
        public PacienteRepository PacienteRepository = new PacienteRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region TesteConexao
            /*Conn = ConnectionMySQL.GetConnection();

            if (Conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexão efetuada com sucesso!", "Conexão ao MySQL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Conn.Close();
            }*/
            #endregion
            PopulaComboConvenio();
            CarregarListView();
            
        }

        #region Methods
        private void CarregarListView()
        {
            listViewPacientes.View = View.Details;
            listViewPacientes.GridLines = true;
            listViewPacientes.Columns.Add("Pacientes", 150, HorizontalAlignment.Left);
            listViewPacientes.Columns.Add("CPF", 150, HorizontalAlignment.Left);
            listViewPacientes.Columns.Add("Id", 30, HorizontalAlignment.Left);
        }
        private void PopulaComboConvenio()
        {
            var listConvenios = ConvenioRepository.FetchAll();

            cboConvenio.DataSource = new BindingSource(listConvenios, null);
            cboConvenio.DisplayMember = "nome";
            cboConvenio.ValueMember = "id";
            listConvenios.Close();
        }
        public String ValidaForm()
        {
            if (textBoxNome.Text.Equals("")) return "O campo nome é obrigatório";
            if (textBoxDocument.Text.Equals("")) return "O campo documento é obrigatório";
            if (cboConvenio.Text.Equals("")) return "O campo convenio é obrigatório";
            if (textBoxCidade.Text.Equals("")) return "O campo cidade é obrigatório";
            if (textBoxBairro.Text.Equals("")) return "O campo bairro é obrigatório";
            if (textBoxRua.Text.Equals("")) return "O campo rua é obrigatório";
            if (textBoxNumero.Text.Equals("")) return "O campo numero é obrigatório";
            if (!(rdFisica.Checked || rdJuridica.Checked)) return "Selecione o tipo de usuário";
            return "";
        }
        #endregion

        #region Events
        private void rdFisica_CheckedChanged(object sender, EventArgs e)
        {
            LblDocument.Text = "CPF";
            LblDocument.Visible = true;
        }

        private void rdJuridica_CheckedChanged(object sender, EventArgs e)
        {
            LblDocument.Text = "CNPJ";
            LblDocument.Visible = true;
        }

        private void cboConvenio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidaForm().Equals(""))
            {
                int pessoaId = PessoaRepository.Cadastrar(textBoxNome.Text, textBoxDocument.Text.Replace(',','.'), rdFisica.Checked);
                EnderecoRepository.Cadastrar(textBoxCep.Text, textBoxRua.Text, Int32.Parse(textBoxNumero.Text),
                    textBoxBairro.Text, textBoxCidade.Text, comboBoxUF.Text, pessoaId);
                PacienteRepository.Cadastrar(0,"não",pessoaId, cboConvenio.SelectedIndex +1);
            }
            else
            {
                MessageBox.Show(ValidaForm(), "Cadastro de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show($"Usuário {textBoxNome.Text} cadastrado com sucesso", "Cadastro de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonCadConv_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }
        #endregion

        private void buttonListar_Click(object sender, EventArgs e)
        {
            var listPacientes = PessoaRepository.FetchAll();

            ListViewItem lvl;

            while (listPacientes.Read())
            {
                lvl = new ListViewItem(listPacientes.GetString("nome"));
                lvl.SubItems.Add(listPacientes.GetString("cgccpf"));
                lvl.SubItems.Add(listPacientes.GetString("id"));
                listViewPacientes.Items.Add(lvl);
            }
            listPacientes.Close();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            textBoxDocument.Clear();
            textBoxCep.Clear();
            textBoxCidade.Clear();
            textBoxBairro.Clear();
            textBoxRua.Clear();
            textBoxNumero.Clear();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
