namespace SenacFoods
{
    partial class FrmCardapio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCardapio));
            panel2 = new Panel();
            minimiza = new Label();
            fecha = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 75);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(0, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 336);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardapio";
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
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(513, 281);
            button1.Name = "button1";
            button1.Size = new Size(150, 60);
            button1.TabIndex = 1;
            button1.Text = "X ESCLUIR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(663, 281);
            button2.Name = "button2";
            button2.Size = new Size(134, 60);
            button2.TabIndex = 2;
            button2.Text = "# EDITAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(513, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 31);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(481, 91);
            label1.Name = "label1";
            label1.Size = new Size(26, 25);
            label1.TabIndex = 10;
            label1.Text = "⌕";
            label1.Click += label1_Click;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            Load += FrmCardapio_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}