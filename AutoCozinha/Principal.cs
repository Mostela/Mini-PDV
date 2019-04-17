using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoCozinha
{
    public partial class form_principal : Form
    {
        public form_principal()
        {
            InitializeComponent();
            switch (Classes.NiveisAcesso.nivelAcessoHabilitado)
            {
                case 1:
                    novoUsuarioToolStripMenuItem.HideDropDown();
                    cadastrarNovoToolStripMenuItem.HideDropDown();
                    break;

                case 2:
                    novoUsuarioToolStripMenuItem.HideDropDown();
                    break;
            }
        }
        public void CarregaFundo()
        {
            Classes.AlterarFundo fundo = new Classes.AlterarFundo();
            if (fundo.BuscaFundo() != null)
            {
                string foto = fundo.BuscaFundo();
                this.BackgroundImage = Image.FromFile(foto);
                pan_barraInfo.BackColor = Color.Transparent;
            }

        }

        protected internal void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void imagemDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["SelecionaFundo"] == null)
                {
                    Telas.SelecionaFundo selecionaFundo = new Telas.SelecionaFundo();
                    selecionaFundo.Owner = this;
                    selecionaFundo.Show();
                }
            }
            catch { }
        }

        private void reinicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.reinicarToolStripMenuItem_Click(sender, e);
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ChamaCliente();
        }

        private void adicionarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ChamaCliente();
        }

        private void cadastrarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ChamaProduto();
        }

        private void ChamaCliente(string nome = null)
        {
            try
            {
                if (Application.OpenForms["Cliente"] == null)
                {
                    Telas.Cliente cliente = new Telas.Cliente();
                    cliente.Show();
                }
            }
            catch { }
        }

        private void ChamaProduto()
        {
            Telas.Produto produto = new Telas.Produto();
            try
            {
                if (Application.OpenForms["Produto"] == null)
                {
                    produto.Show();
                }
                else
                {
                    MessageBox.Show("A tela Produtos ja estava aberta");
                    produto.Activate();
                }
            }
            catch {}
        }

        private void ChamaUsuario()
        {
            Telas.Usuarios Usuario = new Telas.Usuarios();
            try
            {
                if (Application.OpenForms["Usuarios"] == null)
                {
                    Usuario.Show();
                }
                else
                {
                    MessageBox.Show("A tela Usuario ja estava aberta");
                    Usuario.Activate();
                }
            }
            catch { }
        }

        private void alterarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ChamaUsuario();
        }

        private void novoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ChamaUsuario();
        }

        private void form_principal_Load(object sender, EventArgs e)
        {
            this.CarregaFundo();

            Classes.ConsultaRapida consulta = new Classes.ConsultaRapida();
            cBox_modoBuscaProduto.DisplayMember = "metodo";
            cBox_modoBuscaProduto.ValueMember = "ID";
            cBox_modoBuscaProduto.DataSource = consulta.Listar();
        }
    }
}
