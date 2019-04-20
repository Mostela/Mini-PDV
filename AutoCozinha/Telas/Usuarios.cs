using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;

namespace AutoCozinha.Telas
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Verifica se é possivel habilitar o botão salvar
        /// </summary>
        private void HabilitaBtnSalvar()
        {
            if (usuario.nivelAcesso != -1 && tx_email.Text != null && tx_nome != null && tx_senha != null)
            {
                btn_alterar.Enabled = true;
            }
            else
            {
                btn_alterar.Enabled = false;
            }
        }

        Classes.Usuario usuario = new Classes.Usuario();

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            usuario.email = tx_email.Text;
            usuario.nome = tx_nome.Text;
            usuario.senha = tx_senha.Text;
            if (!Classes.Usuario.login)
            {
                usuario.Cadastrar();
                MessageBox.Show("Novo usuario adicionado com sucesso!!");
                Application.Restart();
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            
            if (!Classes.Usuario.login)
            {
                lb_usuariosSistema.Hide();
                dataGridView1.Hide();
                listBox_registros.Hide();
                lb_nivel.Hide();
                cBox_nivel.Hide();
                btn_desabilitar.Hide();
                btn_novo.Hide();
                lb_Titulo.Text = "NÃO EXIBIMOS OUTROS CAMPOS PARA PROTEGER O SISTEMA";
                MessageBox.Show("Você não esta logado no sistema, Recupere a senha");
            }
            else
            {
                cBox_nivel.DisplayMember = "cargo";
                cBox_nivel.ValueMember = "nivel";

                cBox_nivel.DataSource = Classes.NiveisAcesso.Mostra();
            }
        }

        private void tx_nome_KeyUp(object sender, KeyEventArgs e)
        {
            this.HabilitaBtnSalvar();
        }

        private void tx_email_KeyUp(object sender, KeyEventArgs e)
        {
            this.HabilitaBtnSalvar();
        }

        private void tx_senha_KeyUp(object sender, KeyEventArgs e)
        {
            this.HabilitaBtnSalvar();
        }
    }
}
