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
using System.Text.RegularExpressions;

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

        private void ChamaCliente()
        {
            try
            {
                if (Application.OpenForms["Cliente"] == null)
                {
                    Telas.TelaCliente cliente = new Telas.TelaCliente();
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

            cBox_modoBuscaProduto.ValueMember = "id";
            cBox_modoBuscaProduto.DisplayMember = "modelo";
            cBox_modoBuscaProduto.DataSource = Classes.BuscaProdutos.Listar();
            dataGrid_produtos.AutoGenerateColumns = false;

            cBox_Desconto.DisplayMember = "valor";
            cBox_Desconto.ValueMember = "valDesconto";
            cBox_Desconto.DataSource = Classes.Descontos.Listar();
        }

        private void tx_buscaProduto_KeyUp(object sender, KeyEventArgs e)
        {
            Classes.Estoque estoque = new Classes.Estoque();
            if(tx_buscaProduto.Text != " " && tx_buscaProduto.Text != null)
            {
                if (Regex.IsMatch(tx_buscaProduto.Text, @"^[A-z a-z 0-9]+$"))
                {
                    switch (cBox_modoBuscaProduto.SelectedValue)
                    {
                        case 1:
                            dataGrid_produtos.DataSource = estoque.BuscaProdutosEstoque(nome: tx_buscaProduto.Text);
                            break;

                        case 2:
                            dataGrid_produtos.DataSource = estoque.BuscaProdutosEstoque(codigo: tx_buscaProduto.Text);
                            break;

                        default:
                            dataGrid_produtos.DataSource = null;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Caracteres invalidos");
                }
            }
        }

        private void btn_buscaCliente_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tx_buscaCliente.Text, @"^[A-z a-z 0-9]+$"))
            {
                Classes.BuscaCliente.nome = tx_buscaCliente.Text;
                this.ChamaCliente();
            }
            else
            {
                MessageBox.Show("Texto não aceitavel");
            }
            
        }

        private void text_cpfCliente_KeyUp(object sender, KeyEventArgs e)
        {
            Classes.Cliente cliente = new Classes.Cliente();
            string CPF = text_cpfCliente.Text;
            if (CPF.Length == 14)
            {
                if (!Classes.Cliente.ValidaCPF(CPF))
                {
                    var clie = cliente.BuscaCliente(Cpf: CPF);
                    lb_ValueNomeCliente.Text = clie[0].nome;
                }
                else
                {
                    MessageBox.Show("Não Valido");
                }
            }
            else
            {
                lb_ValueNomeCliente.Text = null;
            }
        }

        /* ---------------------------------------
         * INICIO DO CARRINHO DE COMPRAS
         * --------------------------------------- */

        Classes.Produto produtoAtual { get; set; }
        Classes.CarrinhoDeCompas carro = new Classes.CarrinhoDeCompas();
        Classes.Compras compras = new Classes.Compras();
        Classes.Debito debito = new Classes.Debito();
        private void tx_codProd_KeyUp(object sender, KeyEventArgs e)
        {
            if (!Classes.Estoque.CodigosUsados(tx_codProd.Text, overLoad: 0))
            {
                dataGrid_carrinho.DataSource = null;
                var dados = carro.BuscaProdutosEstoque(codigo: tx_codProd.Text);
                produtoAtual = dados[0];

                if (!carro.carrinhoDeCompas.Exists(x => x.ID == produtoAtual.ID))
                {
                    carro.AdicionaCarrinho(produtoAtual.ID, produtoAtual.nomeReferencia, int.Parse(num_itens.Value.ToString()), dados[0].preco);
                }
                else
                {
                    if(num_itens.Value > 1)
                    {
                        carro.EditaCarrinho(produtoAtual.ID, nome: produtoAtual.nomeReferencia, preco: produtoAtual.preco, quantidade: int.Parse(num_itens.Value.ToString()));
                        num_itens.Value = 1;
                    }
                    else
                    {
                        carro.EditaCarrinho(produtoAtual.ID, nome: produtoAtual.nomeReferencia, preco: produtoAtual.preco, aumentaQuantia: true);
                    }
                }

                dataGrid_carrinho.AutoGenerateColumns = false;
                dataGrid_carrinho.DataSource = carro.carrinhoDeCompas;
                tx_codProd.Text = null;
                this.AtualizaTotal();
            }
        }

        protected void AtualizaTotal()
        {
            lb_valorFinal.Text = String.Format("TOTAL: R${0}", carro.CalculaTotal().ToString());
        }

        private void dataGrid_carrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaAtual = dataGrid_carrinho.CurrentRow;
            int indice = linhaAtual.Index;
            if(MessageBox.Show(String.Format("Deseja remover {0}", dataGrid_carrinho.Rows[indice].Cells["carro_produto"].Value.ToString()), "Remover", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                carro.RemoveCarrinho(int.Parse(dataGrid_carrinho.Rows[indice].Cells["ID"].Value.ToString()));
                dataGrid_carrinho.DataSource = null;
                dataGrid_carrinho.AutoGenerateColumns = false;
                dataGrid_carrinho.DataSource = carro.carrinhoDeCompas;
                this.AtualizaTotal();
            }
        }
    }
}
