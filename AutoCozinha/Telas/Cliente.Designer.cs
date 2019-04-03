﻿namespace AutoCozinha.Telas
{
    partial class Cliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_tituloDados = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.panel_esq_baixo = new System.Windows.Forms.Panel();
            this.panel_esq_botoes = new System.Windows.Forms.Panel();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cBox_cidade = new System.Windows.Forms.ComboBox();
            this.cBox_filtro = new System.Windows.Forms.ComboBox();
            this.lb_filtro = new System.Windows.Forms.Label();
            this.dataGrid_ultimosItens = new System.Windows.Forms.DataGridView();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.dataGrid_clientes = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_infoStatus = new System.Windows.Forms.Label();
            this.btn_limpa = new System.Windows.Forms.Button();
            this.pnl_esquerda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_esq_baixo.SuspendLayout();
            this.panel_esq_botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ultimosItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_esquerda
            // 
            this.pnl_esquerda.Controls.Add(this.lb_infoStatus);
            this.pnl_esquerda.Controls.Add(this.lb_status);
            this.pnl_esquerda.Controls.Add(this.cBox_cidade);
            this.pnl_esquerda.Controls.Add(this.maskedTextBox1);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGrid_clientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(297, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 415);
            this.panel1.TabIndex = 1;
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
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(22, 41);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(38, 13);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome:";
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
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Location = new System.Drawing.Point(30, 96);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(30, 13);
            this.lb_cpf.TabIndex = 3;
            this.lb_cpf.Text = "CPF:";
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
            // panel_esq_baixo
            // 
            this.panel_esq_baixo.Controls.Add(this.dataGrid_ultimosItens);
            this.panel_esq_baixo.Controls.Add(this.lb_filtro);
            this.panel_esq_baixo.Controls.Add(this.cBox_filtro);
            this.panel_esq_baixo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_esq_baixo.Location = new System.Drawing.Point(0, 247);
            this.panel_esq_baixo.Name = "panel_esq_baixo";
            this.panel_esq_baixo.Size = new System.Drawing.Size(297, 168);
            this.panel_esq_baixo.TabIndex = 5;
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
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(66, 41);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(225, 20);
            this.txt_nome.TabIndex = 7;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(67, 66);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(224, 20);
            this.txt_email.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(66, 96);
            this.maskedTextBox1.Mask = "000.000.000-0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(225, 20);
            this.maskedTextBox1.TabIndex = 9;
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
            // cBox_filtro
            // 
            this.cBox_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_filtro.FormattingEnabled = true;
            this.cBox_filtro.Location = new System.Drawing.Point(112, 6);
            this.cBox_filtro.Name = "cBox_filtro";
            this.cBox_filtro.Size = new System.Drawing.Size(179, 21);
            this.cBox_filtro.TabIndex = 0;
            // 
            // lb_filtro
            // 
            this.lb_filtro.AutoSize = true;
            this.lb_filtro.Location = new System.Drawing.Point(71, 9);
            this.lb_filtro.Name = "lb_filtro";
            this.lb_filtro.Size = new System.Drawing.Size(35, 13);
            this.lb_filtro.TabIndex = 1;
            this.lb_filtro.Text = "Exibir:";
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
            this.item,
            this.quantidade,
            this.data_pagamento});
            this.dataGrid_ultimosItens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid_ultimosItens.Location = new System.Drawing.Point(0, 33);
            this.dataGrid_ultimosItens.MultiSelect = false;
            this.dataGrid_ultimosItens.Name = "dataGrid_ultimosItens";
            this.dataGrid_ultimosItens.ReadOnly = true;
            this.dataGrid_ultimosItens.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGrid_ultimosItens.Size = new System.Drawing.Size(297, 135);
            this.dataGrid_ultimosItens.TabIndex = 2;
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
            // 
            // dataGrid_clientes
            // 
            this.dataGrid_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_clientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.email,
            this.cpf,
            this.cidade,
            this.btn_editar});
            this.dataGrid_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_clientes.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_clientes.Name = "dataGrid_clientes";
            this.dataGrid_clientes.Size = new System.Drawing.Size(607, 415);
            this.dataGrid_clientes.TabIndex = 0;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 60;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            // 
            // btn_editar
            // 
            this.btn_editar.HeaderText = "Editar";
            this.btn_editar.Name = "btn_editar";
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
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 52;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 87;
            // 
            // data_pagamento
            // 
            this.data_pagamento.HeaderText = "Data pagamento";
            this.data_pagamento.Name = "data_pagamento";
            this.data_pagamento.ReadOnly = true;
            this.data_pagamento.Width = 102;
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
            // lb_infoStatus
            // 
            this.lb_infoStatus.AutoSize = true;
            this.lb_infoStatus.Location = new System.Drawing.Point(67, 152);
            this.lb_infoStatus.Name = "lb_infoStatus";
            this.lb_infoStatus.Size = new System.Drawing.Size(58, 13);
            this.lb_infoStatus.TabIndex = 12;
            this.lb_infoStatus.Text = "Bloqueado";
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
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_esquerda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente";
            this.ShowIcon = false;
            this.Text = "Clientes";
            this.TopMost = true;
            this.pnl_esquerda.ResumeLayout(false);
            this.pnl_esquerda.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel_esq_baixo.ResumeLayout(false);
            this.panel_esq_baixo.PerformLayout();
            this.panel_esq_botoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ultimosItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_clientes)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lb_filtro;
        private System.Windows.Forms.ComboBox cBox_filtro;
        private System.Windows.Forms.DataGridView dataGrid_ultimosItens;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.DataGridView dataGrid_clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewButtonColumn btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_pagamento;
        private System.Windows.Forms.Label lb_infoStatus;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button btn_limpa;
    }
}