using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Bash
{
    public partial class FormRelatorios : Form
    {

        public FormRelatorios()
        {
            InitializeComponent();
        }

        private void DtgPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = "Data Source=bash1.database.windows.net;Initial Catalog=bash;User ID=bash;Password=!Senai456";
            string query = "Select * from pessoa";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable pessoa = new DataTable();
            da.Fill(pessoa);
            DtgPessoa.DataSource = pessoa;
            con.Close();

        }

        private void DtgPessoa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtgPessoa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormCadPessoa Pessoa = new FormCadPessoa();
            Pessoa.txtId.Text = this.DtgPessoa.CurrentRow.Cells[0].Value.ToString();
            Pessoa.txtNome.Text = this.DtgPessoa.CurrentRow.Cells[1].Value.ToString();
            Pessoa.txtcpf.Text = this.DtgPessoa.CurrentRow.Cells[2].Value.ToString();
            
            Pessoa.txtCelular.Text = this.DtgPessoa.CurrentRow.Cells[4].Value.ToString();
            Pessoa.txtEndereco.Text = this.DtgPessoa.CurrentRow.Cells[6].Value.ToString();
            Pessoa.txtNumero.Text = this.DtgPessoa.CurrentRow.Cells[7].Value.ToString();
            Pessoa.txtEstado.Text = this.DtgPessoa.CurrentRow.Cells[8].Value.ToString();
            Pessoa.txtCidade.Text = this.DtgPessoa.CurrentRow.Cells[9].Value.ToString();
            Pessoa.ShowDialog();
        }
    }
}
