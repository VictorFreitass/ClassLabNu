namespace ComercialSys91
{
    partial class FrmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cadastro = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.lbnivel = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtIdPesquisar = new System.Windows.Forms.TextBox();
            this.txtNomePesquisar = new System.Windows.Forms.TextBox();
            this.Pesquisar = new System.Windows.Forms.Label();
            this.IdPesquisar = new System.Windows.Forms.Label();
            this.NomePesquisar = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.Usuarios = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Desbloquear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Cadastro
            // 
            this.Cadastro.AutoSize = true;
            this.Cadastro.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Cadastro.Location = new System.Drawing.Point(8, 23);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(82, 20);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.Click += new System.EventHandler(this.Cadastro_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(9, 68);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(137, 68);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 2;
            this.Nome.Text = "Nome";
            this.Nome.Click += new System.EventHandler(this.label3_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(9, 131);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(329, 134);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(38, 13);
            this.Senha.TabIndex = 4;
            this.Senha.Text = "Senha";
            // 
            // lbnivel
            // 
            this.lbnivel.AutoSize = true;
            this.lbnivel.Location = new System.Drawing.Point(449, 133);
            this.lbnivel.Name = "lbnivel";
            this.lbnivel.Size = new System.Drawing.Size(31, 13);
            this.lbnivel.TabIndex = 5;
            this.lbnivel.Text = "Nivel";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(9, 93);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(131, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(301, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(297, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(332, 158);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 9;
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(452, 158);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(121, 21);
            this.cmbNivel.TabIndex = 10;
            this.cmbNivel.SelectedIndexChanged += new System.EventHandler(this.cmbNivel_SelectedIndexChanged);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(450, 95);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 11;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtIdPesquisar
            // 
            this.txtIdPesquisar.Location = new System.Drawing.Point(614, 97);
            this.txtIdPesquisar.Name = "txtIdPesquisar";
            this.txtIdPesquisar.Size = new System.Drawing.Size(100, 20);
            this.txtIdPesquisar.TabIndex = 12;
            this.txtIdPesquisar.TextChanged += new System.EventHandler(this.txtIdPesquisar_TextChanged);
            // 
            // txtNomePesquisar
            // 
            this.txtNomePesquisar.Location = new System.Drawing.Point(614, 159);
            this.txtNomePesquisar.Name = "txtNomePesquisar";
            this.txtNomePesquisar.Size = new System.Drawing.Size(100, 20);
            this.txtNomePesquisar.TabIndex = 13;
            this.txtNomePesquisar.TextChanged += new System.EventHandler(this.txtNomePesquisar_TextChanged);
            // 
            // Pesquisar
            // 
            this.Pesquisar.AutoSize = true;
            this.Pesquisar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Pesquisar.Location = new System.Drawing.Point(613, 23);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(88, 20);
            this.Pesquisar.TabIndex = 14;
            this.Pesquisar.Text = "Pesquisar";
            // 
            // IdPesquisar
            // 
            this.IdPesquisar.AutoSize = true;
            this.IdPesquisar.Location = new System.Drawing.Point(614, 70);
            this.IdPesquisar.Name = "IdPesquisar";
            this.IdPesquisar.Size = new System.Drawing.Size(18, 13);
            this.IdPesquisar.TabIndex = 15;
            this.IdPesquisar.Text = "ID";
            // 
            // NomePesquisar
            // 
            this.NomePesquisar.AutoSize = true;
            this.NomePesquisar.Location = new System.Drawing.Point(614, 134);
            this.NomePesquisar.Name = "NomePesquisar";
            this.NomePesquisar.Size = new System.Drawing.Size(35, 13);
            this.NomePesquisar.TabIndex = 16;
            this.NomePesquisar.Text = "Nome";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.btnEditar.Location = new System.Drawing.Point(450, 225);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 30);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.btnInserir.Location = new System.Drawing.Point(540, 225);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(84, 30);
            this.btnInserir.TabIndex = 18;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.btnListar.Location = new System.Drawing.Point(630, 225);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(84, 30);
            this.btnListar.TabIndex = 19;
            this.btnListar.Text = "&Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Usuarios
            // 
            this.Usuarios.AutoSize = true;
            this.Usuarios.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Usuarios.Location = new System.Drawing.Point(12, 245);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(80, 20);
            this.Usuarios.TabIndex = 20;
            this.Usuarios.Text = "Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnID,
            this.clnNome,
            this.clnEmail,
            this.clnNivel,
            this.clnAtivo});
            this.dgvUsuarios.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 279);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(702, 131);
            this.dgvUsuarios.TabIndex = 21;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // clnID
            // 
            this.clnID.Frozen = true;
            this.clnID.HeaderText = "Id";
            this.clnID.Name = "clnID";
            this.clnID.ReadOnly = true;
            this.clnID.Width = 50;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 200;
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 300;
            // 
            // clnNivel
            // 
            this.clnNivel.Frozen = true;
            this.clnNivel.HeaderText = "Nivel";
            this.clnNivel.Name = "clnNivel";
            this.clnNivel.ReadOnly = true;
            // 
            // clnAtivo
            // 
            this.clnAtivo.Frozen = true;
            this.clnAtivo.HeaderText = "Ativo";
            this.clnAtivo.Name = "clnAtivo";
            this.clnAtivo.ReadOnly = true;
            this.clnAtivo.Width = 50;
            // 
            // Desbloquear
            // 
            this.Desbloquear.Location = new System.Drawing.Point(474, 32);
            this.Desbloquear.Name = "Desbloquear";
            this.Desbloquear.Size = new System.Drawing.Size(75, 23);
            this.Desbloquear.TabIndex = 22;
            this.Desbloquear.Text = "button1";
            this.Desbloquear.UseVisualStyleBackColor = true;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 417);
            this.Controls.Add(this.Desbloquear);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.Usuarios);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.NomePesquisar);
            this.Controls.Add(this.IdPesquisar);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.txtNomePesquisar);
            this.Controls.Add(this.txtIdPesquisar);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbnivel);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Cadastro);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cadastro;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label lbnivel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtIdPesquisar;
        private System.Windows.Forms.TextBox txtNomePesquisar;
        private System.Windows.Forms.Label Pesquisar;
        private System.Windows.Forms.Label IdPesquisar;
        private System.Windows.Forms.Label NomePesquisar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label Usuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNivel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnAtivo;
        private System.Windows.Forms.Button Desbloquear;
    }
}