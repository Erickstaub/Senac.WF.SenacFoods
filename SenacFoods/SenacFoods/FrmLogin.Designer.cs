namespace SenacFoods
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel2 = new Panel();
            fecha = new Label();
            minimiza = new Label();
            TxtLogin = new TextBox();
            btnEntrar = new Button();
            TxtSenha = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(fecha);
            panel2.Controls.Add(minimiza);
            panel2.Controls.Add(TxtLogin);
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(TxtSenha);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(286, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 450);
            panel2.TabIndex = 1;
            // 
            // fecha
            // 
            fecha.AutoSize = true;
            fecha.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            fecha.ForeColor = SystemColors.Control;
            fecha.Location = new Point(461, 0);
            fecha.Name = "fecha";
            fecha.Size = new Size(53, 55);
            fecha.TabIndex = 9;
            fecha.Text = "X";
            fecha.Click += fecha_Click;
            // 
            // minimiza
            // 
            minimiza.AutoSize = true;
            minimiza.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            minimiza.ForeColor = SystemColors.Control;
            minimiza.Location = new Point(407, 0);
            minimiza.Name = "minimiza";
            minimiza.Size = new Size(48, 55);
            minimiza.TabIndex = 8;
            minimiza.Text = "~";
            minimiza.Click += minimiza_Click;
            // 
            // TxtLogin
            // 
            TxtLogin.BackColor = SystemColors.MenuText;
            TxtLogin.Font = new Font("Comic Sans MS", 18F);
            TxtLogin.ForeColor = SystemColors.Info;
            TxtLogin.Location = new Point(115, 104);
            TxtLogin.Name = "TxtLogin";
            TxtLogin.Size = new Size(366, 58);
            TxtLogin.TabIndex = 0;
            TxtLogin.Text = "USUARIO";
            TxtLogin.TextChanged += TxtLogin_TextChanged;
            TxtLogin.Enter += TxtLogin_Enter;
            TxtLogin.Leave += TxtLogin_Leave;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Black;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Comic Sans MS", 18F);
            btnEntrar.ForeColor = Color.Honeydew;
            btnEntrar.Location = new Point(115, 270);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(366, 138);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // TxtSenha
            // 
            TxtSenha.BackColor = SystemColors.MenuText;
            TxtSenha.Font = new Font("Comic Sans MS", 18F);
            TxtSenha.ForeColor = SystemColors.Info;
            TxtSenha.Location = new Point(115, 182);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(366, 58);
            TxtSenha.TabIndex = 1;
            TxtSenha.Text = "SENHA";
            TxtSenha.Enter += TxtSenha_Enter;
            TxtSenha.Leave += TxtSenha_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(115, 130);
            label1.Name = "label1";
            label1.Size = new Size(306, 25);
            label1.TabIndex = 3;
            label1.Text = "__________________________________________";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 450);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 304);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TextBox textBox2;
        private TextBox TxtLogin;
        private Button btnEntrar;
        private TextBox TxtSenha;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label minimiza;
        private Label fecha;
    }
}
