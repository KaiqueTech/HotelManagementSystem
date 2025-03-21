namespace HotelManagement.Telas
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuCadastros = new ToolStripMenuItem();
            reservasToolStripMenuItem = new ToolStripMenuItem();
            consumoToolStripMenuItem = new ToolStripMenuItem();
            financeiroToolStripMenuItem = new ToolStripMenuItem();
            relatoriToolStripMenuItem = new ToolStripMenuItem();
            segurançaToolStripMenuItem = new ToolStripMenuItem();
            ferramentasToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            subMenuHospedes = new ToolStripMenuItem();
            subMenuHospedesCadastrar = new ToolStripMenuItem();
            subMenuHospedesConsultar = new ToolStripMenuItem();
            subMenuQuartos = new ToolStripMenuItem();
            subMenuQuartosCadastrar = new ToolStripMenuItem();
            subMenuQuartosConsultar = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuCadastros, reservasToolStripMenuItem, consumoToolStripMenuItem, financeiroToolStripMenuItem, relatoriToolStripMenuItem, segurançaToolStripMenuItem, ferramentasToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(867, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastros
            // 
            menuCadastros.DropDownItems.AddRange(new ToolStripItem[] { subMenuHospedes, subMenuQuartos });
            menuCadastros.Name = "menuCadastros";
            menuCadastros.Size = new Size(71, 20);
            menuCadastros.Text = "Cadastros";
            // 
            // reservasToolStripMenuItem
            // 
            reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            reservasToolStripMenuItem.Size = new Size(64, 20);
            reservasToolStripMenuItem.Text = "Reservas";
            // 
            // consumoToolStripMenuItem
            // 
            consumoToolStripMenuItem.Name = "consumoToolStripMenuItem";
            consumoToolStripMenuItem.Size = new Size(71, 20);
            consumoToolStripMenuItem.Text = "Consumo";
            // 
            // financeiroToolStripMenuItem
            // 
            financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            financeiroToolStripMenuItem.Size = new Size(74, 20);
            financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // relatoriToolStripMenuItem
            // 
            relatoriToolStripMenuItem.Name = "relatoriToolStripMenuItem";
            relatoriToolStripMenuItem.Size = new Size(71, 20);
            relatoriToolStripMenuItem.Text = "Relatórios";
            // 
            // segurançaToolStripMenuItem
            // 
            segurançaToolStripMenuItem.Name = "segurançaToolStripMenuItem";
            segurançaToolStripMenuItem.Size = new Size(74, 20);
            segurançaToolStripMenuItem.Text = "Segurança";
            // 
            // ferramentasToolStripMenuItem
            // 
            ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            ferramentasToolStripMenuItem.Size = new Size(84, 20);
            ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // subMenuHospedes
            // 
            subMenuHospedes.DropDownItems.AddRange(new ToolStripItem[] { subMenuHospedesCadastrar, subMenuHospedesConsultar });
            subMenuHospedes.Name = "subMenuHospedes";
            subMenuHospedes.Size = new Size(180, 22);
            subMenuHospedes.Text = "Hospedes";
            // 
            // subMenuHospedesCadastrar
            // 
            subMenuHospedesCadastrar.Name = "subMenuHospedesCadastrar";
            subMenuHospedesCadastrar.Size = new Size(180, 22);
            subMenuHospedesCadastrar.Text = "Cadastrar";
            // 
            // subMenuHospedesConsultar
            // 
            subMenuHospedesConsultar.Name = "subMenuHospedesConsultar";
            subMenuHospedesConsultar.Size = new Size(180, 22);
            subMenuHospedesConsultar.Text = "Consultar";
            // 
            // subMenuQuartos
            // 
            subMenuQuartos.DropDownItems.AddRange(new ToolStripItem[] { subMenuQuartosCadastrar, subMenuQuartosConsultar });
            subMenuQuartos.Name = "subMenuQuartos";
            subMenuQuartos.Size = new Size(180, 22);
            subMenuQuartos.Text = "Quartos";
            // 
            // subMenuQuartosCadastrar
            // 
            subMenuQuartosCadastrar.Name = "subMenuQuartosCadastrar";
            subMenuQuartosCadastrar.Size = new Size(180, 22);
            subMenuQuartosCadastrar.Text = "Cadastrar";
            // 
            // subMenuQuartosConsultar
            // 
            subMenuQuartosConsultar.Name = "subMenuQuartosConsultar";
            subMenuQuartosConsultar.Size = new Size(180, 22);
            subMenuQuartosConsultar.Text = "Consultar";
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 544);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuCadastros;
        private ToolStripMenuItem reservasToolStripMenuItem;
        private ToolStripMenuItem consumoToolStripMenuItem;
        private ToolStripMenuItem financeiroToolStripMenuItem;
        private ToolStripMenuItem relatoriToolStripMenuItem;
        private ToolStripMenuItem segurançaToolStripMenuItem;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem subMenuHospedes;
        private ToolStripMenuItem subMenuHospedesCadastrar;
        private ToolStripMenuItem subMenuHospedesConsultar;
        private ToolStripMenuItem subMenuQuartos;
        private ToolStripMenuItem subMenuQuartosCadastrar;
        private ToolStripMenuItem subMenuQuartosConsultar;
    }
}