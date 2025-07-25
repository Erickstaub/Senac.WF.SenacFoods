namespace SenacFoods
{
    partial class FrmComandaCad
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComandaCad));
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            txtNom = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSalvar = new Button();
            panel2 = new Panel();
            minimiza = new Label();
            fecha = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtNom);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(-1, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 378);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Comanda";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(166, 189);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(179, 46);
            comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(166, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 46);
            comboBox1.TabIndex = 13;
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
            dataGridView1.Location = new Point(13, 252);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(394, 107);
            dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Comic Sans MS", 15F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(351, 189);
            button1.Name = "button1";
            button1.Size = new Size(56, 46);
            button1.TabIndex = 11;
            button1.Text = "+";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(166, 57);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(241, 45);
            txtNom.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 126);
            label3.Name = "label3";
            label3.Size = new Size(87, 38);
            label3.TabIndex = 6;
            label3.Text = "Preço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 192);
            label2.Name = "label2";
            label2.Size = new Size(137, 38);
            label2.TabIndex = 5;
            label2.Text = "Descrição";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(93, 38);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Red;
            btnSalvar.FlatStyle = FlatStyle.Popup;
            btnSalvar.Font = new Font("Comic Sans MS", 15F);
            btnSalvar.ForeColor = SystemColors.ControlLightLight;
            btnSalvar.Location = new Point(480, 310);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(299, 53);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "ADICIONAR";
            btnSalvar.TextAlign = ContentAlignment.TopCenter;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(minimiza);
            panel2.Controls.Add(fecha);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-1, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 75);
            panel2.TabIndex = 12;
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
            // FrmComandaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComandaCad";
            Text = "FrmComandaCad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox txtNom;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSalvar;
        private Panel panel2;
        private Label minimiza;
        private Label fecha;
        private PictureBox pictureBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}