
namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonCadastrarConvenio = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listViewPacientes = new System.Windows.Forms.ListView();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblDocument = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdJuridica = new System.Windows.Forms.RadioButton();
            this.rdFisica = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboConvenio = new System.Windows.Forms.ComboBox();
            this.comboBoxUF = new System.Windows.Forms.ComboBox();
            this.textBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.textBoxDocument = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNumero = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDocument);
            this.groupBox1.Controls.Add(this.buttonAlterar);
            this.groupBox1.Controls.Add(this.buttonCadastrarConvenio);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.buttonLimpar);
            this.groupBox1.Controls.Add(this.buttonListar);
            this.groupBox1.Controls.Add(this.buttonCadastrar);
            this.groupBox1.Controls.Add(this.textBoxNome);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.LblDocument);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboConvenio);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 400);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulário de Cadastro";
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(364, 193);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 49);
            this.buttonAlterar.TabIndex = 18;
            this.buttonAlterar.Text = "Alterar Selecionado";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonCadastrarConvenio
            // 
            this.buttonCadastrarConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrarConvenio.Location = new System.Drawing.Point(283, 84);
            this.buttonCadastrarConvenio.Name = "buttonCadastrarConvenio";
            this.buttonCadastrarConvenio.Size = new System.Drawing.Size(30, 22);
            this.buttonCadastrarConvenio.TabIndex = 17;
            this.buttonCadastrarConvenio.Text = "+";
            this.buttonCadastrarConvenio.UseVisualStyleBackColor = true;
            this.buttonCadastrarConvenio.Click += new System.EventHandler(this.buttonCadConv_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.listViewPacientes);
            this.groupBox4.Location = new System.Drawing.Point(445, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 362);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pacientes";
            // 
            // listViewPacientes
            // 
            this.listViewPacientes.HideSelection = false;
            this.listViewPacientes.Location = new System.Drawing.Point(6, 19);
            this.listViewPacientes.Name = "listViewPacientes";
            this.listViewPacientes.Size = new System.Drawing.Size(276, 337);
            this.listViewPacientes.TabIndex = 0;
            this.listViewPacientes.UseCompatibleStateImageBehavior = false;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(106, 317);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 16;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(8, 317);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 23);
            this.buttonListar.TabIndex = 15;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(204, 317);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 14;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(120, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(144, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.textBoxNumero);
            this.groupBox3.Controls.Add(this.textBoxCep);
            this.groupBox3.Controls.Add(this.comboBoxUF);
            this.groupBox3.Controls.Add(this.textBoxCidade);
            this.groupBox3.Controls.Add(this.textBoxBairro);
            this.groupBox3.Controls.Add(this.textBoxRua);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 186);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço/Contato";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(114, 123);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(143, 20);
            this.textBoxCidade.TabIndex = 8;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(114, 97);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(143, 20);
            this.textBoxBairro.TabIndex = 7;
            // 
            // textBoxRua
            // 
            this.textBoxRua.Location = new System.Drawing.Point(114, 45);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.Size = new System.Drawing.Size(143, 20);
            this.textBoxRua.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cidade*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Bairro*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "UF*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Rua*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cep";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numero*";
            // 
            // LblDocument
            // 
            this.LblDocument.AutoSize = true;
            this.LblDocument.Location = new System.Drawing.Point(31, 61);
            this.LblDocument.Name = "LblDocument";
            this.LblDocument.Size = new System.Drawing.Size(31, 13);
            this.LblDocument.TabIndex = 10;
            this.LblDocument.Text = "CPF*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdJuridica);
            this.groupBox2.Controls.Add(this.rdFisica);
            this.groupBox2.Location = new System.Drawing.Point(283, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 42);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Pessoa";
            // 
            // rdJuridica
            // 
            this.rdJuridica.AutoSize = true;
            this.rdJuridica.Location = new System.Drawing.Point(66, 16);
            this.rdJuridica.Name = "rdJuridica";
            this.rdJuridica.Size = new System.Drawing.Size(63, 17);
            this.rdJuridica.TabIndex = 9;
            this.rdJuridica.Text = "Jurídica";
            this.rdJuridica.UseVisualStyleBackColor = true;
            this.rdJuridica.CheckedChanged += new System.EventHandler(this.rdJuridica_CheckedChanged);
            // 
            // rdFisica
            // 
            this.rdFisica.AutoSize = true;
            this.rdFisica.Checked = true;
            this.rdFisica.Location = new System.Drawing.Point(6, 16);
            this.rdFisica.Name = "rdFisica";
            this.rdFisica.Size = new System.Drawing.Size(54, 17);
            this.rdFisica.TabIndex = 8;
            this.rdFisica.TabStop = true;
            this.rdFisica.Text = "Física";
            this.rdFisica.UseVisualStyleBackColor = true;
            this.rdFisica.CheckedChanged += new System.EventHandler(this.rdFisica_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Convênio*";
            // 
            // cboConvenio
            // 
            this.cboConvenio.FormattingEnabled = true;
            this.cboConvenio.Location = new System.Drawing.Point(120, 84);
            this.cboConvenio.Name = "cboConvenio";
            this.cboConvenio.Size = new System.Drawing.Size(144, 21);
            this.cboConvenio.TabIndex = 3;
            this.cboConvenio.SelectedIndexChanged += new System.EventHandler(this.cboConvenio_SelectedIndexChanged);
            // 
            // comboBoxUF
            // 
            this.comboBoxUF.FormattingEnabled = true;
            this.comboBoxUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBoxUF.Location = new System.Drawing.Point(113, 149);
            this.comboBoxUF.Name = "comboBoxUF";
            this.comboBoxUF.Size = new System.Drawing.Size(144, 21);
            this.comboBoxUF.TabIndex = 9;
            // 
            // textBoxCep
            // 
            this.textBoxCep.Location = new System.Drawing.Point(113, 19);
            this.textBoxCep.Mask = "00.000-000";
            this.textBoxCep.Name = "textBoxCep";
            this.textBoxCep.Size = new System.Drawing.Size(145, 20);
            this.textBoxCep.TabIndex = 4;
            // 
            // textBoxDocument
            // 
            this.textBoxDocument.Location = new System.Drawing.Point(120, 58);
            this.textBoxDocument.Mask = "000.000.000-000";
            this.textBoxDocument.Name = "textBoxDocument";
            this.textBoxDocument.Size = new System.Drawing.Size(145, 20);
            this.textBoxDocument.TabIndex = 2;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(114, 71);
            this.textBoxNumero.Mask = "00000000";
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(143, 20);
            this.textBoxNumero.TabIndex = 6;
            this.textBoxNumero.ValidatingType = typeof(int);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "+Devs2Blu - Sistema de Cadastro Hospitalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboConvenio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdJuridica;
        private System.Windows.Forms.RadioButton rdFisica;
        private System.Windows.Forms.Label LblDocument;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonCadastrarConvenio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.ListView listViewPacientes;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.ComboBox comboBoxUF;
        private System.Windows.Forms.MaskedTextBox textBoxCep;
        private System.Windows.Forms.MaskedTextBox textBoxDocument;
        private System.Windows.Forms.MaskedTextBox textBoxNumero;
    }
}

