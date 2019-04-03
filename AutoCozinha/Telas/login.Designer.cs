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
            this.lb_esqueci = new System.Windows.Forms.LinkLabel();
            this.lb_novoUser = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_acessar = new System.Windows.Forms.Button();
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
            // lb_esqueci
            // 
            this.lb_esqueci.AutoSize = true;
            this.lb_esqueci.Location = new System.Drawing.Point(392, 259);
            this.lb_esqueci.Name = "lb_esqueci";
            this.lb_esqueci.Size = new System.Drawing.Size(86, 13);
            this.lb_esqueci.TabIndex = 4;
            this.lb_esqueci.TabStop = true;
            this.lb_esqueci.Text = "Esqueci a senha";
            // 
            // lb_novoUser
            // 
            this.lb_novoUser.AutoSize = true;
            this.lb_novoUser.Location = new System.Drawing.Point(127, 259);
            this.lb_novoUser.Name = "lb_novoUser";
            this.lb_novoUser.Size = new System.Drawing.Size(70, 13);
            this.lb_novoUser.TabIndex = 5;
            this.lb_novoUser.TabStop = true;
            this.lb_novoUser.Text = "Novo usuario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 20);
            this.textBox2.TabIndex = 7;
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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(586, 284);
            this.Controls.Add(this.btn_acessar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_novoUser);
            this.Controls.Add(this.lb_esqueci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
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
        private System.Windows.Forms.LinkLabel lb_esqueci;
        private System.Windows.Forms.LinkLabel lb_novoUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_acessar;
    }
}