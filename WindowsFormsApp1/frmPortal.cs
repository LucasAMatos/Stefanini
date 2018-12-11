using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaCadastro
{
    public partial class frmPortal : Form
    {
        public frmPortal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCaptura frmCli = new frmCaptura("Cliente");
            frmCli.Show();
        }

        private void brnProdutos_Click(object sender, EventArgs e)
        {
            frmCaptura frmProduto = new frmCaptura("Produto");
            frmProduto.Show();
        }
        
    }
}
