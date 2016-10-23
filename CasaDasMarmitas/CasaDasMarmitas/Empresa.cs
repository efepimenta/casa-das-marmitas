using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDasMarmitas
{
    class Empresa : Pessoa
    {
        private String _razao;
        public String Razao
        {
            get { return _razao; }
            set { _razao = value; }
        }

        private String _cnpj;

        public String Cpf
        {
            get { return _cnpj; }
            set { _cnpj = value; }
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
