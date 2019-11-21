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
            txtPesquisar.Text = "";

        }

        private void da_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    con.Open();
            //    MySqlCommand cmd = new MySqlCommand("select * from cliente where id_cliente = ?;", con);
            //    //cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.Add("id_cliente", MySqlDbType.Int32).Value = txtId.Text;

            //    MySqlDataReader rd = cmd.ExecuteReader();
            //    if (rd.Read())
            //    {
            //        txtId.Text = rd["id_cliente"].ToString();
            //        txtNome.Text = rd["nome"].ToString();
            //        txtcpf.Text = rd["cpf"].ToString();
            //        txtCelular.Text = rd["celular"].ToString();
            //        txtEndereco.Text = rd["endereco"].ToString();
            //        txtNumero.Text = rd["numero"].ToString();
            //        txtCidade.Text = rd["cidade"].ToString();
            //        txtEstado.Text = rd["estado"].ToString();
            //        txtSobrenome.Text = rd["sobrenome"].ToString();
            //        txtCep.Text = rd["cep"].ToString();
            //        txtBairro.Text = rd["bairro"].ToString();
            //        cbSexo.Text = rd["sexo"].ToString();
            //        //dtpNascimento.Text = rd["data_nascimento"].ToString();

            //    }
            //    else
            //    {
            //        MessageBox.Show("Registro não encontrado");
            //        con.Close();
            //        txtId.Text = "";
            //        txtcpf.Text = "";
            //        txtNome.Text = "";
            //        txtEndereco.Text = "";
            //        txtCelular.Text = "";
            //        txtEndereco.Text = "";
            //        txtNumero.Text = "";
            //        txtEstado.Text = "";
            //        txtCidade.Text = "";
            //        txtSobrenome.Text = "";
            //        txtCep.Text = "";
            //        txtCidade.Text = "";
            //        txtBairro.Text = "";
            //        cbSexo.Text = "Escolha o sexo...";
            //        dtpNascimento.Value = DateTime.Now;

            //    }
            //    con.Close();

            //}
            //finally
            //{
            //}
        }
    }
}
