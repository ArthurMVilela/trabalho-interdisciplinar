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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_contas));
            this.trv_contas = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxt_cod = new System.Windows.Forms.MaskedTextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.btn_criar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trv_contas
            // 
            this.trv_contas.Location = new System.Drawing.Point(347, 12);
            this.trv_contas.Name = "trv_contas";
            this.trv_contas.Size = new System.Drawing.Size(486, 478);
            this.trv_contas.TabIndex = 0;
            this.trv_contas.Click += new System.EventHandler(this.trv_contas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Máscara/Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição";
            // 
            // mtxt_cod
            // 
            this.mtxt_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_cod.Location = new System.Drawing.Point(142, 82);
            this.mtxt_cod.Mask = "9-9-99-99-99";
            this.mtxt_cod.Name = "mtxt_cod";
            this.mtxt_cod.Size = new System.Drawing.Size(105, 26);
            this.mtxt_cod.TabIndex = 4;
            this.mtxt_cod.Leave += new System.EventHandler(this.mtxt_cod_Leave);
            // 
            // txt_desc
            // 
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.Location = new System.Drawing.Point(16, 243);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(283, 26);
            this.txt_desc.TabIndex = 5;
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Ativo",
            "Passivo",
            "Patrimônio",
            "Custp/Despesa",
            "Receita"});
            this.cmb_tipo.Location = new System.Drawing.Point(16, 178);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(283, 28);
            this.cmb_tipo.TabIndex = 6;
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(176, 301);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(122, 34);
            this.btn_criar.TabIndex = 7;
            this.btn_criar.Text = "Atualizar/Criar Conta";
            this.btn_criar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(48, 301);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(122, 34);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.Text = "Excluir Conta";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Location = new System.Drawing.Point(711, 496);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(122, 34);
            this.btn_visualizar.TabIndex = 11;
            this.btn_visualizar.Text = "Visualizar em grade";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // frm_contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 551);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.mtxt_cod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trv_contas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_contas";
            this.Text = "Contas";
            this.Load += new System.EventHandler(this.frm_contas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trv_contas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxt_cod;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_visualizar;
    }
}