using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bash
{
    public partial class FormCadProduto : Form
    {
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Database=teste;Uid=root;Pwd=;");
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

                MySqlCommand comando;
                comando = new MySqlCommand("INSERT INTO produto(nome) VALUES (@nome)", con);
                comando.Parameters.AddWithValue("@nome", MySqlDbType.VarChar).Value = txtNome.Text;
                //cmd.Parameters.AddWithValue("@descricao", MySqlDbType.Text).Value = Convert.ToString(txtObs.Text.Trim());
                //cmd.Parameters.AddWithValue("@valor_compra", MySqlDbType.Decimal).Value = Convert.ToString(txtCustoUnitario.Text.Trim());
                //cmd.Parameters.AddWithValue("@valor_venda", MySqlDbType.Decimal).Value = Convert.ToString(txtVenda.Text.Trim());
                //cmd.Parameters.AddWithValue("@fabricante", MySqlDbType.VarChar).Value = Convert.ToString(txtFabricante.Text.Trim());
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Inserido!!");
                con.Close();
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
