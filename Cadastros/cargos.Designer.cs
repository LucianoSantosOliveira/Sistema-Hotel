namespace cc.Cadastros
{
    partial class Frm_cargos
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
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_altera = new System.Windows.Forms.Button();
            this.btn_grava = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.grid_funcionario = new System.Windows.Forms.DataGridView();
            this.txt_nomec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_funcionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_novo
            // 
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.Location = new System.Drawing.Point(12, 123);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 61;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // btn_altera
            // 
            this.btn_altera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_altera.Enabled = false;
            this.btn_altera.Location = new System.Drawing.Point(93, 123);
            this.btn_altera.Name = "btn_altera";
            this.btn_altera.Size = new System.Drawing.Size(75, 23);
            this.btn_altera.TabIndex = 62;
            this.btn_altera.Text = "Alterar";
            this.btn_altera.UseVisualStyleBackColor = true;
            this.btn_altera.Click += new System.EventHandler(this.Btn_altera_Click);
            // 
            // btn_grava
            // 
            this.btn_grava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_grava.Enabled = false;
            this.btn_grava.Location = new System.Drawing.Point(174, 123);
            this.btn_grava.Name = "btn_grava";
            this.btn_grava.Size = new System.Drawing.Size(75, 23);
            this.btn_grava.TabIndex = 63;
            this.btn_grava.Text = "Gravar";
            this.btn_grava.UseVisualStyleBackColor = true;
            this.btn_grava.Click += new System.EventHandler(this.Btn_grava_Click);
            // 
            // btn_del
            // 
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.Enabled = false;
            this.btn_del.Location = new System.Drawing.Point(255, 123);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 64;
            this.btn_del.Text = "Deletar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.Btn_del_Click);
            // 
            // grid_funcionario
            // 
            this.grid_funcionario.AllowUserToAddRows = false;
            this.grid_funcionario.AllowUserToDeleteRows = false;
            this.grid_funcionario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_funcionario.Location = new System.Drawing.Point(12, 152);
            this.grid_funcionario.Name = "grid_funcionario";
            this.grid_funcionario.ReadOnly = true;
            this.grid_funcionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_funcionario.Size = new System.Drawing.Size(318, 265);
            this.grid_funcionario.TabIndex = 60;
            this.grid_funcionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_funcionario_CellClick);
            // 
            // txt_nomec
            // 
            this.txt_nomec.Location = new System.Drawing.Point(53, 6);
            this.txt_nomec.Name = "txt_nomec";
            this.txt_nomec.Size = new System.Drawing.Size(119, 20);
            this.txt_nomec.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Nome:";
            // 
            // Frm_cargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 430);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_altera);
            this.Controls.Add(this.btn_grava);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.grid_funcionario);
            this.Controls.Add(this.txt_nomec);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_cargos";
            this.Text = "Cadastro de Cargos";
            this.Click += new System.EventHandler(this.Frm_cargos_Click);
            ((System.ComponentModel.ISupportInitialize)(this.grid_funcionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_altera;
        private System.Windows.Forms.Button btn_grava;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DataGridView grid_funcionario;
        private System.Windows.Forms.TextBox txt_nomec;
        private System.Windows.Forms.Label label2;
    }
}