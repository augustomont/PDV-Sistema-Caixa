namespace PDV
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MenuForm = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastroFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastroUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastroCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastroFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutosProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutosEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentações = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoesFluxoCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoesLancarVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoesEntradasSaidas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoesDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatório = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorioProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorioVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorioMovimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorioEntradasSaidas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorioDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.img04 = new System.Windows.Forms.PictureBox();
            this.img03 = new System.Windows.Forms.PictureBox();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.MenuForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuForm
            // 
            this.MenuForm.BackColor = System.Drawing.SystemColors.Info;
            this.MenuForm.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuForm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuProdutos,
            this.MenuMovimentações,
            this.MenuRelatório,
            this.MenuSair});
            resources.ApplyResources(this.MenuForm, "MenuForm");
            this.MenuForm.Name = "MenuForm";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastroFuncionarios,
            this.MenuCadastroClientes,
            this.MenuCadastroUsuarios,
            this.MenuCadastroCargos,
            this.MenuCadastroFornecedores});
            this.MenuCadastro.Name = "MenuCadastro";
            resources.ApplyResources(this.MenuCadastro, "MenuCadastro");
            // 
            // MenuCadastroFuncionarios
            // 
            this.MenuCadastroFuncionarios.Name = "MenuCadastroFuncionarios";
            resources.ApplyResources(this.MenuCadastroFuncionarios, "MenuCadastroFuncionarios");
            this.MenuCadastroFuncionarios.Click += new System.EventHandler(this.MenuCadastroFuncionarios_Click);
            // 
            // MenuCadastroClientes
            // 
            this.MenuCadastroClientes.Name = "MenuCadastroClientes";
            resources.ApplyResources(this.MenuCadastroClientes, "MenuCadastroClientes");
            // 
            // MenuCadastroUsuarios
            // 
            this.MenuCadastroUsuarios.Name = "MenuCadastroUsuarios";
            resources.ApplyResources(this.MenuCadastroUsuarios, "MenuCadastroUsuarios");
            // 
            // MenuCadastroCargos
            // 
            this.MenuCadastroCargos.Name = "MenuCadastroCargos";
            resources.ApplyResources(this.MenuCadastroCargos, "MenuCadastroCargos");
            // 
            // MenuCadastroFornecedores
            // 
            this.MenuCadastroFornecedores.Name = "MenuCadastroFornecedores";
            resources.ApplyResources(this.MenuCadastroFornecedores, "MenuCadastroFornecedores");
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProdutosProdutos,
            this.MenuProdutosEstoque});
            this.MenuProdutos.Name = "MenuProdutos";
            resources.ApplyResources(this.MenuProdutos, "MenuProdutos");
            // 
            // MenuProdutosProdutos
            // 
            this.MenuProdutosProdutos.Name = "MenuProdutosProdutos";
            resources.ApplyResources(this.MenuProdutosProdutos, "MenuProdutosProdutos");
            // 
            // MenuProdutosEstoque
            // 
            this.MenuProdutosEstoque.Name = "MenuProdutosEstoque";
            resources.ApplyResources(this.MenuProdutosEstoque, "MenuProdutosEstoque");
            // 
            // MenuMovimentações
            // 
            this.MenuMovimentações.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMovimentacoesFluxoCaixa,
            this.MenuMovimentacoesLancarVendas,
            this.MenuMovimentacoesEntradasSaidas,
            this.MenuMovimentacoesDespesas});
            this.MenuMovimentações.Name = "MenuMovimentações";
            resources.ApplyResources(this.MenuMovimentações, "MenuMovimentações");
            // 
            // MenuMovimentacoesFluxoCaixa
            // 
            this.MenuMovimentacoesFluxoCaixa.Name = "MenuMovimentacoesFluxoCaixa";
            resources.ApplyResources(this.MenuMovimentacoesFluxoCaixa, "MenuMovimentacoesFluxoCaixa");
            // 
            // MenuMovimentacoesLancarVendas
            // 
            this.MenuMovimentacoesLancarVendas.Name = "MenuMovimentacoesLancarVendas";
            resources.ApplyResources(this.MenuMovimentacoesLancarVendas, "MenuMovimentacoesLancarVendas");
            // 
            // MenuMovimentacoesEntradasSaidas
            // 
            this.MenuMovimentacoesEntradasSaidas.Name = "MenuMovimentacoesEntradasSaidas";
            resources.ApplyResources(this.MenuMovimentacoesEntradasSaidas, "MenuMovimentacoesEntradasSaidas");
            // 
            // MenuMovimentacoesDespesas
            // 
            this.MenuMovimentacoesDespesas.Name = "MenuMovimentacoesDespesas";
            resources.ApplyResources(this.MenuMovimentacoesDespesas, "MenuMovimentacoesDespesas");
            // 
            // MenuRelatório
            // 
            this.MenuRelatório.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRelatorioProdutos,
            this.MenuRelatorioVendas,
            this.MenuRelatorioMovimentos,
            this.MenuRelatorioEntradasSaidas,
            this.MenuRelatorioDespesas});
            this.MenuRelatório.Name = "MenuRelatório";
            resources.ApplyResources(this.MenuRelatório, "MenuRelatório");
            // 
            // MenuRelatorioProdutos
            // 
            this.MenuRelatorioProdutos.Name = "MenuRelatorioProdutos";
            resources.ApplyResources(this.MenuRelatorioProdutos, "MenuRelatorioProdutos");
            // 
            // MenuRelatorioVendas
            // 
            this.MenuRelatorioVendas.Name = "MenuRelatorioVendas";
            resources.ApplyResources(this.MenuRelatorioVendas, "MenuRelatorioVendas");
            // 
            // MenuRelatorioMovimentos
            // 
            this.MenuRelatorioMovimentos.Name = "MenuRelatorioMovimentos";
            resources.ApplyResources(this.MenuRelatorioMovimentos, "MenuRelatorioMovimentos");
            // 
            // MenuRelatorioEntradasSaidas
            // 
            this.MenuRelatorioEntradasSaidas.Name = "MenuRelatorioEntradasSaidas";
            resources.ApplyResources(this.MenuRelatorioEntradasSaidas, "MenuRelatorioEntradasSaidas");
            // 
            // MenuRelatorioDespesas
            // 
            this.MenuRelatorioDespesas.Name = "MenuRelatorioDespesas";
            resources.ApplyResources(this.MenuRelatorioDespesas, "MenuRelatorioDespesas");
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            resources.ApplyResources(this.MenuSair, "MenuSair");
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // img04
            // 
            this.img04.Image = global::PDV.Properties.Resources.sistema;
            resources.ApplyResources(this.img04, "img04");
            this.img04.Name = "img04";
            this.img04.TabStop = false;
            // 
            // img03
            // 
            this.img03.Image = global::PDV.Properties.Resources.lupa;
            resources.ApplyResources(this.img03, "img03");
            this.img03.Name = "img03";
            this.img03.TabStop = false;
            // 
            // img02
            // 
            this.img02.Image = global::PDV.Properties.Resources.relatorio;
            resources.ApplyResources(this.img02, "img02");
            this.img02.Name = "img02";
            this.img02.TabStop = false;
            // 
            // img01
            // 
            this.img01.Image = global::PDV.Properties.Resources.carrinho;
            resources.ApplyResources(this.img01, "img01");
            this.img01.Name = "img01";
            this.img01.TabStop = false;
            // 
            // frmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.img04);
            this.Controls.Add(this.img03);
            this.Controls.Add(this.img02);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.MenuForm);
            this.MainMenuStrip = this.MenuForm;
            this.Name = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuForm.ResumeLayout(false);
            this.MenuForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuForm;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentações;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatório;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.PictureBox img01;
        private System.Windows.Forms.PictureBox img02;
        private System.Windows.Forms.PictureBox img03;
        private System.Windows.Forms.PictureBox img04;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastroFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastroClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastroUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastroCargos;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastroFornecedores;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutosProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutosEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoesFluxoCaixa;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoesLancarVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoesEntradasSaidas;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoesDespesas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorioProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorioVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorioMovimentos;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorioEntradasSaidas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorioDespesas;
    }
}

