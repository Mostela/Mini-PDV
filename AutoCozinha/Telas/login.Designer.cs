namespace AutoCozinha.Telas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_senha = new System.Windows.Forms.TextBox();
            this.btn_acessar = new System.Windows.Forms.Button();
            this.btn_esqueciSenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(219, 43);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(235, 37);
            this.lb_titulo.TabIndex = 1;
            this.lb_titulo.Text = "SMART BOSS";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(127, 142);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(35, 13);
            this.lb_user.TabIndex = 2;
            this.lb_user.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // tx_email
            // 
            this.tx_email.Location = new System.Drawing.Point(168, 139);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(310, 20);
            this.tx_email.TabIndex = 6;
            // 
            // tx_senha
            // 
            this.tx_senha.Location = new System.Drawing.Point(168, 188);
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.Size = new System.Drawing.Size(310, 20);
            this.tx_senha.TabIndex = 7;
            // 
            // btn_acessar
            // 
            this.btn_acessar.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_acessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acessar.Location = new System.Drawing.Point(256, 214);
            this.btn_acessar.Name = "btn_acessar";
            this.btn_acessar.Size = new System.Drawing.Size(126, 23);
            this.btn_acessar.TabIndex = 8;
            this.btn_acessar.Text = "ACESSAR";
            this.btn_acessar.UseVisualStyleBackColor = false;
            this.btn_acessar.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // btn_esqueciSenha
            // 
            this.btn_esqueciSenha.Location = new System.Drawing.Point(13, 249);
            this.btn_esqueciSenha.Name = "btn_esqueciSenha";
            this.btn_esqueciSenha.Size = new System.Drawing.Size(103, 23);
            this.btn_esqueciSenha.TabIndex = 9;
            this.btn_esqueciSenha.Text = "Esqueci a senha";
            this.btn_esqueciSenha.UseVisualStyleBackColor = true;
            this.btn_esqueciSenha.Click += new System.EventHandler(this.btn_esqueciSenha_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(586, 284);
            this.Controls.Add(this.btn_esqueciSenha);
            this.Controls.Add(this.btn_acessar);
            this.Controls.Add(this.tx_senha);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_senha;
        private System.Windows.Forms.Button btn_acessar;
        private System.Windows.Forms.Button btn_esqueciSenha;
    }
}