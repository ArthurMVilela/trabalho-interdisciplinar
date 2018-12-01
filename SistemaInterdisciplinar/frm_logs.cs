using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaInterdisciplinar
{
    public partial class frm_logs : Form
    {
        CtrlConexao conexao = new CtrlConexao();

        public frm_logs()
        {
            InitializeComponent();
        }

        private void frm_logs_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbDataSet2.logs'. Você pode movê-la ou removê-la conforme necessário.

            //this.logsTableAdapter.Fill(this.dbDataSet2.logs);
            conexao.iniciarConexao();

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT data, id_usuario, acao FROM logs ORDER BY data DESC",conexao.conexao);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dgv_logs.DataSource = ds.Tables[0];
        }
    }
}
