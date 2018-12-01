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
    public partial class frm_senha : Form
    {
        CtrlConexao conexao = new CtrlConexao();
        CtrlLogin ctrl = new CtrlLogin();

        public frm_senha()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT id, nome FROM usuarios WHERE nome LIKE '%" + txt_nome.Text + "%'", conexao.conexao);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dgv_usuarios.DataSource = ds.Tables[0];
        }

        private void frm_senha_Load(object sender, EventArgs e)
        {
            conexao.iniciarConexao();
        }

        private void dgv_usuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int id = dgv_usuarios.SelectedRows[0].Index;

            txt_id.Text = dgv_usuarios.Rows[dgv_usuarios.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Usuário não foi selecionado.");
                return;
            }
            else if (txt_senha.Text != txt_rsenha.Text) {
                MessageBox.Show("Os campos 'nova senha' e 'repetir senha' estão diferentes.");
                return;
            } else
            {
                try
                {
                    ctrl.mudarSenha(Convert.ToInt32(txt_id.Text), txt_senha.Text);
                    MessageBox.Show("Senha alterada com sucesso!", "SUCESSO");
                    txt_rsenha.Text = "";
                    txt_senha.Text = "";

                } catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar alterar a senha.", "ERRO");
                }
            }
        }
    }
}
