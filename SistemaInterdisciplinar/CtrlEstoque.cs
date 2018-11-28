using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


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

            query = "INSERT INTO movimentos_produtos (id_produto, data, movimento, custo_unitario)" +
                "VALUES (" + id.ToString() + ",'" + data.ToString() + "', 'entrada'," +  custo.ToString().Replace(',', '.') + ")";

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

            dr = contas.getContaParent(Configuracoes.codEstoque);


            while (dr.Read())
            {
                id = (int)dr.GetInt32(0);

                query = "UPDATE contas SET total =" + (dr.GetDouble(8) + (custo * qtde)).ToString() + " WHERE id =" + id.ToString() + "";

                conexao.executarComando(query);
            }

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

            dr = contas.getContaParent(Configuracoes.codFornecedores);


            while (dr.Read())
            {
                id = (int)dr.GetInt32(0);

                query = "UPDATE contas SET total =" + (dr.GetDouble(8) + (custo * qtde)).ToString() + " WHERE id =" + id.ToString() + "";

                conexao.executarComando(query);
            }
            
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

            query = "INSERT INTO movimentos_produtos (id_produto, data, movimento, custo_unitario)" +
                "VALUES (" + id.ToString() + ",'" + DateTime.Now.ToString() + "', 'saída'," + preco.ToString().Replace(',','.') + ")";

            conexao.executarComando(query);
        }
    }
}
