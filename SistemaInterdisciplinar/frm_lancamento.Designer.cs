namespace SistemaInterdisciplinar
{
    partial class frm_lancamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_lancamento));
            this.dgv_movimentos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_hist = new System.Windows.Forms.TextBox();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_alterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_movimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_movimentos
            // 
            this.dgv_movimentos.AllowUserToAddRows = false;
            this.dgv_movimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_movimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.conta,
            this.movimento,
            this.valor});
            this.dgv_movimentos.Location = new System.Drawing.Point(14, 73);
            this.dgv_movimentos.Name = "dgv_movimentos";
            this.dgv_movimentos.Size = new System.Drawing.Size(772, 198);
            this.dgv_movimentos.TabIndex = 9;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código Conta";
            this.codigo.Name = "codigo";
            // 
            // conta
            // 
            this.conta.HeaderText = "Conta";
            this.conta.Name = "conta";
            this.conta.Width = 300;
            // 
            // movimento
            // 
            this.movimento.HeaderText = "Movimento";
            this.movimento.Name = "movimento";
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // txt_hist
            // 
            this.txt_hist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hist.Location = new System.Drawing.Point(95, 41);
            this.txt_hist.Name = "txt_hist";
            this.txt_hist.Size = new System.Drawing.Size(684, 26);
            this.txt_hist.TabIndex = 8;
            // 
            // dtp_data
            // 
            this.dtp_data.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_data.Location = new System.Drawing.Point(68, 6);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(332, 26);
            this.dtp_data.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Histórico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data:";
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(666, 277);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(120, 31);
            this.btn_alterar.TabIndex = 10;
            this.btn_alterar.Text = "Alterar Lançamento";
            this.btn_alterar.UseVisualStyleBackColor = true;
            // 
            // frm_lancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.dgv_movimentos);
            this.Controls.Add(this.txt_hist);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_lancamento";
            this.Text = "Lançamento";
            this.Load += new System.EventHandler(this.frm_lancamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_movimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_movimentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn movimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.TextBox txt_hist;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_alterar;
    }
}