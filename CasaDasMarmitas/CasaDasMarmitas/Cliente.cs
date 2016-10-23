using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDasMarmitas
{
    class Cliente
    {
        private String _nome;

        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private String _cpf;

        public String Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public bool Incluir()
        {
            return true;
        }

        public bool Excluir()
        {
            return true;
        }

        public bool Alterar()
        {
            return true;
        }

    }
}
