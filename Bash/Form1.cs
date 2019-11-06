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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void DtgPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            FormCadPessoa Pessoa = new FormCadPessoa();
            Pessoa.txtNome.Text = this.DtgPessoa.CurrentRow.Cells[1].Value.ToString();
            Pessoa.txtcpf.Text = this.DtgPessoa.CurrentRow.Cells[2].Value.ToString();
            Pessoa.txtRg.Text = this.DtgPessoa.CurrentRow.Cells[3].Value.ToString();
            Pessoa.txtCelular.Text = this.DtgPessoa.CurrentRow.Cells[4].Value.ToString();
            Pessoa.txtTelefone.Text = this.DtgPessoa.CurrentRow.Cells[5].Value.ToString();
            Pessoa.txtEndereco.Text = this.DtgPessoa.CurrentRow.Cells[6].Value.ToString();
            Pessoa.txtNumero.Text = this.DtgPessoa.CurrentRow.Cells[7].Value.ToString();
            Pessoa.txtEstado.Text = this.DtgPessoa.CurrentRow.Cells[8].Value.ToString();
            Pessoa.txtCidade.Text = this.DtgPessoa.CurrentRow.Cells[9].Value.ToString();
            Pessoa.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
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
                DtgPessoa.DataSource = cadastro;
                con.Close();
            
        }
    }
}
