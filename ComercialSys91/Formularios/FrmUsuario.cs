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
        public FrmUsuario(Form parent)
        {         
            InitializeComponent();
            // MdiParent = parent; centralizar formulario
            ListarDataGrid(); // Lista usuario
            MdiParent = parent;
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
               dgvUsuarios.Rows.Add();
               dgvUsuarios.Rows[lista.IndexOf(i)].Cells[clnID.Index].Value = i.id;
               dgvUsuarios.Rows[lista.IndexOf(i)].Cells[clnNome.Index].Value = i.nome;
               dgvUsuarios.Rows[lista.IndexOf(i)].Cells[clnEmail.Index].Value = i.email;
               dgvUsuarios.Rows[lista.IndexOf(i)].Cells[clnNivel.Index].Value = i.nivel;
               dgvUsuarios.Rows[lista.IndexOf(i)].Cells[clnAtivo.Index].Value = i.ativo;
           });
            BloquearCampos();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListarDataGrid();
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
                Convert.ToInt32(cmbNivel.SelectedValue),
                txtNome.Text,
                txtEmail.Text,
                txtSenha.Text
                );

            u.Inserir();

            //Se ID for maior que 0
            if (u.id > 0)
            {
                //Verificar se email é valido
                if (Validacao.EmailValido(txtEmail.Text))
                {
                    txtID.Text = u.id.ToString();
                    MessageBox.Show($"Usuario {u.id} inserido com sucesso", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Atualizar DataGridView
                    ListarDataGrid();
                }
                else
                {
                    //Email Invalido
                    MessageBox.Show($"Email invalido do usuario {u.id}", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                //falha ao inserir cliente
                MessageBox.Show("Falha ao inserir usuario", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
            BloquearCampos();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Objeto cliente
            Usuario usuario = new Usuario();
            //Atributo
            usuario.id = int.Parse(txtID.Text);
            usuario.nome = txtNome.Text;
            usuario.password = txtSenha.Text;
            usuario.email = txtEmail.Text;
            usuario.nivel = Convert.ToInt32(cmbNivel.SelectedValue);
            usuario.ativo = chkAtivo.Checked;

            //Validaçao de email
            if (Validacao.EmailValido (txtEmail.Text))
            {
                //usuario deseja fazer a alteração
                if (MessageBox.Show("Você tem certeza que deseja alterar?", "SysComercial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Condição
                    if (usuario.Alterar()) // Se cliente alterar for igual a TRUE
                    {
                        //Mensagem Box
                        MessageBox.Show("Cliente alterado com sucesso!", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Limpa todos campos
                        LimparTodosCampos();

                        //Lista novamente
                        ListarDataGrid();
                    }
                    else // Senão
                    {
                        //Messagem Box
                        MessageBox.Show("Falha ao alterar o usuario!", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                // Email Invalido
                MessageBox.Show($"Email do usuario {usuario.id} invalido", "SysComercial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            BloquearCampos();
        }

        private void txtNomePesquisar_TextChanged(object sender, EventArgs e)
        {
            // Verificando se o valor a pesquisar é vazio
            if (txtNomePesquisar.Text == "")
            {

            }
            else
            {
                // Objeto Cliente
                Usuario usuario = new Usuario();

                // Metodo Consulta por nome
                usuario.ConsultarPorNome(Convert.ToString(txtNomePesquisar.Text));

                //Atributos
                txtID.Text = Convert.ToString(usuario.id);
                txtNome.Text = usuario.nome;
                txtEmail.Text = usuario.email;
                txtSenha.Text = usuario.password;
                cmbNivel.SelectedValue = usuario.nivel;
                chkAtivo.Checked = usuario.ativo;
            }
            // Limpar textbox pesquisar
            txtIdPesquisar.Clear();
        }


        private void txtIdPesquisar_TextChanged(object sender, EventArgs e)
        {
            // Verificando se o valor a pesquisar é vazio
            if (txtIdPesquisar.Text == "")
            {

            }
            else
            {
                // Objeto Cliente
                Usuario usuario = new Usuario();

                // Metodo Consulta por ID
                usuario.ConsultarPorId(Convert.ToInt32(txtIdPesquisar.Text));

                // Atributos
                txtID.Text = usuario.id.ToString();
                txtNome.Text = usuario.nome;
                txtEmail.Text = usuario.email;
                txtSenha.Text = usuario.password;
                cmbNivel.SelectedValue = usuario.nivel;
            }
        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuario_Load_1(object sender, EventArgs e)
        {

        }
    }
}
