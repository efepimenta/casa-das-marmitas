using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDasMarmitas
{
    class Entregador
    {
        private int _cod;

        public int Cod
        {
            get { return _cod; }
            set { _cod = value; }
        }

        private String _nome;

        public String  Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _cpf;

        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        private String _rg;

        public String Rg
        {
            get { return _rg; }
            set { _rg = value; }
        }

        private String _cel;

        public String Celular
        {
            get { return _cel; }
            set { _cel = value; }
        }
        private Empresa _empresa;

        public Empresa Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
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
