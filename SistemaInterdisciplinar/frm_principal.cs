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
    public partial class frm_principal : Form
    {
        Usuario usuario = new Usuario();
        CtrlConexao conexao = new CtrlConexao();

        public frm_principal()
        {
            InitializeComponent();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            //iniciar conexao
            conexao.iniciarConexao();

            this.Enabled = false; //o usuário fica impedido de usar o formulário principal
            frm_login login = new frm_login(); 
            login.ShowDialog();
            usuario = login.usuario;
            login.Close();
            this.Enabled = true;

            //atualizar a barra de status.
            lbl_usuario.Text = "USUÁRIO: " + usuario.getNome() + " | " + usuario.getRole() + ".";

            switch (usuario.getRole())
            {
                case "ADMIN":
                    mscmd_sistema.Visible = true;
                    mscmd_sistema.Enabled = true;

                    mscmd_config.Visible = true;
                    mscmd_config.Enabled = true;


                    break;
                case "CONTB":
                    mscmd_contas.Visible = true;
                    mscmd_contas.Enabled = true;

                    mscmd_relatorios.Visible = true;
                    mscmd_relatorios.Enabled = true;

                    break;
                case "GEREN":
                    mscmd_estoque.Visible = true;
                    mscmd_estoque.Enabled = true;

                    break;
            }
        }

        private void mscmd_sair_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Você realmente deseja sair?", "ATENÇÃO", MessageBoxButtons.YesNo);

            if (resp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mscmd_config_Click(object sender, EventArgs e)
        {
            frm_config config = new frm_config();
            config.Show();
        }

        private void verContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_contas contas = new frm_contas();

            contas.Show();
        }

        private void novoLançamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_novo_lancamento lancamento = new frm_novo_lancamento();

            lancamento.Show();
        }

        private void frm_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexao.log(usuario, "Saiu do sistema.");

            conexao.terminarConexao();
        }

        private void consultarLogDeAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_logs().Show();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_cadastro().Show();
        }

        private void consultarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void efetuarSaídaEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_es_estoque().Show();
        }
    }
}
