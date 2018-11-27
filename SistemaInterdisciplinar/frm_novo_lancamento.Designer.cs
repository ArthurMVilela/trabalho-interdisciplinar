namespace SistemaInterdisciplinar
{
    partial class frm_novo_lancamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.txt_hist = new System.Windows.Forms.TextBox();
            this.dgv_movimentos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.cmb_movimento = new System.Windows.Forms.ComboBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxt_cod = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_efetuar_lancamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_movimentos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Histórico:";
            // 
            // dtp_data
            // 
            this.dtp_data.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_data.Location = new System.Drawing.Point(66, 4);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(332, 26);
            this.dtp_data.TabIndex = 2;
            // 
            // txt_hist
            // 
            this.txt_hist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hist.Location = new System.Drawing.Point(93, 39);
            this.txt_hist.Name = "txt_hist";
            this.txt_hist.Size = new System.Drawing.Size(684, 26);
            this.txt_hist.TabIndex = 3;
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
            this.dgv_movimentos.Location = new System.Drawing.Point(12, 240);
            this.dgv_movimentos.Name = "dgv_movimentos";
            this.dgv_movimentos.Size = new System.Drawing.Size(772, 203);
            this.dgv_movimentos.TabIndex = 4;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_adicionar);
            this.groupBox1.Controls.Add(this.cmb_movimento);
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_tipo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_desc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mtxt_cod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 163);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movimento:";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(524, 91);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(122, 27);
            this.btn_adicionar.TabIndex = 15;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // cmb_movimento
            // 
            this.cmb_movimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_movimento.FormattingEnabled = true;
            this.cmb_movimento.Items.AddRange(new object[] {
            "Débito",
            "Crédito"});
            this.cmb_movimento.Location = new System.Drawing.Point(96, 89);
            this.cmb_movimento.Name = "cmb_movimento";
            this.cmb_movimento.Size = new System.Drawing.Size(173, 28);
            this.cmb_movimento.TabIndex = 14;
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(338, 91);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(180, 26);
            this.txt_valor.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(282, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Valor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Movimento:";
            // 
            // txt_tipo
            // 
            this.txt_tipo.Enabled = false;
            this.txt_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo.Location = new System.Drawing.Point(435, 19);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(323, 26);
            this.txt_tipo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(250, 18);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(122, 27);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_desc
            // 
            this.txt_desc.Enabled = false;
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.Location = new System.Drawing.Point(96, 51);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(662, 26);
            this.txt_desc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descrição:";
            // 
            // mtxt_cod
            // 
            this.mtxt_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_cod.Location = new System.Drawing.Point(137, 19);
            this.mtxt_cod.Mask = "9-9-99-99-99";
            this.mtxt_cod.Name = "mtxt_cod";
            this.mtxt_cod.Size = new System.Drawing.Size(105, 26);
            this.mtxt_cod.TabIndex = 6;
            this.mtxt_cod.Leave += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código da conta";
            // 
            // btn_efetuar_lancamento
            // 
            this.btn_efetuar_lancamento.Location = new System.Drawing.Point(664, 449);
            this.btn_efetuar_lancamento.Name = "btn_efetuar_lancamento";
            this.btn_efetuar_lancamento.Size = new System.Drawing.Size(120, 31);
            this.btn_efetuar_lancamento.TabIndex = 6;
            this.btn_efetuar_lancamento.Text = "Efetuar Lançamento";
            this.btn_efetuar_lancamento.UseVisualStyleBackColor = true;
            this.btn_efetuar_lancamento.Click += new System.EventHandler(this.btn_efetuar_lancamento_Click);
            // 
            // frm_novo_lancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.btn_efetuar_lancamento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_movimentos);
            this.Controls.Add(this.txt_hist);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_novo_lancamento";
            this.Text = "frm_novo_lancamento";
            this.Load += new System.EventHandler(this.frm_novo_lancamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_movimentos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.TextBox txt_hist;
        private System.Windows.Forms.DataGridView dgv_movimentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxt_cod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.ComboBox cmb_movimento;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_efetuar_lancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn movimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}