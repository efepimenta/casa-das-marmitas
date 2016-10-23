using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDasMarmitas
{
    class Pedido
    {
        private int _qtde;

        public int Quantidade
        {
            get { return _qtde; }
            set { _qtde = value; }
        }

        private Produto _produto;

        public Produto Produto
        {
            get { return _produto; }
            set { _produto = value; }
        }

        public void Add()
        {

        }

        public void Del()
        {

        }
    }
}
