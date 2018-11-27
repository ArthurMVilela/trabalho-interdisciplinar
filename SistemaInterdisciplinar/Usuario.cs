using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInterdisciplinar
{
    
    public class Usuario
    {
        private string nome;
        private string role;
        private long id;

        public Usuario ()
        {
            id = -1;
            nome = "INVALIDO";
            role = "BLOQU";
        }

        public Usuario(long i, string n, string r)
        {
            id = i;
            nome = n;
            role = r;
        }
        public bool invalido() {
            if (id == -1)
            {
                return true;
            }
            return false;
        }
        public string getNome()
        {
            return nome;
        }
        public long getId()
        {
            return id;
        }
        public string getRole()
        {
            return role;
        }
    }
}
