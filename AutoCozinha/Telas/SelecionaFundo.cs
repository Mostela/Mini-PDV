using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCozinha.Telas
{
    public partial class SelecionaFundo : Form
    {
        Classes.AlterarFundo fundo = new Classes.AlterarFundo();

        public SelecionaFundo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (open_buscaFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = open_buscaFoto.FileName;
                if(open_buscaFoto.FileName != null)
                {
                    btn_salvar.Show();
                }
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            fundo.NovoFundo(open_buscaFoto.FileName);
            s main = (s)this.Owner;
            main.CarregaFundo();
            this.Close();
        }

        private void SelecionaFundo_Load(object sender, EventArgs e)
        {
            if(fundo.BuscaFundo() != null)
            {
                pictureBox1.Image = Image.FromFile(fundo.BuscaFundo());
            }
        }
    }
}
