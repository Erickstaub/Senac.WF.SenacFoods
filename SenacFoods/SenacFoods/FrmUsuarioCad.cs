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
                TxtNome.Text = _usuario.Nome;
                TxtSenha.Text = _usuario.Senha;
                TxtEmail.Text = _usuario.Email;
            }
        }

        private void InserirCardapio()
        {
            using (var banco = new ComandaDBContext())
            {
                string nome = TxtNome.Text;
                string senha = TxtSenha.Text;
                string email = TxtEmail.Text;
                int ativo = 1;
                string perfil = CBPerfil.Text;
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
            if (TxtConfSenha.Text != TxtSenha.Text || TxtNome.TextLength <= 1 || TxtSenha.TextLength <= 1 || TxtEmail.TextLength <= 1)
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
                    EditarUsuario();
                }
            }
        }

        private void EditarUsuario()
        {
            using (var banco = new ComandaDBContext())
            {
                string nome = TxtNome.Text;
                string senha = TxtSenha.Text;
                string email = TxtEmail.Text;
                int ativo = 1;
                string perfil = CBPerfil.Text;
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
                TxtSenha.Text = null;
            }

            if (TxtSenha.TextLength == 0)
            {
                TxtSenha.Text = "SENHA";
            }
        }

        private void TxtNome_Enter(object sender, EventArgs e)
        {
            if (_usuario == null)
            {
                if (TxtNome.Text != null)
                {
                    TxtNome.Text = null;
                }
            }
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            if (_usuario == null)
            {
                if (TxtSenha.TextLength > 0)
                {
                    TxtSenha.Text = null;
                }
            }
        }

        private void TxtConfSenha_Enter(object sender, EventArgs e)
        {
            if (_usuario == null)
            {
                if (TxtConfSenha.Text != null)
                {
                    TxtConfSenha.Text = null;
                }
            }
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            if (_usuario == null)
            {
                if (TxtEmail.Text != null)
                {
                    TxtEmail.Text = null;
                }
            }
        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            if (TxtNome.TextLength == 0)
            {
                TxtNome.Text = "NOME";
            }
        }

        private void TxtConfSenha_Leave(object sender, EventArgs e)
        {
            if (TxtConfSenha.TextLength == 0)
            {
                TxtConfSenha.Text = "CONFIRMAR SENHA";
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (TxtEmail.TextLength == 0)
            {
                TxtEmail.Text = "EMAIL";
            }
        }

        private void minimiza_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
    }
}
