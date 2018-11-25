using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace SistemaInterdisciplinar
{
    public class CtrlContas
    {
        CtrlConexao conexao;
        OleDbDataReader dr;

        public CtrlContas()
        {
            conexao = new CtrlConexao();
            conexao.iniciarConexao();
            
        }

        public OleDbDataReader getContas()
        {
            dr = conexao.buscar("SELECT * FROM contas ORDER BY n1, n2, n3, n4, n5");

            return dr;
        }

        public string gerarClassificacao(int n1, int n2, int n3, int n4, int n5)
        {
            string text = "";
            string mascara = Configuracoes.mascaraInterna;

            string[] tokens = mascara.Split('-');

            foreach (string token in tokens) {
                if(token.Contains("9"))
                {

                } else
                {

                }
            }

            return text;
        }
        
    }
}
