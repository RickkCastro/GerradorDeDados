using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GerradorDeMassaDados
{
    public class Campos
    {
        public int Id;
        public string Nome;
        public string Ender;
        public string Telefone;
        public string CPF;
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

        public void Inserir(string campoNome, string campoEnd, string campoTel, string campoCPF)
        {
            Abrir();

            MySqlCommand comando = new MySqlCommand("INSERT INTO " + tabela + "(`Nome`, `Ender`, `Telefone`, `CPF`) " +
                "VALUES (@nome, @end, @tel, @cpf)", minhaConexao);

            comando.Parameters.AddWithValue("@nome", campoNome);
            comando.Parameters.AddWithValue("@end", campoEnd);
            comando.Parameters.AddWithValue("@tel", campoTel);
            comando.Parameters.AddWithValue("@cpf", campoCPF);

            comando.ExecuteNonQuery();

            Fechar();
        }

        //public void Consulta(string campoNome)
        //{
        //    // Sobrecarga do método de consulta para permitir consulta por id tambem
        //    Abrir();

        //    MySqlCommand comando = new MySqlCommand("select * from " + tabela + " where Nome = '" + campoNome + "'", minhaConexao);
        //    MySqlDataReader dtReader = comando.ExecuteReader();

        //    if (dtReader.Read())
        //    {
        //        campos.id = int.Parse(dtReader["Id"].ToString());
        //        campos.nome = dtReader["Nome"].ToString();
        //        campos.ender = dtReader["Endereco"].ToString();
        //        campos.sal = decimal.Parse(dtReader["Salario"].ToString());
        //    }

        //    Fechar();
        //}

        //public void Atualiza(string campoNome, string campoEnder, decimal campoSalario, int id)
        //{
        //    Abrir();

        //    MySqlCommand comando = new MySqlCommand("Update " + tabela + " set Nome=@nome, Endereco=@endereco, Salario=@salario where Id=@id", minhaConexao);

        //    comando.Parameters.AddWithValue("@id", id);
        //    comando.Parameters.AddWithValue("@nome", campoNome);
        //    comando.Parameters.AddWithValue("@endereco", campoEnder);
        //    comando.Parameters.AddWithValue("@salario", campoSalario);
        //    comando.ExecuteNonQuery();

        //    Fechar();
        //}

        //public void Deleta(int id)
        //{
        //    Abrir();

        //    MySqlCommand comando = new MySqlCommand("Delete from " + tabela + " where Id = @id", minhaConexao);

        //    comando.Parameters.AddWithValue("@id", id);
        //    comando.ExecuteNonQuery();

        //    Fechar();
        //}

        //public int NumRegistro()
        //{
        //    Abrir();
        //    //Max retorna o num do ultimo valor do id
        //    MySqlCommand comando = new MySqlCommand("Select max(Id) from " + tabela, minhaConexao);

        //    //ExecuteScalar retorna um dado do tipo object, é preciso converter para string
        //    string n = comando.ExecuteScalar().ToString();

        //    //Agora convertemos o dado para int e somamos um para obter o numero do proximo registro
        //    int num = int.Parse(n) + 1;

        //    Fechar();

        //    return num;
        //}
    }
}