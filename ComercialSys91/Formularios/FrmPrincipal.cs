using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys91
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // criar instância do Formulario Cliente
            FrmCliente frmCliente = new FrmCliente();
            // tornando frmCliente filho do Container FrmPrincipal (this)
            frmCliente.MdiParent = this;
            // exiber o formulário de cliente na formprincipal
            frmCliente.Show();
        }

        private void produtosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // criar instância do Formulario Cliente
            FrmProduto frmProduto = new FrmProduto(this);
            // tornando frmCliente filho do Container FrmPrincipal (this)
            frmProduto.MdiParent = this;
            // exiber o formulário de cliente na formprincipal
            frmProduto.Show();
        }

        private void operaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmlogin = new FrmLogin();
            frmlogin.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // criar instância do Formulario Cliente
            FrmUsuario frmUsuario = new FrmUsuario(this);
            // tornando frmCliente filho do Container FrmPrincipal (this)
            frmUsuario.MdiParent = this;
            // exiber o formulário de cliente na formprincipal
            frmUsuario.Show();
        }
    }
}
