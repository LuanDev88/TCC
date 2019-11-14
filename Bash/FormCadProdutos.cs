using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bash
{
    public partial class FormCadProduto : Form
    {
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Database=bash;Uid=root;Pwd=;");
        public FormCadProduto()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                
                MySqlCommand cmd = new MySqlCommand("inserir_produto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = txtNome.Text;
                cmd.Parameters.Add("?descricao", MySqlDbType.Text).Value = txtObs.Text.Trim();
                cmd.Parameters.Add("?valor_compra", MySqlDbType.Decimal).Value = txtCustoUnitario.Text.Trim().Replace(".",",");
                cmd.Parameters.Add("?valor_venda", MySqlDbType.Decimal).Value = txtVenda.Text.Trim().Replace(".", ",");
                cmd.Parameters.Add("?fabricante", MySqlDbType.VarChar).Value = txtFabricante.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Inserido!!");
                con.Close();
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                con.Close();
            }
        }
    }
}
