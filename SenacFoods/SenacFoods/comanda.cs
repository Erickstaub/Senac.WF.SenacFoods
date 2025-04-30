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
    public partial class comanda : Form
    {
        public comanda()
        {
            InitializeComponent();
        }

        private void fecha_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new frmPrincipal();
            frm.Show();
        }
    }
}
