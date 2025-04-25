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
            panel1 = new Panel();
            panel2 = new Panel();
            TxtLogin = new TextBox();
            btnEntrar = new Button();
            TxtSenha = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(TxtLogin);
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(TxtSenha);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(211, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 450);
            panel2.TabIndex = 1;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox TxtLogin;
        private Button btnEntrar;
        private TextBox TxtSenha;
        private Label label1;
    }
}
