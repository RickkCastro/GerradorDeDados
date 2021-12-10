using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Trabalho_DS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ClassDao dao = new ClassDao();

        public static MySqlConnection minhaconexao;

        public String[] ProdutosList = { "Coca-Cola", "Bolacha Takinas", "Toca de Lã", "Barra de Chocolate Garota",
            "Gif Card Free Fire", "Alface Crespa", "Massa de Tomate", "Batata Doce", "Peito de Frago", "Carne de Jabuti"};

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadFiles();
                conectarBD();
            }
            catch
            {
                conectarBD();
                NomeList.SaveFile("NomeList.txt", RichTextBoxStreamType.PlainText);
                Sb1List.SaveFile("Sb1List.txt", RichTextBoxStreamType.PlainText);
                Sb2List.SaveFile("Sb2List.txt", RichTextBoxStreamType.PlainText);
                richTextBox1.SaveFile("MD.txt", RichTextBoxStreamType.PlainText);
            }
        }

        private void conectarBD()
        {
            try
            {
                dao.conecte("bdmassa", "M_Cliente");
                dao.PreencherTabela(dataGridView1);
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com BD!!");
                Close();
            }
        }

        private void SaveFile(RichTextBox list)
        {
            list.SaveFile(list.Name + ".txt", RichTextBoxStreamType.PlainText);
        }

        private void LoadFiles()
        {
            NomeList.LoadFile("NomeList.txt", RichTextBoxStreamType.PlainText);
            Sb1List.LoadFile("Sb1List.txt", RichTextBoxStreamType.PlainText);
            Sb2List.LoadFile("Sb2List.txt", RichTextBoxStreamType.PlainText);
            richTextBox1.LoadFile("MD.txt", RichTextBoxStreamType.PlainText);
        }

        private void BtNome_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text != "")
            {
                if (NomeList.Text == "")
                    NomeList.Text += TxtNome.Text;
                else
                    NomeList.Text += "\n" + TxtNome.Text;
                SaveFile(NomeList);
                TxtNome.Clear();
            }
        }

        private void BtSb1_Click(object sender, EventArgs e)
        {
            if (TxtSb1.Text != "")
            {
                if (Sb1List.Text == "")
                    Sb1List.Text += TxtSb1.Text;
                else
                    Sb1List.Text += "\n" + TxtSb1.Text;
                SaveFile(Sb1List);
                TxtSb1.Clear();
            }
        }

        private void BtSb2_Click(object sender, EventArgs e)
        {
            if (TxtSb2.Text == "")
            {
                TxtSb2.Text = "*";
            }

            if (Sb2List.Text == "")
                Sb2List.Text += TxtSb2.Text;
            else
                Sb2List.Text += "\n" + TxtSb2.Text;

            SaveFile(Sb2List);

            TxtSb2.Clear();
        }

        private void BtGM_Click(object sender, EventArgs e)
        {
            int NumMassa = 0;

            if (TxtGmNum.Text == "")
            {
                NumMassa = 1;
            }
            else
            {
                NumMassa = int.Parse(TxtGmNum.Text);
            }

            Random rnd = new Random();

            for (int i = 0; i < NumMassa; i++)
            {
                //gerar nome
                int RandomName = rnd.Next(0, NomeList.Lines.Count() - 1);
                int RandomSb1 = rnd.Next(0, Sb1List.Lines.Count() - 1);
                int RandomSb2 = rnd.Next(0, Sb2List.Lines.Count() - 1);

                string nome = NomeList.Lines[RandomName];
                string Sb1 = Sb1List.Lines[RandomSb1];
                string Sb2 = Sb2List.Lines[RandomSb2];

                String NomeC;

                if (Sb2 == "*")
                    NomeC = nome + " " + Sb1;
                else
                    NomeC = nome + " " + Sb1 + " " + Sb2;

                if (richTextBox1.Text == "")
                    richTextBox1.Text += NomeC + "\t";
                else
                    richTextBox1.Text += "\n" + NomeC + "\t";

                //Gerar Valor de compras
                decimal VCompras = rnd.Next(0, 150000);
                richTextBox1.Text += VCompras + "\t";

                //Gerar produto mais comprado aleatorio
                string PComprado = ProdutosList[rnd.Next(0, ProdutosList.Count())];
                richTextBox1.Text += PComprado;

                //passar por bd
                dao.Inserir(NomeC, VCompras, PComprado);
            }

            dao.PreencherTabela(dataGridView1);
            richTextBox1.SaveFile("MD.txt", RichTextBoxStreamType.PlainText);
            MessageBox.Show("Dados foram alocados no banco de dados", "Suscesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtMCliente_Click(object sender, EventArgs e)
        {
            decimal MaiorVolume = 0;
            int MelhorClienteLine = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                decimal CurrentVolume = decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());

                if (CurrentVolume > MaiorVolume)
                {
                    MaiorVolume = CurrentVolume;
                    MelhorClienteLine = i;
                }
            }

            ListBoxMCliente.Text = dataGridView1.Rows[MelhorClienteLine].Cells[1].Value.ToString() + " | " + 
                dataGridView1.Rows[MelhorClienteLine].Cells[2].Value.ToString() + " | " + 
                dataGridView1.Rows[MelhorClienteLine].Cells[3].Value.ToString();
        }
    }
}