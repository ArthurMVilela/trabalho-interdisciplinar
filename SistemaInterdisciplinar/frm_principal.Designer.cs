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
            this.lançamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoLançamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLançamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verContasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relátoriosELivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balançoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.razãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fluxoEntradaESaídaestoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efetuarSaídaEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status_strip = new System.Windows.Forms.StatusStrip();
            this.lbl_usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu_principal.SuspendLayout();
            this.status_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_principal
            // 
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.lançamentosToolStripMenuItem,
            this.relátoriosELivrosToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            resources.ApplyResources(this.menu_principal, "menu_principal");
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
            this.mscmd_sair.Name = "mscmd_sair";
            resources.ApplyResources(this.mscmd_sair, "mscmd_sair");
            this.mscmd_sair.Click += new System.EventHandler(this.mscmd_sair_Click);
            // 
            // lançamentosToolStripMenuItem
            // 
            this.lançamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoLançamentoToolStripMenuItem,
            this.verLançamentosToolStripMenuItem,
            this.verContasToolStripMenuItem});
            this.lançamentosToolStripMenuItem.Name = "lançamentosToolStripMenuItem";
            resources.ApplyResources(this.lançamentosToolStripMenuItem, "lançamentosToolStripMenuItem");
            // 
            // novoLançamentoToolStripMenuItem
            // 
            this.novoLançamentoToolStripMenuItem.Name = "novoLançamentoToolStripMenuItem";
            resources.ApplyResources(this.novoLançamentoToolStripMenuItem, "novoLançamentoToolStripMenuItem");
            this.novoLançamentoToolStripMenuItem.Click += new System.EventHandler(this.novoLançamentoToolStripMenuItem_Click);
            // 
            // verLançamentosToolStripMenuItem
            // 
            this.verLançamentosToolStripMenuItem.Name = "verLançamentosToolStripMenuItem";
            resources.ApplyResources(this.verLançamentosToolStripMenuItem, "verLançamentosToolStripMenuItem");
            // 
            // verContasToolStripMenuItem
            // 
            this.verContasToolStripMenuItem.Name = "verContasToolStripMenuItem";
            resources.ApplyResources(this.verContasToolStripMenuItem, "verContasToolStripMenuItem");
            this.verContasToolStripMenuItem.Click += new System.EventHandler(this.verContasToolStripMenuItem_Click);
            // 
            // relátoriosELivrosToolStripMenuItem
            // 
            this.relátoriosELivrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.relátoriosELivrosToolStripMenuItem.Name = "relátoriosELivrosToolStripMenuItem";
            resources.ApplyResources(this.relátoriosELivrosToolStripMenuItem, "relátoriosELivrosToolStripMenuItem");
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diárioToolStripMenuItem,
            this.balançoToolStripMenuItem,
            this.razãoToolStripMenuItem,
            this.dREToolStripMenuItem});
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            resources.ApplyResources(this.livrosToolStripMenuItem, "livrosToolStripMenuItem");
            // 
            // diárioToolStripMenuItem
            // 
            this.diárioToolStripMenuItem.Name = "diárioToolStripMenuItem";
            resources.ApplyResources(this.diárioToolStripMenuItem, "diárioToolStripMenuItem");
            // 
            // balançoToolStripMenuItem
            // 
            this.balançoToolStripMenuItem.Name = "balançoToolStripMenuItem";
            resources.ApplyResources(this.balançoToolStripMenuItem, "balançoToolStripMenuItem");
            // 
            // razãoToolStripMenuItem
            // 
            this.razãoToolStripMenuItem.Name = "razãoToolStripMenuItem";
            resources.ApplyResources(this.razãoToolStripMenuItem, "razãoToolStripMenuItem");
            // 
            // dREToolStripMenuItem
            // 
            this.dREToolStripMenuItem.Name = "dREToolStripMenuItem";
            resources.ApplyResources(this.dREToolStripMenuItem, "dREToolStripMenuItem");
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aREToolStripMenuItem,
            this.fluxoEntradaESaídaestoqueToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            resources.ApplyResources(this.relatóriosToolStripMenuItem, "relatóriosToolStripMenuItem");
            // 
            // aREToolStripMenuItem
            // 
            this.aREToolStripMenuItem.Name = "aREToolStripMenuItem";
            resources.ApplyResources(this.aREToolStripMenuItem, "aREToolStripMenuItem");
            // 
            // fluxoEntradaESaídaestoqueToolStripMenuItem
            // 
            this.fluxoEntradaESaídaestoqueToolStripMenuItem.Name = "fluxoEntradaESaídaestoqueToolStripMenuItem";
            resources.ApplyResources(this.fluxoEntradaESaídaestoqueToolStripMenuItem, "fluxoEntradaESaídaestoqueToolStripMenuItem");
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarEstoqueToolStripMenuItem,
            this.efetuarSaídaEntradaToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            resources.ApplyResources(this.estoqueToolStripMenuItem, "estoqueToolStripMenuItem");
            // 
            // consultarEstoqueToolStripMenuItem
            // 
            this.consultarEstoqueToolStripMenuItem.Name = "consultarEstoqueToolStripMenuItem";
            resources.ApplyResources(this.consultarEstoqueToolStripMenuItem, "consultarEstoqueToolStripMenuItem");
            // 
            // efetuarSaídaEntradaToolStripMenuItem
            // 
            this.efetuarSaídaEntradaToolStripMenuItem.Name = "efetuarSaídaEntradaToolStripMenuItem";
            resources.ApplyResources(this.efetuarSaídaEntradaToolStripMenuItem, "efetuarSaídaEntradaToolStripMenuItem");
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
        private System.Windows.Forms.ToolStripMenuItem lançamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLançamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mscmd_config;
        private System.Windows.Forms.ToolStripMenuItem novoLançamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relátoriosELivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balançoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem razãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fluxoEntradaESaídaestoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efetuarSaídaEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verContasToolStripMenuItem;
    }
}