using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cc.Produtos
{
    public partial class Frm_Produtos : Form
    {
        public Frm_Produtos()
        {
            InitializeComponent();
            Btn_img.Visible = false;
            this.KeyPreview = true;
        }
        private void limpafoto()
        {
            Img.Image = Properties.Resources.sem_foto;
            Btn_img.Visible = false;
        }
       
        private void Frm_Produtos_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            habilitacampo();
            Img.Visible = true;
            limpafoto();
            Btn_img.Visible = true;
            btn_grava.Enabled = true;
        }
        private void Btn_grava_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "" || txt_valor.Text == "")
            {
                MessageBox.Show("Preencher os campo Nome e Valor", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            desabilitacampos();
            limpa();
            Img.Visible = false;
            Btn_img.Visible = false;
            btn_grava.Enabled = false;
        }
        private void Btn_altera_Click(object sender, EventArgs e)
        {
            habilitacampo();
            btn_grava.Enabled = true;
            Btn_img.Enabled = true;
            btn_del.Enabled = false;
        }

        //metodos___________________________________________________________________

        private void desabilitacampos()
        {
            txt_descricao.Enabled = false;
            Txt_estoque.Enabled = false;
            txt_nome.Enabled = false;
            txt_valor.Enabled = false;
            cb_fornecedor.Enabled = false;
        }
        private void habilitacampo()
        {
            txt_descricao.Enabled = true;
            Txt_estoque.Enabled = true;
            txt_nome.Enabled = true;
            txt_valor.Enabled = true;
            cb_fornecedor.Enabled = true;
        }
        private void limpa()
        {
            txt_descricao.Text = "";
            Txt_estoque.Text = "";
            txt_nome.Text = "";
            txt_valor.Text = "";
            cb_fornecedor.Text = "";
        }
        private void verificacoes()
        {
            if (txt_nome.Text == "" || txt_valor.Text == "")
            {
               MessageBox.Show("Preencher os campo Nome e Valor", "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }
        }

        private void Btn_img_Click(object sender, EventArgs e)
        {
            //criou variável para chamar a imagem.
            OpenFileDialog chamaimagem = new OpenFileDialog();
            chamaimagem.Filter = "Imagem (*.jpg;*.png)|*jgp;*.png|Todos os Arquivos (*.*)|*.*";
            if (chamaimagem.ShowDialog() == DialogResult.OK)
            {
                string foto = chamaimagem.FileName;
                Img.ImageLocation = foto;
            }
        }
    }
}
