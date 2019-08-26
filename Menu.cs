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
    public partial class Frm_menu : Form

    {

        frm_login log = new frm_login();
        public Frm_menu()
        {
            
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            menuStrip1.BackColor = Color.FromArgb(100, 149, 237);
            this.KeyPreview = true;
            

        }

        private void Frm_menu_Load(object sender, EventArgs e)
        {
            pnl_menu.BackColor = Color.FromArgb(100, 149, 237);
            pnl_info.BackColor = Color.FromArgb(100, 149, 237);
            
            

        }

        private void Frm_menu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

       

        private void Sair_topMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frm_funcionarios form = new Cadastros.frm_funcionarios();
            form.Show();
            
        }

        private void Frm_menu_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                log.Fechar();
             
            }
        }

        private void CargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.Frm_cargos form = new Cadastros.Frm_cargos();
            form.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Produtos.Frm_Produtos form = new Produtos.Frm_Produtos();
            form.Show();
        }

        private void NovoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.Frm_Produtos form = new Produtos.Frm_Produtos();
            form.Show();
        }

       
    }
    }
