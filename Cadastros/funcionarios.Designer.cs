namespace cc.Cadastros
{
    partial class frm_funcionarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscarNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mktxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mktxt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_enreco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_cargo = new System.Windows.Forms.ComboBox();
            this.grid_funcionario = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.mktxt_cpfBusca = new System.Windows.Forms.MaskedTextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_grava = new System.Windows.Forms.Button();
            this.btn_altera = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_funcionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por:";
            // 
            // txt_buscarNome
            // 
            this.txt_buscarNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscarNome.Location = new System.Drawing.Point(137, 21);
            this.txt_buscarNome.Name = "txt_buscarNome";
            this.txt_buscarNome.Size = new System.Drawing.Size(123, 20);
            this.txt_buscarNome.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Enabled = false;
            this.txt_nome.Location = new System.Drawing.Point(52, 73);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(119, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPF:";
            // 
            // mktxt_cpf
            // 
            this.mktxt_cpf.Enabled = false;
            this.mktxt_cpf.Location = new System.Drawing.Point(236, 73);
            this.mktxt_cpf.Mask = "000,000,000-00";
            this.mktxt_cpf.Name = "mktxt_cpf";
            this.mktxt_cpf.Size = new System.Drawing.Size(123, 20);
            this.mktxt_cpf.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefone:";
            // 
            // mktxt_telefone
            // 
            this.mktxt_telefone.Enabled = false;
            this.mktxt_telefone.Location = new System.Drawing.Point(236, 99);
            this.mktxt_telefone.Mask = "(00)00000-0000";
            this.mktxt_telefone.Name = "mktxt_telefone";
            this.mktxt_telefone.Size = new System.Drawing.Size(123, 20);
            this.mktxt_telefone.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Endereço:";
            // 
            // txt_enreco
            // 
            this.txt_enreco.Enabled = false;
            this.txt_enreco.Location = new System.Drawing.Point(432, 99);
            this.txt_enreco.Name = "txt_enreco";
            this.txt_enreco.Size = new System.Drawing.Size(123, 20);
            this.txt_enreco.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cargo:";
            // 
            // cb_cargo
            // 
            this.cb_cargo.Enabled = false;
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Location = new System.Drawing.Point(52, 99);
            this.cb_cargo.Name = "cb_cargo";
            this.cb_cargo.Size = new System.Drawing.Size(119, 21);
            this.cb_cargo.TabIndex = 3;
            // 
            // grid_funcionario
            // 
            this.grid_funcionario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_funcionario.Location = new System.Drawing.Point(14, 154);
            this.grid_funcionario.Name = "grid_funcionario";
            this.grid_funcionario.Size = new System.Drawing.Size(541, 265);
            this.grid_funcionario.TabIndex = 53;
            this.grid_funcionario.Click += new System.EventHandler(this.Grid_funcionario_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(78, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 54;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nome";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(78, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 54;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "CPF";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // mktxt_cpfBusca
            // 
            this.mktxt_cpfBusca.Enabled = false;
            this.mktxt_cpfBusca.Location = new System.Drawing.Point(137, 44);
            this.mktxt_cpfBusca.Mask = "000,000,000-00";
            this.mktxt_cpfBusca.Name = "mktxt_cpfBusca";
            this.mktxt_cpfBusca.Size = new System.Drawing.Size(123, 20);
            this.mktxt_cpfBusca.TabIndex = 51;
            // 
            // btn_del
            // 
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.Enabled = false;
            this.btn_del.Location = new System.Drawing.Point(480, 125);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 55;
            this.btn_del.Text = "Deletar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.Btn_del_Click);
            // 
            // btn_grava
            // 
            this.btn_grava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_grava.Enabled = false;
            this.btn_grava.Location = new System.Drawing.Point(399, 125);
            this.btn_grava.Name = "btn_grava";
            this.btn_grava.Size = new System.Drawing.Size(75, 23);
            this.btn_grava.TabIndex = 55;
            this.btn_grava.Text = "Gravar";
            this.btn_grava.UseVisualStyleBackColor = true;
            this.btn_grava.Click += new System.EventHandler(this.Btn_grava_Click);
            // 
            // btn_altera
            // 
            this.btn_altera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_altera.Enabled = false;
            this.btn_altera.Location = new System.Drawing.Point(318, 125);
            this.btn_altera.Name = "btn_altera";
            this.btn_altera.Size = new System.Drawing.Size(75, 23);
            this.btn_altera.TabIndex = 55;
            this.btn_altera.Text = "Alterar";
            this.btn_altera.UseVisualStyleBackColor = true;
            this.btn_altera.Click += new System.EventHandler(this.Btn_altera_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.Location = new System.Drawing.Point(237, 125);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 55;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // frm_funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 431);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_altera);
            this.Controls.Add(this.btn_grava);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.grid_funcionario);
            this.Controls.Add(this.cb_cargo);
            this.Controls.Add(this.mktxt_telefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mktxt_cpfBusca);
            this.Controls.Add(this.mktxt_cpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_enreco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_buscarNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "funcionarios";
            this.Load += new System.EventHandler(this.Frm_funcionarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_funcionarios_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grid_funcionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mktxt_cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mktxt_telefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_enreco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_cargo;
        private System.Windows.Forms.DataGridView grid_funcionario;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.MaskedTextBox mktxt_cpfBusca;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_grava;
        private System.Windows.Forms.Button btn_altera;
        private System.Windows.Forms.Button btn_novo;
    }
}