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
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
            this.CarregaFundo();
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
            Telas.SelecionaFundo selecionaFundo = new Telas.SelecionaFundo();
            selecionaFundo.Owner = this;
            selecionaFundo.Show();
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
            Telas.Cliente cliente = new Telas.Cliente();
            cliente.Show();
        }

        private void adicionarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Cliente cliente = new Telas.Cliente();
            cliente.Show();
        }
    }
}
