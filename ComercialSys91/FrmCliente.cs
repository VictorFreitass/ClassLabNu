﻿using System;
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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(txtNome.Text, txtCpf.Text, txtEmail.Text);
            c.Inserir();
            if (c.Id > 0)
            {
                txtId.Text = c.Id.ToString();
                MessageBox.Show("Cliente gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao inserir cliente.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            List<Cliente> listaDeClientes = Cliente.Listar();
            int cont = 0;
            foreach (Cliente cliente in listaDeClientes)
            {
                dgvClientes.Rows.Add();
                dgvClientes.Rows[cont].Cells[0].Value = cliente.Id.ToString();
                dgvClientes.Rows[cont].Cells[1].Value = cliente.Nome.ToString();
                dgvClientes.Rows[cont].Cells[2].Value = cliente.Cpf.ToString();
                dgvClientes.Rows[cont].Cells[3].Value = cliente.Email.ToString();
                dgvClientes.Rows[cont].Cells[4].Value = cliente.Ativo;
                cont++;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (cliente.Alterar (int.Parse (txtId.Text), txtNome.Text, txtEmail.Text))
            {
                MessageBox.Show("Cliente alterado com Sucesso!");
            }
            else
            {
                MessageBox.Show("Falha na alteração do Cliente!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Text == "...")
            {
                txtId.ReadOnly = false;
                txtId.Focus();
                btnBuscar.Text = "Buscar";
            }
            else
            {
                Cliente cliente = Cliente.ConsultarPorId(int.Parse(txtId.Text));
                if(cliente.Id > 0)
                {
                    txtNome.Text = cliente.Nome.ToString();
                    txtCpf.Text = cliente.Cpf.ToString();
                    txtEmail.Text = cliente.Email.ToString();
                    dtpDataCad.Value = cliente.DataCad.Date;
                    chkAtivo.Checked = cliente.Ativo;

                    btnBuscar.Text = "...";
                    txtId.ReadOnly=true;
                    btnAlterar.Enabled = true;
                    txtCpf.ReadOnly=true;
                }
                else
                {
                    MessageBox.Show("Esse código de cliente não existe!");
                }
            }
        }
    }
}