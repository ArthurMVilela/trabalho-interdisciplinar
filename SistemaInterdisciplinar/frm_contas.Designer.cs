namespace SistemaInterdisciplinar
{
    partial class frm_contas
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
            this.trv_contas = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // trv_contas
            // 
            this.trv_contas.Location = new System.Drawing.Point(347, 64);
            this.trv_contas.Name = "trv_contas";
            this.trv_contas.Size = new System.Drawing.Size(486, 454);
            this.trv_contas.TabIndex = 0;
            // 
            // frm_contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 551);
            this.Controls.Add(this.trv_contas);
            this.Name = "frm_contas";
            this.Text = "frm_contas";
            this.Load += new System.EventHandler(this.frm_contas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trv_contas;
    }
}