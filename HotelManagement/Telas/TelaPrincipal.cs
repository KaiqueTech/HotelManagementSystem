using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.Telas
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            ConfigurarLayout();
        }

        private void ConfigurarLayout()
        {

            // Criar o Rodapé (Panel fixado no final)
            Panel rodape = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 30,
                BackColor = Color.LightGray
            };

            Label lblRodape = new Label
            {
                Text = "Sistema Hotel Manager - Desenvolvido por Kaique Bezerra - 2025",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter

            };
            rodape.Controls.Add(lblRodape);
            this.Controls.Add(rodape);
        }

        private void lblNomeCargo_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
