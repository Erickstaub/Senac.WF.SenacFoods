namespace SenacFoods
{
    partial class FrmUsuarioCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioCad));
            btnEntrar = new Button();
            label1 = new Label();
            TxtSenha = new TextBox();
            TxtNome = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            minimiza = new Label();
            fecha = new Label();
            pictureBox1 = new PictureBox();
            TxtEmail = new TextBox();
            TxtConfSenha = new TextBox();
            CBPerfil = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Red;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Comic Sans MS", 24F);
            btnEntrar.ForeColor = Color.Honeydew;
            btnEntrar.Location = new Point(362, 374);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(366, 81);
            btnEntrar.TabIndex = 20;
            btnEntrar.Text = "CADASTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(79, 343);
            label1.Name = "label1";
            label1.Size = new Size(112, 54);
            label1.TabIndex = 19;
            label1.Text = "Perfil";
            // 
            // TxtSenha
            // 
            TxtSenha.BackColor = SystemColors.HighlightText;
            TxtSenha.Font = new Font("Comic Sans MS", 18F);
            TxtSenha.ForeColor = SystemColors.ControlText;
            TxtSenha.Location = new Point(362, 162);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(366, 58);
            TxtSenha.TabIndex = 18;
            TxtSenha.Text = "SENHA";
            TxtSenha.Enter += TxtSenha_Enter;
            TxtSenha.Leave += TxtSenha_Leave;
            // 
            // TxtNome
            // 
            TxtNome.BackColor = SystemColors.HighlightText;
            TxtNome.Font = new Font("Comic Sans MS", 18F);
            TxtNome.ForeColor = SystemColors.ControlText;
            TxtNome.Location = new Point(362, 98);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(366, 58);
            TxtNome.TabIndex = 17;
            TxtNome.Text = "NOME";
            TxtNome.Enter += TxtNome_Enter;
            TxtNome.Leave += TxtNome_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(224, 223);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
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
            panel2.TabIndex = 15;
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
            minimiza.Click += minimiza_Click;
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
            // TxtEmail
            // 
            TxtEmail.BackColor = SystemColors.HighlightText;
            TxtEmail.Font = new Font("Comic Sans MS", 18F);
            TxtEmail.ForeColor = SystemColors.ControlText;
            TxtEmail.Location = new Point(362, 290);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(366, 58);
            TxtEmail.TabIndex = 21;
            TxtEmail.Text = "EMAIL";
            TxtEmail.Enter += TxtEmail_Enter;
            TxtEmail.Leave += TxtEmail_Leave;
            // 
            // TxtConfSenha
            // 
            TxtConfSenha.BackColor = SystemColors.HighlightText;
            TxtConfSenha.Font = new Font("Comic Sans MS", 18F);
            TxtConfSenha.ForeColor = SystemColors.ControlText;
            TxtConfSenha.Location = new Point(362, 226);
            TxtConfSenha.Name = "TxtConfSenha";
            TxtConfSenha.Size = new Size(366, 58);
            TxtConfSenha.TabIndex = 22;
            TxtConfSenha.Text = "CONFIRMAR SENHA";
            TxtConfSenha.Enter += TxtConfSenha_Enter;
            TxtConfSenha.Leave += TxtConfSenha_Leave;
            // 
            // CBPerfil
            // 
            CBPerfil.Font = new Font("Segoe UI", 14F);
            CBPerfil.FormattingEnabled = true;
            CBPerfil.Items.AddRange(new object[] { "Admin", "Operador", "Usuario" });
            CBPerfil.Location = new Point(24, 400);
            CBPerfil.Name = "CBPerfil";
            CBPerfil.Size = new Size(224, 46);
            CBPerfil.TabIndex = 23;
            // 
            // FrmUsuarioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CBPerfil);
            Controls.Add(TxtConfSenha);
            Controls.Add(TxtEmail);
            Controls.Add(btnEntrar);
            Controls.Add(label1);
            Controls.Add(TxtSenha);
            Controls.Add(TxtNome);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmUsuarioCad";
            Text = "FrmUsuarioCad";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Label label1;
        private TextBox TxtSenha;
        private TextBox TxtNome;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label minimiza;
        private Label fecha;
        private PictureBox pictureBox1;
        private TextBox TxtEmail;
        private TextBox TxtConfSenha;
        private ComboBox CBPerfil;
    }
}