namespace SistemaInterdisciplinar
{
    partial class frm_contas_grade
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
            this.components = new System.ComponentModel.Container();
            this.dgv_contas = new System.Windows.Forms.DataGridView();
            this.contasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet1 = new SistemaInterdisciplinar.dbDataSet1();
            this.dbDataSet = new SistemaInterdisciplinar.dbDataSet();
            this.contasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasTableAdapter = new SistemaInterdisciplinar.dbDataSetTableAdapters.contasTableAdapter();
            this.contasTableAdapter1 = new SistemaInterdisciplinar.dbDataSet1TableAdapters.contasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_contas
            // 
            this.dgv_contas.AllowUserToAddRows = false;
            this.dgv_contas.AllowUserToDeleteRows = false;
            this.dgv_contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_contas.Location = new System.Drawing.Point(0, 0);
            this.dgv_contas.Name = "dgv_contas";
            this.dgv_contas.ReadOnly = true;
            this.dgv_contas.Size = new System.Drawing.Size(1002, 450);
            this.dgv_contas.TabIndex = 0;
            // 
            // contasBindingSource1
            // 
            this.contasBindingSource1.DataMember = "contas";
            this.contasBindingSource1.DataSource = this.dbDataSet1;
            // 
            // dbDataSet1
            // 
            this.dbDataSet1.DataSetName = "dbDataSet1";
            this.dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contasBindingSource
            // 
            this.contasBindingSource.DataMember = "contas";
            this.contasBindingSource.DataSource = this.dbDataSet;
            // 
            // contasTableAdapter
            // 
            this.contasTableAdapter.ClearBeforeFill = true;
            // 
            // contasTableAdapter1
            // 
            this.contasTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_contas_grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.dgv_contas);
            this.Name = "frm_contas_grade";
            this.Text = "Contas";
            this.Load += new System.EventHandler(this.frm_contas_grade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_contas;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource contasBindingSource;
        private dbDataSetTableAdapters.contasTableAdapter contasTableAdapter;
        private dbDataSet1 dbDataSet1;
        private System.Windows.Forms.BindingSource contasBindingSource1;
        private dbDataSet1TableAdapters.contasTableAdapter contasTableAdapter1;
    }
}