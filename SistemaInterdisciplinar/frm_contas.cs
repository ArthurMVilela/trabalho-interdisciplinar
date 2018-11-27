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
        string cod;
        int n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0;

        public frm_contas()
        {
            InitializeComponent();
        }

        private void frm_contas_Load(object sender, EventArgs e)
        {
            ctrl = new CtrlContas();
            //carregar contas
            atualizarTreeview();

            mtxt_cod.Mask = Configuracoes.mascaraInterna;
            mtxt_cod_parent.Mask = Configuracoes.mascaraInterna;
        }

        private void trv_contas_Click(object sender, EventArgs e)
        {
            try
            {
                cod = trv_contas.SelectedNode.Text.Split(' ')[0];
                dr = ctrl.getConta(cod);

                if (dr.HasRows)
                {
                    dr.Read();
                    mtxt_cod.Text = cod;
                    txt_desc.Text = dr.GetString(7);
                }

                dr.Close();

            } catch (Exception ex)
            {

            }
        }

        private void mtxt_cod_Leave(object sender, EventArgs e)
        {
            //tratamento para que a função possa encortrar a conta
            cod = mtxt_cod.Text.Replace(' ','0');
            if (cod.Length < Configuracoes.mascaraInterna.Length)
            {
                for (int i =0; i < Configuracoes.mascaraInterna.Length; i++)
                {
                    if (i>cod.Length - 1)
                    {
                        cod += "0";
                    }
                }
            }

            try
            {
                dr = ctrl.getConta(cod);

                if (dr.HasRows)
                {
                    dr.Read();
                    //mtxt_cod.Text = cod;
                    cmb_tipo.Text = dr.GetString(6);
                    txt_desc.Text = dr.GetString(7);
                } else
                {
                    cmb_tipo.Text = "";
                    txt_desc.Text = "";
                }

                //dr.Close();

                dr = ctrl.getContaParent(cod);

                if (dr.HasRows)
                {
                    dr.Read();

                    n1 = (int)dr.GetInt16(1);
                    n2 = dr.IsDBNull(2) ? 0 : (int)dr.GetInt16(2);
                    n3 = dr.IsDBNull(3) ? 0 : (int)dr.GetInt16(2);
                    n4 = dr.IsDBNull(4) ? 0 : (int)dr.GetInt16(4);
                    n5 = dr.IsDBNull(5) ? 0 : (int)dr.GetInt16(5);
                    

                    mtxt_cod_parent.Text = ctrl.gerarClassificacao(n1, n2, n3, n4, n5);
                }
                else
                {
                    mtxt_cod_parent.Text = "";
                }

                dr.Close();
            } catch(Exception ex)
            {

            }
        }

        void atualizarTreeview()
        {
            dr = ctrl.getContas();


            string conta;

            while (dr.Read())
            {

                try
                {
                    n1 = (int)dr.GetInt16(1);
                    n2 = dr.IsDBNull(2) ? 0 : (int)dr.GetInt16(2);
                    n3 = dr.IsDBNull(3) ? 0 : (int)dr.GetInt16(2);
                    n4 = dr.IsDBNull(4) ? 0 : (int)dr.GetInt16(4);
                    n5 = dr.IsDBNull(5) ? 0 : (int)dr.GetInt16(5);


                    cod = ctrl.gerarClassificacao(n1, n2, n3, n4, n5);
                    conta = "";
                    conta = string.Format("{0} {1} : {2:c}", cod, dr.GetString(7), dr.GetDouble(8));
                }
                catch (Exception ex)
                {

                    conta = string.Format("{0} : {1:c}", dr.GetString(7), dr.GetDouble(8));
                }

                if (dr.IsDBNull(2)) //se n2 é nulo, então a conta é de nivel 1 (n1)
                {

                    trv_contas.Nodes.Add(conta);
                    //n1++;
                }
                else if (dr.IsDBNull(3)) //se n3 é nulo, então a conta é de nivel 2 (n2)
                {

                    trv_contas.Nodes[n1 - 1].Nodes.Add(conta);
                    //n2++;
                    //trv_contas.Nodes.Add(dr.GetString(7));
                }
                else if (dr.IsDBNull(4)) //se n4 é nulo, então a conta é de nivel 3 (n3)
                {
                    trv_contas.Nodes[n1 - 1].Nodes[n2 - 1].Nodes.Add(conta);
                    //n3++;
                }
                else if (dr.IsDBNull(5)) //se n5 é nulo, então a conta é de nivel 4 (n4)
                {
                    trv_contas.Nodes[n1 - 1].Nodes[n2 - 1].Nodes[n3 - 1].Nodes.Add(conta);
                    //n4++;
                }
                else
                {
                    trv_contas.Nodes[n1 - 1].Nodes[n2 - 1].Nodes[n3 - 1].Nodes[n4 - 1].Nodes.Add(conta);
                    //n5++;
                }

            }

            dr.Close();
        }
    }
}
