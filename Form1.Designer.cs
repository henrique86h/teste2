namespace teste2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbox_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.txtbox_senha = new System.Windows.Forms.TextBox();
            this.txtbox_confirmesenha = new System.Windows.Forms.TextBox();
            this.txtbox_usuario = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txtbox_celular = new System.Windows.Forms.TextBox();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_confirmesenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_nome
            // 
            this.txtbox_nome.Location = new System.Drawing.Point(558, 127);
            this.txtbox_nome.Multiline = true;
            this.txtbox_nome.Name = "txtbox_nome";
            this.txtbox_nome.Size = new System.Drawing.Size(299, 26);
            this.txtbox_nome.TabIndex = 0;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(497, 133);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(55, 20);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome:";
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(558, 171);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(299, 26);
            this.txtbox_email.TabIndex = 2;
            // 
            // txtbox_senha
            // 
            this.txtbox_senha.Location = new System.Drawing.Point(558, 312);
            this.txtbox_senha.Name = "txtbox_senha";
            this.txtbox_senha.Size = new System.Drawing.Size(299, 26);
            this.txtbox_senha.TabIndex = 3;
            // 
            // txtbox_confirmesenha
            // 
            this.txtbox_confirmesenha.Location = new System.Drawing.Point(558, 367);
            this.txtbox_confirmesenha.Name = "txtbox_confirmesenha";
            this.txtbox_confirmesenha.Size = new System.Drawing.Size(299, 26);
            this.txtbox_confirmesenha.TabIndex = 4;
            this.txtbox_confirmesenha.TextChanged += new System.EventHandler(this.txtbox_confirmesenha_TextChanged);
            // 
            // txtbox_usuario
            // 
            this.txtbox_usuario.Location = new System.Drawing.Point(558, 262);
            this.txtbox_usuario.Name = "txtbox_usuario";
            this.txtbox_usuario.Size = new System.Drawing.Size(299, 26);
            this.txtbox_usuario.TabIndex = 5;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(498, 177);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(57, 20);
            this.lbl_email.TabIndex = 6;
            this.lbl_email.Text = "E-mail:";
            // 
            // txtbox_celular
            // 
            this.txtbox_celular.Location = new System.Drawing.Point(558, 214);
            this.txtbox_celular.Name = "txtbox_celular";
            this.txtbox_celular.Size = new System.Drawing.Size(299, 26);
            this.txtbox_celular.TabIndex = 7;
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Location = new System.Drawing.Point(492, 220);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(62, 20);
            this.lbl_celular.TabIndex = 8;
            this.lbl_celular.Text = "Celular:";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(487, 268);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(68, 20);
            this.lbl_usuario.TabIndex = 9;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(497, 318);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(60, 20);
            this.lbl_senha.TabIndex = 10;
            this.lbl_senha.Text = "Senha:";
            // 
            // lbl_confirmesenha
            // 
            this.lbl_confirmesenha.AutoSize = true;
            this.lbl_confirmesenha.Location = new System.Drawing.Point(416, 373);
            this.lbl_confirmesenha.Name = "lbl_confirmesenha";
            this.lbl_confirmesenha.Size = new System.Drawing.Size(138, 20);
            this.lbl_confirmesenha.TabIndex = 11;
            this.lbl_confirmesenha.Text = "Confirme a senha:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 733);
            this.Controls.Add(this.lbl_confirmesenha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_celular);
            this.Controls.Add(this.txtbox_celular);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txtbox_usuario);
            this.Controls.Add(this.txtbox_confirmesenha);
            this.Controls.Add(this.txtbox_senha);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txtbox_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.TextBox txtbox_senha;
        private System.Windows.Forms.TextBox txtbox_confirmesenha;
        private System.Windows.Forms.TextBox txtbox_usuario;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txtbox_celular;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_confirmesenha;
    }
}

