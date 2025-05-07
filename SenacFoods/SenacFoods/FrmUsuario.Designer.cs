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
            pictureBox2 = new PictureBox();
            TxtLogin = new TextBox();
            TxtSenha = new TextBox();
            label1 = new Label();
            btnEntrar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel2.Size = new Size(805, 78);
            panel2.TabIndex = 9;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 116);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(224, 223);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // TxtLogin
            // 
            TxtLogin.BackColor = SystemColors.HighlightText;
            TxtLogin.Font = new Font("Comic Sans MS", 18F);
            TxtLogin.ForeColor = SystemColors.ControlText;
            TxtLogin.Location = new Point(362, 95);
            TxtLogin.Name = "TxtLogin";
            TxtLogin.Size = new Size(366, 58);
            TxtLogin.TabIndex = 11;
            TxtLogin.Text = "ALTERAR NOME";
            TxtLogin.Enter += TxtLogin_Enter;
            TxtLogin.Leave += TxtLogin_Leave;
            // 
            // TxtSenha
            // 
            TxtSenha.BackColor = SystemColors.HighlightText;
            TxtSenha.Font = new Font("Comic Sans MS", 18F);
            TxtSenha.ForeColor = SystemColors.ControlText;
            TxtSenha.Location = new Point(362, 174);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(366, 58);
            TxtSenha.TabIndex = 12;
            TxtSenha.Text = "ALTERAR SENHA";
            TxtSenha.Enter += TxtSenha_Enter;
            TxtSenha.Leave += TxtSenha_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(79, 364);
            label1.Name = "label1";
            label1.Size = new Size(112, 38);
            label1.TabIndex = 13;
            label1.Text = "Apelido";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Red;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Comic Sans MS", 24F);
            btnEntrar.ForeColor = Color.Honeydew;
            btnEntrar.Location = new Point(362, 275);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(366, 138);
            btnEntrar.TabIndex = 14;
            btnEntrar.Text = "SAIR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEntrar);
            Controls.Add(label1);
            Controls.Add(TxtSenha);
            Controls.Add(TxtLogin);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label minimiza;
        private Label fecha;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox TxtLogin;
        private TextBox TxtSenha;
        private Label label1;
        private Button btnEntrar;
    }
}