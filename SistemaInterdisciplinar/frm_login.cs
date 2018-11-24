using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaInterdisciplinar;

namespace SistemaInterdisciplinar
{
    public partial class frm_login : Form
    {
        public Usuario usuario = new Usuario();

        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            CtrlLogin ctrlLogin = new CtrlLogin();
            usuario = ctrlLogin.verificarUsuario(txt_nome.Text, txt_senha.Text);
            
            if (!usuario.invalido())
            {
                this.Hide();
            } 
            
        }

        //quando o usuário estiver fechando
        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (usuario.invalido())
            {
                Application.Exit();
            }
        }
    }
}
