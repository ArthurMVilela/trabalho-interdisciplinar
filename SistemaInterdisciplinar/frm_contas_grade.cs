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
    public partial class frm_contas_grade : Form
    {
        public frm_contas_grade()
        {
            InitializeComponent();
        }

        private void frm_contas_grade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbDataSet1.contas'. Você pode movê-la ou removê-la conforme necessário.
            this.contasTableAdapter1.Fill(this.dbDataSet1.contas);
            // TODO: esta linha de código carrega dados na tabela 'dbDataSet.contas'. Você pode movê-la ou removê-la conforme necessário.
            this.contasTableAdapter.Fill(this.dbDataSet.contas);

        }
    }
}
