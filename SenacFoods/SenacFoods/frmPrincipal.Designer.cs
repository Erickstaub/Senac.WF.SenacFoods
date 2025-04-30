namespace SenacFoods
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            btncom = new Button();
            btncar = new Button();
            panel2 = new Panel();
            minimiza = new Label();
            fecha = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 449);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btncom);
            groupBox1.Controls.Add(btncar);
            groupBox1.Location = new Point(10, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 195);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 14F);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(413, 20);
            button4.Name = "button4";
            button4.Size = new Size(153, 154);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14F);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(595, 20);
            button3.Name = "button3";
            button3.Size = new Size(155, 154);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btncom
            // 
            btncom.BackColor = Color.White;
            btncom.BackgroundImage = (Image)resources.GetObject("btncom.BackgroundImage");
            btncom.BackgroundImageLayout = ImageLayout.Stretch;
            btncom.FlatStyle = FlatStyle.Flat;
            btncom.Font = new Font("Segoe UI", 14F);
            btncom.ForeColor = SystemColors.Control;
            btncom.Location = new Point(217, 20);
            btncom.Name = "btncom";
            btncom.Size = new Size(166, 154);
            btncom.TabIndex = 1;
            btncom.UseVisualStyleBackColor = false;
            btncom.Click += btncom_Click;
            // 
            // btncar
            // 
            btncar.BackColor = Color.Snow;
            btncar.BackgroundImage = (Image)resources.GetObject("btncar.BackgroundImage");
            btncar.BackgroundImageLayout = ImageLayout.Stretch;
            btncar.FlatStyle = FlatStyle.Flat;
            btncar.Font = new Font("Segoe UI", 14F);
            btncar.ForeColor = SystemColors.Control;
            btncar.ImageAlign = ContentAlignment.TopCenter;
            btncar.Location = new Point(14, 20);
            btncar.Name = "btncar";
            btncar.RightToLeft = RightToLeft.Yes;
            btncar.Size = new Size(167, 154);
            btncar.TabIndex = 0;
            btncar.UseVisualStyleBackColor = false;
            btncar.Click += button1_Click;
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
            panel2.TabIndex = 6;
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
            minimiza.Click += label2_Click;
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
            fecha.Click += label1_Click;
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
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button btncom;
        private Button btncar;
        private GroupBox groupBox1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label fecha;
        private Label minimiza;
    }
}