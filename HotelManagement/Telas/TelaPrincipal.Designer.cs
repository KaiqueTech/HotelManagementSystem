﻿namespace HotelManagement.Telas
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
            menuCadFunc = new ToolStripMenuItem();
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
            panel7 = new Panel();
            monthCalendar2 = new MonthCalendar();
            panel6 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            monthCalendar1 = new MonthCalendar();
            panel4 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            lblPerfilAcesso = new Label();
            lblNomeCargo = new Label();
            lblNomeUsuarioLogado = new Label();
            lblCargo = new Label();
            lblNamePerfilAcesso = new Label();
            lblUsuario = new Label();
            panel2 = new Panel();
            lblDataHora = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            TelaFundo = new Panel();
            ImgFundo = new PictureBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            TelaFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImgFundo).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuCadastros, menuReservas, menuVendas, menuFinanceiro, menuRelatorios, menuSegurança, menuFerramentas, menuSair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(1198, 25);
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
            subMenuHospedes.Size = new Size(180, 22);
            subMenuHospedes.Text = "Hospedes";
            // 
            // subMenuHospedesCadastrar
            // 
            subMenuHospedesCadastrar.Image = (Image)resources.GetObject("subMenuHospedesCadastrar.Image");
            subMenuHospedesCadastrar.Name = "subMenuHospedesCadastrar";
            subMenuHospedesCadastrar.Size = new Size(180, 22);
            subMenuHospedesCadastrar.Text = "Cadastrar";
            // 
            // subMenuHospedesConsultar
            // 
            subMenuHospedesConsultar.Image = (Image)resources.GetObject("subMenuHospedesConsultar.Image");
            subMenuHospedesConsultar.Name = "subMenuHospedesConsultar";
            subMenuHospedesConsultar.Size = new Size(180, 22);
            subMenuHospedesConsultar.Text = "Consultar";
            // 
            // subMenuQuartos
            // 
            subMenuQuartos.DropDownItems.AddRange(new ToolStripItem[] { subMenuQuartosCadastrar, subMenuQuartosConsultar });
            subMenuQuartos.Image = (Image)resources.GetObject("subMenuQuartos.Image");
            subMenuQuartos.Name = "subMenuQuartos";
            subMenuQuartos.Size = new Size(180, 22);
            subMenuQuartos.Text = "Quartos";
            // 
            // subMenuQuartosCadastrar
            // 
            subMenuQuartosCadastrar.Image = (Image)resources.GetObject("subMenuQuartosCadastrar.Image");
            subMenuQuartosCadastrar.Name = "subMenuQuartosCadastrar";
            subMenuQuartosCadastrar.Size = new Size(180, 22);
            subMenuQuartosCadastrar.Text = "Cadastrar";
            // 
            // subMenuQuartosConsultar
            // 
            subMenuQuartosConsultar.Image = (Image)resources.GetObject("subMenuQuartosConsultar.Image");
            subMenuQuartosConsultar.Name = "subMenuQuartosConsultar";
            subMenuQuartosConsultar.Size = new Size(180, 22);
            subMenuQuartosConsultar.Text = "Consultar";
            // 
            // MenuCadFuncionario
            // 
            MenuCadFuncionario.DropDownItems.AddRange(new ToolStripItem[] { menuCadFunc, menuFuncionarioConsult });
            MenuCadFuncionario.Name = "MenuCadFuncionario";
            MenuCadFuncionario.Size = new Size(180, 22);
            MenuCadFuncionario.Text = "Funcionários";
            // 
            // menuCadFunc
            // 
            menuCadFunc.Image = (Image)resources.GetObject("menuCadFunc.Image");
            menuCadFunc.Name = "menuCadFunc";
            menuCadFunc.Size = new Size(180, 22);
            menuCadFunc.Text = "Cadastrar";
            menuCadFunc.Click += menuCadFunc_Click;
            // 
            // menuFuncionarioConsult
            // 
            menuFuncionarioConsult.Image = (Image)resources.GetObject("menuFuncionarioConsult.Image");
            menuFuncionarioConsult.Name = "menuFuncionarioConsult";
            menuFuncionarioConsult.Size = new Size(180, 22);
            menuFuncionarioConsult.Text = "Consultar";
            // 
            // MenuCadFornecedor
            // 
            MenuCadFornecedor.DropDownItems.AddRange(new ToolStripItem[] { menuFornecedorCad, menuFornecedorConsult });
            MenuCadFornecedor.Name = "MenuCadFornecedor";
            MenuCadFornecedor.Size = new Size(180, 22);
            MenuCadFornecedor.Text = "Fornecedores";
            // 
            // menuFornecedorCad
            // 
            menuFornecedorCad.Image = (Image)resources.GetObject("menuFornecedorCad.Image");
            menuFornecedorCad.Name = "menuFornecedorCad";
            menuFornecedorCad.Size = new Size(180, 22);
            menuFornecedorCad.Text = "Cadastrar";
            // 
            // menuFornecedorConsult
            // 
            menuFornecedorConsult.Image = (Image)resources.GetObject("menuFornecedorConsult.Image");
            menuFornecedorConsult.Name = "menuFornecedorConsult";
            menuFornecedorConsult.Size = new Size(180, 22);
            menuFornecedorConsult.Text = "Consultar";
            // 
            // MenuCadProduto
            // 
            MenuCadProduto.DropDownItems.AddRange(new ToolStripItem[] { menuProdutoCad, menuProdutoConsult });
            MenuCadProduto.Name = "MenuCadProduto";
            MenuCadProduto.Size = new Size(180, 22);
            MenuCadProduto.Text = "Produtos";
            // 
            // menuProdutoCad
            // 
            menuProdutoCad.Image = (Image)resources.GetObject("menuProdutoCad.Image");
            menuProdutoCad.Name = "menuProdutoCad";
            menuProdutoCad.Size = new Size(180, 22);
            menuProdutoCad.Text = "Cadastrar";
            // 
            // menuProdutoConsult
            // 
            menuProdutoConsult.Image = (Image)resources.GetObject("menuProdutoConsult.Image");
            menuProdutoConsult.Name = "menuProdutoConsult";
            menuProdutoConsult.Size = new Size(180, 22);
            menuProdutoConsult.Text = "Consultar";
            // 
            // MenuCadServico
            // 
            MenuCadServico.DropDownItems.AddRange(new ToolStripItem[] { menuServicoCad, menuServicoConsult });
            MenuCadServico.Name = "MenuCadServico";
            MenuCadServico.Size = new Size(180, 22);
            MenuCadServico.Text = "Serviços";
            // 
            // menuServicoCad
            // 
            menuServicoCad.Image = (Image)resources.GetObject("menuServicoCad.Image");
            menuServicoCad.Name = "menuServicoCad";
            menuServicoCad.Size = new Size(180, 22);
            menuServicoCad.Text = "Cadastrar";
            // 
            // menuServicoConsult
            // 
            menuServicoConsult.Image = (Image)resources.GetObject("menuServicoConsult.Image");
            menuServicoConsult.Name = "menuServicoConsult";
            menuServicoConsult.Size = new Size(180, 22);
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
            menuConsultReserva.Image = (Image)resources.GetObject("menuConsultReserva.Image");
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
            MenuContaPagar.Size = new Size(180, 22);
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
            menuContaPagConsult.Image = (Image)resources.GetObject("menuContaPagConsult.Image");
            menuContaPagConsult.Name = "menuContaPagConsult";
            menuContaPagConsult.Size = new Size(133, 22);
            menuContaPagConsult.Text = "Consultar";
            // 
            // MenuContaReceb
            // 
            MenuContaReceb.DropDownItems.AddRange(new ToolStripItem[] { menuContaRecebCad, menuContaRecebConsul });
            MenuContaReceb.Name = "MenuContaReceb";
            MenuContaReceb.Size = new Size(180, 22);
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
            menuContaRecebConsul.Image = (Image)resources.GetObject("menuContaRecebConsul.Image");
            menuContaRecebConsul.Name = "menuContaRecebConsul";
            menuContaRecebConsul.Size = new Size(133, 22);
            menuContaRecebConsul.Text = "Consultar";
            // 
            // MenuBalanco
            // 
            MenuBalanco.Name = "MenuBalanco";
            MenuBalanco.Size = new Size(180, 22);
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
            menuSair.Click += menuSair_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(899, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 577);
            panel1.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(monthCalendar2);
            panel7.Location = new Point(0, 640);
            panel7.Name = "panel7";
            panel7.Size = new Size(284, 215);
            panel7.TabIndex = 7;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(23, 22);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.Controls.Add(label3);
            panel6.Location = new Point(0, 611);
            panel6.Name = "panel6";
            panel6.Size = new Size(287, 30);
            panel6.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 9);
            label3.Name = "label3";
            label3.Size = new Size(176, 17);
            label3.TabIndex = 11;
            label3.Text = "Check-out de Hospedes";
            // 
            // panel5
            // 
            panel5.Controls.Add(monthCalendar1);
            panel5.Location = new Point(3, 425);
            panel5.Name = "panel5";
            panel5.Size = new Size(287, 183);
            panel5.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(31, 11);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 390);
            panel4.Name = "panel4";
            panel4.Size = new Size(287, 34);
            panel4.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 7);
            label2.Name = "label2";
            label2.Size = new Size(168, 17);
            label2.TabIndex = 10;
            label2.Text = "Check-in de Hospedes";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblPerfilAcesso);
            panel3.Controls.Add(lblNomeCargo);
            panel3.Controls.Add(lblNomeUsuarioLogado);
            panel3.Controls.Add(lblCargo);
            panel3.Controls.Add(lblNamePerfilAcesso);
            panel3.Controls.Add(lblUsuario);
            panel3.Location = new Point(0, 266);
            panel3.Name = "panel3";
            panel3.Size = new Size(287, 100);
            panel3.TabIndex = 3;
            // 
            // lblPerfilAcesso
            // 
            lblPerfilAcesso.AutoSize = true;
            lblPerfilAcesso.Font = new Font("Cascadia Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerfilAcesso.Location = new Point(6, 79);
            lblPerfilAcesso.Name = "lblPerfilAcesso";
            lblPerfilAcesso.Size = new Size(162, 20);
            lblPerfilAcesso.TabIndex = 7;
            lblPerfilAcesso.Text = "Perfil de Acesso:";
            // 
            // lblNomeCargo
            // 
            lblNomeCargo.AutoSize = true;
            lblNomeCargo.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeCargo.Location = new Point(90, 49);
            lblNomeCargo.Name = "lblNomeCargo";
            lblNomeCargo.Size = new Size(112, 17);
            lblNomeCargo.TabIndex = 5;
            lblNomeCargo.Text = "Recepcionista";
            // 
            // lblNomeUsuarioLogado
            // 
            lblNomeUsuarioLogado.AutoSize = true;
            lblNomeUsuarioLogado.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeUsuarioLogado.Location = new Point(90, 13);
            lblNomeUsuarioLogado.Name = "lblNomeUsuarioLogado";
            lblNomeUsuarioLogado.Size = new Size(40, 17);
            lblNomeUsuarioLogado.TabIndex = 4;
            lblNomeUsuarioLogado.Text = "Nome";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCargo.Location = new Point(3, 46);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(63, 20);
            lblCargo.TabIndex = 6;
            lblCargo.Text = "Cargo:";
            // 
            // lblNamePerfilAcesso
            // 
            lblNamePerfilAcesso.AutoSize = true;
            lblNamePerfilAcesso.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamePerfilAcesso.Location = new Point(171, 82);
            lblNamePerfilAcesso.Name = "lblNamePerfilAcesso";
            lblNamePerfilAcesso.Size = new Size(72, 17);
            lblNamePerfilAcesso.TabIndex = 8;
            lblNamePerfilAcesso.Text = "Recepção";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Cascadia Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(3, 11);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(81, 20);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuário:";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblDataHora);
            panel2.Location = new Point(0, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 53);
            panel2.TabIndex = 2;
            // 
            // lblDataHora
            // 
            lblDataHora.AutoSize = true;
            lblDataHora.Font = new Font("Cascadia Mono SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataHora.Location = new Point(62, 14);
            lblDataHora.Name = "lblDataHora";
            lblDataHora.Size = new Size(177, 25);
            lblDataHora.TabIndex = 0;
            lblDataHora.Text = "Data do Sistema";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 151);
            label1.Name = "label1";
            label1.Size = new Size(196, 32);
            label1.TabIndex = 1;
            label1.Text = "Hotel Manager";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TelaFundo
            // 
            TelaFundo.Controls.Add(ImgFundo);
            TelaFundo.Dock = DockStyle.Fill;
            TelaFundo.Location = new Point(0, 25);
            TelaFundo.Name = "TelaFundo";
            TelaFundo.Size = new Size(899, 577);
            TelaFundo.TabIndex = 2;
            // 
            // ImgFundo
            // 
            ImgFundo.BackgroundImageLayout = ImageLayout.Stretch;
            ImgFundo.Dock = DockStyle.Fill;
            ImgFundo.Image = (Image)resources.GetObject("ImgFundo.Image");
            ImgFundo.Location = new Point(0, 0);
            ImgFundo.Name = "ImgFundo";
            ImgFundo.Size = new Size(899, 577);
            ImgFundo.SizeMode = PictureBoxSizeMode.StretchImage;
            ImgFundo.TabIndex = 0;
            ImgFundo.TabStop = false;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 602);
            Controls.Add(TelaFundo);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += TelaPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            TelaFundo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImgFundo).EndInit();
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
        private ToolStripMenuItem menuCadFunc;
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
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label lblDataHora;
        private Label lblCargo;
        private Label lblNomeCargo;
        private Label lblNomeUsuarioLogado;
        private Label lblUsuario;
        private Label lblNamePerfilAcesso;
        private Label lblPerfilAcesso;
        private MonthCalendar monthCalendar1;
        private Label label2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Panel panel7;
        private MonthCalendar monthCalendar2;
        private Panel panel6;
        private Label label3;
        private Panel TelaFundo;
        private PictureBox ImgFundo;
    }
}