using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDasMarmitas
{
    class ContasReceber : Contas
    {
        private Cliente _cliente;

        public Cliente Cliene
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        private DateTime _dataRecebimento;

        public DateTime DataRecebimento
        {
            get { return _dataRecebimento; }
            set { _dataRecebimento = value; }
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
