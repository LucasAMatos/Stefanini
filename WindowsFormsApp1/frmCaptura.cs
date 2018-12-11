using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaCadastro
{
    public partial class frmCaptura : Form
    {
        string Tipo;
        OpenFileDialog pOpfArquivo;
        DataSet dsCaptura;
        string fileContent;

        public frmCaptura(string tipo)
        {
            Tipo = tipo;
            InitializeComponent();
            this.Text += string.Concat(" - ", tipo);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LeituraArquivo pLeituraArquivo = new LeituraArquivo();
            LerAquivo();
            dsCaptura = pLeituraArquivo.PreencheTabela(fileContent);
            if (dsCaptura.Tables.Count >= 1)
                dgvResultado.DataSource = dsCaptura.Tables[0];
            dgvResultado.Show();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Gravar os dados apresentados em tela?", "Gravar dados", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    GravaArquivo grArq = new GravaArquivo();
                    grArq.GravarDados(Tipo, dsCaptura);
                    MessageBox.Show("Captura Realizada com sucesso.");
                    limpaResultado();
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

        public void LerAquivo()
        {
            pOpfArquivo = new OpenFileDialog();
            string filtro = "txt files (*.txt)|*.txt";

            pOpfArquivo.Filter = filtro;

            if (pOpfArquivo.ShowDialog() == DialogResult.OK)
            {
                var filePath = string.Empty;

                //Get the path of specified file
                filePath = pOpfArquivo.FileName;


                //Read the contents of the file into a stream
                var fileStream = pOpfArquivo.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
        }

        public void limpaResultado()
        {
            dgvResultado = new DataGridView();
        }
    }
}
