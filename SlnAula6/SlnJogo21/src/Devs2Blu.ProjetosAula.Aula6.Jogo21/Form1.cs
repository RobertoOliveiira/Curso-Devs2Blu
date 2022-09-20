using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.Aula6.Jogo21
{
    public partial class Form1 : Form
    {
        public int PontuacaoP1 { get; set; }
        public int PontuacaoTotalP1 { get; set; }
        public int PontuacaoP2 { get; set; }
        public int PontuacaoTotalP2 { get; set; }
        public int Aleatorio { get; set; }
        public int Rodada { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtConsole.Text += "\r\n Pressione \"Iniciar\" para começar o jogo.";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            txtConsole.Text += "\r\n Primeira Rodada";
            txtConsole.Text += "\r\n Informe um número de 1 a 20";
            gbPlayer1.Visible = true;
            gbPlayer2.Visible = true;
            txtPlayer1.Focus();
            Rodada = 1;
            PontuacaoTotalP2 = 0;
            PontuacaoTotalP1 = 0;
            btnIniciar.Visible = false;
        }

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            txtConsole.Text += "\r\n Player 1 escolheu seu número...";
            Random rd = new Random();
            Aleatorio = rd.Next(1,20);
            PontuacaoP1 = Int32.Parse(txtPlayer1.Text);
            PontuacaoTotalP1+= CalculaPontuação(Aleatorio+PontuacaoP1,txtResultP1 );
            Thread.Sleep(1000);
            txtPlayer1.Clear();
            GeraNumeroPlayer2();
        }

        //Exemplo Metodo sem retornar valor
        private void GeraNumeroPlayer2()
        {
            Random rd = new Random();
            PontuacaoP2 = rd.Next(1, 20);
            txtPlayer2.Text = PontuacaoP2.ToString();
            txtConsole.Text += "\r\n Player 2 escolheu seu número...";
            PontuacaoTotalP2+= CalculaPontuação(Aleatorio+PontuacaoP2, txtResultP2);
            DefinirVencedor();
            Final();
        }

        //Exemplo Metodo retornando valor
        private int CalculaPontuação(int valor, TextBox local)
        {
            switch (valor)
            {
                case int i when (i <= 7):
                   local.Text += "ganhou 1 ponto\r\n";
                    return 1;
                case 7:
                    local.Text += "ganhou 10 ponto\r\n";
                    return 10;
                case int i when (i >= 8 && i <= 13):
                    local.Text += "ganhou 5 ponto\r\n";
                    return 5;
                case 14:
                    local.Text += "ganhou 20 ponto\n";
                    return 20;
                case int i when (i >= 15 && i <= 20):
                    local.Text += "ganhou 6 ponto\r\n";
                    return 6;
                case 21:
                    local.Text += "ganhou 30 ponto\r\n";
                    return 30;
                default:
                    local.Text += "Perdeu esta rodada\r\n";
                    return 0;
            }
        }
        private void DefinirVencedor()
        {
            txtConsole.Text += "\r\n O valor aleatorio foi: " + Aleatorio;
            if (PontuacaoP1 > PontuacaoP2)
            {
                txtConsole.Text += "\r\n O player 1 venceu a "+ Rodada +"° rodada";
            }
            else if(PontuacaoP2 > PontuacaoP1)
            {
                txtConsole.Text += "\r\n O player 2(PC) venceu a " + Rodada + "° rodada";
            }
            else
            {
                txtConsole.Text += "\r\n Ouve um empate na " + Rodada + "° rodada";
            }
            
        }
        private void Final()
        {
            Rodada++;
            if(Rodada == 4)
            {
                if (PontuacaoTotalP1 >PontuacaoTotalP2)
                {
                    txtConsole.Text += "\r\n Parabens o player 1 venceu o jogo com "+ PontuacaoTotalP1+" Pontos";
                }
                else if(PontuacaoTotalP2 > PontuacaoTotalP1){
                    txtConsole.Text += "\r\n Voce perdeu, o computador venceu com "+ PontuacaoTotalP2+" Pontos";
                }
                else
                {
                    txtConsole.Text += "\r\n Ouve um empate os dois players conseguirão " + PontuacaoTotalP1 + " pontos";
                }
                btnNovoJogo.Visible = true;
                btnPlayer1.Visible= false;
                
            }
        }

        private void txtResultP1_TextChanged(object sender, EventArgs e)
        {
        }

        private void gbPlayer1_Enter(object sender, EventArgs e)
        {
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
            txtResultP1.Clear();
            txtResultP2.Clear();
            Rodada = 1;
            PontuacaoTotalP2 = 0;
            PontuacaoTotalP1 = 0;
            txtConsole.Text += "Primeira Rodada";
            txtConsole.Text += "\r\n Informe um número de 1 a 20";
            btnNovoJogo.Visible = false;
        }
    }
}
