using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography; // Ferramentas de criptografia
using System.Windows.Forms; //So para depuração (no momento)
using System.Data.OleDb; //Para a conexão com o banco de dado access

namespace SistemaInterdisciplinar
{
    // Esta classe serve para controlar o cadastro e acesso de usuários
    class CtrlLogin
    {
        private CtrlConexao conexao; //Objeto para gerenciar conexão com o banco de dados

        public CtrlLogin()
        {
            conexao = new CtrlConexao(); 
            conexao.iniciarConexao();
            
        }

        //Gera o salt para a verificação da chave de acesso do usuário
        //Retorna uma string com números em base 64
        private string gerarSalt(int tamanho) {
            RNGCryptoServiceProvider randomico = new RNGCryptoServiceProvider();
            byte[] buff = new byte[tamanho];
            randomico.GetBytes(buff); // Enche um vetor de bytes com numeros randomicos
            return Convert.ToBase64String(buff); // converte os bytes em uma string com algarismos base 64
        }

        //gera uma chave de segurança usada para validar o login
        private string gerarChave (string input, string salt) {
            byte[] bytesInput = new UTF8Encoding().GetBytes(input + salt);
            SHA256Managed hash = new SHA256Managed();
            byte[] chave = hash.ComputeHash(bytesInput);

            return Convert.ToBase64String(chave);
        }

        //Procura por um usuário ja cadastrado com a entrada do usuário
        private bool procurarUsuario(string nome, string email, string cpf)
        {
            OleDbDataReader dr = conexao.buscar("SELECT * FROM usuarios WHERE nome = '"+ nome +"' OR email = '"+ email + "' OR cpf = '"+ cpf +"'");

            
            if (dr.HasRows)
            {
                dr.Read();
                
                if(dr.GetString(1) == nome)
                {
                    MessageBox.Show("Já existe um usuário cadastrado com esse nome.");
                    
                } else if (dr.GetString(2) == email)
                {
                    MessageBox.Show("Já existe um usuário cadastrado com esse email.");
                } else
                {
                    MessageBox.Show("Já existe um usuário cadastrado com esse cpf.");
                }
                dr.Close();
                return true;
            }
            dr.Close();
            return false;
        }

        // Verifica se o usuario existe e libera o acesso ou não
        public Usuario verificarUsuario(string nome, string senha) {
            OleDbDataReader dr = conexao.buscar("SELECT * FROM usuarios WHERE nome = '" + nome + "'");

            if(dr.HasRows)
            {
                dr.Read();

                //variáveis com informações do usuário
                long id = dr.GetInt32(0);
                string salt = dr.GetString(6);
                string chave = dr.GetString(7);
                string status = dr.GetString(10);
                string role = dr.GetString(8);
                int tentativas = dr.GetInt16(9);

                string query;

                if (status == "ATIVO")
                {
                    if (chave == gerarChave(senha, salt))
                    {
                        //logar usuário
                        MessageBox.Show("Logado com sucesso");
                        //retorna um objeto usuario valido com as informações validas
                        return new Usuario(id, nome, role);
                    }
                    else
                    {
                        //Atualizar tentativas (acesso)
                        //Se for igual à 0, a conta é bloqueada.
                        tentativas--;
                        
                        if (tentativas == 0)
                        {
                            query = "UPDATE usuarios SET tentativas = " + tentativas.ToString() + ", status = 'BLOQU' WHERE nome = '" + nome + "'";
                        } else
                        {
                            query = "UPDATE usuarios SET tentativas = " + tentativas.ToString() + " WHERE nome = '" + nome + "'";

                        }
                        conexao.executarComando(query);
                        MessageBox.Show("Esta conta foi bloqueada. Entre em contato com o seu administrador de sistema.");
                    }
                } else if(status == "DESAT")
                {
                    MessageBox.Show("Está conta está desativada.");
                } else if (status == "BLOQU")
                {
                    MessageBox.Show("Esta conta está bloqueada. Entre em contato com o seu administrador de sistema.");
                }

                
            } else
            {
                MessageBox.Show("Não existe um usuário com este nome.");
            }

            dr.Close(); // fechar o objeto de leitura (IMPORTANTE)
            return new Usuario(); //retorna um usuário invalido que a aplicação não deixa usar o programa
        }

        public void cadastrarUsuario (string nome, string email, string cpf, string cep, string endereco, string senha, string cargo)
        {
            string salt = gerarSalt(20);
            MessageBox.Show(salt.Length.ToString());
            string chaveSeguranca = gerarChave(senha, salt);
            MessageBox.Show(chaveSeguranca.Length.ToString());
            string query = "INSERT INTO usuarios (nome, email, cpf, cep, endereco, salt, chave_seguranca, role, tentativas, status)" +
                "VALUES ('"+ nome +"', '"+ email +"', '"+ cpf +"', '"+ cep +"' , '"+ endereco +"', '"+ salt +"', '"+ chaveSeguranca +"'," +
                "'"+ cargo +"',"+ 3 +", 'ATIVO')";

            if (!procurarUsuario(nome,email,cpf))
            {
                conexao.executarComando(query);
            }

        }
            
    }
}
