using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDasMarmitas
{
    class Pessoa
    {
        private int _cod;

        public int Codigo
        {
            get { return _cod; }
            set { _cod = value; }
        }

        private String _tel;

        public String Telefone
        {
            get { return _tel; }
            set { _tel = value; }
        }
        private DateTime _nasc;

        public DateTime Nascimento
        {
            get { return _nasc; }
            set { _nasc = value; }
        }
        private String _pais;

        public String Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }
        private String _uf;

        public String Uf
        {
            get { return _uf; }
            set { _uf = value; }
        }
        private String _cidade;

        public String Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        private String _bairro;

        public String Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }
        private String _logradouro;

        public String Logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }
        private int _num_logra;

        public int Num_logradouro
        {
            get { return _num_logra; }
            set { _num_logra = value; }
        }
        private String _complemento;

        public String Complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }
        private String _referencia;

        public String Referencia
        {
            get { return _referencia; }
            set { _referencia = value; }
        }
        private String _email;

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

    }
}
