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
    public partial class frm_cadastro : Form
    {
        public frm_cadastro()
        {
            InitializeComponent();
        }

        private void btn_criar_conta_Click(object sender, EventArgs e)
        {
            string senha, cargo = "";

            //verificar se todos os campos foram preenchidos
            if ((txt_nome.Text == "") || (txt_email.Text == "") || (mtxt_cpf.Text == "") || (mtxt_cep.Text == "") || (txt_endereco.Text == "") || (txt_senha.Text == "") || (txt_rsenha.Text == "") || (cmb_cargo.SelectedIndex == -1)) {
                MessageBox.Show("Preencha todos os campos.");
                return; //Sair da função
            }
            
            //verificar se o campo de senha e confirmar senha são iguais
            if (txt_senha.Text == txt_rsenha.Text) {
                senha = txt_senha.Text;
            } else {
                txt_senha.Text = "";
                txt_rsenha.Text = "";
                txt_senha.Focus();
                MessageBox.Show("Entre novamente o campo 'Senha'.");
                return; //Sair da função
            }

            switch (cmb_cargo.Text)
            {
                case "Administrador":
                    cargo = "ADMIN";
                    break;
                case "Gerente":
                    cargo = "GEREN";
                    break;
                case "Contador":
                    cargo = "CONTB";
                    break;
                default:
                    //corrigir -> o usuário não selecionou
                    MessageBox.Show("Entrada invalida no campo 'Cargo', por favor entre com novamente.");

                    break;
            }


            CtrlLogin ctrlLogin = new CtrlLogin();
            ctrlLogin.cadastrarUsuario(txt_nome.Text, txt_email.Text, mtxt_cpf.Text, mtxt_cep.Text, txt_endereco.Text, senha, cargo);
        }

        private void txt_rsenha_Leave(object sender, EventArgs e)
        {
            if (txt_senha.Text == txt_rsenha.Text)
            {
                
            }
        }

        private void frm_cadastro_Load(object sender, EventArgs e)
        {
            cmb_cargo.SelectedIndex = 0;
        }
    }
}
