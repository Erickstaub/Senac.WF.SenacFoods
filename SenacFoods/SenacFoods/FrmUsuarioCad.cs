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
    public partial class FrmUsuarioCad : Form
    {
        private Usuario _usuario;
        public FrmUsuarioCad()
        {
            InitializeComponent();
        }
        public FrmUsuarioCad(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            if (_usuario != null)
            {
                TxtLogin.Text = _usuario.Nome;
                TxtSenha.Text = _usuario.Senha;
                TxtEmail.Text = _usuario.Email;
                



            }
        }
        private void InserirCardapio()
        {
            using (var banco = new ComandaDBContext())
            {
                string nome = TxtLogin.Text;
                string senha = TxtSenha.Text;
                string email = TxtEmail.Text;
                int ativo = 1;
                string perfil = comboBox1.Text;

                var usu = new Usuario()
                {
                    Nome = nome,
                    Senha = senha,
                    Email = email,
                    Ativo = Convert.ToBoolean(ativo),
                    Perfil = perfil,
                    

                };
                banco.Usuarios.Add(usu);
                banco.SaveChanges();
            }
            MessageBox.Show("Usuario cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != TxtSenha.Text || TxtLogin.Text == null || TxtSenha.Text == null || TxtEmail.Text == null)
            {
                MessageBox.Show("Algo de errado ocorreu! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (_usuario == null)
                {
                    InserirCardapio();
                    this.Close();
                }
                else
                {
                    AtualizarUsuario();
                }
            }
        }

        private void AtualizarUsuario()
        {
            using (var banco = new ComandaDBContext())
            {
                string nome = TxtLogin.Text;
                string senha = TxtSenha.Text;
                string email = TxtEmail.Text;
                int ativo = 1;
                string perfil = comboBox1.Text;
                Usuario usuario = banco.Usuarios.First(x => x.Id == _usuario.Id);
                usuario.Nome = nome;
                usuario.Senha = senha;
                usuario.Email = email;
                usuario.Ativo = Convert.ToBoolean(ativo);
                usuario.Perfil = perfil;
                banco.Usuarios.Update(usuario);
                banco.SaveChanges();
            }
            MessageBox.Show("Usuario salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            if (TxtSenha.TextLength <= 5)
            {
    
                MessageBox.Show("Senha pequena", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void TxtLogin_Enter(object sender, EventArgs e)
        {
            if (TxtLogin.Text != null) { 
            TxtLogin.Text = null;
            }
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            if (TxtSenha.Text != null) { 
            TxtSenha.Text = null;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text != null) {
            textBox2.Text = null;
            }

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text != null) { 
            TxtEmail.Text = null;
            }

        }
    }
}
