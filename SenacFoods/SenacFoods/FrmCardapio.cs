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
        CardapioItem? cdpselec;
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
                    cardapios = cardapios.Where(c => c.Titulo.Contains(txtPesquisa.Text) ||
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

        }

        private void btnmaisitem_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                cdpselec = dataGridView1.Rows[e.RowIndex].DataBoundItem as CardapioItem;
                btnEditar.Enabled = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cdpselec != null)
            {
                var cdpcad = new FrmCardapioCad(cdpselec);
                cdpcad.Show();
                BuscarCardapio();
                cdpselec = null;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(cdpselec != null)
            {
                using (var bd = new ComandaDBContext())
                {
                    bd.CardapioItems.Remove(cdpselec);
                    bd.SaveChanges();
                }
                MessageBox.Show("Cardápio excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarCardapio();
                cdpselec = null;
              
            }
        }
    }
}
