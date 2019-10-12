using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bash
{
    public partial class FormCadPessoa : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Bash\\Bash\\bashbd.mdf;Integrated Security=True;Connect Timeout=30");
        public FormCadPessoa()
        {
            InitializeComponent();
        }
        
        public void Carregadtg()
        {
            string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Bash\\Bash\\bashbd.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "Select * from cadastro";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable cadastro = new DataTable();
            da.Fill(cadastro);
            //dtgCadastro.DataSource = cadastro;
            con.Close();
        }
       
        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastros_Load(object sender, EventArgs e)
        {
            Carregadtg();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("inserir", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text.Trim();
                cmd.Parameters.AddWithValue("@rg", SqlDbType.NChar).Value = txtRg.Text.Trim();
                cmd.Parameters.AddWithValue("@cpf", SqlDbType.NChar).Value = txtcpf.Text.Trim();
                cmd.Parameters.AddWithValue("@telefone", SqlDbType.NChar).Value = txtNome.Text.Trim();
                cmd.Parameters.AddWithValue("@endereco", SqlDbType.NChar).Value = txtEndereco.Text.Trim();
                cmd.Parameters.AddWithValue("@celular", SqlDbType.NChar).Value = txtCelular.Text.Trim();
                cmd.Parameters.AddWithValue("@numero", SqlDbType.Int).Value = txtNumero.Text.Trim();
                cmd.Parameters.AddWithValue("@cidade", SqlDbType.NChar).Value = txtCidade.Text.Trim();
                cmd.Parameters.AddWithValue("@estado", SqlDbType.NChar).Value = txtEstado.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Inserido!!");
                Carregadtg();
                con.Close();
                txtId.Text = "";
                txtcpf.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtCelular.Text = "";
                txtRg.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                txtEstado.Text = "";
                txtCidade.Text = "";
                txtTelefone.Text = "";
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pesquisar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtId.Text = rd["id"].ToString();
                    txtNome.Text = rd["nome"].ToString();
                    txtcpf.Text = rd["cpf"].ToString();
                    txtRg.Text = rd["rg"].ToString();
                    txtTelefone.Text = rd["telefone"].ToString();
                    txtCelular.Text = rd["celular"].ToString();
                    txtEndereco.Text = rd["endereco"].ToString();
                    txtNumero.Text = rd["numero"].ToString();
                    txtCidade.Text = rd["cidade"].ToString();
                    txtEstado.Text = rd["estado"].ToString();

                }
                else
                {
                    MessageBox.Show("Registro não encontrado");
                    txtId.Text = "";
                    txtcpf.Text = "";
                    txtNome.Text = "";
                    txtEndereco.Text = "";
                    txtCelular.Text = "";
                    txtRg.Text = "";
                    txtEndereco.Text = "";
                    txtNumero.Text = "";
                    txtEstado.Text = "";
                    txtCidade.Text = "";
                    txtTelefone.Text = "";
                }
                con.Close();

            }
            finally
            {
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("editar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", SqlDbType.Int).Value = txtId.Text.Trim();
                cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text.Trim();
                cmd.Parameters.AddWithValue("@rg", SqlDbType.NChar).Value = txtRg.Text.Trim();
                cmd.Parameters.AddWithValue("@cpf", SqlDbType.NChar).Value = txtcpf.Text.Trim();
                cmd.Parameters.AddWithValue("@telefone", SqlDbType.NChar).Value = txtNome.Text.Trim();
                cmd.Parameters.AddWithValue("@endereco", SqlDbType.NChar).Value = txtEndereco.Text.Trim();
                cmd.Parameters.AddWithValue("@celular", SqlDbType.NChar).Value = txtCelular.Text.Trim();
                cmd.Parameters.AddWithValue("@numero", SqlDbType.Int).Value = txtNumero.Text.Trim();
                cmd.Parameters.AddWithValue("@cidade", SqlDbType.NChar).Value = txtCidade.Text.Trim();
                cmd.Parameters.AddWithValue("@estado", SqlDbType.NChar).Value = txtEstado.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Alterado!!");
                Carregadtg();
                con.Close();
                txtId.Text = "";
                txtcpf.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtCelular.Text = "";
                txtRg.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                txtEstado.Text = "";
                txtCidade.Text = "";
                txtTelefone.Text = "";
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("excluir", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.txtId.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Apagado!!");
                Carregadtg();
                con.Close();
                txtId.Text = "";
                txtcpf.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtCelular.Text = "";
                txtRg.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                txtEstado.Text = "";
                txtCidade.Text = "";
                txtTelefone.Text = "";

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void DtgCadastro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dtgCadastro.Rows[e.RowIndex];
            //    txtId.Text = row.Cells[0].Value.ToString();
            //    txtNome.Text = row.Cells[1].Value.ToString();
            //    txtcpf.Text = row.Cells[2].Value.ToString();
            //    txtRg.Text = row.Cells[3].Value.ToString();
            //    txtCelular.Text = row.Cells[4].Value.ToString();
            //    txtTelefone.Text = row.Cells[5].Value.ToString();
            //    txtEndereco.Text = row.Cells[6].Value.ToString();
            //    txtNumero.Text = row.Cells[7].Value.ToString();
            //    txtEstado.Text = row.Cells[8].Value.ToString();
            //    txtCidade.Text = row.Cells[9].Value.ToString();

            //}
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
