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
            ctrlLogin.verificarUsuario(txt_nome.Text, txt_senha.Text);
        }
    }
}
