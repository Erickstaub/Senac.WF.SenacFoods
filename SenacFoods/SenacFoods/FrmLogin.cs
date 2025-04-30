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
            this.Hide();
            var prm = new frmPrincipal();
            prm.Show();
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
