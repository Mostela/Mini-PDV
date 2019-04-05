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
            this.lb_userEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_NomeuserAtual = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_desabilitar = new System.Windows.Forms.Button();
            this.cBox_nivel = new System.Windows.Forms.ComboBox();
            this.lb_nivel = new System.Windows.Forms.Label();
            this.lb_usuariosSistema = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.listBox_registros = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel_direito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_direito
            // 
            this.panel_direito.Controls.Add(this.textBox3);
            this.panel_direito.Controls.Add(this.textBox2);
            this.panel_direito.Controls.Add(this.textBox1);
            this.panel_direito.Controls.Add(this.dataGridView1);
            this.panel_direito.Controls.Add(this.lb_usuariosSistema);
            this.panel_direito.Controls.Add(this.lb_nivel);
            this.panel_direito.Controls.Add(this.cBox_nivel);
            this.panel_direito.Controls.Add(this.btn_desabilitar);
            this.panel_direito.Controls.Add(this.btn_novo);
            this.panel_direito.Controls.Add(this.btn_alterar);
            this.panel_direito.Controls.Add(this.lb_senha);
            this.panel_direito.Controls.Add(this.lb_userEmail);
            this.panel_direito.Controls.Add(this.label1);
            this.panel_direito.Controls.Add(this.lb_NomeuserAtual);
            this.panel_direito.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_direito.Location = new System.Drawing.Point(263, 0);
            this.panel_direito.Name = "panel_direito";
            this.panel_direito.Size = new System.Drawing.Size(208, 409);
            this.panel_direito.TabIndex = 0;
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
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(7, 98);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(41, 13);
            this.lb_senha.TabIndex = 4;
            this.lb_senha.Text = "Senha:";
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(25, 149);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(56, 23);
            this.btn_alterar.TabIndex = 5;
            this.btn_alterar.Text = "Salvar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(156, 149);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(44, 23);
            this.btn_novo.TabIndex = 1;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            // 
            // btn_desabilitar
            // 
            this.btn_desabilitar.Location = new System.Drawing.Point(87, 149);
            this.btn_desabilitar.Name = "btn_desabilitar";
            this.btn_desabilitar.Size = new System.Drawing.Size(63, 23);
            this.btn_desabilitar.TabIndex = 6;
            this.btn_desabilitar.Text = "Desativar";
            this.btn_desabilitar.UseVisualStyleBackColor = true;
            // 
            // cBox_nivel
            // 
            this.cBox_nivel.FormattingEnabled = true;
            this.cBox_nivel.Location = new System.Drawing.Point(51, 122);
            this.cBox_nivel.Name = "cBox_nivel";
            this.cBox_nivel.Size = new System.Drawing.Size(121, 21);
            this.cBox_nivel.TabIndex = 7;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.editar});
            this.dataGridView1.Location = new System.Drawing.Point(10, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(195, 167);
            this.dataGridView1.TabIndex = 10;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.HeaderText = "Editar";
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Location = new System.Drawing.Point(85, 18);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(121, 13);
            this.lb_Titulo.TabIndex = 1;
            this.lb_Titulo.Text = "Ultimos registros sistema";
            // 
            // listBox_registros
            // 
            this.listBox_registros.FormattingEnabled = true;
            this.listBox_registros.Location = new System.Drawing.Point(13, 49);
            this.listBox_registros.Name = "listBox_registros";
            this.listBox_registros.Size = new System.Drawing.Size(231, 355);
            this.listBox_registros.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(48, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(157, 20);
            this.textBox3.TabIndex = 13;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 409);
            this.Controls.Add(this.listBox_registros);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.panel_direito);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.panel_direito.ResumeLayout(false);
            this.panel_direito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_direito;
        private System.Windows.Forms.Label lb_NomeuserAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_userEmail;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Button btn_desabilitar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label lb_nivel;
        private System.Windows.Forms.ComboBox cBox_nivel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewButtonColumn editar;
        private System.Windows.Forms.Label lb_usuariosSistema;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.ListBox listBox_registros;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}