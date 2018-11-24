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
            this.Enabled = false; //o usuário fica impedido de usar o formulário principal
            frm_login login = new frm_login(); 
            login.ShowDialog();
            usuario = login.usuario;
            login.Close();
            this.Enabled = true;

            //atualizar a barra de status.
            lbl_usuario.Text = "USUÁRIO: " + usuario.getNome() + ".";

            ;
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
    }
}
