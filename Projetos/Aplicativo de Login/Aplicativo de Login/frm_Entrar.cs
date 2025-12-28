using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicativo_de_Login
{
    public partial class frm_Entrar : Form
    {
        public frm_Entrar()
        {
            InitializeComponent();
        }

        private void lk_Cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Cadastro cadastro = new frm_Cadastro();
            cadastro.Show();
            this.Close();
        }

        private bool CamposVasios()
        {
            if (String.IsNullOrWhiteSpace(txt_Email.Text)) //Verifica o email
            {
                MessageBox.Show("O campo Email está vazio");
                txt_Email.Focus();
                return false;
            } 
            else if (String.IsNullOrWhiteSpace(txt_Senha.Text)) //verifica a senha
            {
                MessageBox.Show("O campo de senha está vazio");
                txt_Senha.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            //puxar as informações
            string email = txt_Email.Text;
            string senha = txt_Senha.Text;

            //verificações
            if (!CamposVasios())
            {
                return;
            }

            // fazer verificação com o banco aqui

            //apos a verificação com o banco
            MessageBox.Show("Login feito com sucesso, redirecionando......");
        }
    }
}
