using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bash
{
    public partial class Venda : Form
    {

        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Database=bash;Uid=root;Pwd=;");

        public Venda()
        {
            InitializeComponent();
        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisarProduto.Text = "";

        }

        private void da_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from produto where id_produto = ?;", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id_produto", MySqlDbType.Int32).Value = txtPesquisarProduto.Text;

                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    lblId.Text = rd["id_produto"].ToString();
                    lblNomeProduto.Text = rd["nome"].ToString();
                    lblValorProduto.Text = rd["valor_venda"].ToString();
                    lblDescricao.Text = rd["descricao"].ToString();                   
                }
                else
                {
                    MessageBox.Show("Registro não encontrado");
                    con.Close();
                    lblId.Text = "";
                    lblNomeProduto.Text = "";
                    lblValorProduto.Text = "";
                    lblDescricao.Text = "";

                }
                con.Close();

            }
            finally
            {
            }
        }

       

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from cliente where id = ?;", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", MySqlDbType.Int32).Value = txtPesquiseCliente.Text;

                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {                    
                    txtPesquisarProduto.Text = "Pesquise o Clinte Pelo Numero de identificação 'ID'";
                    lblNomeCliente.Text = rd["nome"].ToString();
                    lblCpfCliente.Text = rd["cpf"].ToString();
                }
                else
                {


                }
                con.Close();

            }
            finally
            {
            }
        }

        private void lblNomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquiseCliente_Enter(object sender, EventArgs e)
        {
            txtPesquiseCliente.Text = "";
        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        { 
            if (txtQtd.Text == "")
            {
                return;
            }
            Decimal ValorProduto = Convert.ToDecimal(lblValorProduto.Text);
            int Quantidade = Convert.ToInt32(txtQtd.Text);
           
            Decimal Total;
            Total = ValorProduto * Quantidade;

            txtValorItem.Text = Convert.ToString(Total);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow item = new DataGridViewRow();
            item.CreateCells(dtgVenda);
            item.Cells[0].Value = lblId.Text;
            item.Cells[1].Value = lblNomeProduto.Text;
            item.Cells[2].Value = lblValorProduto.Text;
            item.Cells[3].Value = txtQtd.Text;
            item.Cells[4].Value = txtValorItem.Text;
            dtgVenda.Rows.Add(item);


        }

        private void Venda_Load(object sender, EventArgs e)
        {
            dtgVenda.Columns.Add("Id Produto", "Id Produto");
            dtgVenda.Columns.Add("Produto", "Produto");
            dtgVenda.Columns.Add("Valor Produto", "Valor Produto");
            dtgVenda.Columns.Add("Quantidade", "Quantidade");
            dtgVenda.Columns.Add("Valor Total do Produto", "Valor Total do Produto");
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int linha = dtgVenda.CurrentRow.Index;
            dtgVenda.Rows.RemoveAt(linha);
            dtgVenda.Refresh();
            
        }
    }
}
