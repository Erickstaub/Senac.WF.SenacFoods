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
        Usuario? ususelec;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void fecha_Click(object sender, EventArgs e)
        {
            this.Close();
            var prm = new FrmPrincipal("", "");
            prm.Show();
        }



        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
            var ini = new FrmLogin();
            ini.Show();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void BuscarUsuario()
        {
            using (var bd = new ComandaDBContext())
            {
                var usuario = bd.Usuarios.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    usuario = usuario.Where(c => c.Nome.Contains(txtPesquisa.Text) ||
                                                c.Email.Contains(txtPesquisa.Text));
                }
                dataGridView1.DataSource = usuario.ToList();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                ususelec = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
               string selec = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                label2.Text = selec;
            }
        }

        private void btnmaisitem_Click(object sender, EventArgs e)
        {
            new FrmUsuarioCad().ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirmacao = MessageBox.Show("Você tem certesa disso?!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmacao == DialogResult.Yes)
            {
                if (ususelec != null)
                {

                    using (var bd = new ComandaDBContext())
                    {
                        bd.Usuarios.Remove(ususelec);
                        bd.SaveChanges();
                    }
                    MessageBox.Show("Usuario excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BuscarUsuario();
                    ususelec = null;

                }
            }
            else
            {
                ususelec = null;
            }
        }

        private void fecha_Click_1(object sender, EventArgs e)
        {
            this.Close();
            var a = new FrmPrincipal(" ", "");
            a.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ususelec != null)
            {
                var usucad = new FrmUsuarioCad(ususelec);
                usucad.Show();
                BuscarUsuario();
                ususelec = null;
            }
        }

        private void minimiza_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
    }
}
