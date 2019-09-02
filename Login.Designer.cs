namespace cc
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.painel_login = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.text_senha = new System.Windows.Forms.TextBox();
            this.text_login = new System.Windows.Forms.TextBox();
            this.painel_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_login
            // 
            this.painel_login.BackColor = System.Drawing.Color.Transparent;
            this.painel_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painel_login.BackgroundImage")));
            this.painel_login.Controls.Add(this.btn_login);
            this.painel_login.Controls.Add(this.text_senha);
            this.painel_login.Controls.Add(this.text_login);
            this.painel_login.Location = new System.Drawing.Point(12, 12);
            this.painel_login.Name = "painel_login";
            this.painel_login.Size = new System.Drawing.Size(778, 442);
            this.painel_login.TabIndex = 0;
            // 
            // btn_login
            // 
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.btn_login.Location = new System.Drawing.Point(570, 347);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(175, 67);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Entrar";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Button1_Click);
            // 
            // text_senha
            // 
            this.text_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.text_senha.Location = new System.Drawing.Point(260, 248);
            this.text_senha.Name = "text_senha";
            this.text_senha.PasswordChar = '*';
            this.text_senha.Size = new System.Drawing.Size(476, 22);
            this.text_senha.TabIndex = 1;
            // 
            // text_login
            // 
            this.text_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.text_login.Location = new System.Drawing.Point(260, 172);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(476, 22);
            this.text_login.TabIndex = 0;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 610);
            this.Controls.Add(this.painel_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frm_login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_login_KeyDown);
            this.Resize += new System.EventHandler(this.Frm_login_Resize);
            this.painel_login.ResumeLayout(false);
            this.painel_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel_login;
        private System.Windows.Forms.TextBox text_senha;
        private System.Windows.Forms.TextBox text_login;
        private System.Windows.Forms.Button btn_login;
    }
}

