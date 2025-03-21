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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            menuStrip1 = new MenuStrip();
            menuCadastros = new ToolStripMenuItem();
            subMenuHospedes = new ToolStripMenuItem();
            subMenuHospedesCadastrar = new ToolStripMenuItem();
            subMenuHospedesConsultar = new ToolStripMenuItem();
            subMenuQuartos = new ToolStripMenuItem();
            subMenuQuartosCadastrar = new ToolStripMenuItem();
            subMenuQuartosConsultar = new ToolStripMenuItem();
            MenuCadFuncionario = new ToolStripMenuItem();
            menuFuncionarioCad = new ToolStripMenuItem();
            menuFuncionarioConsult = new ToolStripMenuItem();
            MenuCadFornecedor = new ToolStripMenuItem();
            menuFornecedorCad = new ToolStripMenuItem();
            menuFornecedorConsult = new ToolStripMenuItem();
            MenuCadProduto = new ToolStripMenuItem();
            menuProdutoCad = new ToolStripMenuItem();
            menuProdutoConsult = new ToolStripMenuItem();
            MenuCadServico = new ToolStripMenuItem();
            menuServicoCad = new ToolStripMenuItem();
            menuServicoConsult = new ToolStripMenuItem();
            menuReservas = new ToolStripMenuItem();
            menuCadReserva = new ToolStripMenuItem();
            menuConsultReserva = new ToolStripMenuItem();
            menuFinalizarReserva = new ToolStripMenuItem();
            menuVendas = new ToolStripMenuItem();
            menuVendaProd = new ToolStripMenuItem();
            menuVendaServ = new ToolStripMenuItem();
            menuFinanceiro = new ToolStripMenuItem();
            MenuContaPagar = new ToolStripMenuItem();
            menuContaPagCad = new ToolStripMenuItem();
            menuContaPagConsult = new ToolStripMenuItem();
            MenuContaReceb = new ToolStripMenuItem();
            menuContaRecebCad = new ToolStripMenuItem();
            menuContaRecebConsul = new ToolStripMenuItem();
            MenuBalanco = new ToolStripMenuItem();
            menuRelatorios = new ToolStripMenuItem();
            financeiroToolStripMenuItem = new ToolStripMenuItem();
            contasAPagarToolStripMenuItem = new ToolStripMenuItem();
            contasAReceberToolStripMenuItem = new ToolStripMenuItem();
            balançoToolStripMenuItem = new ToolStripMenuItem();
            reservasToolStripMenuItem = new ToolStripMenuItem();
            quartosDisponiveisToolStripMenuItem = new ToolStripMenuItem();
            quartosOcupadosToolStripMenuItem = new ToolStripMenuItem();
            reservasFuturasToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            hospedesToolStripMenuItem = new ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            menuSegurança = new ToolStripMenuItem();
            fazerBackupToolStripMenuItem = new ToolStripMenuItem();
            restaurarBackupToolStripMenuItem = new ToolStripMenuItem();
            menuFerramentas = new ToolStripMenuItem();
            telaDeFundoToolStripMenuItem = new ToolStripMenuItem();
            addImagemToolStripMenuItem = new ToolStripMenuItem();
            apagarImagemToolStripMenuItem = new ToolStripMenuItem();
            restaurarPadrãoToolStripMenuItem = new ToolStripMenuItem();
            sobreOSistemaToolStripMenuItem = new ToolStripMenuItem();
            menuSair = new ToolStripMenuItem();
            panel1 = new Panel();
            trackBar1 = new TrackBar();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuCadastros, menuReservas, menuVendas, menuFinanceiro, menuRelatorios, menuSegurança, menuFerramentas, menuSair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(867, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastros
            // 
            menuCadastros.DropDownItems.AddRange(new ToolStripItem[] { subMenuHospedes, subMenuQuartos, MenuCadFuncionario, MenuCadFornecedor, MenuCadProduto, MenuCadServico });
            menuCadastros.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuCadastros.Image = (Image)resources.GetObject("menuCadastros.Image");
            menuCadastros.Name = "menuCadastros";
            menuCadastros.Size = new Size(95, 21);
            menuCadastros.Text = "Cadastros";
            // 
            // subMenuHospedes
            // 
            subMenuHospedes.DropDownItems.AddRange(new ToolStripItem[] { subMenuHospedesCadastrar, subMenuHospedesConsultar });
            subMenuHospedes.Image = (Image)resources.GetObject("subMenuHospedes.Image");
            subMenuHospedes.Name = "subMenuHospedes";
            subMenuHospedes.Size = new Size(156, 22);
            subMenuHospedes.Text = "Hospedes";
            // 
            // subMenuHospedesCadastrar
            // 
            subMenuHospedesCadastrar.Name = "subMenuHospedesCadastrar";
            subMenuHospedesCadastrar.Size = new Size(133, 22);
            subMenuHospedesCadastrar.Text = "Cadastrar";
            // 
            // subMenuHospedesConsultar
            // 
            subMenuHospedesConsultar.Name = "subMenuHospedesConsultar";
            subMenuHospedesConsultar.Size = new Size(133, 22);
            subMenuHospedesConsultar.Text = "Consultar";
            // 
            // subMenuQuartos
            // 
            subMenuQuartos.DropDownItems.AddRange(new ToolStripItem[] { subMenuQuartosCadastrar, subMenuQuartosConsultar });
            subMenuQuartos.Image = (Image)resources.GetObject("subMenuQuartos.Image");
            subMenuQuartos.Name = "subMenuQuartos";
            subMenuQuartos.Size = new Size(156, 22);
            subMenuQuartos.Text = "Quartos";
            // 
            // subMenuQuartosCadastrar
            // 
            subMenuQuartosCadastrar.Name = "subMenuQuartosCadastrar";
            subMenuQuartosCadastrar.Size = new Size(133, 22);
            subMenuQuartosCadastrar.Text = "Cadastrar";
            // 
            // subMenuQuartosConsultar
            // 
            subMenuQuartosConsultar.Name = "subMenuQuartosConsultar";
            subMenuQuartosConsultar.Size = new Size(133, 22);
            subMenuQuartosConsultar.Text = "Consultar";
            // 
            // MenuCadFuncionario
            // 
            MenuCadFuncionario.DropDownItems.AddRange(new ToolStripItem[] { menuFuncionarioCad, menuFuncionarioConsult });
            MenuCadFuncionario.Name = "MenuCadFuncionario";
            MenuCadFuncionario.Size = new Size(156, 22);
            MenuCadFuncionario.Text = "Funcionários";
            // 
            // menuFuncionarioCad
            // 
            menuFuncionarioCad.Name = "menuFuncionarioCad";
            menuFuncionarioCad.Size = new Size(133, 22);
            menuFuncionarioCad.Text = "Cadastrar";
            // 
            // menuFuncionarioConsult
            // 
            menuFuncionarioConsult.Name = "menuFuncionarioConsult";
            menuFuncionarioConsult.Size = new Size(133, 22);
            menuFuncionarioConsult.Text = "Consultar";
            // 
            // MenuCadFornecedor
            // 
            MenuCadFornecedor.DropDownItems.AddRange(new ToolStripItem[] { menuFornecedorCad, menuFornecedorConsult });
            MenuCadFornecedor.Name = "MenuCadFornecedor";
            MenuCadFornecedor.Size = new Size(156, 22);
            MenuCadFornecedor.Text = "Fornecedores";
            // 
            // menuFornecedorCad
            // 
            menuFornecedorCad.Name = "menuFornecedorCad";
            menuFornecedorCad.Size = new Size(133, 22);
            menuFornecedorCad.Text = "Cadastrar";
            // 
            // menuFornecedorConsult
            // 
            menuFornecedorConsult.Name = "menuFornecedorConsult";
            menuFornecedorConsult.Size = new Size(133, 22);
            menuFornecedorConsult.Text = "Consultar";
            // 
            // MenuCadProduto
            // 
            MenuCadProduto.DropDownItems.AddRange(new ToolStripItem[] { menuProdutoCad, menuProdutoConsult });
            MenuCadProduto.Name = "MenuCadProduto";
            MenuCadProduto.Size = new Size(156, 22);
            MenuCadProduto.Text = "Produtos";
            // 
            // menuProdutoCad
            // 
            menuProdutoCad.Name = "menuProdutoCad";
            menuProdutoCad.Size = new Size(133, 22);
            menuProdutoCad.Text = "Cadastrar";
            // 
            // menuProdutoConsult
            // 
            menuProdutoConsult.Name = "menuProdutoConsult";
            menuProdutoConsult.Size = new Size(133, 22);
            menuProdutoConsult.Text = "Consultar";
            // 
            // MenuCadServico
            // 
            MenuCadServico.DropDownItems.AddRange(new ToolStripItem[] { menuServicoCad, menuServicoConsult });
            MenuCadServico.Name = "MenuCadServico";
            MenuCadServico.Size = new Size(156, 22);
            MenuCadServico.Text = "Serviços";
            // 
            // menuServicoCad
            // 
            menuServicoCad.Name = "menuServicoCad";
            menuServicoCad.Size = new Size(133, 22);
            menuServicoCad.Text = "Cadastrar";
            // 
            // menuServicoConsult
            // 
            menuServicoConsult.Name = "menuServicoConsult";
            menuServicoConsult.Size = new Size(133, 22);
            menuServicoConsult.Text = "Consultar";
            // 
            // menuReservas
            // 
            menuReservas.DropDownItems.AddRange(new ToolStripItem[] { menuCadReserva, menuConsultReserva, menuFinalizarReserva });
            menuReservas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuReservas.Image = (Image)resources.GetObject("menuReservas.Image");
            menuReservas.Name = "menuReservas";
            menuReservas.Size = new Size(88, 21);
            menuReservas.Text = "Reservas";
            // 
            // menuCadReserva
            // 
            menuCadReserva.Name = "menuCadReserva";
            menuCadReserva.Size = new Size(183, 22);
            menuCadReserva.Text = "Cadastrar Reserva";
            // 
            // menuConsultReserva
            // 
            menuConsultReserva.Name = "menuConsultReserva";
            menuConsultReserva.Size = new Size(183, 22);
            menuConsultReserva.Text = "Consultar Reserva";
            // 
            // menuFinalizarReserva
            // 
            menuFinalizarReserva.Name = "menuFinalizarReserva";
            menuFinalizarReserva.Size = new Size(183, 22);
            menuFinalizarReserva.Text = "Finalizar Reserva";
            // 
            // menuVendas
            // 
            menuVendas.DropDownItems.AddRange(new ToolStripItem[] { menuVendaProd, menuVendaServ });
            menuVendas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuVendas.Image = (Image)resources.GetObject("menuVendas.Image");
            menuVendas.Name = "menuVendas";
            menuVendas.Size = new Size(78, 21);
            menuVendas.Text = "Vendas";
            menuVendas.Click += menuConsumo_Click;
            // 
            // menuVendaProd
            // 
            menuVendaProd.Name = "menuVendaProd";
            menuVendaProd.Size = new Size(129, 22);
            menuVendaProd.Text = "Produtos";
            // 
            // menuVendaServ
            // 
            menuVendaServ.Name = "menuVendaServ";
            menuVendaServ.Size = new Size(129, 22);
            menuVendaServ.Text = "Serviços";
            // 
            // menuFinanceiro
            // 
            menuFinanceiro.DropDownItems.AddRange(new ToolStripItem[] { MenuContaPagar, MenuContaReceb, MenuBalanco });
            menuFinanceiro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuFinanceiro.Image = (Image)resources.GetObject("menuFinanceiro.Image");
            menuFinanceiro.Name = "menuFinanceiro";
            menuFinanceiro.Size = new Size(95, 21);
            menuFinanceiro.Text = "Financeiro";
            // 
            // MenuContaPagar
            // 
            MenuContaPagar.DropDownItems.AddRange(new ToolStripItem[] { menuContaPagCad, menuContaPagConsult });
            MenuContaPagar.Name = "MenuContaPagar";
            MenuContaPagar.Size = new Size(179, 22);
            MenuContaPagar.Text = "Contas a Pagar";
            // 
            // menuContaPagCad
            // 
            menuContaPagCad.Name = "menuContaPagCad";
            menuContaPagCad.Size = new Size(133, 22);
            menuContaPagCad.Text = "Cadastrar";
            // 
            // menuContaPagConsult
            // 
            menuContaPagConsult.Name = "menuContaPagConsult";
            menuContaPagConsult.Size = new Size(133, 22);
            menuContaPagConsult.Text = "Consultar";
            // 
            // MenuContaReceb
            // 
            MenuContaReceb.DropDownItems.AddRange(new ToolStripItem[] { menuContaRecebCad, menuContaRecebConsul });
            MenuContaReceb.Name = "MenuContaReceb";
            MenuContaReceb.Size = new Size(179, 22);
            MenuContaReceb.Text = "Contas a Receber";
            // 
            // menuContaRecebCad
            // 
            menuContaRecebCad.Name = "menuContaRecebCad";
            menuContaRecebCad.Size = new Size(133, 22);
            menuContaRecebCad.Text = "Cadastrar";
            // 
            // menuContaRecebConsul
            // 
            menuContaRecebConsul.Name = "menuContaRecebConsul";
            menuContaRecebConsul.Size = new Size(133, 22);
            menuContaRecebConsul.Text = "Consultar";
            // 
            // MenuBalanco
            // 
            MenuBalanco.Name = "MenuBalanco";
            MenuBalanco.Size = new Size(179, 22);
            MenuBalanco.Text = "Balanço";
            // 
            // menuRelatorios
            // 
            menuRelatorios.DropDownItems.AddRange(new ToolStripItem[] { financeiroToolStripMenuItem, reservasToolStripMenuItem, vendasToolStripMenuItem, hospedesToolStripMenuItem, funcionáriosToolStripMenuItem, fornecedoresToolStripMenuItem });
            menuRelatorios.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuRelatorios.Image = (Image)resources.GetObject("menuRelatorios.Image");
            menuRelatorios.Name = "menuRelatorios";
            menuRelatorios.Size = new Size(95, 21);
            menuRelatorios.Text = "Relatórios";
            // 
            // financeiroToolStripMenuItem
            // 
            financeiroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contasAPagarToolStripMenuItem, contasAReceberToolStripMenuItem, balançoToolStripMenuItem });
            financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            financeiroToolStripMenuItem.Size = new Size(156, 22);
            financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // contasAPagarToolStripMenuItem
            // 
            contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            contasAPagarToolStripMenuItem.Size = new Size(179, 22);
            contasAPagarToolStripMenuItem.Text = "Contas a Pagar";
            // 
            // contasAReceberToolStripMenuItem
            // 
            contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            contasAReceberToolStripMenuItem.Size = new Size(179, 22);
            contasAReceberToolStripMenuItem.Text = "Contas a Receber";
            // 
            // balançoToolStripMenuItem
            // 
            balançoToolStripMenuItem.Name = "balançoToolStripMenuItem";
            balançoToolStripMenuItem.Size = new Size(179, 22);
            balançoToolStripMenuItem.Text = "Balanço";
            // 
            // reservasToolStripMenuItem
            // 
            reservasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quartosDisponiveisToolStripMenuItem, quartosOcupadosToolStripMenuItem, reservasFuturasToolStripMenuItem });
            reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            reservasToolStripMenuItem.Size = new Size(156, 22);
            reservasToolStripMenuItem.Text = "Reservas";
            // 
            // quartosDisponiveisToolStripMenuItem
            // 
            quartosDisponiveisToolStripMenuItem.Name = "quartosDisponiveisToolStripMenuItem";
            quartosDisponiveisToolStripMenuItem.Size = new Size(193, 22);
            quartosDisponiveisToolStripMenuItem.Text = "Quartos Disponiveis";
            // 
            // quartosOcupadosToolStripMenuItem
            // 
            quartosOcupadosToolStripMenuItem.Name = "quartosOcupadosToolStripMenuItem";
            quartosOcupadosToolStripMenuItem.Size = new Size(193, 22);
            quartosOcupadosToolStripMenuItem.Text = "Quartos Ocupados";
            // 
            // reservasFuturasToolStripMenuItem
            // 
            reservasFuturasToolStripMenuItem.Name = "reservasFuturasToolStripMenuItem";
            reservasFuturasToolStripMenuItem.Size = new Size(193, 22);
            reservasFuturasToolStripMenuItem.Text = "Reservas Futuras";
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(156, 22);
            vendasToolStripMenuItem.Text = "Vendas";
            // 
            // hospedesToolStripMenuItem
            // 
            hospedesToolStripMenuItem.Name = "hospedesToolStripMenuItem";
            hospedesToolStripMenuItem.Size = new Size(156, 22);
            hospedesToolStripMenuItem.Text = "Hospedes";
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new Size(156, 22);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(156, 22);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // menuSegurança
            // 
            menuSegurança.DropDownItems.AddRange(new ToolStripItem[] { fazerBackupToolStripMenuItem, restaurarBackupToolStripMenuItem });
            menuSegurança.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuSegurança.Image = (Image)resources.GetObject("menuSegurança.Image");
            menuSegurança.Name = "menuSegurança";
            menuSegurança.Size = new Size(97, 21);
            menuSegurança.Text = "Segurança";
            // 
            // fazerBackupToolStripMenuItem
            // 
            fazerBackupToolStripMenuItem.Name = "fazerBackupToolStripMenuItem";
            fazerBackupToolStripMenuItem.Size = new Size(177, 22);
            fazerBackupToolStripMenuItem.Text = "Fazer Backup";
            // 
            // restaurarBackupToolStripMenuItem
            // 
            restaurarBackupToolStripMenuItem.Name = "restaurarBackupToolStripMenuItem";
            restaurarBackupToolStripMenuItem.Size = new Size(177, 22);
            restaurarBackupToolStripMenuItem.Text = "Restaurar Backup";
            // 
            // menuFerramentas
            // 
            menuFerramentas.DropDownItems.AddRange(new ToolStripItem[] { telaDeFundoToolStripMenuItem, sobreOSistemaToolStripMenuItem });
            menuFerramentas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuFerramentas.Image = (Image)resources.GetObject("menuFerramentas.Image");
            menuFerramentas.Name = "menuFerramentas";
            menuFerramentas.Size = new Size(108, 21);
            menuFerramentas.Text = "Ferramentas";
            // 
            // telaDeFundoToolStripMenuItem
            // 
            telaDeFundoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addImagemToolStripMenuItem, apagarImagemToolStripMenuItem, restaurarPadrãoToolStripMenuItem });
            telaDeFundoToolStripMenuItem.Name = "telaDeFundoToolStripMenuItem";
            telaDeFundoToolStripMenuItem.Size = new Size(172, 22);
            telaDeFundoToolStripMenuItem.Text = "Tela de Fundo";
            // 
            // addImagemToolStripMenuItem
            // 
            addImagemToolStripMenuItem.Name = "addImagemToolStripMenuItem";
            addImagemToolStripMenuItem.Size = new Size(178, 22);
            addImagemToolStripMenuItem.Text = "Add Imagem";
            // 
            // apagarImagemToolStripMenuItem
            // 
            apagarImagemToolStripMenuItem.Name = "apagarImagemToolStripMenuItem";
            apagarImagemToolStripMenuItem.Size = new Size(178, 22);
            apagarImagemToolStripMenuItem.Text = "Apagar Imagem";
            // 
            // restaurarPadrãoToolStripMenuItem
            // 
            restaurarPadrãoToolStripMenuItem.Name = "restaurarPadrãoToolStripMenuItem";
            restaurarPadrãoToolStripMenuItem.Size = new Size(178, 22);
            restaurarPadrãoToolStripMenuItem.Text = "Restaurar Padrão";
            // 
            // sobreOSistemaToolStripMenuItem
            // 
            sobreOSistemaToolStripMenuItem.Name = "sobreOSistemaToolStripMenuItem";
            sobreOSistemaToolStripMenuItem.Size = new Size(172, 22);
            sobreOSistemaToolStripMenuItem.Text = "Sobre o Sistema";
            // 
            // menuSair
            // 
            menuSair.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuSair.Image = (Image)resources.GetObject("menuSair.Image");
            menuSair.Name = "menuSair";
            menuSair.Size = new Size(58, 21);
            menuSair.Text = "Sair";
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 451);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 95);
            panel1.TabIndex = 1;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(366, 400);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(164, 45);
            trackBar1.TabIndex = 2;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 544);
            Controls.Add(trackBar1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += TelaPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuCadastros;
        private ToolStripMenuItem menuReservas;
        private ToolStripMenuItem menuVendas;
        private ToolStripMenuItem menuFinanceiro;
        private ToolStripMenuItem menuRelatorios;
        private ToolStripMenuItem menuSegurança;
        private ToolStripMenuItem menuFerramentas;
        private ToolStripMenuItem menuSair;
        private ToolStripMenuItem subMenuHospedes;
        private ToolStripMenuItem subMenuHospedesCadastrar;
        private ToolStripMenuItem subMenuHospedesConsultar;
        private ToolStripMenuItem subMenuQuartos;
        private ToolStripMenuItem subMenuQuartosCadastrar;
        private ToolStripMenuItem subMenuQuartosConsultar;
        private ToolStripMenuItem MenuCadFuncionario;
        private ToolStripMenuItem menuFuncionarioCad;
        private ToolStripMenuItem menuFuncionarioConsult;
        private ToolStripMenuItem MenuCadFornecedor;
        private ToolStripMenuItem menuFornecedorCad;
        private ToolStripMenuItem menuFornecedorConsult;
        private ToolStripMenuItem MenuCadProduto;
        private ToolStripMenuItem menuProdutoCad;
        private ToolStripMenuItem menuProdutoConsult;
        private ToolStripMenuItem MenuCadServico;
        private ToolStripMenuItem menuServicoCad;
        private ToolStripMenuItem menuServicoConsult;
        private ToolStripMenuItem menuCadReserva;
        private ToolStripMenuItem menuConsultReserva;
        private ToolStripMenuItem menuFinalizarReserva;
        private ToolStripMenuItem menuVendaProd;
        private ToolStripMenuItem menuVendaServ;
        private ToolStripMenuItem MenuContaPagar;
        private ToolStripMenuItem menuContaPagCad;
        private ToolStripMenuItem menuContaPagConsult;
        private ToolStripMenuItem MenuContaReceb;
        private ToolStripMenuItem menuContaRecebCad;
        private ToolStripMenuItem menuContaRecebConsul;
        private ToolStripMenuItem MenuBalanco;
        private ToolStripMenuItem financeiroToolStripMenuItem;
        private ToolStripMenuItem contasAPagarToolStripMenuItem;
        private ToolStripMenuItem contasAReceberToolStripMenuItem;
        private ToolStripMenuItem balançoToolStripMenuItem;
        private ToolStripMenuItem reservasToolStripMenuItem;
        private ToolStripMenuItem quartosDisponiveisToolStripMenuItem;
        private ToolStripMenuItem quartosOcupadosToolStripMenuItem;
        private ToolStripMenuItem reservasFuturasToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem hospedesToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem fazerBackupToolStripMenuItem;
        private ToolStripMenuItem restaurarBackupToolStripMenuItem;
        private ToolStripMenuItem telaDeFundoToolStripMenuItem;
        private ToolStripMenuItem sobreOSistemaToolStripMenuItem;
        private ToolStripMenuItem addImagemToolStripMenuItem;
        private ToolStripMenuItem apagarImagemToolStripMenuItem;
        private ToolStripMenuItem restaurarPadrãoToolStripMenuItem;
        private Panel panel1;
        private TrackBar trackBar1;
    }
}