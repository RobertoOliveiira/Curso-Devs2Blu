using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data
{
    public class PessoaRepository
    {
        public MySqlDataReader FetchAll()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_PESSOA, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public MySqlDataReader FetchOne(String name)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT nome FROM pessoa WHERE pessoa.nome = {name} ", conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public int Cadastrar(String nome, String document, bool tipoPessoa)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                int aux = 0;
                if (tipoPessoa)
                {
                    MySqlCommand cmd = new MySqlCommand($"INSERT INTO pessoa (nome, cgccpf, tipopessoa, flstatus) VALUES ('{nome}', '{document}','PF','A')", conn);
                    cmd.ExecuteReader();
                    aux = (int)cmd.LastInsertedId;
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand($"INSERT INTO pessoa (nome, cgccpf, tipopessoa, flstatus) VALUES ('{nome}', '{document}','PJ','A')", conn);
                    cmd.ExecuteReader();
                    aux = (int)cmd.LastInsertedId;
                }
                return aux;

            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQLS
        private const String SQL_SELECT_PESSOA = "SELECT * FROM pessoa";
        #endregion
    }
}
