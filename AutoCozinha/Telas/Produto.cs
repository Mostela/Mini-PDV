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

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();

            if(produto.ID != 0)
            {

            }
            else
            {
                //SE O PRODUTO NÃO HOUVER SIDO APONTADO CRIA UM NOVO
                Classes.Produto produtoNovo = new Classes.Produto(double.Parse(tx_valor.Value.ToString()), text_lote.Text, date_validade.Text, tx_nomeProduto.Text, text_codigo.Text, text_descricao.Text, int.Parse(text_quantidade.Value.ToString()));
                if (produtoNovo.Cadastra())
                {
                    MessageBox.Show("O produto foi adicionado!");
                }
                else
                {
                    MessageBox.Show("O produto não foi adicionado!");
                }
            }
            this.CarregaTabela();
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
        }

        private void dataGrid_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Ok");
        }
    }
}
