using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cc.Cadastros
{
    public partial class Frm_cargos : Form
    {
        Class1 conc = new Class1();
        string sql;
        MySqlCommand cmd;
        string id;


        public Frm_cargos()
        {
            InitializeComponent();
            grid_funcionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid();
            
        }
        private void formatadat()
        {
            grid_funcionario.Columns[0].HeaderText = "ID";
            grid_funcionario.Columns[1].HeaderText = "Cargos";
            grid_funcionario.Columns[1].Width = 200;
            grid_funcionario.Columns[0].Visible = false;
        }
        private void datagrid()
        {
            conc.abrircon();
            sql = "SELECT *FROM cargos order by cargos asc";
            cmd = new MySqlCommand(sql, conc.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_funcionario.DataSource = dt;
            formatadat();
            conc.fechacon();

        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            if (txt_nomec.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Inserir nome do cargo." , "Erro de preenchimento.",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_nomec.Focus();
                return;
            }
            btn_grava.Enabled = true;
        }

        private void Btn_grava_Click(object sender, EventArgs e)
        {
           

            if (txt_nomec.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Inserir nome do cargo.", "Erro de preenchimento.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_nomec.Focus();
                return;
            }
            
            
            //BACKEND

            //BOTAO SALVAR-------------------------------
            conc.abrircon();
            sql = "INSERT INTO cargos (cargos) VALUE(@cargos)";
            cmd = new MySqlCommand(sql, conc.con);
            cmd.Parameters.AddWithValue("@cargos", txt_nomec.Text);
            cmd.ExecuteNonQuery();
            conc.fechacon();
            txt_nomec.Text = "";
            datagrid();
            
            
        }

        

        private void Btn_altera_Click(object sender, EventArgs e)
        {
           
            btn_altera.Enabled = false;
            btn_del.Enabled = false;
            btn_grava.Enabled = false;
            conc.abrircon();
            sql = "UPDATE cargos SET cargos = @cargos where id = @id";
            cmd = new MySqlCommand(sql, conc.con);
            cmd.Parameters.AddWithValue("@cargos",txt_nomec.Text);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            datagrid();
            conc.fechacon();
            

        }
        private void verifica ()
        {
            if (btn_grava.Enabled == true) 
            {
                btn_altera.Enabled = false;
                btn_del.Enabled = false;
            }
                

            
        }

        private void Btn_del_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja excluir registro?","Excluir",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                btn_del.Enabled = false;
            }
            else
            {
                btn_del.Enabled = false;
            }
            conc.abrircon();
            sql = "DELETE FROM cargos where id  = @id";
            cmd = new MySqlCommand(sql, conc.con);
            cmd.Parameters.AddWithValue("@id",id);
            cmd.ExecuteNonQuery();
            datagrid();
            conc.fechacon();

        }

        private void Frm_cargos_Click(object sender, EventArgs e)
        {
            btn_altera.Enabled = false;
            btn_del.Enabled = false;
        }

        private void Grid_funcionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_funcionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btn_altera.Enabled = true;
            btn_grava.Enabled = false;
            btn_del.Enabled = true;
            //sempre converter valor para string
            id = grid_funcionario.CurrentRow.Cells[0].Value.ToString();
            txt_nomec.Text = grid_funcionario.CurrentRow.Cells[1].Value.ToString();
            verifica();
        }
    }
}
