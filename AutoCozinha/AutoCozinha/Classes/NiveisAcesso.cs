﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCozinha.Classes
{
    class NiveisAcesso : Usuario
    {
        public int nivel { get; set; }
        public string cargo { get; set; }
        public NiveisAcesso()
        {

        }

        public NiveisAcesso(int nivel_acesso, string nomeNivel)
        {
            this.nivel = nivel_acesso;
            this.cargo = nomeNivel;
        }

        public List<NiveisAcesso> Mostra()
        {
            List<NiveisAcesso> niveis = new List<NiveisAcesso>();

            niveis.Add(new NiveisAcesso(1, "Estagiario"));
            niveis.Add(new NiveisAcesso(2, "Funcionario"));
            niveis.Add(new NiveisAcesso(3, "Gerente"));

            return niveis;
        }
    }
}
