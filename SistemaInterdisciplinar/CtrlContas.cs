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
                
                //se o nivel for maior que 25 não pode ser representado por caracter [a,z]
                if (tokens[i].Contains("9") || nivel > 25)
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
        
        public int[] getNiveis(string cod)
        {
            int[] niveis = { 0, 0, 0, 0, 0 };

            string[] tokens = cod.Split('-');

            int i = 0;

            foreach(string token in tokens)
            {
                niveis[i] = Convert.ToInt32(token);
                i++;
            }
            
            return niveis;
        }

        //buscar por conta com base no código/mascara da conta
        public OleDbDataReader getConta(string cod)
        {
            int[] niveis = getNiveis(cod);
            string query = "SELECT * FROM contas WHERE n1=" + niveis[0].ToString();

            if (niveis[1] != 0)
            {
                query += "AND n2 = " + niveis[1].ToString();
            }
            if (niveis[2] != 0)
            {
                query += "AND n3 = " + niveis[2].ToString();
            }
            if (niveis[3] != 0)
            {
                query += "AND n4 = " + niveis[3].ToString();
            }
            if (niveis[4] != 0)
            {
                query += "AND n5 = " + niveis[4].ToString();
            }
            dr = conexao.buscar(query);

            return dr;
        }

        //buscar por "conta pai" com base no código/mascara da conta
        public OleDbDataReader getContaParent(string cod)
        {

            int[] niveis = getNiveis(cod);
            int[] niveisParent = { 0, 0, 0, 0, 0 };

            int i = 0;

            for (i = 0; i < 5; i++)
            {
                niveisParent[i] = niveis[i];
            }

            i = 0;

            while (niveis[i] != 0)
            {
                niveisParent[i] = niveis[i];
                i++;
            }

            niveisParent[i - 1] = 0;


            string query = "SELECT * FROM contas WHERE n1=" + niveisParent[0].ToString() + "AND n"+i.ToString()+ " IS NULL";

            dr = conexao.buscar(query);


            return dr;
        }
    }
}
