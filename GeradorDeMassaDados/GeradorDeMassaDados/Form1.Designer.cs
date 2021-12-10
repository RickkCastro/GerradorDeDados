namespace GerradorDeMassaDados
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtNome = new System.Windows.Forms.Button();
            this.NomeList = new System.Windows.Forms.RichTextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtSb1 = new System.Windows.Forms.TextBox();
            this.BtSb1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSb2 = new System.Windows.Forms.TextBox();
            this.BtSb2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtGM = new System.Windows.Forms.Button();
            this.TxtGmNum = new System.Windows.Forms.TextBox();
            this.Sb1List = new System.Windows.Forms.RichTextBox();
            this.Sb2List = new System.Windows.Forms.RichTextBox();
            this.dataSet1 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CpfsSpList = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtCPFSP = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomes:";
            // 
            // BtNome
            // 
            this.BtNome.Location = new System.Drawing.Point(130, 23);
            this.BtNome.Name = "BtNome";
            this.BtNome.Size = new System.Drawing.Size(62, 20);
            this.BtNome.TabIndex = 1;
            this.BtNome.Text = "Add";
            this.BtNome.UseVisualStyleBackColor = true;
            this.BtNome.Click += new System.EventHandler(this.BtNome_Click);
            // 
            // NomeList
            // 
            this.NomeList.Location = new System.Drawing.Point(12, 63);
            this.NomeList.Name = "NomeList";
            this.NomeList.Size = new System.Drawing.Size(180, 257);
            this.NomeList.TabIndex = 2;
            this.NomeList.Text = "";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(12, 23);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(112, 22);
            this.TxtNome.TabIndex = 3;
            // 
            // TxtSb1
            // 
            this.TxtSb1.Location = new System.Drawing.Point(208, 24);
            this.TxtSb1.Name = "TxtSb1";
            this.TxtSb1.Size = new System.Drawing.Size(112, 22);
            this.TxtSb1.TabIndex = 4;
            // 
            // BtSb1
            // 
            this.BtSb1.Location = new System.Drawing.Point(326, 24);
            this.BtSb1.Name = "BtSb1";
            this.BtSb1.Size = new System.Drawing.Size(62, 20);
            this.BtSb1.TabIndex = 5;
            this.BtSb1.Text = "Add";
            this.BtSb1.UseVisualStyleBackColor = true;
            this.BtSb1.Click += new System.EventHandler(this.BtSb1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sobrenomes:";
            // 
            // TxtSb2
            // 
            this.TxtSb2.Location = new System.Drawing.Point(405, 23);
            this.TxtSb2.Name = "TxtSb2";
            this.TxtSb2.Size = new System.Drawing.Size(112, 22);
            this.TxtSb2.TabIndex = 4;
            // 
            // BtSb2
            // 
            this.BtSb2.Location = new System.Drawing.Point(523, 23);
            this.BtSb2.Name = "BtSb2";
            this.BtSb2.Size = new System.Drawing.Size(62, 20);
            this.BtSb2.TabIndex = 5;
            this.BtSb2.Text = "Add";
            this.BtSb2.UseVisualStyleBackColor = true;
            this.BtSb2.Click += new System.EventHandler(this.BtSb2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sobrenomes 2:";
            // 
            // BtGM
            // 
            this.BtGM.Location = new System.Drawing.Point(110, 341);
            this.BtGM.Margin = new System.Windows.Forms.Padding(0);
            this.BtGM.Name = "BtGM";
            this.BtGM.Size = new System.Drawing.Size(82, 22);
            this.BtGM.TabIndex = 1;
            this.BtGM.Text = "Gerar Massa";
            this.BtGM.UseVisualStyleBackColor = true;
            this.BtGM.Click += new System.EventHandler(this.BtGM_Click);
            // 
            // TxtGmNum
            // 
            this.TxtGmNum.Location = new System.Drawing.Point(12, 341);
            this.TxtGmNum.Name = "TxtGmNum";
            this.TxtGmNum.Size = new System.Drawing.Size(92, 22);
            this.TxtGmNum.TabIndex = 3;
            // 
            // Sb1List
            // 
            this.Sb1List.Location = new System.Drawing.Point(208, 63);
            this.Sb1List.Name = "Sb1List";
            this.Sb1List.Size = new System.Drawing.Size(180, 257);
            this.Sb1List.TabIndex = 2;
            this.Sb1List.Text = "";
            // 
            // Sb2List
            // 
            this.Sb2List.Location = new System.Drawing.Point(405, 63);
            this.Sb2List.Name = "Sb2List";
            this.Sb2List.Size = new System.Drawing.Size(180, 257);
            this.Sb2List.TabIndex = 2;
            this.Sb2List.Text = "";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 55;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(573, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // CpfsSpList
            // 
            this.CpfsSpList.Location = new System.Drawing.Point(799, 63);
            this.CpfsSpList.Name = "CpfsSpList";
            this.CpfsSpList.Size = new System.Drawing.Size(180, 257);
            this.CpfsSpList.TabIndex = 2;
            this.CpfsSpList.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(856, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cpfs SP";
            // 
            // BtCPFSP
            // 
            this.BtCPFSP.Location = new System.Drawing.Point(839, 327);
            this.BtCPFSP.Margin = new System.Windows.Forms.Padding(0);
            this.BtCPFSP.Name = "BtCPFSP";
            this.BtCPFSP.Size = new System.Drawing.Size(82, 22);
            this.BtCPFSP.TabIndex = 1;
            this.BtCPFSP.Text = "CPFs de SP";
            this.BtCPFSP.UseVisualStyleBackColor = true;
            this.BtCPFSP.Click += new System.EventHandler(this.BtCPFSP_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(613, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(180, 257);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(673, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1015, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtSb2);
            this.Controls.Add(this.BtSb1);
            this.Controls.Add(this.TxtSb2);
            this.Controls.Add(this.TxtSb1);
            this.Controls.Add(this.TxtGmNum);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.BtCPFSP);
            this.Controls.Add(this.BtGM);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CpfsSpList);
            this.Controls.Add(this.Sb2List);
            this.Controls.Add(this.Sb1List);
            this.Controls.Add(this.NomeList);
            this.Controls.Add(this.BtNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gerrador de dados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtNome;
        private System.Windows.Forms.RichTextBox NomeList;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtSb1;
        private System.Windows.Forms.Button BtSb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSb2;
        private System.Windows.Forms.Button BtSb2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtGM;
        private System.Windows.Forms.TextBox TxtGmNum;
        private System.Windows.Forms.RichTextBox Sb1List;
        private System.Windows.Forms.RichTextBox Sb2List;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox CpfsSpList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtCPFSP;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
    }
}

