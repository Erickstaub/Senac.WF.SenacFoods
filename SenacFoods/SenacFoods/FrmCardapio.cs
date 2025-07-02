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
    public partial class FrmCardapio : Form
    {
        public FrmCardapio()
        {
            InitializeComponent();
        }

        private void fecha_Click(object sender, EventArgs e)
        {
            this.Close();
            var prm = new FrmPrincipal(",", "");
            prm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCardapio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
        {
            using (var bd = new ComandaDBContext())
            {
                var cardapios = bd.CardapioItems.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    cardapios = cardapios.Where(c=>c.Titulo.Contains(txtPesquisa.Text) ||
                                                c.Descricao.Contains(txtPesquisa.Text));
                }
                dataGridView1.DataSource = cardapios.ToList();
            }
        }

        private void btnmaisiten(object sender, EventArgs e)
        {


            new FrmCardapioCad().ShowDialog();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
            var pr = new FrmCardapioCad();
            pr.Show();
        }

        private void btnmaisitem_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarCardapio();
        }
    }
}
