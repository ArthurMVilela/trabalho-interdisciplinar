namespace SistemaInterdisciplinar
{
    partial class frm_lancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_lancamentos));
            this.dgv_lancamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lancamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_lancamentos
            // 
            this.dgv_lancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lancamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_lancamentos.Location = new System.Drawing.Point(0, 0);
            this.dgv_lancamentos.Name = "dgv_lancamentos";
            this.dgv_lancamentos.Size = new System.Drawing.Size(800, 450);
            this.dgv_lancamentos.TabIndex = 0;
            // 
            // frm_lancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_lancamentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_lancamentos";
            this.Text = "Lançamentos";
            this.Load += new System.EventHandler(this.frm_lancamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lancamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_lancamentos;
    }
}