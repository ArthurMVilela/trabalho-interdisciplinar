using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInterdisciplinar
{
    public partial class frm_logs : Form
    {
        public frm_logs()
        {
            InitializeComponent();
        }

        private void frm_logs_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbDataSet2.logs'. Você pode movê-la ou removê-la conforme necessário.
            
            this.logsTableAdapter.Fill(this.dbDataSet2.logs);

        }
    }
}
