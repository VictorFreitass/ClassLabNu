namespace ComercialSys91
{
    partial class FrmCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.DatadeCadastro = new System.Windows.Forms.Label();
            this.dtpDataCad = new System.Windows.Forms.DateTimePicker();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clnIdCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Endereços = new System.Windows.Forms.Label();
            this.CEP = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.Logradouro = new System.Windows.Forms.Label();
            this.txtlogradouro = new System.Windows.Forms.TextBox();
            this.Número = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.Complemento = new System.Windows.Forms.Label();
            this.Bairro = new System.Windows.Forms.Label();
            this.Cidade = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.Label();
            this.UF = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.cmbuf = new System.Windows.Forms.ComboBox();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.Tipo = new System.Windows.Forms.Label();
            this.Telefones = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.DDD = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(70, 21);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(37, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(257, 21);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(190, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(70, 57);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 2;
            this.txtCpf.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(257, 57);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ID.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ID.Location = new System.Drawing.Point(46, 25);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 15);
            this.ID.TabIndex = 4;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nome.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Nome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nome.Location = new System.Drawing.Point(216, 24);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(40, 15);
            this.Nome.TabIndex = 5;
            this.Nome.Text = "Nome";
            this.Nome.Click += new System.EventHandler(this.Nome_Click);
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CPF.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.CPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CPF.Location = new System.Drawing.Point(37, 60);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(29, 15);
            this.CPF.TabIndex = 6;
            this.CPF.Text = "CPF";
            this.CPF.Click += new System.EventHandler(this.label3_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Email.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Email.Location = new System.Drawing.Point(216, 60);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(38, 15);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInserir.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInserir.Location = new System.Drawing.Point(32, 135);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.btnListar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnListar.Location = new System.Drawing.Point(271, 135);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "&Listar Todos";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.btnAlterar.Location = new System.Drawing.Point(137, 135);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnDesativar
            // 
            this.btnDesativar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesativar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.btnDesativar.Location = new System.Drawing.Point(372, 135);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(75, 23);
            this.btnDesativar.TabIndex = 12;
            this.btnDesativar.Text = "&Desativar";
            this.btnDesativar.UseVisualStyleBackColor = false;
            this.btnDesativar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Status.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Status.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Status.Location = new System.Drawing.Point(27, 93);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(43, 15);
            this.Status.TabIndex = 13;
            this.Status.Text = "Status";
            this.Status.Click += new System.EventHandler(this.label5_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkAtivo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.chkAtivo.Location = new System.Drawing.Point(70, 92);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(55, 19);
            this.chkAtivo.TabIndex = 14;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = false;
            this.chkAtivo.CheckedChanged += new System.EventHandler(this.chkAtivo_CheckedChanged);
            // 
            // DatadeCadastro
            // 
            this.DatadeCadastro.AutoSize = true;
            this.DatadeCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DatadeCadastro.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.DatadeCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DatadeCadastro.Location = new System.Drawing.Point(161, 93);
            this.DatadeCadastro.Name = "DatadeCadastro";
            this.DatadeCadastro.Size = new System.Drawing.Size(108, 15);
            this.DatadeCadastro.TabIndex = 15;
            this.DatadeCadastro.Text = "Data de Cadastro";
            this.DatadeCadastro.Click += new System.EventHandler(this.DatadeCadastro_Click);
            // 
            // dtpDataCad
            // 
            this.dtpDataCad.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.dtpDataCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCad.Location = new System.Drawing.Point(257, 89);
            this.dtpDataCad.Name = "dtpDataCad";
            this.dtpDataCad.Size = new System.Drawing.Size(89, 21);
            this.dtpDataCad.TabIndex = 16;
            this.dtpDataCad.ValueChanged += new System.EventHandler(this.dtpDataCad_ValueChanged);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdCli,
            this.clnNome,
            this.clnCpf,
            this.clnEmail,
            this.clnAtivo});
            this.dgvClientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvClientes.Location = new System.Drawing.Point(23, 175);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(436, 131);
            this.dgvClientes.TabIndex = 17;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // clnIdCli
            // 
            this.clnIdCli.Frozen = true;
            this.clnIdCli.HeaderText = "Id";
            this.clnIdCli.Name = "clnIdCli";
            this.clnIdCli.ReadOnly = true;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            // 
            // clnCpf
            // 
            this.clnCpf.Frozen = true;
            this.clnCpf.HeaderText = "CPF";
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            // 
            // clnAtivo
            // 
            this.clnAtivo.Frozen = true;
            this.clnAtivo.HeaderText = "Ativo";
            this.clnAtivo.Name = "clnAtivo";
            this.clnAtivo.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(114, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(39, 20);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(476, 561);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 40);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Endereços
            // 
            this.Endereços.AutoSize = true;
            this.Endereços.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Endereços.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Endereços.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Endereços.Location = new System.Drawing.Point(20, 321);
            this.Endereços.Name = "Endereços";
            this.Endereços.Size = new System.Drawing.Size(66, 15);
            this.Endereços.TabIndex = 20;
            this.Endereços.Text = "Endereços";
            this.Endereços.Click += new System.EventHandler(this.label1_Click);
            // 
            // CEP
            // 
            this.CEP.AutoSize = true;
            this.CEP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CEP.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.CEP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CEP.Location = new System.Drawing.Point(17, 344);
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(30, 15);
            this.CEP.TabIndex = 21;
            this.CEP.Text = "CEP";
            this.CEP.Click += new System.EventHandler(this.CEP_Click);
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(20, 360);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(71, 20);
            this.txtcep.TabIndex = 22;
            this.txtcep.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.txtcep.Leave += new System.EventHandler(this.cep_Leave);
            // 
            // Logradouro
            // 
            this.Logradouro.AutoSize = true;
            this.Logradouro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Logradouro.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Logradouro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Logradouro.Location = new System.Drawing.Point(102, 344);
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Size = new System.Drawing.Size(72, 15);
            this.Logradouro.TabIndex = 23;
            this.Logradouro.Text = "Logradouro";
            this.Logradouro.Click += new System.EventHandler(this.Logradouro_Click);
            // 
            // txtlogradouro
            // 
            this.txtlogradouro.Location = new System.Drawing.Point(97, 360);
            this.txtlogradouro.Name = "txtlogradouro";
            this.txtlogradouro.Size = new System.Drawing.Size(342, 20);
            this.txtlogradouro.TabIndex = 24;
            this.txtlogradouro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Número
            // 
            this.Número.AutoSize = true;
            this.Número.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Número.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Número.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Número.Location = new System.Drawing.Point(452, 344);
            this.Número.Name = "Número";
            this.Número.Size = new System.Drawing.Size(52, 15);
            this.Número.TabIndex = 25;
            this.Número.Text = "Número";
            this.Número.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(445, 360);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(81, 20);
            this.txtnumero.TabIndex = 26;
            this.txtnumero.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // Complemento
            // 
            this.Complemento.AutoSize = true;
            this.Complemento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Complemento.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Complemento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Complemento.Location = new System.Drawing.Point(20, 387);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(87, 15);
            this.Complemento.TabIndex = 27;
            this.Complemento.Text = "Complemento";
            this.Complemento.Click += new System.EventHandler(this.Complemento_Click);
            // 
            // Bairro
            // 
            this.Bairro.AutoSize = true;
            this.Bairro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bairro.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Bairro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Bairro.Location = new System.Drawing.Point(184, 388);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(42, 15);
            this.Bairro.TabIndex = 28;
            this.Bairro.Text = "Bairro";
            this.Bairro.Click += new System.EventHandler(this.Bairro_Click);
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cidade.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Cidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cidade.Location = new System.Drawing.Point(375, 387);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(47, 15);
            this.Cidade.TabIndex = 29;
            this.Cidade.Text = "Cidade";
            this.Cidade.Click += new System.EventHandler(this.Cidade_Click);
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(20, 404);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(153, 20);
            this.txtcomplemento.TabIndex = 30;
            this.txtcomplemento.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(179, 404);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(187, 20);
            this.txtbairro.TabIndex = 31;
            this.txtbairro.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(372, 404);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(154, 20);
            this.txtcidade.TabIndex = 32;
            this.txtcidade.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Estado.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Estado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Estado.Location = new System.Drawing.Point(20, 431);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(45, 15);
            this.Estado.TabIndex = 33;
            this.Estado.Text = "Estado";
            this.Estado.Click += new System.EventHandler(this.Estado_Click);
            // 
            // UF
            // 
            this.UF.AutoSize = true;
            this.UF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UF.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.UF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UF.Location = new System.Drawing.Point(184, 430);
            this.UF.Name = "UF";
            this.UF.Size = new System.Drawing.Size(21, 15);
            this.UF.TabIndex = 34;
            this.UF.Text = "UF";
            this.UF.Click += new System.EventHandler(this.UF_Click);
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(20, 447);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(153, 20);
            this.txtestado.TabIndex = 35;
            this.txtestado.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // cmbuf
            // 
            this.cmbuf.FormattingEnabled = true;
            this.cmbuf.Location = new System.Drawing.Point(179, 446);
            this.cmbuf.Name = "cmbuf";
            this.cmbuf.Size = new System.Drawing.Size(48, 21);
            this.cmbuf.TabIndex = 36;
            this.cmbuf.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbtipo
            // 
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Location = new System.Drawing.Point(411, 446);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(115, 21);
            this.cmbtipo.TabIndex = 37;
            this.cmbtipo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tipo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Tipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tipo.Location = new System.Drawing.Point(416, 430);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(31, 15);
            this.Tipo.TabIndex = 38;
            this.Tipo.Text = "Tipo";
            this.Tipo.Click += new System.EventHandler(this.Tipo_Click);
            // 
            // Telefones
            // 
            this.Telefones.AutoSize = true;
            this.Telefones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Telefones.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Telefones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Telefones.Location = new System.Drawing.Point(20, 497);
            this.Telefones.Name = "Telefones";
            this.Telefones.Size = new System.Drawing.Size(62, 15);
            this.Telefones.TabIndex = 39;
            this.Telefones.Text = "Telefones";
            this.Telefones.Click += new System.EventHandler(this.Telefones_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(20, 540);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(54, 20);
            this.textBox8.TabIndex = 40;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // DDD
            // 
            this.DDD.AutoSize = true;
            this.DDD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DDD.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.DDD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DDD.Location = new System.Drawing.Point(20, 524);
            this.DDD.Name = "DDD";
            this.DDD.Size = new System.Drawing.Size(34, 15);
            this.DDD.TabIndex = 41;
            this.DDD.Text = "DDD";
            this.DDD.Click += new System.EventHandler(this.DDD_Click);
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Telefone.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Telefone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Telefone.Location = new System.Drawing.Point(82, 524);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(56, 15);
            this.Telefone.TabIndex = 42;
            this.Telefone.Text = "Telefone";
            this.Telefone.Click += new System.EventHandler(this.Telefone_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(85, 540);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 43;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(193, 539);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 44;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(193, 580);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 49;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(85, 581);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 48;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(82, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Telefone";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(20, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "DDD";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(20, 581);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(54, 20);
            this.textBox11.TabIndex = 45;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "çgçr",
            "gg",
            "[~",
            "rg",
            "[~[",
            "rg~",
            "[r",
            "gr",
            "g.rçglçprçpçp]",
            "r",
            "ç´[gr[~",
            "gr~",
            "[~",
            "["});
            this.metroComboBox1.Location = new System.Drawing.Point(465, 175);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 50;
            this.metroComboBox1.UseSelectable = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(620, 650);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.DDD);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.Telefones);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.cmbtipo);
            this.Controls.Add(this.cmbuf);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.UF);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.txtcomplemento);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.Bairro);
            this.Controls.Add(this.Complemento);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.Número);
            this.Controls.Add(this.txtlogradouro);
            this.Controls.Add(this.Logradouro);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.CEP);
            this.Controls.Add(this.Endereços);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.dtpDataCad);
            this.Controls.Add(this.DatadeCadastro);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label DatadeCadastro;
        private System.Windows.Forms.DateTimePicker dtpDataCad;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnAtivo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Endereços;
        private System.Windows.Forms.Label CEP;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.Label Logradouro;
        private System.Windows.Forms.TextBox txtlogradouro;
        private System.Windows.Forms.Label Número;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label Complemento;
        private System.Windows.Forms.Label Bairro;
        private System.Windows.Forms.Label Cidade;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Label UF;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.ComboBox cmbuf;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Label Telefones;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label DDD;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox11;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}

