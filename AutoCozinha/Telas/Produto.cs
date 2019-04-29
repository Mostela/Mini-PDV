using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCozinha.Telas
{
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }
        Classes.Produto produto = new Classes.Produto();

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (text_codigo.Text != null && tx_nomeProduto.Text != null && text_quantidade.Value > 0 && text_codigo.BackColor == Color.Green)
            {
                var CatSelect = Classes.CategoriaProduto.RetornaCategoria(int.Parse(cBox_categoria.SelectedValue.ToString()));
                if (this.produto.ID != 0)
                {
                    Classes.Produto produtoEdita = new Classes.Produto(float.Parse(tx_valor.Value.ToString()), CatSelect, date_validade.Text, tx_nomeProduto.Text, text_codigo.Text, text_descricao.Text, int.Parse(text_quantidade.Value.ToString()),produto.ID);
                    if (MessageBox.Show(string.Format("Deseja editar o produto {0}!", produto.nomeReferencia),"Editar",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (produtoEdita.Editar()){
                            Classes.Log.GravarLog("Alterou produto", produto.nomeReferencia, produtoEdita.nomeReferencia);
                        }
                    }

                }
                else
                {
                    //SE O PRODUTO NÃO HOUVER SIDO APONTADO CRIA UM NOVO
                    Classes.Produto produtoNovo = new Classes.Produto(float.Parse(tx_valor.Value.ToString()), CatSelect, date_validade.Text, tx_nomeProduto.Text, text_codigo.Text, text_descricao.Text, int.Parse(text_quantidade.Value.ToString()));
                    if (produtoNovo.Cadastra())
                    {
                        MessageBox.Show("O produto foi adicionado!");
                        Classes.Log.GravarLog("O produto foi adicionado", null, produtoNovo.nomeReferencia);
                    }
                    else
                    {
                        MessageBox.Show("O produto não foi adicionado!");
                    }
                }
                this.CarregaTabela();
            }
            else
            {
                MessageBox.Show("Prencha os campos para cadastrar um novo produto");
            }
        }

        private void CarregaTabela()
        {
            Classes.Estoque estoque = new Classes.Estoque();
            dataGrid_produtos.AutoGenerateColumns = false;
            dataGrid_produtos.DataSource = estoque.BuscaProdutosEstoque();
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            this.CarregaTabela();
            cBox_busca.ValueMember = "id";
            cBox_busca.DisplayMember = "modelo";
            cBox_busca.DataSource = Classes.BuscaProdutos.Listar();

            //Classes.CategoriaProduto categoriaProduto = new Classes.CategoriaProduto(2,"Congelados");
            //categoriaProduto.NovaCategoria();

            cBox_categoria.ValueMember = "id_categoria";
            cBox_categoria.DisplayMember = "categoria";
            cBox_categoria.DataSource = Classes.CategoriaProduto.Listar();
        }

        private void dataGrid_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaAtual = dataGrid_produtos.CurrentRow;
            int indice = linhaAtual.Index;

            //OBTEM O VALOR DA LINHA E ATRIBUI A CLASSE
            produto.ID = int.Parse(dataGrid_produtos.Rows[indice].Cells["ID"].Value.ToString());
                //ATRIBUI ID A OBJETO APENAS
            produto.categoria = int.Parse(dataGrid_produtos.Rows[indice].Cells["categoria"].Value.ToString());
            produto.codigo = dataGrid_produtos.Rows[indice].Cells["codigo"].Value.ToString();
            produto.descricao = dataGrid_produtos.Rows[indice].Cells["descricao"].Value.ToString();
            produto.nomeReferencia = dataGrid_produtos.Rows[indice].Cells["nomeReferencia"].Value.ToString();
            produto.preco = float.Parse(dataGrid_produtos.Rows[indice].Cells["preco"].Value.ToString());
            produto.quantidade = int.Parse(dataGrid_produtos.Rows[indice].Cells["quantidade"].Value.ToString());
            produto.validade = dataGrid_produtos.Rows[indice].Cells["validade"].Value.ToString();

            //ATRIBUI A CLASSE AOS CAMPOS
            cBox_categoria.SelectedValue = produto.categoria;
            tx_valor.Value = decimal.Parse(produto.preco.ToString());
            date_validade.Text = produto.validade;
            tx_nomeProduto.Text = produto.nomeReferencia;
            text_codigo.Text = produto.codigo;
            text_descricao.Text = produto.descricao;
            text_quantidade.Value = produto.quantidade;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(produto.ID != 0)
            {
                if (MessageBox.Show(string.Format("Deseja excluir {0}", produto.nomeReferencia), "Editar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (produto.Excluir())
                    {
                        Classes.Log.GravarLog("Foi exlcuido o produto", produto.nomeReferencia);
                        produto.ID = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("Não atribuito produto para exclusão");
            }
            
        }

        private void btn_limpa_Click(object sender, EventArgs e)
        {
            produto.ID = 0;
            tx_valor.Value = 1;
            /*DateTime date = new DateTime();
            date_validade.Text = date.Day + "/"+ date.Month+"/"+date.Year;*/
            tx_nomeProduto.Text = null;
            text_codigo.Text = null;
            text_descricao.Text = null;
            text_quantidade.Value = 1;
        }

        private void cheBox_emFalta_CheckedChanged(object sender, EventArgs e)
        {
            if (cheBox_emFalta.Checked)
            {
                cBox_busca.Enabled = false;
                tx_busca.Enabled = false;
                dataGrid_produtos.DataSource = produto.ProdutosEmFalta();
            }
            else
            {
                cBox_busca.Enabled = true;
                tx_busca.Enabled = true;
                dataGrid_produtos.DataSource = produto.BuscaProdutosEstoque();
            }
        }

        private void tx_busca_KeyUp(object sender, KeyEventArgs e)
        {
            switch (cBox_busca.SelectedValue)
            {
                case 1:
                    dataGrid_produtos.DataSource = produto.BuscaProdutosEstoque(nome: tx_busca.Text);
                    break;

                case 2:
                    dataGrid_produtos.DataSource = produto.BuscaProdutosEstoque(codigo: tx_busca.Text);
                    break;
                default:
                    break;
            }
        }

        private void text_codigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (Classes.Estoque.CodigosUsados(text_codigo.Text))
            {
                text_codigo.BackColor = Color.Green;
            }
            else
            {
                text_codigo.BackColor = Color.Red;
            }
        }
    }
}
