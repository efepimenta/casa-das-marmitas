using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDasMarmitas
{
    class ContasPagar : Contas
    {
        private Entregador _entregador;

        public Entregador Entregador
        {
            get { return _entregador; }
            set { _entregador = value; }
        }

        private DateTime _dataPagamento;

        public DateTime DataPagamento
        {
            get { return _dataPagamento; }
            set { _dataPagamento = value; }
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
