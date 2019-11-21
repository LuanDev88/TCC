using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bash
{
    public partial class FormEstoque : Form
    {

        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Database=bash;Uid=root;Pwd=;");


        public FormEstoque()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from produto where id_produto = ?;", con);
                cmd.Parameters.Add("id_produto", MySqlDbType.Int32).Value = txtPesquisar.Text;
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {

                    txtIdProduto.Text = rd["id_produto"].ToString();
                    txtNomeProduto.Text = rd["nome"].ToString();
                    txtFabricante.Text = rd["fabricante"].ToString();
                    txtValorCompra.Text = rd["valor_compra"].ToString();
                    txtValorVenda.Text = rd["valor_venda"].ToString();
                    txtObs.Text = rd["descricao"].ToString();

                }
                else
                {
                    MessageBox.Show("Registro não encontrado");
                    con.Close();

                }
                con.Close();

            }
            finally
            {
            }
        }

        private void txtPesquisar_Enter(object sender, System.EventArgs e)
        {
           
        }

        private void txtPesquisar_Click(object sender, System.EventArgs e)
        {
            txtPesquisar.Text = "";
        }
    }
}
