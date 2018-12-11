namespace ProgramaCadastro
{
    partial class frmCaptura
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 344);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 25);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "ofdArquivo";
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.ColumnHeadersVisible = false;
            this.dgvResultado.Location = new System.Drawing.Point(12, 12);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(497, 326);
            this.dgvResultado.TabIndex = 1;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(271, 344);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(116, 25);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(393, 344);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(116, 25);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCaptura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 381);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmCaptura";
            this.Text = "Empresa XPTO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnSair;
    }
}

