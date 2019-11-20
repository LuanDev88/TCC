using System;
using System.Windows.Forms;

namespace Bash
{
    public partial class Venda : Form
    {
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
    }
}
