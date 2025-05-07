using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void fecha_Click(object sender, EventArgs e)
        {
            this.Close();
            var prm = new FrmPrincipal("","");
            prm.Show();
        }

        private void TxtLogin_Enter(object sender, EventArgs e)
        {
            TxtLogin.Text = string.Empty;
        }

        private void TxtLogin_Leave(object sender, EventArgs e)
        {
            if (TxtLogin.Text == string.Empty)
                TxtLogin.Text = "USUARIO";
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            TxtSenha.Text = string.Empty;
        }

        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            if (TxtSenha.Text == string.Empty)
                TxtSenha.Text = "SENHA";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
            var ini = new FrmLogin();
            ini.Show();
        }
    }
}
