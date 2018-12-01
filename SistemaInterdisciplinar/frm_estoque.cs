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
    public partial class frm_estoque : Form
    {
        CtrlConexao conexao = new CtrlConexao();
        CtrlEstoque ctrl = new CtrlEstoque();
        OleDbDataReader dr;

        public frm_estoque()
        {
            InitializeComponent();
        }

        private void frm_estoque_Load(object sender, EventArgs e)
        {
            conexao.iniciarConexao();

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM produtos", conexao.conexao);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dgv_estoque.DataSource = ds.Tables[0];
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                dr = ctrl.buscarProduto(Convert.ToInt32(txt_cod.Text));

                if (dr.HasRows)
                {
                    dr.Read();

                    txt_desc.Text = dr.GetString(1);
                    txt_preco.Text = dr.GetDouble(3).ToString();
                    txt_qtde_estoque.Text = dr.GetDouble(2).ToString();

                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM movimentos_produtos WHERE id_produto=" + txt_cod.Text, conexao.conexao);
                    DataSet ds = new DataSet();

                    da.Fill(ds);

                    dgv_historico.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Não existe nenhum próduto com este código.");
                    txt_desc.Text = "";
                    txt_preco.Text = "";
                    txt_qtde_estoque.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Código invalido.");

            }



        }
    }
}
