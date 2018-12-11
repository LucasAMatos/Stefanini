namespace ProgramaCadastro
{
    partial class frmPortal
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
            this.btnCliente = new System.Windows.Forms.Button();
            this.brnProdutos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnProcedures = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(31, 12);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(156, 35);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Captura de Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // brnProdutos
            // 
            this.brnProdutos.Location = new System.Drawing.Point(31, 53);
            this.brnProdutos.Name = "brnProdutos";
            this.brnProdutos.Size = new System.Drawing.Size(156, 35);
            this.brnProdutos.TabIndex = 1;
            this.brnProdutos.Text = "Captura de Produtos";
            this.brnProdutos.UseVisualStyleBackColor = true;
            this.brnProdutos.Click += new System.EventHandler(this.brnProdutos_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(31, 135);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(156, 30);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Finalizar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnProcedures
            // 
            this.btnProcedures.Location = new System.Drawing.Point(31, 94);
            this.btnProcedures.Name = "btnProcedures";
            this.btnProcedures.Size = new System.Drawing.Size(156, 35);
            this.btnProcedures.TabIndex = 3;
            this.btnProcedures.Text = "Criar Procedures";
            this.btnProcedures.UseVisualStyleBackColor = true;
            this.btnProcedures.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // frmPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 205);
            this.Controls.Add(this.btnProcedures);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.brnProdutos);
            this.Controls.Add(this.btnCliente);
            this.Name = "frmPortal";
            this.Text = "Empresa XPTO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button brnProdutos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnProcedures;
    }
}