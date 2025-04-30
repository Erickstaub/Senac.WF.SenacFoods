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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
            var frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var car = new FrmCardapio();
            car.ShowDialog();
        }

        private void btncom_Click(object sender, EventArgs e)
        {
            this.Hide();
            var com = new FrmComanda();
            com.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var coz = new FrmPedidoCozinha();
            coz.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var usu = new FrmUsuario();
            usu.Show();
        }
    }
}
