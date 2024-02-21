namespace Farmacia
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CadastroCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CadastroProduto = new System.Windows.Forms.Button();
            this.Ranking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CadastroCliente
            // 
            this.CadastroCliente.BackColor = System.Drawing.Color.Transparent;
            this.CadastroCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastroCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.CadastroCliente.Location = new System.Drawing.Point(102, 210);
            this.CadastroCliente.Name = "CadastroCliente";
            this.CadastroCliente.Size = new System.Drawing.Size(152, 31);
            this.CadastroCliente.TabIndex = 1;
            this.CadastroCliente.Text = "Cadastrar Cliente";
            this.CadastroCliente.UseVisualStyleBackColor = false;
            this.CadastroCliente.Click += new System.EventHandler(this.CadastroCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(110, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha uma das opções abaixo:";
            // 
            // CadastroProduto
            // 
            this.CadastroProduto.BackColor = System.Drawing.Color.Transparent;
            this.CadastroProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastroProduto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.CadastroProduto.Location = new System.Drawing.Point(102, 262);
            this.CadastroProduto.Name = "CadastroProduto";
            this.CadastroProduto.Size = new System.Drawing.Size(152, 31);
            this.CadastroProduto.TabIndex = 3;
            this.CadastroProduto.Text = "Cadastrar Produto";
            this.CadastroProduto.UseVisualStyleBackColor = false;
            // 
            // Ranking
            // 
            this.Ranking.BackColor = System.Drawing.Color.Transparent;
            this.Ranking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ranking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ranking.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ranking.ForeColor = System.Drawing.SystemColors.Control;
            this.Ranking.Location = new System.Drawing.Point(260, 210);
            this.Ranking.Name = "Ranking";
            this.Ranking.Size = new System.Drawing.Size(161, 31);
            this.Ranking.TabIndex = 4;
            this.Ranking.Text = "Ranking";
            this.Ranking.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(522, 519);
            this.Controls.Add(this.Ranking);
            this.Controls.Add(this.CadastroProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CadastroCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Farmacia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CadastroCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CadastroProduto;
        private System.Windows.Forms.Button Ranking;
    }
}

