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
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Bash\\Bash\\bashbd.mdf;Integrated Security=True;Connect Timeout=30";
                string query = "select * from bebidas";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("Banco de Dados Conectado!");
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
           
        }

       
        private void Button2_Click_1(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            FormCadGeral cad = new FormCadGeral();
            cad.TopLevel = false;
            panel3.Controls.Add(cad);
            cad.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Form1 f = new Form1();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.Show();
        }

        private void BtnCadastros_Enter(object sender, EventArgs e)
        {
         
        }

        private void BtnCadastros_Leave(object sender, EventArgs e)
        {
           
        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            FormPDV pdv = new FormPDV();
            pdv.TopLevel = false;
            panel3.Controls.Add(pdv);
            pdv.Show();
        }
    }
}
