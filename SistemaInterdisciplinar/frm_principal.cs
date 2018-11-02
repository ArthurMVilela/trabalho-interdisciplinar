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

        public frm_principal()
        {
            InitializeComponent();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            frm_login login = new frm_login();
            login.ShowDialog();
            usuario = login.usuario;
            login.Close();
            this.Enabled = true;

            lbl_usuario.Text = "USUÁRIO: " + usuario.getNome() + ".";

        }
        
    }
}
