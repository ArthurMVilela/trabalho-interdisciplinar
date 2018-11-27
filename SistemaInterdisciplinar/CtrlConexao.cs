using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaInterdisciplinar
{
    public class CtrlConexao
    {
        // String de connexão
        private string sConexao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\FATEC\trabalho-interdisciplinar\SistemaInterdisciplinar\bin\Debug\db\db.accdb";
        private OleDbConnection conexao;

        public void iniciarConexao()
        {
            conexao = new OleDbConnection(sConexao);
            try
            {
                conexao.Open();
                //MessageBox.Show("Sucesso!");
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void terminarConexao()
        {
            conexao.Close();
        }

        public void executarComando(string query)
        {
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.CommandText = query;
                cmd.Connection = conexao;
                cmd.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(query);
            }
        }

        public OleDbDataReader buscar(string query)
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;
            try
            {
                cmd.CommandText = query;
                cmd.Connection = conexao;
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void log(Usuario usr, string acao)
        {
            string query = "INSERT INTO logs (id_usuario,data,acao) VALUES (" + usr.getId().ToString() + ", '" + DateTime.Now.ToString() +"', '"+ acao +"')";


            executarComando(query);
        }
    }
}
