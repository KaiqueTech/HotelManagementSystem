using HotelManagement.Telas;

namespace HotelManagement
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //TESTE 
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();

            // Esconde a tela de login antes de fechá-la
            this.Hide();

            // Fecha a tela de login após abrir a principal
            telaPrincipal.FormClosed += (s, args) => this.Close();

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
