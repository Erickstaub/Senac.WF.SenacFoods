using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SenacFoods
{
    public partial class FrmMesaCad : Form
    {
        public FrmMesaCad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarMesa();
            this.Close();
        }

        private void SalvarMesa()
        {
            using (var b = new ComandaDBContext())
            {
                int.TryParse(txtNom.Text, out int numero);
                var numeromesa = new Mesa()
                {
                    NumeroMesa = numero
                };
                b.Mesas.Add(numeromesa);
                b.SaveChanges();
            }
            MessageBox.Show("Cardapio salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Enter(object sender, EventArgs e)
        {
            label2.Text = txtNom.Text;
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            label2.Text = txtNom.Text;
        }

        private void FrmMesaCad_Load(object sender, EventArgs e)
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
        }
    }
}

