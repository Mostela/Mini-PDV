﻿using System;
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
        public Usuarios()
        {
            InitializeComponent();
        }

        Classes.Usuario usuario = new Classes.Usuario();

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            usuario. tx_email.Text;
            if (!Classes.Usuario.login)
            {
                usuario.Cadastrar();
                MessageBox.Show("Senha recuperada com sucesso!!");
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            
            if (!Classes.Usuario.login)
            {
                lb_usuariosSistema.Hide();
                dataGridView1.Hide();
                listBox_registros.Hide();
                lb_nivel.Hide();
                cBox_nivel.Hide();
                btn_desabilitar.Hide();
                btn_novo.Hide();
                lb_Titulo.Text = "NÃO EXIBIMOS OUTROS CAMPOS PARA PROTEGER O SISTEMA";
                MessageBox.Show("Você não esta logado no sistema, Recupere a senha");
            }
            else
            {
                Classes.NiveisAcesso niveis = new Classes.NiveisAcesso();

                cBox_nivel.DisplayMember = "nome";
                cBox_nivel.ValueMember = "nivel";

                cBox_nivel.DataSource = niveis.Mostra();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }
    }
}
