namespace SenacFoods
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool loginValido = ValidateLogin(TxtLogin.Text, TxtSenha.Text);

            if (loginValido)
            {
                this.Hide();
                var prm = new FrmPrincipal(TxtLogin.Text, TxtSenha.Text);
                prm.Show();
            }
        }

        private bool ValidateLogin(string nome, string senha)
        {
            if (nome == "admin" && senha == "123") { 
                return true;
            }
            else
            {
              MessageBox.Show("Tudo errado");
            }

                return false;
        }

        private void TxtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtLogin_Enter(object sender, EventArgs e)
        {
            if (TxtLogin.Text == "USUARIO")
                TxtLogin.Text = string.Empty;

        }

        private void TxtLogin_Leave(object sender, EventArgs e)
        {
            if (TxtLogin.Text == string.Empty)
                TxtLogin.Text = "USUARIO";
        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            if (TxtSenha.Text == "SENHA")
                TxtSenha.Text = string.Empty;
        }

        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            if (TxtSenha.Text == string.Empty)
                TxtSenha.Text = "SENHA";
        }

        private void fecha_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimiza_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
