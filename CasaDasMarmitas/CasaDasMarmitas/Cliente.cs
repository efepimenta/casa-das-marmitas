using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDasMarmitas
{
    class Cliente : Pessoa
    {
        private static DataSet data = new DataSet();

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

        public static void Preenche(ListView list)
        {
            list.Items.Clear();
            data.Clear();
            data = Db.Select("select * from cliente c inner join pessoa p on p.id = c.idPessoa");
            foreach (DataRow row in data.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["id"].ToString();
                item.SubItems.Add(row["nome"].ToString());
                item.SubItems.Add(row["cpf"].ToString());
                item.SubItems.Add(row["telefone"].ToString());
                item.SubItems.Add(row["dtNascimento"].ToString());
                item.SubItems.Add(row["endereco"].ToString());
                item.SubItems.Add(row["num"].ToString());
                item.SubItems.Add(row["complemento"].ToString());
                item.SubItems.Add(row["bairro"].ToString());
                item.SubItems.Add(row["cep"].ToString());
                item.SubItems.Add(row["cidade"].ToString());
                item.SubItems.Add(row["uf"].ToString());
                item.SubItems.Add(row["referencia"].ToString());
                item.SubItems.Add(row["email"].ToString());
                item.SubItems.Add(row["idPessoa"].ToString());
                list.Items.Add(item);
            }
        }

        public bool Salvar()
        {
            string query = String.Format("insert into Pessoa (telefone,dtNascimento,uf,cidade,bairro,endereco,num,complemento,referencia,email,cep) " +
                    "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                    this.Telefone, Convert.ToDateTime(this.Nascimento).ToString("yyyy-MM-dd"),
                    this.Uf, this.Cidade, this.Bairro, this.Logradouro, this.Num_logradouro, this.Complemento,
                    this.Referencia, this.Email, this.Cep);
            if (this.incluir(query))
            {
                data = Db.Select("SELECT IDENT_CURRENT('Pessoa') as id");
                query = String.Format("insert into Cliente (nome,cpf,idPessoa) values ('{0}','{1}','{2}')",
                this.Nome, this.Cpf, data.Tables[0].Rows[1]["id"]);
                if (this.incluir(query))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Atualizar(int id)
        {
            string query = String.Format("update pessoa set telefone='{0}',dtNascimento='{1}',uf='{2}',cidade='{3}',bairro='{4}'," +
                "endereco='{5}',num='{6}',complemento='{7}',referencia='{8}',email='{9}',cep='{10}' where id = {11}",
                this.Telefone, Convert.ToDateTime(this.Nascimento).ToString("yyyy-MM-dd"),
                    this.Uf, this.Cidade, this.Bairro, this.Logradouro, this.Num_logradouro, this.Complemento,
                    this.Referencia, this.Email, this.Cep, id);
            if (base.atualizar(query))
            {
                query = String.Format("update Cliente set nome='{0}',cpf='{1}' where idPessoa={2}",
                this.Nome, this.Cpf, id);
                if (this.incluir(query))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Excluir(int id)
        {
            string query = String.Format("delete from Cliente where idPessoa={0}", id);
            if (this.incluir(query))
            {
                return true;
            }
            return false;
        }
    }
}
