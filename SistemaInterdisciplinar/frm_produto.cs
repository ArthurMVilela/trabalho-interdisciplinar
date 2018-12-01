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
    public partial class frm_produto : Form
    {
        CtrlConexao conexao = new CtrlConexao();
        OleDbDataReader dr;

        public frm_produto()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            if (txt_desc.Text == "" || txt_preco.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.", "ATENÇÃO");
                return;
            }
            conexao.executarComando("INSERT INTO produto ([desc],preco) SET ("+ txt_desc.Text + "," + txt_preco.Text.Replace(',','.') + ")");

            MessageBox.Show("Novo produto cadastrado com sucesso!");

            txt_desc.Text = "";
            txt_preco.Text = "";
        }

        private void frm_produto_Load(object sender, EventArgs e)
        {
            conexao.iniciarConexao();
        }
    }
}
