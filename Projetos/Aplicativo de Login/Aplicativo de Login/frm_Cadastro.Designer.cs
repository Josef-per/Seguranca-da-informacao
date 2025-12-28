namespace Aplicativo_de_Login
{
    partial class frm_Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_Title = new Label();
            pn_forms = new Panel();
            lk_Entrar = new LinkLabel();
            chcbx_Termos = new CheckBox();
            btn_Cadastrar = new Button();
            txt_ConfSenha = new TextBox();
            txt_Senha = new TextBox();
            txt_Email = new TextBox();
            txt_Nome = new TextBox();
            lb_ConfirmarSenha = new Label();
            lb_Senha = new Label();
            lb_Email = new Label();
            lb_Nome = new Label();
            pn_forms.SuspendLayout();
            SuspendLayout();
            // 
            // lb_Title
            // 
            lb_Title.AutoSize = true;
            lb_Title.Font = new Font("Segoe UI", 22F);
            lb_Title.Location = new Point(319, 9);
            lb_Title.Name = "lb_Title";
            lb_Title.Size = new Size(136, 41);
            lb_Title.TabIndex = 0;
            lb_Title.Text = "Cadastro";
            // 
            // pn_forms
            // 
            pn_forms.Controls.Add(lk_Entrar);
            pn_forms.Controls.Add(chcbx_Termos);
            pn_forms.Controls.Add(btn_Cadastrar);
            pn_forms.Controls.Add(txt_ConfSenha);
            pn_forms.Controls.Add(txt_Senha);
            pn_forms.Controls.Add(txt_Email);
            pn_forms.Controls.Add(txt_Nome);
            pn_forms.Controls.Add(lb_ConfirmarSenha);
            pn_forms.Controls.Add(lb_Senha);
            pn_forms.Controls.Add(lb_Email);
            pn_forms.Controls.Add(lb_Nome);
            pn_forms.Location = new Point(78, 72);
            pn_forms.Name = "pn_forms";
            pn_forms.Size = new Size(646, 471);
            pn_forms.TabIndex = 1;
            // 
            // lk_Entrar
            // 
            lk_Entrar.AutoSize = true;
            lk_Entrar.Location = new Point(132, 365);
            lk_Entrar.Name = "lk_Entrar";
            lk_Entrar.Size = new Size(116, 15);
            lk_Entrar.TabIndex = 10;
            lk_Entrar.TabStop = true;
            lk_Entrar.Text = "Já tem conta ? Entrar";
            lk_Entrar.LinkClicked += lk_Entrar_LinkClicked;
            // 
            // chcbx_Termos
            // 
            chcbx_Termos.AutoSize = true;
            chcbx_Termos.Location = new Point(132, 334);
            chcbx_Termos.Name = "chcbx_Termos";
            chcbx_Termos.Size = new Size(213, 19);
            chcbx_Termos.TabIndex = 9;
            chcbx_Termos.Text = "Eu concordo com os termos de uso";
            chcbx_Termos.UseVisualStyleBackColor = true;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Font = new Font("Segoe UI", 16F);
            btn_Cadastrar.Location = new Point(241, 401);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(156, 44);
            btn_Cadastrar.TabIndex = 8;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // txt_ConfSenha
            // 
            txt_ConfSenha.Location = new Point(132, 293);
            txt_ConfSenha.Name = "txt_ConfSenha";
            txt_ConfSenha.Size = new Size(358, 23);
            txt_ConfSenha.TabIndex = 7;
            // 
            // txt_Senha
            // 
            txt_Senha.Location = new Point(132, 213);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.Size = new Size(358, 23);
            txt_Senha.TabIndex = 6;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(132, 130);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(358, 23);
            txt_Email.TabIndex = 5;
            // 
            // txt_Nome
            // 
            txt_Nome.Location = new Point(132, 52);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(358, 23);
            txt_Nome.TabIndex = 4;
            // 
            // lb_ConfirmarSenha
            // 
            lb_ConfirmarSenha.AutoSize = true;
            lb_ConfirmarSenha.Font = new Font("Segoe UI", 14F);
            lb_ConfirmarSenha.Location = new Point(132, 265);
            lb_ConfirmarSenha.Name = "lb_ConfirmarSenha";
            lb_ConfirmarSenha.Size = new Size(167, 25);
            lb_ConfirmarSenha.TabIndex = 3;
            lb_ConfirmarSenha.Text = "Confirmar Senha *";
            // 
            // lb_Senha
            // 
            lb_Senha.AutoSize = true;
            lb_Senha.Font = new Font("Segoe UI", 14F);
            lb_Senha.Location = new Point(132, 185);
            lb_Senha.Name = "lb_Senha";
            lb_Senha.Size = new Size(77, 25);
            lb_Senha.TabIndex = 2;
            lb_Senha.Text = "Senha *";
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Font = new Font("Segoe UI", 14F);
            lb_Email.Location = new Point(132, 102);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(71, 25);
            lb_Email.TabIndex = 1;
            lb_Email.Text = "Email *";
            // 
            // lb_Nome
            // 
            lb_Nome.AutoSize = true;
            lb_Nome.Font = new Font("Segoe UI", 14F);
            lb_Nome.Location = new Point(132, 24);
            lb_Nome.Name = "lb_Nome";
            lb_Nome.Size = new Size(76, 25);
            lb_Nome.TabIndex = 0;
            lb_Nome.Text = "Nome *";
            lb_Nome.Click += lb_Nome_Click;
            // 
            // frm_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 555);
            Controls.Add(pn_forms);
            Controls.Add(lb_Title);
            Name = "frm_Cadastro";
            Text = "Cadastro";
            pn_forms.ResumeLayout(false);
            pn_forms.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Title;
        private Panel pn_forms;
        private Label lb_Nome;
        private Label lb_ConfirmarSenha;
        private Label lb_Senha;
        private Label lb_Email;
        private TextBox txt_ConfSenha;
        private TextBox txt_Senha;
        private TextBox txt_Email;
        private TextBox txt_Nome;
        private CheckBox chcbx_Termos;
        private Button btn_Cadastrar;
        private LinkLabel lk_Entrar;
    }
}
