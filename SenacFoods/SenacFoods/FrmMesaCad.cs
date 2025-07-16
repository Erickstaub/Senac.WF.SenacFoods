using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SenacFoods
{
    public partial class FrmMesaCad : Form
    {
        private Mesa? _mesa;
        public FrmMesaCad()
        {
            InitializeComponent();
        }
        public FrmMesaCad(Mesa mesae)
        {
            _mesa = mesae;
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            if (_mesa != null)
            {
                txtNom.Text = _mesa.NumeroMesa.ToString("F0");
       
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_mesa == null)
            {
                SalvarMesa();
                _mesa = null;
                this.Close();
               
            }
            else {
                EditarMesa();
                _mesa = null;
            }
        }

        private void EditarMesa()
        {
            using (var banco = new ComandaDBContext())
            {
                int Num = int.Parse(txtNom.Text);
                //Mesa mesa = banco.Mesas.First(x => x.Id == _mesa.Id);
                _mesa.NumeroMesa = Num;
                banco.Mesas.Update(_mesa);
                banco.SaveChanges();
            }
            MessageBox.Show("Mesa editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

