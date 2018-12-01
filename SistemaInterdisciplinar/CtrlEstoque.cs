using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;


namespace SistemaInterdisciplinar
{
    class CtrlEstoque
    {
        CtrlConexao conexao = new CtrlConexao();
        CtrlContas contas = new CtrlContas();
        OleDbDataReader dr;

        public CtrlEstoque()
        {
            conexao.iniciarConexao();
        }

        public OleDbDataReader buscarProduto(int cod)
        {
            string query = "SELECT * FROM produtos WHERE id =" + cod.ToString() + "";

            dr = conexao.buscar(query);

            return dr;
        }

        public void entrada(int cod, double custo, double qtde)
        {
            buscarProduto(cod);

            dr.Read();

            int id = dr.GetInt32(0);
            double qtde_atual = dr.GetDouble(2);
            DateTime data = DateTime.Now;

            string query = "UPDATE produtos SET qtde=" + (qtde_atual + qtde).ToString() + " WHERE id=" + id.ToString();

            conexao.executarComando(query);

            query = "INSERT INTO movimentos_produtos (id_produto, data, movimento, qtde, custo_unitario, retirados)" +
                "VALUES (" + id.ToString() + ",'" + data.ToString() + "', 'entrada', "+ qtde.ToString() +"," +  custo.ToString().Replace(',', '.') + ", 0)";

            conexao.executarComando(query);

            //lançamento
            query = "INSERT INTO lancamentos (data, [desc]) VALUES ('" + data + "', 'Entrada estoque.')";

            conexao.executarComando(query);

            int idLancamento;

            //pegar id do lançamento (último id)
            query = "SELECT TOP 1 id FROM lancamentos ORDER BY id DESC";

            dr = conexao.buscar(query);
            dr.Read();

            idLancamento = (int)dr.GetInt32(0);

            dr.Close();

            //debitar estoque
            //registrar movimento
            dr = contas.getConta(Configuracoes.codEstoque);

            dr.Read();

            id = dr.GetInt32(0);

            
            query = "INSERT INTO movimentos_contas (id_lancamento, id_conta, tipo, valor) " +
                    "VALUES (" + idLancamento.ToString() + ", " + id.ToString() + ", 'Débito', " + (custo * qtde).ToString() + ")";

            conexao.executarComando(query);

            //atualizar conta
            query = "UPDATE contas SET total =" + (dr.GetDouble(8) + (custo * qtde)).ToString() + " WHERE id =" + id + "";

            conexao.executarComando(query);

            //atualizar "contas-pai"
            //dr = contas.getContaParent(Configuracoes.codEstoque);
            //while (dr.Read())
            //{
            //    id = (int)dr.GetInt32(0);
            //    query = "UPDATE contas SET total =" + (dr.GetDouble(8) + (custo * qtde)).ToString() + " WHERE id =" + id.ToString() + "";
            //    conexao.executarComando(query);
            //}

            //creditar fornecedores
            dr = contas.getConta(Configuracoes.codFornecedores);

            dr.Read();

            id = dr.GetInt32(0);
                        
            //registrar movimento
            query = "INSERT INTO movimentos_contas (id_lancamento, id_conta, tipo, valor) " +
                    "VALUES (" + idLancamento.ToString() + ", " + id.ToString() + ", 'Crédito', " + (custo * qtde).ToString() + ")";

            conexao.executarComando(query);

            //atualizar conta
            query = "UPDATE contas SET total =" + (dr.GetDouble(8) + (custo * qtde)).ToString() + " WHERE id =" + id + "";

            conexao.executarComando(query);

            //atualizar "contas-pai"
            //dr = contas.getContaParent(Configuracoes.codFornecedores);
            //while (dr.Read())
            //{
            //    id = (int)dr.GetInt32(0);
            //    query = "UPDATE contas SET total =" + (dr.GetDouble(8) + (custo * qtde)).ToString() + " WHERE id =" + id.ToString() + "";
            //    conexao.executarComando(query);
            //}
            
        }

        public void saida(int cod, double qtde)
        {
            buscarProduto(cod);

            dr.Read();

            int id = dr.GetInt32(0);
            double qtde_atual = dr.GetDouble(2);
            double preco = dr.GetDouble(3);
            

            string query = "UPDATE produtos SET qtde=" + (qtde_atual - qtde).ToString() + " WHERE id=" + id.ToString();

            conexao.executarComando(query);

            query = "INSERT INTO movimentos_produtos (id_produto, data, movimento, custo_unitario, qtde)" +
                "VALUES (" + id.ToString() + ",'" + DateTime.Now.ToString() + "', 'saída'," + preco.ToString().Replace(',','.') + ", "+qtde.ToString()+")";

            conexao.executarComando(query);

            query = "SELECT * FROM movimentos_produtos WHERE id_produto = " + id.ToString() + " AND qtde <> retirados AND movimento = 'entrada' ORDER BY data ASC";

            dr = conexao.buscar(query);

            double qtdeRemovida = 0;
            double totalRemovido = 0;
            double custo = 0;

            //PEPS
            while (dr.Read() && (totalRemovido < qtde))
            {
                if ((dr.GetDouble(4) - dr.GetDouble(6)) > (qtde - totalRemovido)) // O quanto há for maior que o quanto precisa
                {
                    qtdeRemovida = (qtde - totalRemovido);

                    query = "UPDATE movimentos_produtos SET retirados =" + (dr.GetDouble(6) + (qtdeRemovida)).ToString() + " WHERE id = " + dr.GetInt32(0).ToString();
                    //quantidade de retirados já cadastrada + os retirados agora;

                    
                } else
                {
                    qtdeRemovida = (dr.GetDouble(4) - dr.GetDouble(6));

                    query = "UPDATE movimentos_produtos SET retirados =" + (dr.GetDouble(4)).ToString() + " WHERE id = " + dr.GetInt32(0).ToString();
                    //zerar a o lote
                }

                conexao.executarComando(query);

                totalRemovido += qtdeRemovida; //quantidade retirada agora

                custo += qtdeRemovida * dr.GetDouble(5);
            }

            //lançamento
            DateTime data = DateTime.Now;

            query = "INSERT INTO lancamentos (data, [desc]) VALUES ('" + data + "', 'Saída estoque.')";

            conexao.executarComando(query);

            int idLancamento;

            //pegar id do lançamento (último id)
            query = "SELECT TOP 1 id FROM lancamentos ORDER BY id DESC";

            dr = conexao.buscar(query);
            dr.Read();

            idLancamento = (int)dr.GetInt32(0);

            dr.Close();

            //creditar estoque
            //registrar movimento
            dr = contas.getConta(Configuracoes.codEstoque);

            dr.Read();

            id = dr.GetInt32(0);


            query = "INSERT INTO movimentos_contas (id_lancamento, id_conta, tipo, valor) " +
                    "VALUES (" + idLancamento.ToString() + ", " + id.ToString() + ", 'Crédito', " + (custo).ToString().Replace(',', '.') + ")";

            conexao.executarComando(query);

            //atualizar conta
            query = "UPDATE contas SET total =" + (dr.GetDouble(8) - (custo)).ToString().Replace(',', '.') + " WHERE id =" + id + "";

            conexao.executarComando(query);

            //creditar receita
            //registrar movimento
            dr = buscarProduto(cod);

            dr.Read();

            double valor = dr.GetDouble(3) * qtde;

            dr = contas.getConta(Configuracoes.codReceita);

            dr.Read();

            id = (int)dr.GetInt32(0);

            query = "INSERT INTO movimentos_contas (id_lancamento, id_conta, tipo, valor) " +
                    "VALUES (" + idLancamento.ToString() + ", " + id.ToString() + ", 'Crédito', " + (valor).ToString().Replace(',','.') + ")";

            conexao.executarComando(query);

            //atualizar conta
            query = "UPDATE contas SET total =" + (dr.GetDouble(8) + (valor)).ToString().Replace(',', '.') + " WHERE id =" + id.ToString() + "";

            MessageBox.Show(query);

            conexao.executarComando(query);

            //Debitar CMV
            //registrar movimento
            dr = contas.getConta(Configuracoes.codCMV);

            dr.Read();

            id = dr.GetInt32(0);


            query = "INSERT INTO movimentos_contas (id_lancamento, id_conta, tipo, valor) " +
                    "VALUES (" + idLancamento.ToString() + ", " + id.ToString() + ", 'Débito', " + (custo).ToString().Replace(',', '.') + ")";

            conexao.executarComando(query);

            //atualizar conta
            query = "UPDATE contas SET total =" + (dr.GetDouble(8) + (custo)).ToString().Replace(',', '.') + " WHERE id =" + id.ToString() + "";

            conexao.executarComando(query);

            //Debitar Caixa
            dr = contas.getConta(Configuracoes.codCaixa);

            dr.Read();

            id = dr.GetInt32(0);


            query = "INSERT INTO movimentos_contas (id_lancamento, id_conta, tipo, valor) " +
                    "VALUES (" + idLancamento.ToString() + ", " + id.ToString() + ", 'Débito', " + (valor).ToString().Replace(',', '.') + ")";

            conexao.executarComando(query);

            //atualizar conta
            query = "UPDATE contas SET total =" + (valor).ToString().Replace(',', '.') + " WHERE id =" + id.ToString() + "";

            conexao.executarComando(query);
        }
    }
}
