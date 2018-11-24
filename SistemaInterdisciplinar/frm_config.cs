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
            txt_class_interna.Text = Configuracoes.mascaraInterna;
            txt_class_impressao.Text = Configuracoes.mascaraImpressao;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Você realmente deseja alterar as configurções?", "ATENÇÃO", MessageBoxButtons.YesNo);

            if (resp == DialogResult.Yes)
            {
                Configuracoes.nomeEmpresa = txt_nome.Text;
                Configuracoes.mascaraInterna = txt_class_interna.Text;
                Configuracoes.mascaraImpressao = txt_class_impressao.Text;

                Configuracoes.update();
            } else
            {

            }

            
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            //Pegar configurações atuais do sistema
            txt_nome.Text = Configuracoes.nomeEmpresa;
            txt_class_interna.Text = Configuracoes.mascaraInterna;
            txt_class_impressao.Text = Configuracoes.mascaraImpressao;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //resetar configurações
            Configuracoes.reset();

        }
    }
}
