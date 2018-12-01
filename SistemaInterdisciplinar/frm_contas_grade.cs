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
    public partial class frm_contas_grade : Form
    {
        CtrlConexao conexao = new CtrlConexao();
        OleDbDataReader dr;

        public frm_contas_grade()
        {
            InitializeComponent();
        }

        private void frm_contas_grade_Load(object sender, EventArgs e)
        {
            conexao.iniciarConexao();

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM contas", conexao.conexao);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dgv_contas.DataSource = ds.Tables[0];

        }
    }
}
