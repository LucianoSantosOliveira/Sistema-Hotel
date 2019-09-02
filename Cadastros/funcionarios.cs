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
    public partial class frm_funcionarios : Form
    {
        Class1 conc = new Class1();
        MySqlCommand cmd;
        string sql;


        public frm_funcionarios()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            this.KeyPreview = true;
            comboboxload();
            
        }
        private void comboboxload()
        {
            conc.abrircon();
            sql = "SELECT *FROM cargos order by cargos asc";
            cmd = new MySqlCommand(sql, conc.con);
            MySqlDataAdapter cb = new MySqlDataAdapter();
            cb.SelectCommand = cmd;
            DataTable da = new DataTable();
            cb.Fill(da);
            cb_cargo.DataSource = da;
            cb_cargo.DisplayMember = "cargos";
            conc.fechacon();

        }

        private void habilitacampo()
        {
            mktxt_cpf.Enabled = true;
            mktxt_telefone.Enabled = true;
            txt_enreco.Enabled = true;
            txt_nome.Enabled = true;
            cb_cargo.Enabled = true;
        }
        private void desabilitacampo()
        {
            mktxt_cpf.Enabled = false;
            mktxt_telefone.Enabled = false;
            txt_enreco.Enabled = false;
            txt_nome.Enabled = false;
            cb_cargo.Enabled = false;
        }
        private void limpacampo()
        {
            mktxt_cpf.Text = "";
            mktxt_telefone.Text = "";
            txt_enreco.Text = "";
            txt_nome.Text = "";

        }
        

        private void Frm_funcionarios_Load(object sender, EventArgs e)
        {
            grid_funcionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Frm_funcionarios_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        //gravar e novo.

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            habilitacampo();
            btn_grava.Enabled = true;
            btn_altera.Enabled = false;
            btn_del.Enabled = false;

        }

        private void Btn_grava_Click(object sender, EventArgs e)
        {

            if (txt_nome.Text.ToString().Trim() == "" || mktxt_cpf.Text.ToString().Trim() == "")
            {
                MessageBox.Show ("Preencha pelo menos:Nome e Cpf. " , "Erro de preenchimento", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                txt_nome.Focus();
                return;
            }
            btn_grava.Enabled = false;
            sql = "INSERT INTO fucionarios (??) VALUE (@??)";
            cmd = new MySqlCommand(sql, conc.con);
            cmd.Parameters.AddWithValue("@??", txt_enreco);
            cmd.ExecuteNonQuery();
            conc.fechacon();
            limpacampo();
            desabilitacampo();
        }
        //opções de busca 
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_buscarNome.Visible = true;
            mktxt_cpfBusca.Visible = false;
            txt_buscarNome.Text = "";
            mktxt_cpfBusca.Text = "";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_buscarNome.Visible = false;
            mktxt_cpfBusca.Visible = true;
            txt_buscarNome.Text = "";
            mktxt_cpfBusca.Text = "";
        }

        private void Grid_funcionario_Click(object sender, EventArgs e)
        {
            
            btn_altera.Enabled = true;
            btn_del.Enabled = true;
            if (btn_grava.Enabled == true)
            {
                btn_altera.Enabled = false;
                btn_del.Enabled = false;

            }

        }

        private void Btn_altera_Click(object sender, EventArgs e)
        {
                btn_grava.Enabled = true;
                btn_altera.Enabled = false;
                btn_del.Enabled = false;
                habilitacampo();
            
        }

        private void Btn_del_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja excluir registro?", "Excluir", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                btn_del.Enabled = false;
            }
            else
            {
                btn_del.Enabled = false;
            }
        }
    }
}
