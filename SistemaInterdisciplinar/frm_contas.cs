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
    public partial class frm_contas : Form
    {
        OleDbDataReader dr;
        CtrlContas ctrl;

        public frm_contas()
        {
            InitializeComponent();
        }

        private void frm_contas_Load(object sender, EventArgs e)
        {
            ctrl = new CtrlContas();
            //carregar contas
            dr = ctrl.getContas();

            int n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0;
            string conta;

            while(dr.Read())
            {
                conta = string.Format("{0} : {1:c}", dr.GetString(7), dr.GetDouble(8));
                if (dr.IsDBNull(2)) //se n2 é nulo, então a conta é de nivel 1 (n1)
                {
                    
                    trv_contas.Nodes.Add(conta);
                    n1++;
                } else if (dr.IsDBNull(3)) //se n3 é nulo, então a conta é de nivel 2 (n2)
                {

                    trv_contas.Nodes[n1 - 1].Nodes.Add(conta);
                    n2++;
                    //trv_contas.Nodes.Add(dr.GetString(7));
                } else if (dr.IsDBNull(4)) //se n4 é nulo, então a conta é de nivel 3 (n3)
                {
                    trv_contas.Nodes[n1 - 1].Nodes[n2 - 1].Nodes.Add(conta);
                    n3++;
                } else if (dr.IsDBNull(5)) //se n5 é nulo, então a conta é de nivel 4 (n4)
                {
                    trv_contas.Nodes[n1 - 1].Nodes[n2 - 1].Nodes[n3 - 1].Nodes.Add(conta);
                    n4++;
                } else
                {
                    trv_contas.Nodes[n1 - 1].Nodes[n2 - 1].Nodes[n3 - 1].Nodes[n4 - 1].Nodes.Add(conta);
                    n5++;
                }

            }

            dr.Close();
        }
    }
}
