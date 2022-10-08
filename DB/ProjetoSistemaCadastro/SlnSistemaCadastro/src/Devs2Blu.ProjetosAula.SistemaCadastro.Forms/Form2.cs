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
    public partial class Form2 : Form
    {
        private readonly Form1 _parent;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form)
        {
            InitializeComponent();
            _parent = form;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            _parent.ConvenioRepository.Cadastrar(textBoxNome.Text);
            Close();
        }

        private void buttonCacelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
