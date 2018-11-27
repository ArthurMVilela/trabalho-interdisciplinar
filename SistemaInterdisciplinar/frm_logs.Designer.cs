namespace SistemaInterdisciplinar
{
    partial class frm_logs
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
            this.dbDataSet2 = new SistemaInterdisciplinar.dbDataSet2();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logsTableAdapter = new SistemaInterdisciplinar.dbDataSet2TableAdapters.logsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idusuarioDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.acaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbDataSet2
            // 
            this.dbDataSet2.DataSetName = "dbDataSet2";
            this.dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logsBindingSource
            // 
            this.logsBindingSource.DataMember = "logs";
            this.logsBindingSource.DataSource = this.dbDataSet2;
            // 
            // logsTableAdapter
            // 
            this.logsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 200;
            // 
            // acaoDataGridViewTextBoxColumn
            // 
            this.acaoDataGridViewTextBoxColumn.DataPropertyName = "acao";
            this.acaoDataGridViewTextBoxColumn.HeaderText = "acao";
            this.acaoDataGridViewTextBoxColumn.Name = "acaoDataGridViewTextBoxColumn";
            this.acaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.acaoDataGridViewTextBoxColumn.Width = 400;
            // 
            // frm_logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_logs";
            this.Text = "Logs de acesso";
            this.Load += new System.EventHandler(this.frm_logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbDataSet2 dbDataSet2;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private dbDataSet2TableAdapters.logsTableAdapter logsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acaoDataGridViewTextBoxColumn;
    }
}