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
        protected bool existeUser { get; set; }
        public Usuarios()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Verifica se é possivel habilitar o botão salvar
        /// </summary>
        private void HabilitaBtnSalvar()
        {
            if(usuario.ID != 0)
            {
                if (tx_email.Text != null && this.existeUser && tx_senha != null)
                {
                    btn_salvar.Enabled = true;
                }
                else
                {
                    btn_salvar.Enabled = false;
                }
            }
            else
            {
                btn_salvar.Enabled = true;
            }
        }

        Classes.Usuario usuario = new Classes.Usuario();
       
        private void Btn_alterar_Click(object sender, EventArgs e)
        {
            usuario.email = tx_email.Text;
            usuario.nome = tx_nome.Text;
            usuario.senha = tx_senha.Text;
            

            if (!Classes.Usuario.login)
            {
                usuario.nivelAcesso.nivel = 1;
                usuario.nivelAcesso.cargo = "Estagiario";
            }
            else
            {
                this.usuario.nivelAcesso = new Classes.NiveisAcesso();
                usuario.nivelAcesso.nivel = int.Parse(cBox_nivel.SelectedValue.ToString()); ;
                usuario.nivelAcesso.cargo = cBox_nivel.SelectedText;
            }
            if(usuario.ID == 0)
            {
                usuario.Cadastrar();
                MessageBox.Show("Novo usuario adicionado com sucesso!!");
            }
            else
            {
                usuario.Atualiza();
                MessageBox.Show("Dados do usuario atualizados com sucesso!!");
            }
            
            usuario = new Classes.Usuario();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            
            if (!Classes.Usuario.login)
            {
                lb_usuariosSistema.Hide();
                dataGridView1.Hide();
                lb_nivel.Hide();
                cBox_nivel.Hide();
                btn_desabilitar.Hide();
                btn_novo.Hide();
                MessageBox.Show("Você não esta logado no sistema, Recupere a senha");
            }
            else
            {
                cBox_nivel.DisplayMember = "cargo";
                cBox_nivel.ValueMember = "nivel";
                cBox_nivel.DataSource = Classes.NiveisAcesso.Mostra();

                this.AtualizaTabela();
                
            }
        }

        /// <summary>
        /// Atualiza o DataGrid
        /// </summary>
        protected void AtualizaTabela()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Classes.Usuario.TodosUsuarios();
        }

        private void tx_nome_KeyUp(object sender, KeyEventArgs e)
        {
            this.HabilitaBtnSalvar();
            if((tx_nome != null && usuario.ID != 0) || !Classes.Usuario.login)
            {
                if (Classes.Usuario.BuscaUsuario(tx_nome.Text))
                {
                    tx_nome.BackColor = Color.Green;
                    this.existeUser = true;
                }
                else
                {
                    tx_nome.BackColor = Color.Red;
                    this.existeUser = false;
                }
            }
            else
            {
                tx_nome.BackColor = DefaultBackColor;
            }
        }

        private void tx_email_KeyUp(object sender, KeyEventArgs e)
        {
            this.HabilitaBtnSalvar();
        }

        private void tx_senha_KeyUp(object sender, KeyEventArgs e)
        {
            this.HabilitaBtnSalvar();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tx_email.Text = "";
            tx_nome.Text = "";
            tx_senha.Text = "";
            cBox_nivel.SelectedItem = 0;
            usuario = new Classes.Usuario();
        }

        private void btn_desabilitar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja remover usuario?","Remover usuario" ,MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (usuario.RemoverUsuario(usuario.ID))
                {
                    MessageBox.Show("Usuario removido com sucesso!");
                    this.AtualizaTabela();
                    this.btn_novo.PerformClick();
                }
                else
                {
                    MessageBox.Show("Falha localizada");
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaAtual = dataGridView1.CurrentRow;
            int indice = linhaAtual.Index;
            //ATRIBUI DADOS A CLASSE E DEPOIS A CLASSE AOS CAMPOS
            usuario.ID = int.Parse(dataGridView1.Rows[indice].Cells["id"].Value.ToString());
            usuario.email = dataGridView1.Rows[indice].Cells["email"].Value.ToString();
            usuario.nome = dataGridView1.Rows[indice].Cells["nome"].Value.ToString();
            //usuario.nivelAcesso.nivel = int.Parse(dataGridView1.Rows[indice].Cells["Nivel"].Value.ToString());
            this.existeUser = true;
            //cBox_nivel.SelectedValue = usuario.nivelAcesso.nivel;

            tx_email.Text = usuario.email;
            tx_nome.Text = usuario.nome;
        }
    }
}
