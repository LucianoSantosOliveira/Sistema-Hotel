using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cc
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
            painel_login.Visible = false;
            this.KeyPreview = true;
            this.ShowInTaskbar = false;
            this.MinimizeBox = true;
            this.ShowInTaskbar = true;
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            
            painel_login.Location = new Point(this.Width / 2 - 289, this.Height / 2 - 221);
            btn_login.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 98, 255);
            btn_login.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 37, 97);
            painel_login.Visible = true;
            
            
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                logar();          
            }


        }

        private void Frm_login_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            if (e.KeyCode == Keys.Enter)
            {
                logar();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            
        }
        private void logar()
        {
            if (text_senha.Text == "" && text_login.Text == "")
            {
                MessageBox.Show("Inserir Login e senha." , "" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                text_login.Focus();
                return;
            }
            if (text_login.Text == "")
            {
                MessageBox.Show("Inserir Login. " , "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_login.Focus();
                return;
            }
            if (text_senha.Text == "")
            {
                MessageBox.Show("Inserir Senha.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_senha.Focus();
                return;
            }
            Frm_menu frm_Menu = new Frm_menu();
            limpa();
            
            frm_Menu.Show();
            
            
            
        }
        public void Fechar()
        {
            this.Close();
        }

        private void limpa()
        {
            text_login.Text = "";
            text_senha.Text = "";
            text_login.Focus();
        }

        private void Frm_login_Resize(object sender, EventArgs e)
        {           
            painel_login.Location = new Point(this.Width / 2 - 289, this.Height / 2 - 221);
           
        }
    }
    //backend
}
