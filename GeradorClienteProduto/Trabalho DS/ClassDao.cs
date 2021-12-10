using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Trabalho_DS
{
    public class Campos
    {
        public int Id;
        public string Nome;
        public decimal V_Compras;
        public string P_Comprado;
    }

    public class ClassDao
    {
        public ClassDao()
        {
        }

        public Campos campos = new Campos();

        public MySqlConnection minhaConexao;

        public string usuarioBD = "root";
        public string senhaBd = "admin";
        public string servidor = "localhost";
        string bancoDados;
        string tabela;

        public void conecte(string BancoDados, string Tabela)
        {
            bancoDados = BancoDados;
            tabela = Tabela;
            minhaConexao = new MySqlConnection("server=" + servidor + "; database=" + bancoDados +
                                                "; uid=" + usuarioBD + "; password=" + senhaBd);
        }

        void Abrir()
        {
            minhaConexao.Open();
        }
        void Fechar()
        {
            minhaConexao.Close();
        }

        public void PreencherTabela(System.Windows.Forms.DataGridView dgv)
        {
            Abrir();

            MySqlDataAdapter meuAdapter = new MySqlDataAdapter("Select * From " + tabela, minhaConexao);
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.Clear();
            meuAdapter.Fill(dataSet, tabela);
            dgv.DataSource = dataSet;
            dgv.DataMember = tabela;

            Fechar();
        }

        public void Inserir(string campoNome, decimal V_Compras, string P_Comprado)
        {
            Abrir();

            MySqlCommand comando = new MySqlCommand("INSERT INTO " + tabela + "(`Nome`, `V_Compras`, `P_Comprado`) " +
                "VALUES (@nome, @VCompras, @PComprado)", minhaConexao);

            comando.Parameters.AddWithValue("@nome", campoNome);
            comando.Parameters.AddWithValue("@VCompras", V_Compras);
            comando.Parameters.AddWithValue("@PComprado", P_Comprado);

            comando.ExecuteNonQuery();

            Fechar();
        }
    }
}