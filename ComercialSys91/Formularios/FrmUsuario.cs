using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComercialSys;
using ClassLabNu;

namespace ComercialSys91
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {         
            InitializeComponent();
            MdiParent = parent; // centralizar formulario
            ListarDataGrid(); // Lista usuario
        }

        private void LiberarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
            cmbNivel.Enabled = true;
            chkAtivo.Enabled = true;

        }
        /// <summary>
        /// Metodo bloquear campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BloquearCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled= false;
            cmbNivel.Enabled = false;
            chkAtivo.Enabled = false;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            var lista = Nivel.ListarNivel();
            //Listar usuario combobox
            cmbNivel.DataSource = lista.ToArray();
            cmbNivel.DisplayMember = "Nome";
            cmbNivel.ValueMember = "Id";

        }

        /// <summary>
        /// Listar DataGrid de usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ListarDataGrid()
        {
            //Limpar Grid
            dgvUsuarios.Rows.Clear();

            //Var para listar usuario
            var lista = Usuario.ListarUsuarios();

            //Listando usuarios no DataGrid
            lista.ForEach(i =>
           {
               GridUsuarios.Rows.Add();
               GridUsuarios.Rows[lista.IndexOf(i)].Cells[clnID.Index].Value = i.Id;
               GridUsuarios.Rows[lista.IndexOf(i)].Cells[clnNome.Index].Value = i.Nome;
               GridUsuarios.Rows[lista.IndexOf(i)].Cells[clnEmail.Index].Value = i.Email;
               GridUsuarios.Rows[lista.IndexOf(i)].Cells[clnSenha.Index].Value = i.Password;
               GridUsuarios.Rows[lista.IndexOf(i)].Cells[clnNivel.Index].Value = i.Nivel;
               GridUsuarios.Rows[lista.IndexOf(i)].Cells[clnAtivo.Index].Value = i.Ativo;
           });
            BloquearCampos();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Varial para objeto cliente
            Usuario u = new Usuario();

            //Valores para o objeto
            u.id = Convert.ToInt32(dgvUsuarios["clnID", e.RowIndex].Value);
            u.nome = Convert.ToString(dgvUsuarios["clnNome", e.RowIndex].Value);
            u.email = Convert.ToString(dgvUsuarios["clnEmail", e.RowIndex].Value);
            u.ativo = Convert.ToBoolean(dgvUsuarios["clnAtivo", e.RowIndex].Value);
            u.nivel = Convert.ToInt32(dgvUsuarios["clnNivel", e.RowIndex].Value);

            //Atributos
            txtID.Text = u.id.ToString();
            txtNome.Text = u.nome;
            txtEmail.Text = u.email;
            txtSenha.Text = u.password;
            cmbNivel.SelectedValue = u.nivel;
            chkAtivo.Checked = u.ativo;
        }

        /// <summary>
        /// Metodo limpar todos campos
        /// </summary>
        private void LimparTodosCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Objeto Usuario
            Usuario u = new Usuario(
                txtNome.Text,
                txtEmail.Text,
                txtSenha.Text,
                Convert.ToInt32(cmbNivel.SelectedValue)
                );

            u.Inserir();

            //Se ID for maior que 0
            if (u.id > 0)
            {
                //Verificar se email é valido
                if (ValidacaoController.EmailValido(txtEmail.Text))
                {
                    txtID.Text = u.id.ToString();
                    MessageBox.Show($"Usuario {u.Id} inserido com sucesso", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Atualizar DataGridView
                    ListarDataGrid();
                }
                else
                {
                    //Email Invalido
                    MessageBox.Show($"Email invalido do usuario {u.Id}", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                //falha ao inserir cliente
                MessageBox.Show("Falha ao inserir usuario", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
            BloquearCampos();

        }
    }
}
