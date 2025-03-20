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

        private void btnSair_Click(object sender, EventArgs e)
        {

        
        }
    }
}
