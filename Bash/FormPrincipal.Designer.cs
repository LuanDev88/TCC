﻿namespace Bash
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnTesteBanco = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCadastros);
            this.panel1.Controls.Add(this.btnRelatorio);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCaixa);
            this.panel1.Controls.Add(this.btnTesteBanco);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 752);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Painel Principal";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(293, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1061, 752);
            this.panel3.TabIndex = 2;
            // 
            // btnCadastros
            // 
            this.btnCadastros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastros.FlatAppearance.BorderSize = 0;
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.ForeColor = System.Drawing.Color.Snow;
            this.btnCadastros.Image = global::Bash.Properties.Resources.desktop;
            this.btnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastros.Location = new System.Drawing.Point(39, 246);
            this.btnCadastros.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(196, 66);
            this.btnCadastros.TabIndex = 8;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.UseVisualStyleBackColor = true;
            this.btnCadastros.Click += new System.EventHandler(this.BtnCadastros_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.Snow;
            this.btnRelatorio.Image = global::Bash.Properties.Resources.marketing;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelatorio.Location = new System.Drawing.Point(39, 370);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(196, 66);
            this.btnRelatorio.TabIndex = 7;
            this.btnRelatorio.Text = "Relatorios";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.BtnEstoque_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Image = global::Bash.Properties.Resources.logout;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(39, 661);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(196, 66);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCaixa.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.Color.Snow;
            this.btnCaixa.Image = global::Bash.Properties.Resources.pos;
            this.btnCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaixa.Location = new System.Drawing.Point(39, 124);
            this.btnCaixa.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(196, 66);
            this.btnCaixa.TabIndex = 1;
            this.btnCaixa.Text = "Caixa de Venda";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.BtnCaixa_Click);
            // 
            // btnTesteBanco
            // 
            this.btnTesteBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTesteBanco.FlatAppearance.BorderSize = 0;
            this.btnTesteBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesteBanco.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTesteBanco.ForeColor = System.Drawing.Color.Snow;
            this.btnTesteBanco.Image = global::Bash.Properties.Resources.icons8_banco_de_dados_481;
            this.btnTesteBanco.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTesteBanco.Location = new System.Drawing.Point(39, 522);
            this.btnTesteBanco.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.btnTesteBanco.Name = "btnTesteBanco";
            this.btnTesteBanco.Size = new System.Drawing.Size(196, 66);
            this.btnTesteBanco.TabIndex = 3;
            this.btnTesteBanco.Text = "Teste de \r\nBanco";
            this.btnTesteBanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTesteBanco.UseVisualStyleBackColor = true;
            this.btnTesteBanco.Click += new System.EventHandler(this.BtnTesteBanco_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bash.Properties.Resources.imagem_de_fundo_bash1;
            this.pictureBox1.Location = new System.Drawing.Point(37, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(985, 779);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1357, 752);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bash Sistemas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnTesteBanco;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

