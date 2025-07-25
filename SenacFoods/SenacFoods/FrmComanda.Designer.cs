namespace SenacFoods
{
    partial class FrmComanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComanda));
            panel2 = new Panel();
            minimiza = new Label();
            fecha = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            btnmaisitem = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            txtPesquisa = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(minimiza);
            panel2.Controls.Add(fecha);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(805, 78);
            panel2.TabIndex = 7;
            // 
            // minimiza
            // 
            minimiza.AutoSize = true;
            minimiza.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            minimiza.ForeColor = SystemColors.Control;
            minimiza.Location = new Point(680, 9);
            minimiza.Name = "minimiza";
            minimiza.Size = new Size(48, 55);
            minimiza.TabIndex = 7;
            minimiza.Text = "~";
            // 
            // fecha
            // 
            fecha.AutoSize = true;
            fecha.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            fecha.ForeColor = SystemColors.Control;
            fecha.Location = new Point(739, 9);
            fecha.Name = "fecha";
            fecha.Size = new Size(53, 55);
            fecha.TabIndex = 6;
            fecha.Text = "X";
            fecha.Click += fecha_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 75);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(680, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 55);
            label1.TabIndex = 7;
            label1.Text = "~";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(739, 9);
            label2.Name = "label2";
            label2.Size = new Size(53, 55);
            label2.TabIndex = 6;
            label2.Text = "X";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Red;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(239, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnmaisitem);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(-1, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 336);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Comandas";
            // 
            // btnmaisitem
            // 
            btnmaisitem.BackColor = Color.Lime;
            btnmaisitem.FlatStyle = FlatStyle.Popup;
            btnmaisitem.ForeColor = SystemColors.ActiveCaptionText;
            btnmaisitem.Location = new Point(643, 281);
            btnmaisitem.Name = "btnmaisitem";
            btnmaisitem.Size = new Size(134, 60);
            btnmaisitem.TabIndex = 3;
            btnmaisitem.Text = "+ ITEM";
            btnmaisitem.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Yellow;
            btnEditar.Enabled = false;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Location = new Point(23, 281);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(134, 60);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "# EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Location = new Point(487, 281);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(150, 60);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "X EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(753, 242);
            dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 91);
            label3.Name = "label3";
            label3.Size = new Size(26, 25);
            label3.TabIndex = 14;
            label3.Text = "⌕";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(512, 88);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(264, 31);
            txtPesquisa.TabIndex = 13;
            // 
            // FrmComanda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(txtPesquisa);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComanda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "comanda";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label minimiza;
        private Label fecha;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Button btnmaisitem;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtPesquisa;
    }
}