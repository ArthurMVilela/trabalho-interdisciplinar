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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_logs));
            this.dgv_logs = new System.Windows.Forms.DataGridView();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet2 = new SistemaInterdisciplinar.dbDataSet2();
            this.logsTableAdapter = new SistemaInterdisciplinar.dbDataSet2TableAdapters.logsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_logs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_logs
            // 
            this.dgv_logs.AllowUserToAddRows = false;
            this.dgv_logs.AllowUserToDeleteRows = false;
            this.dgv_logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_logs.Location = new System.Drawing.Point(0, 0);
            this.dgv_logs.Name = "dgv_logs";
            this.dgv_logs.ReadOnly = true;
            this.dgv_logs.Size = new System.Drawing.Size(800, 450);
            this.dgv_logs.TabIndex = 0;
            // 
            // logsBindingSource
            // 
            this.logsBindingSource.DataMember = "logs";
            this.logsBindingSource.DataSource = this.dbDataSet2;
            // 
            // dbDataSet2
            // 
            this.dbDataSet2.DataSetName = "dbDataSet2";
            this.dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logsTableAdapter
            // 
            this.logsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_logs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_logs";
            this.Text = "Logs de acesso";
            this.Load += new System.EventHandler(this.frm_logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_logs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_logs;
        private dbDataSet2 dbDataSet2;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private dbDataSet2TableAdapters.logsTableAdapter logsTableAdapter;
    }
}