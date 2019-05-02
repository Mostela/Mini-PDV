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
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Marca como valido o CPF para realizar o cadastro ou alteração no cliente
        /// </summary>
        protected bool validoCPF { get; set; }
        /// <summary>
        /// Marca como valido o Email para realizar o cadastro ou alteração no cliente
        /// </summary>
        protected bool validoEmail { get; set; }
        /// <summary>
        /// Usado como cliente atual para cadastro e excluir
        /// </summary>
        Classes.Cliente atualCliente =new Classes.Cliente();
        Classes.Fidelidade atualFidelidade = new Classes.Fidelidade();
        Classes.Debito atualDebito = new Classes.Debito();
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (this.validoEmail && this.validoCPF)
            {
                if (atualCliente.id == 0)
                {
                
                    Classes.Cliente cadaCliente = new Classes.Cliente(txt_nome.Text, txt_email.Text, txt_cpf.Text, cBox_cidade.SelectedIndex.ToString());
                    if (cadaCliente.CriaNovoCliente())
                    {
                        MessageBox.Show(String.Format("Novo cliente {0} adicionado", txt_nome.Text));
                    }
                    if (cheBox_fidelidade.Checked)
                    {
                        Classes.Fidelidade fidelidade = new Classes.Fidelidade(cadaCliente.id);
                        if (fidelidade.NovoFidelidade())
                        {
                            MessageBox.Show(String.Format("{0} ao plano fidelidade", txt_nome.Text));
                        }
                    }
                    lb_infoStatus.Text = "Liberado";
                }
                else
                {
                    atualCliente.nome = txt_nome.Text;
                    atualCliente.email = txt_email.Text;
                    atualCliente.cidade = cBox_cidade.SelectedIndex.ToString();
                    atualCliente.cpf = txt_cpf.Text;
                    if (atualCliente.EditarCliente())
                    {
                        if (cheBox_fidelidade.Checked)
                        {
                            atualFidelidade.id_cliente = atualCliente.id;
                            atualFidelidade.NovoFidelidade();
                        }
                        else
                        {
                            if (atualFidelidade.Excluir())
                            {
                                MessageBox.Show(String.Format("{0} retirado de Fidelidade",atualCliente.nome));
                            }
                        }
                        MessageBox.Show(String.Format("{0} foi atualizado!", atualCliente.nome));
                    }
                    else
                    {
                        MessageBox.Show("Falha na operação");
                    }
                }
            }
            else
            {
                MessageBox.Show("Alguns dados não são validos");
            }
            this.CarregaTabela();

        }


        private void CarregaTabela()
        {
            Classes.Cliente cadaCliente = new Classes.Cliente();
            dataGrid_clientes.AutoGenerateColumns = false;
            var test =cadaCliente.BuscaCliente();
            dataGrid_clientes.DataSource = cadaCliente.BuscaCliente();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            cBox_cidade.ValueMember = "id";
            cBox_cidade.DisplayMember = "nome";
            cBox_cidade.DataSource = Classes.ListaCidades.Listar();

            if(Classes.BuscaCliente.nome != null)
            {
                txt_buscaClie.Text = Classes.BuscaCliente.nome;
                dataGrid_clientes.DataSource = atualCliente.BuscaCliente(Classes.BuscaCliente.nome);
            }
            else
            {
                this.CarregaTabela();
            }

        }

        private void txt_cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Classes.Cliente.ValidaCPF(txt_cpf.Text) && txt_cpf.Text.Length == 14)
            {
                txt_cpf.BackColor = Color.Green;
                this.validoCPF = true;
            }
            else
            {
                txt_cpf.BackColor = Color.Red;
                this.validoCPF = false;
            }
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Classes.Cliente.ValidaEmail(txt_email.Text))
            {
                txt_email.BackColor = Color.Green;
                this.validoEmail = true;
            }
            else
            {
                txt_email.BackColor = Color.Red;
                this.validoEmail = false;
            }
        }

        private void txt_buscaClie_KeyUp(object sender, KeyEventArgs e)
        {
            dataGrid_clientes.DataSource = atualCliente.BuscaCliente(txt_buscaClie.Text);
        }

        private void btn_limpa_Click(object sender, EventArgs e)
        {
            atualCliente.id = 0;
            txt_nome.Text = "";
            txt_email.Text = "";
            txt_cpf.Text = "";
            cBox_cidade.SelectedValue = 1;
            lb_infoStatus.Text = "Liberado";
            cheBox_fidelidade.Checked = false;
            lb_infoDesconto.Text = "0%";
            dataGrid_ultimosItens.DataSource = null;

            txt_email.BackColor = DefaultBackColor;
            txt_cpf.BackColor = DefaultBackColor;

            atualFidelidade.id_cliente = 0;
            atualDebito.id_cliente = 0;
        }

        private void dataGrid_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //OBTEM A LINHA CLICADA
            DataGridViewRow linhaAtual = dataGrid_clientes.CurrentRow;
            int indice = linhaAtual.Index;
            //ATRIBUI DADOS A CLASSE E DEPOIS A CLASSE AOS CAMPOS
            atualCliente.id = int.Parse(dataGrid_clientes.Rows[indice].Cells["id"].Value.ToString());

            atualCliente.cidade = dataGrid_clientes.Rows[indice].Cells["cidade"].Value.ToString();
            atualCliente.cpf = dataGrid_clientes.Rows[indice].Cells["cpf"].Value.ToString();
            atualCliente.email = dataGrid_clientes.Rows[indice].Cells["email"].Value.ToString();
            atualCliente.nome = dataGrid_clientes.Rows[indice].Cells["nome"].Value.ToString();
            atualCliente.status = bool.Parse(dataGrid_clientes.Rows[indice].Cells["status"].Value.ToString());

            this.validoCPF = true;
            this.validoEmail = true;

            cBox_cidade.SelectedIndex = int.Parse(atualCliente.cidade);
            txt_cpf.Text = atualCliente.cpf;
            txt_email.Text = atualCliente.email;
            txt_nome.Text = atualCliente.nome;
            lb_infoStatus.Text = atualCliente.status ? "Liberado" : "Bloqueado";

            atualFidelidade.id_cliente = atualCliente.id;
            atualFidelidade.BuscaCliente();
            //TEM FIDELIDADE
            if(atualFidelidade.desconto != 0)
            {
                cheBox_fidelidade.Checked = true ;
                lb_infoDesconto.Text = String.Format("{0}%", atualFidelidade.desconto);
            }
            else
            {
                cheBox_fidelidade.Checked = false;
                lb_infoDesconto.Text = String.Format("{0}%", 0);
            }
            
            
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(atualCliente.id != 0)
            {
                if (atualCliente.ExcluirCliente())
                {
                    MessageBox.Show(String.Format("O cliente {0} foi retirado da base de dados", atualCliente.nome));
                }
                else
                {
                    MessageBox.Show("Erro na operação");
                }
            }
        }
    }
}
