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
    public partial class frm_config : Form
    {
        public frm_config()
        {
            InitializeComponent();
        }

        private void frm_config_Load(object sender, EventArgs e)
        {
            //Pegar configurações atuais do sistema
            txt_nome.Text = Configuracoes.nomeEmpresa;
            //txt_class_interna.Text = Configuracoes.mascaraInterna;
            //txt_class_impressao.Text = Configuracoes.mascaraImpressao;
            mtxt_caixa.Mask = Configuracoes.mascaraInterna;
            mtxt_caixa.Text = Configuracoes.codCaixa;
            mtxt_estoque.Mask = Configuracoes.mascaraInterna;
            mtxt_estoque.Text = Configuracoes.codEstoque;
            mtxt_receita.Mask = Configuracoes.mascaraInterna;
            mtxt_receita.Text = Configuracoes.codReceita;
            mtxt_cmv.Mask = Configuracoes.mascaraInterna;
            mtxt_cmv.Text = Configuracoes.codCMV;
            mtxt_fornecedores.Mask = Configuracoes.mascaraInterna;
            mtxt_fornecedores.Text = Configuracoes.codFornecedores;

            txt_ativo.Text = Configuracoes.nAtivo;
            txt_passivo.Text = Configuracoes.nPassivo;
            txt_patr.Text = Configuracoes.nPatrimonio;
            txt_receitas.Text = Configuracoes.nReceitas;
            txt_custos.Text = Configuracoes.nCustos;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Você realmente deseja alterar as configurções?", "ATENÇÃO", MessageBoxButtons.YesNo);

            if (resp == DialogResult.Yes)
            {
                Configuracoes.nomeEmpresa = txt_nome.Text;
                //Configuracoes.mascaraInterna = txt_class_interna.Text;
                //Configuracoes.mascaraImpressao = txt_class_impressao.Text;
                Configuracoes.codCaixa = mtxt_caixa.Text;
                Configuracoes.codEstoque = mtxt_estoque.Text;
                Configuracoes.codReceita = mtxt_receita.Text;
                Configuracoes.codCMV = mtxt_cmv.Text;
                Configuracoes.codFornecedores = mtxt_fornecedores.Text;

                Configuracoes.nAtivo = txt_ativo.Text;
                Configuracoes.nPassivo = txt_passivo.Text;
                Configuracoes.nPatrimonio = txt_patr.Text ;
                Configuracoes.nReceitas = txt_receitas.Text;
                Configuracoes.nCustos = txt_custos.Text;

                Configuracoes.update();
            } else
            {

            }

            
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            //Pegar configurações atuais do sistema
            txt_nome.Text = Configuracoes.nomeEmpresa;
            //txt_class_interna.Text = Configuracoes.mascaraInterna;
            //txt_class_impressao.Text = Configuracoes.mascaraImpressao;
            mtxt_caixa.Text = Configuracoes.codCaixa;
            
            mtxt_estoque.Text = Configuracoes.codEstoque;
            
            mtxt_receita.Text = Configuracoes.codReceita;
            
            mtxt_cmv.Text = Configuracoes.codCMV;

            mtxt_fornecedores.Text = Configuracoes.codFornecedores;

            txt_ativo.Text = Configuracoes.nAtivo;
            txt_passivo.Text = Configuracoes.nPassivo;
            txt_patr.Text = Configuracoes.nPatrimonio;
            txt_receitas.Text = Configuracoes.nReceitas;
            txt_custos.Text = Configuracoes.nCustos;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //resetar configurações
            Configuracoes.reset();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
