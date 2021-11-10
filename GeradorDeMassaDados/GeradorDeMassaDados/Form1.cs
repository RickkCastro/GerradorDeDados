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

namespace GerradorDeMassaDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ClassDao dao = new ClassDao();

        public static MySqlConnection minhaconexao;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadFiles();
                conectarBD();
            }
            catch
            {
                NomeList.SaveFile("NomeList.txt", RichTextBoxStreamType.PlainText);
                Sb1List.SaveFile("Sb1List.txt", RichTextBoxStreamType.PlainText);
                Sb2List.SaveFile("Sb2List.txt", RichTextBoxStreamType.PlainText);
            }
        }

        private void conectarBD()
        {
            try
            {
                dao.conecte("bdmassa", "Cliente");
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
        }

        private void BtNome_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text != "")
            {
                if(NomeList.Text == "")
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

            if(TxtGmNum.Text == "")
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

                //richTextBox1.Text += NomeC + "\t";

                //gerar end
                int RuaRndName1 = rnd.Next(0, NomeList.Lines.Count() - 1);
                int RuaRnName2 = rnd.Next(0, Sb1List.Lines.Count() - 1);
                int RuaRnName3 = rnd.Next(0, Sb2List.Lines.Count() - 1);

                string Rua1 = NomeList.Lines[RuaRndName1];
                string Rua2 = Sb1List.Lines[RuaRnName2];
                string Rua3 = Sb2List.Lines[RuaRnName3];

                int RnHomeNum = rnd.Next(0, 1000);

                String End;

                if (Rua3 == "*")
                    End = "Rua " + Rua1 + " " + Rua2 + ", " + RnHomeNum.ToString("000");
                else
                    End = "Rua " + Rua1 + " " + Rua2 + " " + Rua3 + ", " + RnHomeNum.ToString("000");

                //richTextBox1.Text += End + "\t";

                //gerar telefone
                String telefone = "";

                int[] nums = new int[10];

                for (int t = 0; t < nums.Count(); t++)
                {
                    nums[t] = rnd.Next(0, 10);
                }

                if (nums[1] == 0)
                    nums[1] = 1;

                telefone = "(" + nums[0].ToString() + nums[1].ToString() + ") " + "9 " + nums[2].ToString() + nums[3].ToString() + nums[4].ToString()
                    + nums[5].ToString() + "-" + nums[6].ToString() + nums[7].ToString() + nums[8].ToString() + nums[9].ToString();

                //richTextBox1.Text += telefone + "\t";

                //gerar cpf
                String cpf = "";

                int[] cpfnums = new int[11];

                for (int c = 0; c < cpfnums.Count(); c++)
                {
                    cpfnums[c] = rnd.Next(0, 10);
                }

                cpf = cpfnums[0].ToString() + cpfnums[1].ToString() + cpfnums[2].ToString() + "." + cpfnums[3].ToString() + cpfnums[4].ToString() + cpfnums[5].ToString() + "." + cpfnums[6].ToString() +
                    cpfnums[7].ToString() + cpfnums[8].ToString() + "-" + cpfnums[9].ToString() + cpfnums[10].ToString();

                //richTextBox1.Text += cpf + "\n";

                //passar por bd
                dao.Inserir(NomeC, End, telefone, cpf);
            }

            dao.PreencherTabela(dataGridView1);
            MessageBox.Show("Dados foram alocados no banco de dados", "Suscesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
