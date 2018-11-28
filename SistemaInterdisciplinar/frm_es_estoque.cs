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
    public partial class frm_es_estoque : Form
    {
        CtrlEstoque ctrl;
        OleDbDataReader dr;

        public frm_es_estoque()
        {
            InitializeComponent();
        }

        private void frm_es_estoque_Load(object sender, EventArgs e)
        {
            ctrl = new CtrlEstoque();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                dr = ctrl.buscarProduto(Convert.ToInt32(txt_cod.Text));

                if (dr.HasRows)
                {
                    dr.Read();

                    txt_desc.Text = dr.GetString(1);
                    txt_preco.Text = dr.GetDouble(3).ToString();
                    txt_qtde_estoque.Text = dr.GetDouble(2).ToString();
                } else
                {
                    MessageBox.Show("Não existe nenhum próduto com este código.");
                    txt_desc.Text = "";
                    txt_preco.Text = "";
                    txt_qtde_estoque.Text = "";
                }
                
            } catch(Exception ex)
            {
                MessageBox.Show("Código invalido.");
            }
                
        }

        private void btn_efetuar_Click(object sender, EventArgs e)
        {
            if (cmb_mov.Text == "Entrada")
            {
                try
                {
                    ctrl.entrada(Convert.ToInt32(txt_cod.Text), Convert.ToDouble(txt_custo.Text), Convert.ToDouble(txt_qtde.Text));

                    MessageBox.Show("Entrada registrada com sucesso.", "SUCESSO");

                    //limpar input
                    txt_qtde.Text = "";
                    txt_custo.Text = "";

                    //atualizar informação do produto
                    dr = ctrl.buscarProduto(Convert.ToInt32(txt_cod.Text));

                    if (dr.HasRows)
                    {
                        dr.Read();

                        txt_desc.Text = dr.GetString(1);
                        txt_preco.Text = dr.GetDouble(3).ToString();
                        txt_qtde_estoque.Text = dr.GetDouble(2).ToString();
                    }
                    
                } catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registrar movimento.");
                    MessageBox.Show(ex.Message);
                }
                
            } else if (cmb_mov.Text == "Saída")
            {
                try
                {
                    ctrl.saida(Convert.ToInt32(txt_cod.Text), Convert.ToDouble(txt_qtde.Text));

                    MessageBox.Show("Saída registrada com sucesso.", "SUCESSO");

                    //limpar input
                    txt_qtde.Text = "";
                    txt_custo.Text = "";

                    //atualizar informação do produto
                    dr = ctrl.buscarProduto(Convert.ToInt32(txt_cod.Text));

                    if (dr.HasRows)
                    {
                        dr.Read();

                        txt_desc.Text = dr.GetString(1);
                        txt_preco.Text = dr.GetDouble(3).ToString();
                        txt_qtde_estoque.Text = dr.GetDouble(2).ToString();
                    }
                } catch(Exception ex)
                {
                    MessageBox.Show("Erro ao registrar movimento.");
                }
            }
        }

        private void cmb_mov_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_mov.Text == "Saída")
            {
                txt_custo.Enabled = false;
                txt_custo.Text = "";
            } else
            {
                txt_custo.Enabled = true;
            }
        }
    }
}
