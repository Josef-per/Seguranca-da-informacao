namespace Aplicativo_de_Login
{
    partial class frm_Entrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_Title = new Label();
            pn_forms = new Panel();
            lk_Cadastrar = new LinkLabel();
            chcbx_Manter = new CheckBox();
            btn_Entrar = new Button();
            txt_Senha = new TextBox();
            txt_Email = new TextBox();
            lb_Senha = new Label();
            lb_Email = new Label();
            pn_forms.SuspendLayout();
            SuspendLayout();
            // 
            // lb_Title
            // 
            lb_Title.AutoSize = true;
            lb_Title.Font = new Font("Segoe UI", 22F);
            lb_Title.Location = new Point(330, 9);
            lb_Title.Name = "lb_Title";
            lb_Title.Size = new Size(95, 41);
            lb_Title.TabIndex = 1;
            lb_Title.Text = "Entrar";
            // 
            // pn_forms
            // 
            pn_forms.Controls.Add(lk_Cadastrar);
            pn_forms.Controls.Add(chcbx_Manter);
            pn_forms.Controls.Add(btn_Entrar);
            pn_forms.Controls.Add(txt_Senha);
            pn_forms.Controls.Add(txt_Email);
            pn_forms.Controls.Add(lb_Senha);
            pn_forms.Controls.Add(lb_Email);
            pn_forms.Location = new Point(80, 53);
            pn_forms.Name = "pn_forms";
            pn_forms.Size = new Size(646, 314);
            pn_forms.TabIndex = 2;
            // 
            // lk_Cadastrar
            // 
            lk_Cadastrar.AutoSize = true;
            lk_Cadastrar.Location = new Point(132, 194);
            lk_Cadastrar.Name = "lk_Cadastrar";
            lk_Cadastrar.Size = new Size(174, 15);
            lk_Cadastrar.TabIndex = 10;
            lk_Cadastrar.TabStop = true;
            lk_Cadastrar.Text = "Não tem uma conta ? Cadastrar";
            lk_Cadastrar.LinkClicked += lk_Cadastrar_LinkClicked;
            // 
            // chcbx_Manter
            // 
            chcbx_Manter.AutoSize = true;
            chcbx_Manter.Location = new Point(132, 157);
            chcbx_Manter.Name = "chcbx_Manter";
            chcbx_Manter.Size = new Size(138, 19);
            chcbx_Manter.TabIndex = 9;
            chcbx_Manter.Text = "Se manter conectado";
            chcbx_Manter.UseVisualStyleBackColor = true;
            // 
            // btn_Entrar
            // 
            btn_Entrar.Font = new Font("Segoe UI", 16F);
            btn_Entrar.Location = new Point(234, 236);
            btn_Entrar.Name = "btn_Entrar";
            btn_Entrar.Size = new Size(156, 44);
            btn_Entrar.TabIndex = 8;
            btn_Entrar.Text = "Entrar";
            btn_Entrar.UseVisualStyleBackColor = true;
            btn_Entrar.Click += btn_Entrar_Click;
            // 
            // txt_Senha
            // 
            txt_Senha.Location = new Point(132, 117);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.PasswordChar = '*';
            txt_Senha.Size = new Size(358, 23);
            txt_Senha.TabIndex = 6;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(132, 53);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(358, 23);
            txt_Email.TabIndex = 5;
            // 
            // lb_Senha
            // 
            lb_Senha.AutoSize = true;
            lb_Senha.Font = new Font("Segoe UI", 14F);
            lb_Senha.Location = new Point(132, 89);
            lb_Senha.Name = "lb_Senha";
            lb_Senha.Size = new Size(77, 25);
            lb_Senha.TabIndex = 2;
            lb_Senha.Text = "Senha *";
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Font = new Font("Segoe UI", 14F);
            lb_Email.Location = new Point(132, 25);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(71, 25);
            lb_Email.TabIndex = 1;
            lb_Email.Text = "Email *";
            // 
            // frm_Entrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pn_forms);
            Controls.Add(lb_Title);
            Name = "frm_Entrar";
            Text = "frm_Entrar";
            pn_forms.ResumeLayout(false);
            pn_forms.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Title;
        private Panel pn_forms;
        private LinkLabel lk_Cadastrar;
        private CheckBox chcbx_Manter;
        private Button btn_Entrar;
        private TextBox txt_Senha;
        private TextBox txt_Email;
        private Label lb_Senha;
        private Label lb_Email;
    }
}