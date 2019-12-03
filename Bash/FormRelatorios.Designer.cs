namespace Bash
{
    partial class FormRelatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cliente = new System.Windows.Forms.TabPage();
            this.DtgPessoa = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.cliente.SuspendLayout();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DtgPessoa = new System.Windows.Forms.DataGridView();
            this.tbCliente = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DtgFuncionario = new System.Windows.Forms.DataGridView();
            this.DtgProduto = new System.Windows.Forms.DataGridView();
            this.DtgVendas = new System.Windows.Forms.DataGridView();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPessoa)).BeginInit();
            this.tbCliente.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabControl1.Controls.Add(this.cliente);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 788);
            this.tabControl1.TabIndex = 1;
            this.tabPage3.Controls.Add(this.DtgProduto);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1264, 762);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Produtos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DtgFuncionario);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1264, 762);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Funcionários";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cliente
            // 
            this.cliente.Controls.Add(this.DtgPessoa);
            this.cliente.Location = new System.Drawing.Point(4, 22);
            this.cliente.Name = "cliente";
            this.cliente.Padding = new System.Windows.Forms.Padding(3);
            this.cliente.Size = new System.Drawing.Size(1264, 762);
            this.cliente.TabIndex = 0;
            this.cliente.Text = "tabPage1";
            this.cliente.UseVisualStyleBackColor = true;
            this.tabPage1.Controls.Add(this.DtgPessoa);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1264, 762);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DtgPessoa
            // 
            this.DtgPessoa.AllowUserToAddRows = false;
            this.DtgPessoa.AllowUserToDeleteRows = false;
            this.DtgPessoa.AllowUserToOrderColumns = true;
            this.DtgPessoa.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DtgPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPessoa.Location = new System.Drawing.Point(3, 3);
            this.DtgPessoa.Name = "DtgPessoa";
            this.DtgPessoa.ReadOnly = true;
            this.DtgPessoa.Size = new System.Drawing.Size(1060, 756);
            this.DtgPessoa.Location = new System.Drawing.Point(0, 3);
            this.DtgPessoa.Name = "DtgPessoa";
            this.DtgPessoa.ReadOnly = true;
            this.DtgPessoa.Size = new System.Drawing.Size(1261, 756);
            this.DtgPessoa.TabIndex = 1;
            this.DtgPessoa.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgPessoa_CellContentDoubleClick);
            this.DtgPessoa.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgPessoa_CellMouseDoubleClick);
            // 
            // tbCliente
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1264, 762);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tbCliente.Controls.Add(this.tabPage1);
            this.tbCliente.Controls.Add(this.tabPage2);
            this.tbCliente.Controls.Add(this.tabPage3);
            this.tbCliente.Controls.Add(this.tabPage4);
            this.tbCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCliente.Location = new System.Drawing.Point(0, 0);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.SelectedIndex = 0;
            this.tbCliente.Size = new System.Drawing.Size(1272, 788);
            this.tbCliente.TabIndex = 1;
            this.tbCliente.Tag = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DtgVendas);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1264, 762);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vendas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DtgFuncionario
            // 
            this.DtgFuncionario.AllowUserToAddRows = false;
            this.DtgFuncionario.AllowUserToDeleteRows = false;
            this.DtgFuncionario.AllowUserToOrderColumns = true;
            this.DtgFuncionario.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DtgFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgFuncionario.Location = new System.Drawing.Point(2, 3);
            this.DtgFuncionario.Name = "DtgFuncionario";
            this.DtgFuncionario.ReadOnly = true;
            this.DtgFuncionario.Size = new System.Drawing.Size(1261, 756);
            this.DtgFuncionario.TabIndex = 2;
            // 
            // DtgProduto
            // 
            this.DtgProduto.AllowUserToAddRows = false;
            this.DtgProduto.AllowUserToDeleteRows = false;
            this.DtgProduto.AllowUserToOrderColumns = true;
            this.DtgProduto.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DtgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgProduto.Location = new System.Drawing.Point(2, 3);
            this.DtgProduto.Name = "DtgProduto";
            this.DtgProduto.ReadOnly = true;
            this.DtgProduto.Size = new System.Drawing.Size(1261, 756);
            this.DtgProduto.TabIndex = 3;
            // 
            // DtgVendas
            // 
            this.DtgVendas.AllowUserToAddRows = false;
            this.DtgVendas.AllowUserToDeleteRows = false;
            this.DtgVendas.AllowUserToOrderColumns = true;
            this.DtgVendas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DtgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgVendas.Location = new System.Drawing.Point(2, 3);
            this.DtgVendas.Name = "DtgVendas";
            this.DtgVendas.ReadOnly = true;
            this.DtgVendas.Size = new System.Drawing.Size(1261, 756);
            this.DtgVendas.TabIndex = 4;
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1272, 788);
            this.Controls.Add(this.tbCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRelatorios";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.cliente.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPessoa)).EndInit();
            this.tbCliente.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage cliente;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DataGridView DtgPessoa;
        private System.Windows.Forms.TabControl tbCliente;
        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.DataGridView DtgFuncionario;
        public System.Windows.Forms.DataGridView DtgProduto;
        public System.Windows.Forms.DataGridView DtgVendas;
    }
}