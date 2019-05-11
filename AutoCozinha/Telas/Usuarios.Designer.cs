namespace AutoCozinha.Telas
{
    partial class Usuarios
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
            this.panel_direito = new System.Windows.Forms.Panel();
            this.tx_senha = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_usuariosSistema = new System.Windows.Forms.Label();
            this.lb_nivel = new System.Windows.Forms.Label();
            this.cBox_nivel = new System.Windows.Forms.ComboBox();
            this.btn_desabilitar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.lb_senha = new System.Windows.Forms.Label();
            this.lb_userEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_NomeuserAtual = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_direito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_direito
            // 
            this.panel_direito.Controls.Add(this.tx_senha);
            this.panel_direito.Controls.Add(this.tx_email);
            this.panel_direito.Controls.Add(this.tx_nome);
            this.panel_direito.Controls.Add(this.dataGridView1);
            this.panel_direito.Controls.Add(this.lb_usuariosSistema);
            this.panel_direito.Controls.Add(this.lb_nivel);
            this.panel_direito.Controls.Add(this.cBox_nivel);
            this.panel_direito.Controls.Add(this.btn_desabilitar);
            this.panel_direito.Controls.Add(this.btn_novo);
            this.panel_direito.Controls.Add(this.btn_salvar);
            this.panel_direito.Controls.Add(this.lb_senha);
            this.panel_direito.Controls.Add(this.lb_userEmail);
            this.panel_direito.Controls.Add(this.label1);
            this.panel_direito.Controls.Add(this.lb_NomeuserAtual);
            this.panel_direito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_direito.Location = new System.Drawing.Point(0, 0);
            this.panel_direito.Name = "panel_direito";
            this.panel_direito.Size = new System.Drawing.Size(216, 409);
            this.panel_direito.TabIndex = 0;
            // 
            // tx_senha
            // 
            this.tx_senha.Location = new System.Drawing.Point(48, 98);
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.PasswordChar = '*';
            this.tx_senha.Size = new System.Drawing.Size(157, 20);
            this.tx_senha.TabIndex = 13;
            this.tx_senha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tx_senha_KeyUp);
            // 
            // tx_email
            // 
            this.tx_email.Location = new System.Drawing.Point(48, 72);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(157, 20);
            this.tx_email.TabIndex = 12;
            this.tx_email.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tx_email_KeyUp);
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(48, 46);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(157, 20);
            this.tx_nome.TabIndex = 11;
            this.tx_nome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tx_nome_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.email,
            this.id,
            this.nivel});
            this.dataGridView1.Location = new System.Drawing.Point(10, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(195, 167);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lb_usuariosSistema
            // 
            this.lb_usuariosSistema.AutoSize = true;
            this.lb_usuariosSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuariosSistema.Location = new System.Drawing.Point(48, 205);
            this.lb_usuariosSistema.Name = "lb_usuariosSistema";
            this.lb_usuariosSistema.Size = new System.Drawing.Size(142, 17);
            this.lb_usuariosSistema.TabIndex = 9;
            this.lb_usuariosSistema.Text = "USUARIOS SISTEMA";
            // 
            // lb_nivel
            // 
            this.lb_nivel.AutoSize = true;
            this.lb_nivel.Location = new System.Drawing.Point(14, 125);
            this.lb_nivel.Name = "lb_nivel";
            this.lb_nivel.Size = new System.Drawing.Size(34, 13);
            this.lb_nivel.TabIndex = 8;
            this.lb_nivel.Text = "Nivel:";
            // 
            // cBox_nivel
            // 
            this.cBox_nivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_nivel.FormattingEnabled = true;
            this.cBox_nivel.Location = new System.Drawing.Point(51, 122);
            this.cBox_nivel.Name = "cBox_nivel";
            this.cBox_nivel.Size = new System.Drawing.Size(121, 21);
            this.cBox_nivel.TabIndex = 7;
            // 
            // btn_desabilitar
            // 
            this.btn_desabilitar.Location = new System.Drawing.Point(87, 149);
            this.btn_desabilitar.Name = "btn_desabilitar";
            this.btn_desabilitar.Size = new System.Drawing.Size(63, 23);
            this.btn_desabilitar.TabIndex = 6;
            this.btn_desabilitar.Text = "Desativar";
            this.btn_desabilitar.UseVisualStyleBackColor = true;
            this.btn_desabilitar.Click += new System.EventHandler(this.btn_desabilitar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(156, 149);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(44, 23);
            this.btn_novo.TabIndex = 1;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(25, 149);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(56, 23);
            this.btn_salvar.TabIndex = 5;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.Btn_alterar_Click);
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(7, 98);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(41, 13);
            this.lb_senha.TabIndex = 4;
            this.lb_senha.Text = "Senha:";
            // 
            // lb_userEmail
            // 
            this.lb_userEmail.AutoSize = true;
            this.lb_userEmail.Location = new System.Drawing.Point(13, 75);
            this.lb_userEmail.Name = "lb_userEmail";
            this.lb_userEmail.Size = new System.Drawing.Size(35, 13);
            this.lb_userEmail.TabIndex = 3;
            this.lb_userEmail.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dados Atuais";
            // 
            // lb_NomeuserAtual
            // 
            this.lb_NomeuserAtual.AutoSize = true;
            this.lb_NomeuserAtual.Location = new System.Drawing.Point(10, 49);
            this.lb_NomeuserAtual.Name = "lb_NomeuserAtual";
            this.lb_NomeuserAtual.Size = new System.Drawing.Size(38, 13);
            this.lb_NomeuserAtual.TabIndex = 1;
            this.lb_NomeuserAtual.Text = "Nome:";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nivel
            // 
            this.nivel.DataPropertyName = "nivelAcesso";
            this.nivel.HeaderText = "Nivel";
            this.nivel.Name = "nivel";
            this.nivel.ReadOnly = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 409);
            this.Controls.Add(this.panel_direito);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel_direito.ResumeLayout(false);
            this.panel_direito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_direito;
        private System.Windows.Forms.Label lb_NomeuserAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_userEmail;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Button btn_desabilitar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label lb_nivel;
        private System.Windows.Forms.ComboBox cBox_nivel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_usuariosSistema;
        private System.Windows.Forms.TextBox tx_senha;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivel;
    }
}