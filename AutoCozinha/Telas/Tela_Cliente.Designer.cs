namespace AutoCozinha.Telas
{
    partial class TelaCliente
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
            this.pnl_esquerda = new System.Windows.Forms.Panel();
            this.lb_infoDesconto = new System.Windows.Forms.Label();
            this.lb_desconto = new System.Windows.Forms.Label();
            this.cheBox_fidelidade = new System.Windows.Forms.CheckBox();
            this.lb_infoStatus = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.cBox_cidade = new System.Windows.Forms.ComboBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.panel_esq_botoes = new System.Windows.Forms.Panel();
            this.btn_limpa = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.panel_esq_baixo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid_ultimosItens = new System.Windows.Forms.DataGridView();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_tituloDados = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGrid_clientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_topBusca = new System.Windows.Forms.Panel();
            this.txt_buscaClie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodo_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_esquerda.SuspendLayout();
            this.panel_esq_botoes.SuspendLayout();
            this.panel_esq_baixo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ultimosItens)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_clientes)).BeginInit();
            this.panel_topBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_esquerda
            // 
            this.pnl_esquerda.Controls.Add(this.lb_infoDesconto);
            this.pnl_esquerda.Controls.Add(this.lb_desconto);
            this.pnl_esquerda.Controls.Add(this.cheBox_fidelidade);
            this.pnl_esquerda.Controls.Add(this.lb_infoStatus);
            this.pnl_esquerda.Controls.Add(this.lb_status);
            this.pnl_esquerda.Controls.Add(this.cBox_cidade);
            this.pnl_esquerda.Controls.Add(this.txt_cpf);
            this.pnl_esquerda.Controls.Add(this.txt_email);
            this.pnl_esquerda.Controls.Add(this.txt_nome);
            this.pnl_esquerda.Controls.Add(this.panel_esq_botoes);
            this.pnl_esquerda.Controls.Add(this.panel_esq_baixo);
            this.pnl_esquerda.Controls.Add(this.lb_cidade);
            this.pnl_esquerda.Controls.Add(this.lb_cpf);
            this.pnl_esquerda.Controls.Add(this.lb_email);
            this.pnl_esquerda.Controls.Add(this.lb_nome);
            this.pnl_esquerda.Controls.Add(this.lb_tituloDados);
            this.pnl_esquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_esquerda.Location = new System.Drawing.Point(0, 0);
            this.pnl_esquerda.Name = "pnl_esquerda";
            this.pnl_esquerda.Size = new System.Drawing.Size(297, 415);
            this.pnl_esquerda.TabIndex = 0;
            // 
            // lb_infoDesconto
            // 
            this.lb_infoDesconto.AutoSize = true;
            this.lb_infoDesconto.Location = new System.Drawing.Point(229, 172);
            this.lb_infoDesconto.Name = "lb_infoDesconto";
            this.lb_infoDesconto.Size = new System.Drawing.Size(21, 13);
            this.lb_infoDesconto.TabIndex = 15;
            this.lb_infoDesconto.Text = "0%";
            // 
            // lb_desconto
            // 
            this.lb_desconto.AutoSize = true;
            this.lb_desconto.Location = new System.Drawing.Point(175, 172);
            this.lb_desconto.Name = "lb_desconto";
            this.lb_desconto.Size = new System.Drawing.Size(56, 13);
            this.lb_desconto.TabIndex = 14;
            this.lb_desconto.Text = "Desconto:";
            // 
            // cheBox_fidelidade
            // 
            this.cheBox_fidelidade.AutoSize = true;
            this.cheBox_fidelidade.Location = new System.Drawing.Point(178, 152);
            this.cheBox_fidelidade.Name = "cheBox_fidelidade";
            this.cheBox_fidelidade.Size = new System.Drawing.Size(74, 17);
            this.cheBox_fidelidade.TabIndex = 13;
            this.cheBox_fidelidade.Text = "Fidelidade";
            this.cheBox_fidelidade.UseVisualStyleBackColor = true;
            // 
            // lb_infoStatus
            // 
            this.lb_infoStatus.AutoSize = true;
            this.lb_infoStatus.Location = new System.Drawing.Point(67, 152);
            this.lb_infoStatus.Name = "lb_infoStatus";
            this.lb_infoStatus.Size = new System.Drawing.Size(58, 13);
            this.lb_infoStatus.TabIndex = 12;
            this.lb_infoStatus.Text = "Bloqueado";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(20, 152);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(40, 13);
            this.lb_status.TabIndex = 11;
            this.lb_status.Text = "Status:";
            // 
            // cBox_cidade
            // 
            this.cBox_cidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_cidade.FormattingEnabled = true;
            this.cBox_cidade.Location = new System.Drawing.Point(66, 119);
            this.cBox_cidade.Name = "cBox_cidade";
            this.cBox_cidade.Size = new System.Drawing.Size(225, 21);
            this.cBox_cidade.TabIndex = 10;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(66, 96);
            this.txt_cpf.Mask = "000.000.000-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(225, 20);
            this.txt_cpf.TabIndex = 9;
            this.txt_cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cpf_KeyPress);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(67, 66);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(224, 20);
            this.txt_email.TabIndex = 8;
            this.txt_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_email_KeyPress);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(66, 41);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(225, 20);
            this.txt_nome.TabIndex = 7;
            // 
            // panel_esq_botoes
            // 
            this.panel_esq_botoes.Controls.Add(this.btn_limpa);
            this.panel_esq_botoes.Controls.Add(this.btn_excluir);
            this.panel_esq_botoes.Controls.Add(this.btn_salvar);
            this.panel_esq_botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_esq_botoes.Location = new System.Drawing.Point(0, 208);
            this.panel_esq_botoes.Name = "panel_esq_botoes";
            this.panel_esq_botoes.Size = new System.Drawing.Size(297, 39);
            this.panel_esq_botoes.TabIndex = 6;
            // 
            // btn_limpa
            // 
            this.btn_limpa.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_limpa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_limpa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpa.Location = new System.Drawing.Point(93, 0);
            this.btn_limpa.Name = "btn_limpa";
            this.btn_limpa.Size = new System.Drawing.Size(105, 39);
            this.btn_limpa.TabIndex = 2;
            this.btn_limpa.Text = "LIMPAR";
            this.btn_limpa.UseVisualStyleBackColor = false;
            this.btn_limpa.Click += new System.EventHandler(this.btn_limpa_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Tomato;
            this.btn_excluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(0, 0);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(93, 39);
            this.btn_excluir.TabIndex = 1;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_salvar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salvar.Location = new System.Drawing.Point(198, 0);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(99, 39);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // panel_esq_baixo
            // 
            this.panel_esq_baixo.Controls.Add(this.label2);
            this.panel_esq_baixo.Controls.Add(this.dataGrid_ultimosItens);
            this.panel_esq_baixo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_esq_baixo.Location = new System.Drawing.Point(0, 247);
            this.panel_esq_baixo.Name = "panel_esq_baixo";
            this.panel_esq_baixo.Size = new System.Drawing.Size(297, 168);
            this.panel_esq_baixo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ultimos Pedidos";
            // 
            // dataGrid_ultimosItens
            // 
            this.dataGrid_ultimosItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid_ultimosItens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_ultimosItens.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid_ultimosItens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid_ultimosItens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGrid_ultimosItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ultimosItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.total,
            this.metodo_pagamento});
            this.dataGrid_ultimosItens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid_ultimosItens.Location = new System.Drawing.Point(0, 36);
            this.dataGrid_ultimosItens.MultiSelect = false;
            this.dataGrid_ultimosItens.Name = "dataGrid_ultimosItens";
            this.dataGrid_ultimosItens.ReadOnly = true;
            this.dataGrid_ultimosItens.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGrid_ultimosItens.Size = new System.Drawing.Size(297, 132);
            this.dataGrid_ultimosItens.TabIndex = 2;
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Location = new System.Drawing.Point(22, 119);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(43, 13);
            this.lb_cidade.TabIndex = 4;
            this.lb_cidade.Text = "Cidade:";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Location = new System.Drawing.Point(30, 96);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(30, 13);
            this.lb_cpf.TabIndex = 3;
            this.lb_cpf.Text = "CPF:";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(25, 66);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(35, 13);
            this.lb_email.TabIndex = 2;
            this.lb_email.Text = "Email:";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(22, 41);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(38, 13);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_tituloDados
            // 
            this.lb_tituloDados.AutoSize = true;
            this.lb_tituloDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tituloDados.Location = new System.Drawing.Point(91, 9);
            this.lb_tituloDados.Name = "lb_tituloDados";
            this.lb_tituloDados.Size = new System.Drawing.Size(144, 26);
            this.lb_tituloDados.TabIndex = 0;
            this.lb_tituloDados.Text = "Dados cliente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGrid_clientes);
            this.panel1.Controls.Add(this.panel_topBusca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(297, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 415);
            this.panel1.TabIndex = 1;
            // 
            // dataGrid_clientes
            // 
            this.dataGrid_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_clientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.email,
            this.cpf,
            this.cidade,
            this.status});
            this.dataGrid_clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGrid_clientes.Location = new System.Drawing.Point(0, 45);
            this.dataGrid_clientes.MultiSelect = false;
            this.dataGrid_clientes.Name = "dataGrid_clientes";
            this.dataGrid_clientes.ReadOnly = true;
            this.dataGrid_clientes.Size = new System.Drawing.Size(607, 367);
            this.dataGrid_clientes.TabIndex = 0;
            this.dataGrid_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_clientes_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 60;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            // 
            // panel_topBusca
            // 
            this.panel_topBusca.Controls.Add(this.txt_buscaClie);
            this.panel_topBusca.Controls.Add(this.label1);
            this.panel_topBusca.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topBusca.Location = new System.Drawing.Point(0, 0);
            this.panel_topBusca.Name = "panel_topBusca";
            this.panel_topBusca.Size = new System.Drawing.Size(607, 45);
            this.panel_topBusca.TabIndex = 1;
            // 
            // txt_buscaClie
            // 
            this.txt_buscaClie.Location = new System.Drawing.Point(48, 11);
            this.txt_buscaClie.Name = "txt_buscaClie";
            this.txt_buscaClie.Size = new System.Drawing.Size(273, 20);
            this.txt_buscaClie.TabIndex = 1;
            this.txt_buscaClie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscaClie_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // date
            // 
            this.date.DataPropertyName = "date_Date";
            this.date.HeaderText = "Data";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 55;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 56;
            // 
            // metodo_pagamento
            // 
            this.metodo_pagamento.DataPropertyName = "metodo_pagamento";
            this.metodo_pagamento.HeaderText = "Metodo Pagamento";
            this.metodo_pagamento.Name = "metodo_pagamento";
            this.metodo_pagamento.ReadOnly = true;
            this.metodo_pagamento.Width = 114;
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_esquerda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.pnl_esquerda.ResumeLayout(false);
            this.pnl_esquerda.PerformLayout();
            this.panel_esq_botoes.ResumeLayout(false);
            this.panel_esq_baixo.ResumeLayout(false);
            this.panel_esq_baixo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ultimosItens)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_clientes)).EndInit();
            this.panel_topBusca.ResumeLayout(false);
            this.panel_topBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_esquerda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_tituloDados;
        private System.Windows.Forms.Panel panel_esq_botoes;
        private System.Windows.Forms.Panel panel_esq_baixo;
        private System.Windows.Forms.Label lb_cidade;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.ComboBox cBox_cidade;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.DataGridView dataGrid_ultimosItens;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.DataGridView dataGrid_clientes;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Label lb_infoStatus;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button btn_limpa;
        private System.Windows.Forms.Panel panel_topBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscaClie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cheBox_fidelidade;
        private System.Windows.Forms.Label lb_infoDesconto;
        private System.Windows.Forms.Label lb_desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodo_pagamento;
    }
}