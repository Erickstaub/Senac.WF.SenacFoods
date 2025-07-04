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
    public partial class FrmMesa : Form
    {
        public FrmMesa()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMesa_Load(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void BuscarMesa()
        {
            using (var bd = new ComandaDBContext())
            {
                var mesa = bd.Mesas.AsQueryable();
                dataGridView1.DataSource = mesa.ToList();
            }
        }

        private void fecha_Click(object sender, EventArgs e)
        {
            this.Close();
            var f = new FrmPrincipal(" ", "");
            f.Show();
        }

        private void btnmaisitem_Click(object sender, EventArgs e)
        {
            var fm = new FrmMesaCad();
            fm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var valor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            label1.Text = valor;
        }
    }
}
