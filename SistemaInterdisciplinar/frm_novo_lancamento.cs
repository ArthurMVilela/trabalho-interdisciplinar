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
    public partial class frm_novo_lancamento : Form
    {
        CtrlContas ctrl;
        CtrlConexao conexao;
        string codConta;
        OleDbDataReader dr;
        
        public frm_novo_lancamento()
        {
            InitializeComponent();
        }

        private void frm_novo_lancamento_Load(object sender, EventArgs e)
        {
            ctrl = new CtrlContas();
            conexao = new CtrlConexao();

            conexao.iniciarConexao();

            mtxt_cod.Mask = Configuracoes.mascaraInterna;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //tratamento para que a função possa encortrar a conta
            codConta = mtxt_cod.Text.Replace(' ', '0');
            if (codConta.Length < Configuracoes.mascaraInterna.Length)
            {
                for (int i = 0; i < Configuracoes.mascaraInterna.Length; i++)
                {
                    if (i > codConta.Length - 1)
                    {
                        codConta += "0";
                    }
                }
            }

            dr = ctrl.getConta(codConta);

            if (dr.HasRows)
            {
                dr.Read();
                //mtxt_cod.Text = cod;
                txt_tipo.Text = dr.GetString(6);
                txt_desc.Text = dr.GetString(7);
            }
            else
            {
                MessageBox.Show("Está conta não existe.");
                txt_tipo.Text = "";
                txt_desc.Text = "";
            }

            dr.Close();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            //adicionar movimento ao lançamento
            dgv_movimentos.Rows.Add(codConta, txt_desc.Text, cmb_movimento.Text, txt_valor.Text);
        }

        private void btn_efetuar_lancamento_Click(object sender, EventArgs e)
        {
            double debito = 0, credito = 0;
            //validar dados
            //Falta histórico do lançamento
            if (txt_hist.Text == "")
            {
                MessageBox.Show("Preencha o histórico do lançamento.", "ATENÇÃO!");
                return;
            } else if (txt_desc.Text == "")
            {
                MessageBox.Show("Nenhuma conta seleciona ou conta não existe.", "ATENÇÃO!");
                return;
            } else
            {
                foreach (DataGridViewRow row in dgv_movimentos.Rows)
                {
                    if(row.Cells[2].Value.ToString() == "Débito")
                    {
                        debito += Convert.ToDouble(row.Cells[3].Value);                       
                    } else
                    {
                        credito += Convert.ToDouble(row.Cells[3].Value);
                    }
                }

                if (debito != credito)
                {
                    MessageBox.Show("Valores de débito e crédito não batem.", "ATENÇÃO!");
                    MessageBox.Show(debito.ToString() +"!="+credito.ToString(), "ATENÇÃO!");
                    return;
                }
            }
            string query;
            string data = dtp_data.Value.ToString();
            int idLancamento;
            int idConta;
            string tipo;
            double valor, valorParent, valorMudanca;
            //Inserir lançamento (data, descrição = histórico)
            //IMPORTANTE: DESC é uma palavra reservada;
            query = "INSERT INTO lancamentos (data, [desc]) VALUES ('"+data+"', '"+ txt_hist.Text +"')";

            conexao.executarComando(query);

            //pegar id do lançamento (último id)
            query = "SELECT TOP 1 id FROM lancamentos ORDER BY id DESC";

            dr = conexao.buscar(query);
            dr.Read();

            idLancamento = (int)dr.GetInt32(0);

            dr.Close();

            //Inserir movimento das contas (id_lançamento, id_conta, tipo, valor)
            foreach(DataGridViewRow row in dgv_movimentos.Rows)
            {
                //pegar id da conta
                codConta = row.Cells[0].Value.ToString();
                dr = ctrl.getConta(codConta);
                dr.Read();

                idConta = (int)dr.GetInt32(0);
                tipo = dr.GetString(6);
                valor = dr.GetDouble(8);

                query = "INSERT INTO movimentos_contas (id_lancamento, id_conta, tipo, valor) " +
                    "VALUES (" + idLancamento.ToString() + ", " + idConta.ToString() + ", '"+ row.Cells[2].Value.ToString() + "', "+ row.Cells[3].Value.ToString() + ")";

                conexao.executarComando(query);

                //atualizar valor das contas
                //definir se adiciona ou subtrai a conta
                switch (tipo)
                {
                    case "Ativo":
                        if (row.Cells[2].Value.ToString() == "Débito")
                        {
                            valorMudanca = Convert.ToDouble(row.Cells[3].Value);

                        }
                        else
                        {
                            valorMudanca = -Convert.ToDouble(row.Cells[3].Value);

                        }
                        break;
                    case "Passivo":
                    case "Patrimônio":
                        if (row.Cells[2].Value.ToString() == "Débito")
                        {
                            valorMudanca = -Convert.ToDouble(row.Cells[3].Value);
                        }
                        else
                        {
                            valorMudanca = Convert.ToDouble(row.Cells[3].Value);
                        }
                        break;
                    case "Despesa":
                    case "Custo":
                        if (row.Cells[2].Value.ToString() == "Débito")
                        {
                            valorMudanca = Convert.ToDouble(row.Cells[3].Value);
                        }
                        else
                        {
                            valorMudanca = -Convert.ToDouble(row.Cells[3].Value);
                        }
                        break;
                    case "Receita":
                        if (row.Cells[2].Value.ToString() == "Débito")
                        {
                            valorMudanca = -Convert.ToDouble(row.Cells[3].Value);
                        }
                        else
                        {
                            valorMudanca = Convert.ToDouble(row.Cells[3].Value);
                        }
                        break;
                    default:
                        valorMudanca = 0;
                        break;
                }

                valor += valorMudanca;
                query = "UPDATE contas SET total =" + valor.ToString() + " WHERE id ="+ idConta.ToString() +"";
                conexao.executarComando(query);

                //atualizar "contas pai"
                dr = ctrl.getContaParent(codConta);


                while (dr.Read())
                {
                    idConta = (int)dr.GetInt32(0);
                    valorParent = dr.GetDouble(8);

                    query = "UPDATE contas SET total =" + (valorParent + valorMudanca).ToString() + " WHERE id =" + idConta.ToString() + "";
                    
                    conexao.executarComando(query);
                }
            }

            
        }
    }
}
