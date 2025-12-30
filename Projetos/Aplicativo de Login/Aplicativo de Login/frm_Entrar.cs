using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
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

        //variaveis publicas
        public int tent = 0;
        public bool status = false;

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

        private bool Entrar()
        {
            //puxar as informações
            string email = txt_Email.Text;
            string senha = txt_Senha.Text;

            MySqlConnection conn = DbConnection.GetSqlConnection();

            try
            {
                conn.Open();

                //comando SQL
                string sql = "SELECT usuarios_email, usuarios_senha_hash " +
                    "         FROM tb_usuarios" +
                    "         WHERE usuarios_email = @email AND" +
                    "               usuarios_senha_hash = @senha";

                using (MySqlCommand comando = new MySqlCommand(sql, conn)) 
                { 
                    //trocando os parametos
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@senha", senha);

                    //verificando os dados
                    using (MySqlDataReader reader = comando.ExecuteReader()) 
                    { 
                        if (reader.Read()) //achou algo
                        {
                            MessageBox.Show("Login realizado com sucesso");
                            status = true;
                            EntrarLogs();
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Login ou Senha invalidos");
                            status = false;
                            EntrarLogs();
                            return false;
                        }
                    }

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro de conexão ao banco" + ex.Message);
                return false;  
            }
            finally 
            {
                conn.Close();
            }
        }

        private bool Tetativas()
        {
            if (tent < 3)
            {
                tent++;
                return true;
            }
            else
            {
                MessageBox.Show("Tentativas máximas atingidas\nVolte mais tarde");
                return false;
            }
        }

        private void EntrarLogs()
        {
            //caminho do arquivo
            string path = "C:\\Users\\josef\\Security\\Projetos\\Aplicativo de Login\\log\\log.txt";

            //fazendo o texto do log
            string email = txt_Email.Text;
            string logText = $"[{DateTime.Now:dd-MM-yyyy HH:mm:ss}] " +
                             $"Email= {email} | Sucesso= {status}";

            //escrevendo
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(logText + Environment.NewLine);
            }
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            //verificações
            if (!CamposVasios())
            {
                return;
            }

            if (!Tetativas())
            {
                return;
            }

            if (!Entrar())
            {
                return;
            }
        }
    }
}
