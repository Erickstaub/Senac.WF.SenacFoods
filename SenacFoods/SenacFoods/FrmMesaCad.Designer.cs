namespace SenacFoods
{
    partial class FrmMesaCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMesaCad));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            minimiza = new Label();
            fecha = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            txtNom = new TextBox();
            label1 = new Label();
            btnSalvar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(txtNom);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(0, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 378);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Cardapio";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(554, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(218, 242);
            dataGridView1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(156, 146);
            label2.Name = "label2";
            label2.Size = new Size(32, 54);
            label2.TabIndex = 10;
            label2.Text = ".";
            label2.Enter += label2_Enter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(79, 158);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(219, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(211, 57);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(241, 45);
            txtNom.TabIndex = 8;
            txtNom.TextChanged += txtNom_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(193, 38);
            label1.TabIndex = 4;
            label1.Text = "Numero Mesa";
            label1.Click += label1_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Red;
            btnSalvar.FlatStyle = FlatStyle.Popup;
            btnSalvar.Font = new Font("Comic Sans MS", 15F);
            btnSalvar.ForeColor = SystemColors.ControlLightLight;
            btnSalvar.Location = new Point(554, 306);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(218, 53);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "ADICIONAR";
            btnSalvar.TextAlign = ContentAlignment.TopCenter;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmMesaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMesaCad";
            Text = "FrmMesaCad";
            Load += FrmMesaCad_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label minimiza;
        private Label fecha;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox txtNom;
        private Label label1;
        private Button btnSalvar;
        private Label label2;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
    }
}