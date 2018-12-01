namespace SistemaInterdisciplinar
{
    partial class frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.menu_principal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mscmd_config = new System.Windows.Forms.ToolStripMenuItem();
            this.mscmd_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.mscmd_estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efetuarSaídaEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mscmd_contas = new System.Windows.Forms.ToolStripMenuItem();
            this.novoLançamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLançamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verContasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mscmd_sistema = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLogDeAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status_strip = new System.Windows.Forms.StatusStrip();
            this.lbl_usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu_principal.SuspendLayout();
            this.status_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_principal
            // 
            resources.ApplyResources(this.menu_principal, "menu_principal");
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.mscmd_estoque,
            this.mscmd_contas,
            this.mscmd_sistema});
            this.menu_principal.Name = "menu_principal";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mscmd_config,
            this.mscmd_sair});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            resources.ApplyResources(this.arquivoToolStripMenuItem, "arquivoToolStripMenuItem");
            // 
            // mscmd_config
            // 
            resources.ApplyResources(this.mscmd_config, "mscmd_config");
            this.mscmd_config.Name = "mscmd_config";
            this.mscmd_config.Click += new System.EventHandler(this.mscmd_config_Click);
            // 
            // mscmd_sair
            // 
            resources.ApplyResources(this.mscmd_sair, "mscmd_sair");
            this.mscmd_sair.Name = "mscmd_sair";
            this.mscmd_sair.Click += new System.EventHandler(this.mscmd_sair_Click);
            // 
            // mscmd_estoque
            // 
            this.mscmd_estoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarEstoqueToolStripMenuItem,
            this.efetuarSaídaEntradaToolStripMenuItem,
            this.cadastrarProdutosToolStripMenuItem});
            resources.ApplyResources(this.mscmd_estoque, "mscmd_estoque");
            this.mscmd_estoque.Name = "mscmd_estoque";
            // 
            // consultarEstoqueToolStripMenuItem
            // 
            resources.ApplyResources(this.consultarEstoqueToolStripMenuItem, "consultarEstoqueToolStripMenuItem");
            this.consultarEstoqueToolStripMenuItem.Name = "consultarEstoqueToolStripMenuItem";
            this.consultarEstoqueToolStripMenuItem.Click += new System.EventHandler(this.consultarEstoqueToolStripMenuItem_Click);
            // 
            // efetuarSaídaEntradaToolStripMenuItem
            // 
            resources.ApplyResources(this.efetuarSaídaEntradaToolStripMenuItem, "efetuarSaídaEntradaToolStripMenuItem");
            this.efetuarSaídaEntradaToolStripMenuItem.Name = "efetuarSaídaEntradaToolStripMenuItem";
            this.efetuarSaídaEntradaToolStripMenuItem.Click += new System.EventHandler(this.efetuarSaídaEntradaToolStripMenuItem_Click);
            // 
            // cadastrarProdutosToolStripMenuItem
            // 
            resources.ApplyResources(this.cadastrarProdutosToolStripMenuItem, "cadastrarProdutosToolStripMenuItem");
            this.cadastrarProdutosToolStripMenuItem.Name = "cadastrarProdutosToolStripMenuItem";
            this.cadastrarProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutosToolStripMenuItem_Click);
            // 
            // mscmd_contas
            // 
            this.mscmd_contas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoLançamentoToolStripMenuItem,
            this.verLançamentosToolStripMenuItem,
            this.verContasToolStripMenuItem});
            resources.ApplyResources(this.mscmd_contas, "mscmd_contas");
            this.mscmd_contas.Name = "mscmd_contas";
            // 
            // novoLançamentoToolStripMenuItem
            // 
            resources.ApplyResources(this.novoLançamentoToolStripMenuItem, "novoLançamentoToolStripMenuItem");
            this.novoLançamentoToolStripMenuItem.Name = "novoLançamentoToolStripMenuItem";
            this.novoLançamentoToolStripMenuItem.Click += new System.EventHandler(this.novoLançamentoToolStripMenuItem_Click);
            // 
            // verLançamentosToolStripMenuItem
            // 
            this.verLançamentosToolStripMenuItem.Name = "verLançamentosToolStripMenuItem";
            resources.ApplyResources(this.verLançamentosToolStripMenuItem, "verLançamentosToolStripMenuItem");
            this.verLançamentosToolStripMenuItem.Click += new System.EventHandler(this.verLançamentosToolStripMenuItem_Click);
            // 
            // verContasToolStripMenuItem
            // 
            this.verContasToolStripMenuItem.Name = "verContasToolStripMenuItem";
            resources.ApplyResources(this.verContasToolStripMenuItem, "verContasToolStripMenuItem");
            this.verContasToolStripMenuItem.Click += new System.EventHandler(this.verContasToolStripMenuItem_Click);
            // 
            // mscmd_sistema
            // 
            this.mscmd_sistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarUsuárioToolStripMenuItem,
            this.consultarLogDeAcessoToolStripMenuItem});
            resources.ApplyResources(this.mscmd_sistema, "mscmd_sistema");
            this.mscmd_sistema.Name = "mscmd_sistema";
            // 
            // administrarUsuárioToolStripMenuItem
            // 
            this.administrarUsuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.alterarSenhaToolStripMenuItem});
            resources.ApplyResources(this.administrarUsuárioToolStripMenuItem, "administrarUsuárioToolStripMenuItem");
            this.administrarUsuárioToolStripMenuItem.Name = "administrarUsuárioToolStripMenuItem";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            resources.ApplyResources(this.cadastrarUsuárioToolStripMenuItem, "cadastrarUsuárioToolStripMenuItem");
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            resources.ApplyResources(this.alterarSenhaToolStripMenuItem, "alterarSenhaToolStripMenuItem");
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // consultarLogDeAcessoToolStripMenuItem
            // 
            resources.ApplyResources(this.consultarLogDeAcessoToolStripMenuItem, "consultarLogDeAcessoToolStripMenuItem");
            this.consultarLogDeAcessoToolStripMenuItem.Name = "consultarLogDeAcessoToolStripMenuItem";
            this.consultarLogDeAcessoToolStripMenuItem.Click += new System.EventHandler(this.consultarLogDeAcessoToolStripMenuItem_Click);
            // 
            // status_strip
            // 
            this.status_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_usuario});
            resources.ApplyResources(this.status_strip, "status_strip");
            this.status_strip.Name = "status_strip";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Name = "lbl_usuario";
            resources.ApplyResources(this.lbl_usuario, "lbl_usuario");
            // 
            // frm_principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.status_strip);
            this.Controls.Add(this.menu_principal);
            this.MainMenuStrip = this.menu_principal;
            this.Name = "frm_principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_principal_FormClosing);
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.menu_principal.ResumeLayout(false);
            this.menu_principal.PerformLayout();
            this.status_strip.ResumeLayout(false);
            this.status_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_principal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mscmd_sair;
        private System.Windows.Forms.StatusStrip status_strip;
        private System.Windows.Forms.ToolStripStatusLabel lbl_usuario;
        private System.Windows.Forms.ToolStripMenuItem mscmd_contas;
        private System.Windows.Forms.ToolStripMenuItem mscmd_estoque;
        private System.Windows.Forms.ToolStripMenuItem verLançamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mscmd_config;
        private System.Windows.Forms.ToolStripMenuItem novoLançamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efetuarSaídaEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verContasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mscmd_sistema;
        private System.Windows.Forms.ToolStripMenuItem administrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarLogDeAcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutosToolStripMenuItem;
    }
}