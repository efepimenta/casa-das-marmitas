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
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pnlWelcome.Dock = DockStyle.Fill;
            pnlWelcome.BringToFront();
            if (Db.Connect())
            {
                lblDbStatus.Text = "Db Conectado";
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
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pnlEmpresas.Dock = DockStyle.Fill;
            pnlEmpresas.BringToFront();
        }
    }
}
