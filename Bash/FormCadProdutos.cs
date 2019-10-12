using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bash
{
    public partial class FormCadProduto : Form
    {
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=F:\\Bash\\Bash\\bashbd.mdf;Integrated Security = True; Connect Timeout = 30");
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
                SqlCommand cmd = new SqlCommand("Salvar_Prod", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text.Trim();
                cmd.Parameters.AddWithValue("@codigobarras", SqlDbType.Int).Value = txtCodBarras.Text.Trim();
                cmd.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = txtQuantidade.Text.Trim();
                cmd.Parameters.AddWithValue("@valorvenda", SqlDbType.Decimal).Value = txtVenda.Text.Trim();
                cmd.Parameters.AddWithValue("@custounitario", SqlDbType.Decimal).Value = txtCustoUnitario.Text.Trim();
                cmd.Parameters.AddWithValue("@peso", SqlDbType.Int).Value = txtPeso.Text.Trim();
                cmd.Parameters.AddWithValue("@categoria", SqlDbType.VarChar).Value = cbCategoria.Text.Trim();
                cmd.Parameters.AddWithValue("@fabricante", SqlDbType.NChar).Value = txtFabricante.Text.Trim();
                cmd.Parameters.AddWithValue("@obs", SqlDbType.VarChar).Value = txtObs.Text.Trim();
                cmd.ExecuteNonQuery();
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
