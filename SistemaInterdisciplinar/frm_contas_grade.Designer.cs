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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbDataSet = new SistemaInterdisciplinar.dbDataSet();
            this.contasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasTableAdapter = new SistemaInterdisciplinar.dbDataSetTableAdapters.contasTableAdapter();
            this.dbDataSet1 = new SistemaInterdisciplinar.dbDataSet1();
            this.contasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contasTableAdapter1 = new SistemaInterdisciplinar.dbDataSet1TableAdapters.contasTableAdapter();
            this.n1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n1DataGridViewTextBoxColumn,
            this.n2DataGridViewTextBoxColumn,
            this.n3DataGridViewTextBoxColumn,
            this.n4DataGridViewTextBoxColumn,
            this.n5DataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.descDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contasBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 450);
            this.dataGridView1.TabIndex = 0;
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
            // dbDataSet1
            // 
            this.dbDataSet1.DataSetName = "dbDataSet1";
            this.dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contasBindingSource1
            // 
            this.contasBindingSource1.DataMember = "contas";
            this.contasBindingSource1.DataSource = this.dbDataSet1;
            // 
            // contasTableAdapter1
            // 
            this.contasTableAdapter1.ClearBeforeFill = true;
            // 
            // n1DataGridViewTextBoxColumn
            // 
            this.n1DataGridViewTextBoxColumn.DataPropertyName = "n1";
            this.n1DataGridViewTextBoxColumn.HeaderText = "n1";
            this.n1DataGridViewTextBoxColumn.Name = "n1DataGridViewTextBoxColumn";
            this.n1DataGridViewTextBoxColumn.Width = 50;
            // 
            // n2DataGridViewTextBoxColumn
            // 
            this.n2DataGridViewTextBoxColumn.DataPropertyName = "n2";
            this.n2DataGridViewTextBoxColumn.HeaderText = "n2";
            this.n2DataGridViewTextBoxColumn.Name = "n2DataGridViewTextBoxColumn";
            this.n2DataGridViewTextBoxColumn.Width = 50;
            // 
            // n3DataGridViewTextBoxColumn
            // 
            this.n3DataGridViewTextBoxColumn.DataPropertyName = "n3";
            this.n3DataGridViewTextBoxColumn.HeaderText = "n3";
            this.n3DataGridViewTextBoxColumn.Name = "n3DataGridViewTextBoxColumn";
            this.n3DataGridViewTextBoxColumn.Width = 50;
            // 
            // n4DataGridViewTextBoxColumn
            // 
            this.n4DataGridViewTextBoxColumn.DataPropertyName = "n4";
            this.n4DataGridViewTextBoxColumn.HeaderText = "n4";
            this.n4DataGridViewTextBoxColumn.Name = "n4DataGridViewTextBoxColumn";
            this.n4DataGridViewTextBoxColumn.Width = 50;
            // 
            // n5DataGridViewTextBoxColumn
            // 
            this.n5DataGridViewTextBoxColumn.DataPropertyName = "n5";
            this.n5DataGridViewTextBoxColumn.HeaderText = "n5";
            this.n5DataGridViewTextBoxColumn.Name = "n5DataGridViewTextBoxColumn";
            this.n5DataGridViewTextBoxColumn.Width = 50;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // descDataGridViewTextBoxColumn
            // 
            this.descDataGridViewTextBoxColumn.DataPropertyName = "desc";
            this.descDataGridViewTextBoxColumn.HeaderText = "desc";
            this.descDataGridViewTextBoxColumn.Name = "descDataGridViewTextBoxColumn";
            this.descDataGridViewTextBoxColumn.Width = 300;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // frm_contas_grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_contas_grade";
            this.Text = "Contas";
            this.Load += new System.EventHandler(this.frm_contas_grade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource contasBindingSource;
        private dbDataSetTableAdapters.contasTableAdapter contasTableAdapter;
        private dbDataSet1 dbDataSet1;
        private System.Windows.Forms.BindingSource contasBindingSource1;
        private dbDataSet1TableAdapters.contasTableAdapter contasTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn n1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}