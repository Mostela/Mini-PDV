namespace AutoCozinha.Telas
{
    partial class Produto
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
            this.panel_esquerda = new System.Windows.Forms.Panel();
            this.tx_valor = new System.Windows.Forms.NumericUpDown();
            this.lb_valor = new System.Windows.Forms.Label();
            this.date_validade = new System.Windows.Forms.DateTimePicker();
            this.text_quantidade = new System.Windows.Forms.NumericUpDown();
            this.text_lote = new System.Windows.Forms.TextBox();
            this.text_codigo = new System.Windows.Forms.TextBox();
            this.text_descricao = new System.Windows.Forms.RichTextBox();
            this.tx_nomeProduto = new System.Windows.Forms.TextBox();
            this.panel_btns_esquerda = new System.Windows.Forms.Panel();
            this.btn_limpa = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.lb_validade = new System.Windows.Forms.Label();
            this.lb_lote = new System.Windows.Forms.Label();
            this.lb_quantidade = new System.Windows.Forms.Label();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.lb_descricao = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.cheBox_emFalta = new System.Windows.Forms.CheckBox();
            this.tx_busca = new System.Windows.Forms.TextBox();
            this.cBox_busca = new System.Windows.Forms.ComboBox();
            this.dataGrid_produtos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_instrucao = new System.Windows.Forms.Label();
            this.panel_esquerda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tx_valor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_quantidade)).BeginInit();
            this.panel_btns_esquerda.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_esquerda
            // 
            this.panel_esquerda.Controls.Add(this.tx_valor);
            this.panel_esquerda.Controls.Add(this.lb_valor);
            this.panel_esquerda.Controls.Add(this.date_validade);
            this.panel_esquerda.Controls.Add(this.text_quantidade);
            this.panel_esquerda.Controls.Add(this.text_lote);
            this.panel_esquerda.Controls.Add(this.text_codigo);
            this.panel_esquerda.Controls.Add(this.text_descricao);
            this.panel_esquerda.Controls.Add(this.tx_nomeProduto);
            this.panel_esquerda.Controls.Add(this.panel_btns_esquerda);
            this.panel_esquerda.Controls.Add(this.lb_validade);
            this.panel_esquerda.Controls.Add(this.lb_lote);
            this.panel_esquerda.Controls.Add(this.lb_quantidade);
            this.panel_esquerda.Controls.Add(this.lb_codigo);
            this.panel_esquerda.Controls.Add(this.lb_descricao);
            this.panel_esquerda.Controls.Add(this.lb_nome);
            this.panel_esquerda.Controls.Add(this.lb_titulo);
            this.panel_esquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_esquerda.Location = new System.Drawing.Point(0, 0);
            this.panel_esquerda.Name = "panel_esquerda";
            this.panel_esquerda.Size = new System.Drawing.Size(200, 493);
            this.panel_esquerda.TabIndex = 0;
            // 
            // tx_valor
            // 
            this.tx_valor.Location = new System.Drawing.Point(64, 71);
            this.tx_valor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tx_valor.Name = "tx_valor";
            this.tx_valor.Size = new System.Drawing.Size(120, 20);
            this.tx_valor.TabIndex = 15;
            this.tx_valor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Location = new System.Drawing.Point(12, 74);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(51, 13);
            this.lb_valor.TabIndex = 14;
            this.lb_valor.Text = "Valor: R$";
            // 
            // date_validade
            // 
            this.date_validade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_validade.Location = new System.Drawing.Point(77, 300);
            this.date_validade.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.date_validade.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.date_validade.Name = "date_validade";
            this.date_validade.Size = new System.Drawing.Size(100, 20);
            this.date_validade.TabIndex = 13;
            // 
            // text_quantidade
            // 
            this.text_quantidade.Location = new System.Drawing.Point(77, 215);
            this.text_quantidade.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.text_quantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.text_quantidade.Name = "text_quantidade";
            this.text_quantidade.Size = new System.Drawing.Size(120, 20);
            this.text_quantidade.TabIndex = 12;
            this.text_quantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // text_lote
            // 
            this.text_lote.Location = new System.Drawing.Point(77, 260);
            this.text_lote.Name = "text_lote";
            this.text_lote.Size = new System.Drawing.Size(107, 20);
            this.text_lote.TabIndex = 11;
            // 
            // text_codigo
            // 
            this.text_codigo.Location = new System.Drawing.Point(12, 170);
            this.text_codigo.Name = "text_codigo";
            this.text_codigo.Size = new System.Drawing.Size(184, 20);
            this.text_codigo.TabIndex = 10;
            // 
            // text_descricao
            // 
            this.text_descricao.Location = new System.Drawing.Point(3, 110);
            this.text_descricao.Name = "text_descricao";
            this.text_descricao.Size = new System.Drawing.Size(194, 37);
            this.text_descricao.TabIndex = 9;
            this.text_descricao.Text = "";
            // 
            // tx_nomeProduto
            // 
            this.tx_nomeProduto.Location = new System.Drawing.Point(56, 39);
            this.tx_nomeProduto.Name = "tx_nomeProduto";
            this.tx_nomeProduto.Size = new System.Drawing.Size(141, 20);
            this.tx_nomeProduto.TabIndex = 8;
            // 
            // panel_btns_esquerda
            // 
            this.panel_btns_esquerda.Controls.Add(this.btn_limpa);
            this.panel_btns_esquerda.Controls.Add(this.btn_excluir);
            this.panel_btns_esquerda.Controls.Add(this.btn_salvar);
            this.panel_btns_esquerda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_btns_esquerda.Location = new System.Drawing.Point(0, 362);
            this.panel_btns_esquerda.Name = "panel_btns_esquerda";
            this.panel_btns_esquerda.Size = new System.Drawing.Size(200, 131);
            this.panel_btns_esquerda.TabIndex = 7;
            // 
            // btn_limpa
            // 
            this.btn_limpa.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_limpa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_limpa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpa.Location = new System.Drawing.Point(0, 78);
            this.btn_limpa.Name = "btn_limpa";
            this.btn_limpa.Size = new System.Drawing.Size(200, 39);
            this.btn_limpa.TabIndex = 5;
            this.btn_limpa.Text = "LIMPAR";
            this.btn_limpa.UseVisualStyleBackColor = false;
            this.btn_limpa.Click += new System.EventHandler(this.btn_limpa_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Tomato;
            this.btn_excluir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(0, 39);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(200, 39);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_salvar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salvar.Location = new System.Drawing.Point(0, 0);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(200, 39);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // lb_validade
            // 
            this.lb_validade.AutoSize = true;
            this.lb_validade.Location = new System.Drawing.Point(24, 300);
            this.lb_validade.Name = "lb_validade";
            this.lb_validade.Size = new System.Drawing.Size(51, 13);
            this.lb_validade.TabIndex = 6;
            this.lb_validade.Text = "Validade:";
            // 
            // lb_lote
            // 
            this.lb_lote.AutoSize = true;
            this.lb_lote.Location = new System.Drawing.Point(39, 260);
            this.lb_lote.Name = "lb_lote";
            this.lb_lote.Size = new System.Drawing.Size(31, 13);
            this.lb_lote.TabIndex = 5;
            this.lb_lote.Text = "Lote:";
            // 
            // lb_quantidade
            // 
            this.lb_quantidade.AutoSize = true;
            this.lb_quantidade.Location = new System.Drawing.Point(16, 215);
            this.lb_quantidade.Name = "lb_quantidade";
            this.lb_quantidade.Size = new System.Drawing.Size(59, 13);
            this.lb_quantidade.TabIndex = 4;
            this.lb_quantidade.Text = "Quantiade:";
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Location = new System.Drawing.Point(91, 154);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(40, 13);
            this.lb_codigo.TabIndex = 3;
            this.lb_codigo.Text = "Codigo";
            // 
            // lb_descricao
            // 
            this.lb_descricao.AutoSize = true;
            this.lb_descricao.Location = new System.Drawing.Point(76, 94);
            this.lb_descricao.Name = "lb_descricao";
            this.lb_descricao.Size = new System.Drawing.Size(55, 13);
            this.lb_descricao.TabIndex = 2;
            this.lb_descricao.Text = "Descricao";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(12, 42);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(38, 13);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(21, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(163, 20);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "DADOS PRODUTO";
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.lb_instrucao);
            this.panel_top.Controls.Add(this.cheBox_emFalta);
            this.panel_top.Controls.Add(this.tx_busca);
            this.panel_top.Controls.Add(this.cBox_busca);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(200, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(725, 55);
            this.panel_top.TabIndex = 1;
            // 
            // cheBox_emFalta
            // 
            this.cheBox_emFalta.AutoSize = true;
            this.cheBox_emFalta.Location = new System.Drawing.Point(430, 17);
            this.cheBox_emFalta.Name = "cheBox_emFalta";
            this.cheBox_emFalta.Size = new System.Drawing.Size(64, 17);
            this.cheBox_emFalta.TabIndex = 3;
            this.cheBox_emFalta.Text = "Em falta";
            this.cheBox_emFalta.UseVisualStyleBackColor = true;
            this.cheBox_emFalta.CheckedChanged += new System.EventHandler(this.cheBox_emFalta_CheckedChanged);
            // 
            // tx_busca
            // 
            this.tx_busca.Location = new System.Drawing.Point(119, 14);
            this.tx_busca.Name = "tx_busca";
            this.tx_busca.Size = new System.Drawing.Size(305, 20);
            this.tx_busca.TabIndex = 1;
            this.tx_busca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tx_busca_KeyUp);
            // 
            // cBox_busca
            // 
            this.cBox_busca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_busca.FormattingEnabled = true;
            this.cBox_busca.Location = new System.Drawing.Point(7, 13);
            this.cBox_busca.Name = "cBox_busca";
            this.cBox_busca.Size = new System.Drawing.Size(106, 21);
            this.cBox_busca.TabIndex = 0;
            // 
            // dataGrid_produtos
            // 
            this.dataGrid_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_produtos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_produtos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NumLote,
            this.descricao,
            this.codigo,
            this.nomeReferencia,
            this.preco,
            this.quantidade,
            this.validade});
            this.dataGrid_produtos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_produtos.Location = new System.Drawing.Point(200, 55);
            this.dataGrid_produtos.Name = "dataGrid_produtos";
            this.dataGrid_produtos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid_produtos.Size = new System.Drawing.Size(725, 438);
            this.dataGrid_produtos.TabIndex = 2;
            this.dataGrid_produtos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_produtos_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NumLote
            // 
            this.NumLote.DataPropertyName = "NumLote";
            this.NumLote.HeaderText = "numLote";
            this.NumLote.Name = "NumLote";
            this.NumLote.Visible = false;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "descricao";
            this.descricao.Name = "descricao";
            this.descricao.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nomeReferencia
            // 
            this.nomeReferencia.DataPropertyName = "nomeReferencia";
            this.nomeReferencia.HeaderText = "Nome";
            this.nomeReferencia.Name = "nomeReferencia";
            this.nomeReferencia.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "preco";
            this.preco.HeaderText = "Valor";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // validade
            // 
            this.validade.DataPropertyName = "validade";
            this.validade.HeaderText = "Validade";
            this.validade.Name = "validade";
            this.validade.ReadOnly = true;
            // 
            // lb_instrucao
            // 
            this.lb_instrucao.AutoSize = true;
            this.lb_instrucao.Location = new System.Drawing.Point(487, 17);
            this.lb_instrucao.Name = "lb_instrucao";
            this.lb_instrucao.Size = new System.Drawing.Size(235, 26);
            this.lb_instrucao.TabIndex = 4;
            this.lb_instrucao.Text = "Escreva o codigo ou nome do produto\r\nClique em um item para selecionar para a edi" +
    "ção";
            this.lb_instrucao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 493);
            this.Controls.Add(this.dataGrid_produtos);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_esquerda);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Produto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produto_Load);
            this.panel_esquerda.ResumeLayout(false);
            this.panel_esquerda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tx_valor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_quantidade)).EndInit();
            this.panel_btns_esquerda.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_produtos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_esquerda;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.Label lb_descricao;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_validade;
        private System.Windows.Forms.Label lb_lote;
        private System.Windows.Forms.Label lb_quantidade;
        private System.Windows.Forms.Panel panel_btns_esquerda;
        private System.Windows.Forms.Button btn_limpa;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox tx_nomeProduto;
        private System.Windows.Forms.DateTimePicker date_validade;
        private System.Windows.Forms.NumericUpDown text_quantidade;
        private System.Windows.Forms.TextBox text_lote;
        private System.Windows.Forms.TextBox text_codigo;
        private System.Windows.Forms.RichTextBox text_descricao;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.ComboBox cBox_busca;
        private System.Windows.Forms.TextBox tx_busca;
        private System.Windows.Forms.CheckBox cheBox_emFalta;
        private System.Windows.Forms.DataGridView dataGrid_produtos;
        private System.Windows.Forms.NumericUpDown tx_valor;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Label lb_instrucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn validade;
    }
}