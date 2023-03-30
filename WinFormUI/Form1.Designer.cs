namespace WinFormUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            kategoriler = new DataGridViewTextBoxColumn();
            Ekle = new Button();
            Sil = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kategoriler });
            dataGridView1.Location = new Point(139, 285);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(1210, 511);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // kategoriler
            // 
            kategoriler.HeaderText = "Kategoriler";
            kategoriler.MinimumWidth = 9;
            kategoriler.Name = "kategoriler";
            kategoriler.ReadOnly = true;
            kategoriler.Width = 175;
            // 
            // Ekle
            // 
            Ekle.Location = new Point(139, 214);
            Ekle.Name = "Ekle";
            Ekle.Size = new Size(131, 40);
            Ekle.TabIndex = 1;
            Ekle.Text = "Ekle";
            Ekle.UseVisualStyleBackColor = true;
            Ekle.Click += button1_Click;
            // 
            // Sil
            // 
            Sil.Location = new Point(321, 214);
            Sil.Name = "Sil";
            Sil.Size = new Size(131, 40);
            Sil.TabIndex = 2;
            Sil.Text = "Sil";
            Sil.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 103);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 61);
            textBox1.TabIndex = 3;
            textBox1.Text = "Kategori Adı";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1866, 850);
            Controls.Add(textBox1);
            Controls.Add(Sil);
            Controls.Add(Ekle);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn kategoriler;
        private Button Ekle;
        private Button Sil;
        private TextBox textBox1;
    }
}