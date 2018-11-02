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
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status_strip = new System.Windows.Forms.StatusStrip();
            this.lbl_usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu_principal.SuspendLayout();
            this.status_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_principal
            // 
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            resources.ApplyResources(this.menu_principal, "menu_principal");
            this.menu_principal.Name = "menu_principal";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            resources.ApplyResources(this.arquivoToolStripMenuItem, "arquivoToolStripMenuItem");
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            resources.ApplyResources(this.sairToolStripMenuItem, "sairToolStripMenuItem");
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
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status_strip;
        private System.Windows.Forms.ToolStripStatusLabel lbl_usuario;
    }
}