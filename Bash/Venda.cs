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
                    lblIdCliente.Text = rd["id"].ToString();
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

            txtValorVenda.Text = Convert.ToString(Total);
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
            item.Cells[4].Value = txtValorVenda.Text;
            dtgVenda.Rows.Add(item);

            decimal soma = 0;
            foreach (DataGridViewRow dr in dtgVenda.Rows) soma += Convert.ToDecimal(dr.Cells[4].Value);
            txtValorTotal.Text = Convert.ToString(soma);


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

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO venda(valor_venda, data_venda, fk_id_cliente) OUTPUT INSERTED.id_venda VALUES (@valor_venda, @data_venda, @fk_id_cliente)", con);
            cmd.Parameters.Add("@valor_venda", MySqlDbType.Decimal).Value = Convert.ToDecimal(txtValorTotal.Text);
            cmd.Parameters.Add("@data_venda", MySqlDbType.Date).Value = DateTime.Now;
            cmd.Parameters.Add("@fk_id_cliente", MySqlDbType.Int32).Value = Convert.ToInt32(lblIdCliente.Text);
            int idvenda = (int)cmd.ExecuteScalar();
            foreach (DataGridViewRow dr in dtgVenda.Rows)
            {
                MySqlCommand cmdItens = new MySqlCommand("INSERT INTO itens_venda(quantidade_vendida, fk_venda, fk_id_produto, valor_produto, valor_total) VALUES (@quantidade_vendida, @fk_venda, @fk_id_produto, @valor_produto, @valor_total)", con);
                string ven = "update produto set quantidade = (quantidade - @quantidade2) from produto where id_produto = @id_produto2";
                MySqlCommand cmditemvenda = new MySqlCommand(ven, con);
                cmditemvenda.Parameters.Add("@quantidade2", MySqlDbType.Int32).Value = Convert.ToInt32(dr.Cells[3].Value);
                cmditemvenda.Parameters.Add("@id_produto2", MySqlDbType.Int32).Value = Convert.ToInt32(dr.Cells[0].Value);
                cmdItens.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = Convert.ToInt32(dr.Cells[3].Value);
                cmdItens.Parameters.Add("@id_produto", MySqlDbType.Int32).Value = Convert.ToInt32(dr.Cells[0].Value);
                cmdItens.Parameters.Add("@id_venda", MySqlDbType.Int32).Value = idvenda;
                cmdItens.Parameters.Add("@valor_produto", MySqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[2].Value);
                cmdItens.Parameters.Add("@valor_total", MySqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[4].Value);
                MySqlCommand estoque = new MySqlCommand("select produto.id_produto, produto.quantidade, itens_venda.fk_id_produto, itens_venda.quantidade_vendida, itens_venda.fk_venda, (produto.quantidade - itens_venda.quantidade_vendida) as estoque from produto inner join itens_venda on itens_venda.fk_id_produto = produto.id_produto where itens_venda.fk_venda = @id_venda;, update produto set produto.quantidade = (produto.quantidade - itens_venda.quantidade_vendida) from produto inner join itens_venda on itens_venda.fk_id_produto = produto.id_produto where itens_venda.fk_venda = @id_venda;");
                estoque.Parameters.Add("@id_venda", MySqlDbType.Int32).Value = idvenda;
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                cmdItens.ExecuteNonQuery();
                estoque.ExecuteNonQuery();
                con.Close();

            }

        }
    }
}
