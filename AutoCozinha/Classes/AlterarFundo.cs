using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class AlterarFundo
    {
        private string localArq;
        public AlterarFundo()
        {
            this.localArq = "config.txt";
            if (!File.Exists(this.localArq))
            {
                File.WriteAllText(this.localArq, "Fundo>default.jpg");
            }
        }
        public void NovoFundo(string ImgFundo)
        {
            string[] linha = File.ReadAllLines(this.localArq);
            for (int x = 0; x < linha.Length; x++)
            {
                string[] conf = linha[x].Split('>');
                Console.WriteLine(conf[0]);
                if (conf[0] == "Fundo")
                {
                    linha[x] = "Fundo>" + ImgFundo;
                }
            }
            File.WriteAllLines(this.localArq, linha);
        }

        public string BuscaFundo()
        {
            string[] linha = File.ReadAllLines("config.txt");
            string saida = null;
            foreach (string cong in linha)
            {
                string[] conf = cong.Split('>');
                if (conf[0] == "Fundo")
                {
                    if (File.Exists(conf[1]))
                    {
                        saida = conf[1];
                    }

                }
            }
            return saida;
        }
    }
}
