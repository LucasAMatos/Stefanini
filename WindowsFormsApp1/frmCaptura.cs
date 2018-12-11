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
    public partial class frmCaptura : Form
    {
        string Tipo;
        public frmCaptura(string tipo)
        {
            Tipo = tipo;
            InitializeComponent();
            this.Text += string.Concat(" - ", tipo);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LeituraArquivo pLeituraArquivo = new LeituraArquivo();
            pLeituraArquivo.LerAquivo();
            dgvResultado.DataSource = pLeituraArquivo.PreencheTabela();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Gravar os dados apresentados em tela?", "Gravar dados", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    GravaArquivo grArq = new GravaArquivo();
                    grArq.GravarDados(Tipo, (DataTable)dgvResultado.DataSource);
                    MessageBox.Show("Captura Realizada com sucesso.");
                    Close();
                }
                catch (Exception E)
                {
                    MessageBox.Show("Houve Erro na captura. Favor validar com o suporte.");
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if ((dgvResultado.DataSource != null) && ((DataTable)dgvResultado.DataSource).Rows.Count > 0)
            {
                if (MessageBox.Show("Todos os dados capturados serão perdidos. Deseja Prosseguir?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }
    }
}
