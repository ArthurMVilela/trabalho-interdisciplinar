using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

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

            int[] niveis = { n1, n2, n3, n4, n5 };
            string[] niveisStr = new string[5];
            string[] tokens = mascara.Split('-');

            int i = 0;
            string chave = "";
            char c;
            foreach (int nivel in niveis)
            {
                chave = "";
                
                if (tokens[i].Contains("9"))
                {
                    
                    for (int j = 0; j < tokens[i].Length; j++)
                    {
                        chave += "0";
                    }
                    niveisStr[i] = string.Format("{0:"+ chave +"}", nivel);
                } else if (tokens[i].Contains("l"))
                {
                    c = (char) (nivel + 'a');
                    chave = c.ToString();
                }
                i++;
            }

            if (n2 == 0)
            {
                text = String.Format("{0}", niveisStr[0]);
            } else if (n3 == 0)
            {
                text = String.Format("{0}-{1}", niveisStr[0], niveisStr[1]);
            } else if (n4 == 0)
            {
                text = String.Format("{0}-{1}-{2}", niveisStr[0], niveisStr[1], niveisStr[2]);
            } else if (n5 == 0)
            {
                text = String.Format("{0}-{1}-{2}-{3}", niveisStr[0], niveisStr[1], niveisStr[2], niveisStr[3]);
            } else
            {
                text = String.Format("{0}-{1}-{2}-{3}-{4}", niveisStr[0], niveisStr[1], niveisStr[2], niveisStr[3], niveisStr[4]);
            }


            return text;
        }
        
    }
}
