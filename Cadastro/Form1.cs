using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void BtnCad_Click(object sender, EventArgs e)
        {

            string Nome = TxtNome.Text;
            string Senha = TxtSenha.Text;


            string CONFIG = "server=127.0.0.1;userid=jorge;password=sondeminas;database=bd";
            MySqlConnection Conexao = new MySqlConnection(CONFIG);
            MySqlCommand Query = new MySqlCommand();
            Query.Connection = Conexao;
            Conexao.Open();
            Query.CommandText = "INSERT INTO membros(Nome, Senha) VALUES(@nome, @senha)";
            Query.Parameters.AddWithValue("@nome", Nome);
            Query.Parameters.AddWithValue("@senha", Senha);
            Query.ExecuteNonQuery();
            Conexao.Close();
        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            string busca = TxtBusca.Text;

            string connString = "server=127.0.0.1;userid=jorge;password=sondeminas;database=bd";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "Select nome from membros where ";
            try
            {

                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                MessageBox.Show(reader["nome"].ToString());
            }
            
         
        }
    }
}
