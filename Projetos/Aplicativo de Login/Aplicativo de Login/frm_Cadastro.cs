namespace Aplicativo_de_Login
{
    public partial class frm_Cadastro : Form
    {
        public frm_Cadastro()
        {
            InitializeComponent();
        }

        private void lb_Nome_Click(object sender, EventArgs e)
        {

        }

        private void lk_Entrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Entrar Entrar = new frm_Entrar();
            Entrar.Show();
            this.Hide();
        }

        private bool CamposVasios()
        {
            //verificar campos vazios
            if (String.IsNullOrWhiteSpace(txt_Nome.Text)) //verificação do nome
            {
                MessageBox.Show("Nome de usuário faltando");
                txt_Nome.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(txt_Email.Text)) //verificação do email
            {
                MessageBox.Show("Email de usuário faltando");
                txt_Email.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(txt_Senha.Text)) //verificação da senha
            {
                MessageBox.Show("Senha do usuário faltado");
                txt_Senha.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(txt_ConfSenha.Text)) //confirmar senha
            {
                MessageBox.Show("Confirme a sua senha");
                txt_ConfSenha.Focus();
                return false;
            } else if (chcbx_Termos.Checked == false)
            {
                MessageBox.Show("Para se cadastrar precisa concordar com os termos de uso");
                chcbx_Termos.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool Senhas()
        {
            //verificação das senhas
            if (txt_Senha.Text != txt_ConfSenha.Text)
            {
                MessageBox.Show("As senhas não estão iguais");
                txt_ConfSenha.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            //pegar o valor dos campos
            string nome = txt_Nome.Text;
            string email = txt_Email.Text;
            string senha = txt_Senha.Text;
            string confSenha = txt_ConfSenha.Text;

            //verificações
            if (!CamposVasios())
            {
                return;
            }

            if (!Senhas())
            {
                return;
            }

            MessageBox.Show("Cadastro realizado com sucesso");

            //salvar no banco

            //apos salvar no banco
            frm_Entrar entrar = new frm_Entrar();
            entrar.Show();

        }
    }
}
