using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDasMarmitas
{
    class Produto
    {
        private String _cod;

        public String Codigo
        {
            get { return _cod; }
            set { _cod = value; }
        }

        private String _nome;

        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private String _desc;

        public String Descricao
        {
            get { return _desc; }
            set { _desc = value; }
        }

        private double _preco;

        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }


    }
}
