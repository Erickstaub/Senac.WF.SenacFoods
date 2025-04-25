namespace SenacFoods
{
    partial class frmPrincipal
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
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(2, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 202);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 64, 0);
            button1.Dock = DockStyle.Left;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(199, 202);
            button1.TabIndex = 0;
            button1.Text = "Cardapio";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Dock = DockStyle.Left;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14F);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(199, 0);
            button2.Name = "button2";
            button2.Size = new Size(201, 202);
            button2.TabIndex = 1;
            button2.Text = "Comanda";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Purple;
            button3.Dock = DockStyle.Right;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 14F);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(594, 0);
            button3.Name = "button3";
            button3.Size = new Size(209, 202);
            button3.TabIndex = 2;
            button3.Text = "Usuarios";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.Dock = DockStyle.Fill;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 14F);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(400, 0);
            button4.Name = "button4";
            button4.Size = new Size(194, 202);
            button4.TabIndex = 3;
            button4.Text = "Pedido de cozinha";
            button4.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}