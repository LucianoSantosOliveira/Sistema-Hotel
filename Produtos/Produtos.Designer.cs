namespace cc.Produtos
{
    partial class Frm_Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Produtos));
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_altera = new System.Windows.Forms.Button();
            this.btn_grava = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.grid_funcionario = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_buscarNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.cb_fornecedor = new System.Windows.Forms.ComboBox();
            this.Btn_img = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_estoque = new System.Windows.Forms.TextBox();
            this.Img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_funcionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_novo
            // 
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.Location = new System.Drawing.Point(235, 144);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 75;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // btn_altera
            // 
            this.btn_altera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_altera.Enabled = false;
            this.btn_altera.Location = new System.Drawing.Point(316, 144);
            this.btn_altera.Name = "btn_altera";
            this.btn_altera.Size = new System.Drawing.Size(75, 23);
            this.btn_altera.TabIndex = 74;
            this.btn_altera.Text = "Alterar";
            this.btn_altera.UseVisualStyleBackColor = true;
            this.btn_altera.Click += new System.EventHandler(this.Btn_altera_Click);
            // 
            // btn_grava
            // 
            this.btn_grava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_grava.Enabled = false;
            this.btn_grava.Location = new System.Drawing.Point(397, 144);
            this.btn_grava.Name = "btn_grava";
            this.btn_grava.Size = new System.Drawing.Size(75, 23);
            this.btn_grava.TabIndex = 73;
            this.btn_grava.Text = "Gravar";
            this.btn_grava.UseVisualStyleBackColor = true;
            this.btn_grava.Click += new System.EventHandler(this.Btn_grava_Click);
            // 
            // btn_del
            // 
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.Enabled = false;
            this.btn_del.Location = new System.Drawing.Point(478, 144);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 72;
            this.btn_del.Text = "Deletar";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // grid_funcionario
            // 
            this.grid_funcionario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_funcionario.Location = new System.Drawing.Point(12, 173);
            this.grid_funcionario.Name = "grid_funcionario";
            this.grid_funcionario.Size = new System.Drawing.Size(541, 265);
            this.grid_funcionario.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Fornecedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Descrição:";
            // 
            // txt_valor
            // 
            this.txt_valor.Enabled = false;
            this.txt_valor.Location = new System.Drawing.Point(258, 92);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(119, 20);
            this.txt_valor.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Valor:";
            // 
            // txt_nome
            // 
            this.txt_nome.Enabled = false;
            this.txt_nome.Location = new System.Drawing.Point(77, 92);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(119, 20);
            this.txt_nome.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nome:";
            // 
            // txt_buscarNome
            // 
            this.txt_buscarNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscarNome.Location = new System.Drawing.Point(258, 12);
            this.txt_buscarNome.Name = "txt_buscarNome";
            this.txt_buscarNome.Size = new System.Drawing.Size(123, 20);
            this.txt_buscarNome.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Buscar produtos:";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Enabled = false;
            this.txt_descricao.Location = new System.Drawing.Point(258, 66);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(119, 20);
            this.txt_descricao.TabIndex = 62;
            // 
            // cb_fornecedor
            // 
            this.cb_fornecedor.Enabled = false;
            this.cb_fornecedor.FormattingEnabled = true;
            this.cb_fornecedor.Location = new System.Drawing.Point(77, 118);
            this.cb_fornecedor.Name = "cb_fornecedor";
            this.cb_fornecedor.Size = new System.Drawing.Size(119, 21);
            this.cb_fornecedor.TabIndex = 77;
            // 
            // Btn_img
            // 
            this.Btn_img.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Btn_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_img.FlatAppearance.BorderSize = 0;
            this.Btn_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_img.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_img.Location = new System.Drawing.Point(523, 109);
            this.Btn_img.Name = "Btn_img";
            this.Btn_img.Size = new System.Drawing.Size(30, 23);
            this.Btn_img.TabIndex = 78;
            this.Btn_img.Text = "+";
            this.Btn_img.UseVisualStyleBackColor = false;
            this.Btn_img.Click += new System.EventHandler(this.Btn_img_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Estoque:";
            // 
            // Txt_estoque
            // 
            this.Txt_estoque.Enabled = false;
            this.Txt_estoque.Location = new System.Drawing.Point(77, 66);
            this.Txt_estoque.Name = "Txt_estoque";
            this.Txt_estoque.Size = new System.Drawing.Size(119, 20);
            this.Txt_estoque.TabIndex = 66;
            // 
            // Img
            // 
            this.Img.Location = new System.Drawing.Point(397, 12);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(120, 120);
            this.Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img.TabIndex = 76;
            this.Img.TabStop = false;
            // 
            // Frm_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.Btn_img);
            this.Controls.Add(this.cb_fornecedor);
            this.Controls.Add(this.Img);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_altera);
            this.Controls.Add(this.btn_grava);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.grid_funcionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_estoque);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_buscarNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Frm_Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_funcionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_altera;
        private System.Windows.Forms.Button btn_grava;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DataGridView grid_funcionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_buscarNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.PictureBox Img;
        private System.Windows.Forms.ComboBox cb_fornecedor;
        private System.Windows.Forms.Button Btn_img;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_estoque;
    }
}