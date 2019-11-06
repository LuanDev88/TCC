namespace Bash
{
    partial class FormCadGeral
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCadastros_Produtos = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnCadastros_Produtos);
            this.panel1.Controls.Add(this.btnCadastro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 791);
            this.panel1.TabIndex = 3;
            // 
            // BtnCadastros_Produtos
            // 
            this.BtnCadastros_Produtos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadastros_Produtos.FlatAppearance.BorderSize = 0;
            this.BtnCadastros_Produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastros_Produtos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastros_Produtos.ForeColor = System.Drawing.Color.Black;
            this.BtnCadastros_Produtos.Image = global::Bash.Properties.Resources.icons8_procurar_estoque_48;
            this.BtnCadastros_Produtos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCadastros_Produtos.Location = new System.Drawing.Point(184, 85);
            this.BtnCadastros_Produtos.Name = "BtnCadastros_Produtos";
            this.BtnCadastros_Produtos.Size = new System.Drawing.Size(95, 99);
            this.BtnCadastros_Produtos.TabIndex = 4;
            this.BtnCadastros_Produtos.Text = "Cadastro de \r\nEstoque\r\n";
            this.BtnCadastros_Produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCadastros_Produtos.UseVisualStyleBackColor = true;
            this.BtnCadastros_Produtos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.Black;
            this.btnCadastro.Image = global::Bash.Properties.Resources.iconfinder_UI_Basic_outline_77_4733185;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastro.Location = new System.Drawing.Point(67, 85);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(111, 99);
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.Text = "Cadastro de \r\nPessoas Fisicas\r\n";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // FormCadGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1272, 791);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadGeral";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button BtnCadastros_Produtos;
    }
}