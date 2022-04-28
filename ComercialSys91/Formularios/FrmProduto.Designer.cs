namespace ComercialSys91
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.btnInserir = new System.Windows.Forms.Button();
            this.Codbar = new System.Windows.Forms.Label();
            this.Unidade = new System.Windows.Forms.Label();
            this.Descricao = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.txtCodbar = new System.Windows.Forms.TextBox();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lstProduto = new System.Windows.Forms.ListBox();
            this.Valor = new System.Windows.Forms.Label();
            this.Desconto = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInserir.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnInserir.Location = new System.Drawing.Point(119, 197);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 17;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // Codbar
            // 
            this.Codbar.AutoSize = true;
            this.Codbar.Location = new System.Drawing.Point(46, 107);
            this.Codbar.Name = "Codbar";
            this.Codbar.Size = new System.Drawing.Size(41, 13);
            this.Codbar.TabIndex = 16;
            this.Codbar.Text = "Codbar";
            this.Codbar.Click += new System.EventHandler(this.label5_Click);
            // 
            // Unidade
            // 
            this.Unidade.AutoSize = true;
            this.Unidade.Location = new System.Drawing.Point(46, 84);
            this.Unidade.Name = "Unidade";
            this.Unidade.Size = new System.Drawing.Size(47, 13);
            this.Unidade.TabIndex = 15;
            this.Unidade.Text = "Unidade";
            // 
            // Descricao
            // 
            this.Descricao.AutoSize = true;
            this.Descricao.Location = new System.Drawing.Point(46, 58);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(55, 13);
            this.Descricao.TabIndex = 14;
            this.Descricao.Text = "Descrição";
            this.Descricao.Click += new System.EventHandler(this.label7_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(46, 36);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 13;
            this.ID.Text = "ID";
            // 
            // txtCodbar
            // 
            this.txtCodbar.Location = new System.Drawing.Point(107, 107);
            this.txtCodbar.MaxLength = 60;
            this.txtCodbar.Name = "txtCodbar";
            this.txtCodbar.Size = new System.Drawing.Size(190, 20);
            this.txtCodbar.TabIndex = 12;
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(107, 81);
            this.txtUnidade.MaxLength = 11;
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(100, 20);
            this.txtUnidade.TabIndex = 11;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(107, 55);
            this.txtDescricao.MaxLength = 60;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(190, 20);
            this.txtDescricao.TabIndex = 10;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(107, 29);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(37, 20);
            this.txtId.TabIndex = 9;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.Window;
            this.btnListar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnListar.Location = new System.Drawing.Point(418, 197);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 19;
            this.btnListar.Text = "&Listar Todos";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lstProduto
            // 
            this.lstProduto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstProduto.FormattingEnabled = true;
            this.lstProduto.Location = new System.Drawing.Point(356, 29);
            this.lstProduto.Name = "lstProduto";
            this.lstProduto.Size = new System.Drawing.Size(190, 147);
            this.lstProduto.TabIndex = 18;
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Location = new System.Drawing.Point(46, 134);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(31, 13);
            this.Valor.TabIndex = 20;
            this.Valor.Text = "Valor";
            // 
            // Desconto
            // 
            this.Desconto.AutoSize = true;
            this.Desconto.Location = new System.Drawing.Point(46, 160);
            this.Desconto.Name = "Desconto";
            this.Desconto.Size = new System.Drawing.Size(53, 13);
            this.Desconto.TabIndex = 21;
            this.Desconto.Text = "Desconto";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(107, 134);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 22;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(107, 157);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtDesconto.TabIndex = 23;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.Desconto);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lstProduto);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.Codbar);
            this.Controls.Add(this.Unidade);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtCodbar);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label Codbar;
        private System.Windows.Forms.Label Unidade;
        private System.Windows.Forms.Label Descricao;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtCodbar;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lstProduto;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.Label Desconto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDesconto;
    }
}