using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDasMarmitas
{
    class Contas
    {
        public enum ContaStatus { Aberto, Recebido, Pago };

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private double _valor;

        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        private DateTime _dataVenc;

        public DateTime DataVencimento
        {
            get { return _dataVenc; }
            set { _dataVenc = value; }
        }

        private ContaStatus _status;

        public ContaStatus StatusConta
        {
            get { return _status; }
            set { _status = value; }
        }

    }
}
