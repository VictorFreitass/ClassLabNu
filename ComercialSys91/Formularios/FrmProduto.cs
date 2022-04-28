using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLabNu;

namespace ComercialSys91
{
    public partial class FrmProduto : Form
    {
        public FrmProduto(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Produto c= new Produto(txtDescricao.Text, txtUnidade.Text, txtCodbar.Text, Convert.ToDouble(txtValor.Text), Convert.ToDouble (txtDesconto.Text));
            c.Inserir();
            if (c.Id > 0)
            {
                txtId.Text = c.Id.ToString();
                MessageBox.Show("Produto gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao inserir produto.");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lstProduto.Items.Clear();
            List<Produto> listaDeClientes = Produto.Listar();
            foreach (Produto produto in listaDeClientes)
            {
                lstProduto.Items.Add(produto.Id + " - " + produto.Descricao);
            }
        }
    }
}
