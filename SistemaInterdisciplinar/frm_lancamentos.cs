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
    public partial class frm_lancamentos : Form
    {
        CtrlConexao conexao = new CtrlConexao();

        public frm_lancamentos()
        {
            InitializeComponent();
        }

        private void frm_lancamentos_Load(object sender, EventArgs e)
        {
            conexao.iniciarConexao();

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT data, [desc] FROM lancamentos ORDER BY data DESC", conexao.conexao);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dgv_lancamentos.DataSource = ds.Tables[0];
        }

        private void dgv_lancamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
