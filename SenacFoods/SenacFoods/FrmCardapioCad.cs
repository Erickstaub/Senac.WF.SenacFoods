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
    public partial class FrmCardapioCad : Form
    {
        public FrmCardapioCad()
        {
            InitializeComponent();
        }
        public FrmCardapioCad(CardapioItem cardapioItem)
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fecha_Click(object sender, EventArgs e)
        {
            this.Close();
            var prm = new FrmCardapio();
            prm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCardapio();
            this.Close();
        }

        private void SalvarCardapio()
        {
            using (var banco = new ComandaDBContext())
            {
                string nome = txtNom.Text;
                string descricao = txtDesc.Text;
                decimal.TryParse(txtPrec.Text, out var preco);
                bool possuiPreparo = checkBox1.Checked;
                var cardapio = new CardapioItem()
                {
                    Descricao = descricao,
                    Titulo = nome,
                    Preco = preco,
                    PossuiPreparo = possuiPreparo
                };
                banco.CardapioItems.Add(cardapio);
                banco.SaveChanges();
            }
            MessageBox.Show("Cardapio salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmCardapioCad_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
        {
            using (var bd = new ComandaDBContext())
            {
                var cardapios = bd.CardapioItems.ToList();
                dataGridView1.DataSource = cardapios;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalvarCardapio();
        }
    }
}
