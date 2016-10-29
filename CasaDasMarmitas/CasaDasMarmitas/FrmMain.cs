using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDasMarmitas
{
    public partial class FrmMain : Form
    {
        private enum DbAction {create, update, delete };
        Cliente cliente;
        DbAction action;

        private bool isConnected = false;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pnlWelcome.Dock = DockStyle.Fill;
            pnlWelcome.BringToFront();
            status.BringToFront();
            if (Db.Connect())
            {
                lblDbStatus.Text = "Db Conectado";
                isConnected = true;
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Db.Disconnect();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pnlClientes.Dock = DockStyle.Fill;
            pnlClientes.BringToFront();
            status.BringToFront();
            if (isConnected)
            {
                Cliente.Preenche(lstClientes);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pnlEmpresas.Dock = DockStyle.Fill;
            pnlEmpresas.BringToFront();
            status.BringToFront();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            pnlEntregador.Dock = DockStyle.Fill;
            pnlEntregador.BringToFront();
            status.BringToFront();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            pnlContasReceber.Dock = DockStyle.Fill;
            pnlContasReceber.BringToFront();
            status.BringToFront();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            pnlContasPagar.Dock = DockStyle.Fill;
            pnlContasPagar.BringToFront();
            status.BringToFront();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            pnlProdutos.Dock = DockStyle.Fill;
            pnlProdutos.BringToFront();
            status.BringToFront();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            pnlPedidos.Dock = DockStyle.Fill;
            pnlPedidos.BringToFront();
            status.BringToFront();
        }

        private void btnClienteNovo_Click(object sender, EventArgs e)
        {
            btnClienteNovo.Enabled = false;
            btnClienteCancelar.Enabled = true;
            btnClienteSalvar.Enabled = true;
            cliente = new Cliente();
            action = DbAction.create;
            this.LimparEdits();
        }

        private void PopularCliente()
        {
            cliente = new Cliente();
            cliente.Codigo = int.Parse(lstClientes.SelectedItems[0].SubItems[14].Text);
            cliente.Nome = edtClienteNome.Text;
            cliente.Cpf = edtClienteCpf.Text;
            cliente.Telefone = edtClienteTelefone.Text;
            cliente.Nascimento = edtClienteDataNasc.Value;
            cliente.Logradouro = edtClienteEndereco.Text;
            cliente.Num_logradouro = int.Parse(edtClienteNumero.Text);
            cliente.Complemento = edtClienteComplemento.Text;
            cliente.Bairro = edtClienteBairro.Text;
            cliente.Cep = edtClienteCep.Text;
            cliente.Cidade = edtClienteCidade.Text;
            cliente.Uf = edtClienteUf.Text;
            cliente.Referencia = edtClienteReferencia.Text;
            cliente.Email = edtClienteEmail.Text;
        }

        private void PopularEdits()
        {
            edtClienteNome.Text = lstClientes.SelectedItems[0].SubItems[1].Text;
            edtClienteCpf.Text = lstClientes.SelectedItems[0].SubItems[2].Text;
            edtClienteTelefone.Text = lstClientes.SelectedItems[0].SubItems[3].Text;
            edtClienteDataNasc.Value = DateTime.Parse(lstClientes.SelectedItems[0].SubItems[4].Text);
            edtClienteEndereco.Text = lstClientes.SelectedItems[0].SubItems[5].Text;
            edtClienteNumero.Text = lstClientes.SelectedItems[0].SubItems[6].Text;
            edtClienteComplemento.Text = lstClientes.SelectedItems[0].SubItems[7].Text;
            edtClienteBairro.Text = lstClientes.SelectedItems[0].SubItems[8].Text;
            edtClienteCep.Text = lstClientes.SelectedItems[0].SubItems[9].Text;
            edtClienteCidade.Text = lstClientes.SelectedItems[0].SubItems[10].Text;
            edtClienteUf.Text = lstClientes.SelectedItems[0].SubItems[11].Text;
            edtClienteReferencia.Text = lstClientes.SelectedItems[0].SubItems[12].Text;
            edtClienteEmail.Text = lstClientes.SelectedItems[0].SubItems[13].Text;
        }

        private void LimparEdits()
        {
            edtClienteNome.Text = "";
            edtClienteCpf.Text = "";
            edtClienteTelefone.Text = "";
            edtClienteDataNasc.Value = DateTime.Now;
            edtClienteEndereco.Text = "";
            edtClienteNumero.Text = "";
            edtClienteComplemento.Text = "";
            edtClienteBairro.Text = "";
            edtClienteCep.Text = "";
            edtClienteCidade.Text = "";
            edtClienteUf.Text = "";
            edtClienteReferencia.Text = "";
            edtClienteEmail.Text = "";
        }

        private void Do()
        {
            switch (action)
            {
                case DbAction.create:
                    if (cliente.Salvar())
                    {
                        Cliente.Preenche(lstClientes);
                    }
                    break;
                case DbAction.update:
                    if (cliente.Atualizar(cliente.Codigo))
                    {
                        Cliente.Preenche(lstClientes);
                    }
                    break;
                case DbAction.delete:
                    if (cliente.Excluir(cliente.Codigo))
                    {
                        Cliente.Preenche(lstClientes);
                    }
                    break;
            }
        }

        private void btnClienteSalvar_Click(object sender, EventArgs e)
        {
            this.PopularCliente();
            if (isConnected)
            {
                this.Do();
            }
            btnClienteCancelar.Enabled = false;
            btnClienteSalvar.Enabled = false;
            btnClienteNovo.Enabled = true;
            this.LimparEdits();
        }

        private void btnClienteCancelar_Click(object sender, EventArgs e)
        {
            this.LimparEdits();
            btnClienteCancelar.Enabled = false;
            btnClienteSalvar.Enabled = false;
            btnClienteNovo.Enabled = true;
        }

        private void lstClientes_DoubleClick(object sender, EventArgs e)
        {
            this.PopularEdits();
            action = DbAction.update;
            btnClienteCancelar.Enabled = true;
            btnClienteNovo.Enabled = false;
            btnClienteSalvar.Enabled = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            action = DbAction.delete;
            cliente = new Cliente();
            cliente.Codigo = int.Parse(lstClientes.SelectedItems[0].SubItems[14].Text);
            if (cliente.Codigo > 0)
            {
                this.Do();
            }
        }
    }
}
