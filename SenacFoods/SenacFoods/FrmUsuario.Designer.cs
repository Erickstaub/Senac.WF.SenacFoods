namespace SenacFoods
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            panel2 = new Panel();
            minimiza = new Label();
            fecha = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtPesquisa = new TextBox();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            btnmaisitem = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(minimiza);
            panel2.Controls.Add(fecha);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 75);
            panel2.TabIndex = 8;
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
            fecha.Click += fecha_Click_1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 96);
            label1.Name = "label1";
            label1.Size = new Size(26, 25);
            label1.TabIndex = 13;
            label1.Text = "⌕";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(181, 90);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(264, 31);
            txtPesquisa.TabIndex = 12;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(btnmaisitem);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(0, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 336);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(533, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(224, 223);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
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
            btnmaisitem.Text = "+ USUARIO";
            btnmaisitem.UseVisualStyleBackColor = false;
            btnmaisitem.Click += btnmaisitem_Click;
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
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Enabled = false;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Location = new Point(487, 281);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(150, 60);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "X EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(422, 242);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtPesquisa);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += FrmUsuario_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label minimiza;
        private Label fecha;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtPesquisa;
        private GroupBox groupBox1;
        private Button btnmaisitem;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
    }
}