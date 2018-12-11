using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaCadastro
{
    /// <summary>
    /// Classe de captura de arquivo
    /// </summary>
    public class LeituraArquivo
    {
        private OpenFileDialog pOpfArquivo;
        private string filtro;
        private string fileContent;
        private char marcaLinha;
        private char marcaColuna;

        public string Filtro { get; set; }
        public char MarcaLinha { get; set; }
        public char MarcaColuna { get; set; }

        /// <summary>
        /// Construtor Padrão
        /// </summary>
        public LeituraArquivo()
        {
            pOpfArquivo = new OpenFileDialog();
            filtro = "txt files (*.txt)|*.txt";
            marcaLinha = ';';
            marcaColuna = ',';
        }
                
        /// <summary>
        /// Método para leitura inicial do arquivo. O retorno será guardado
        /// </summary>
        public void LerAquivo()
        {
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

        /// <summary>
        /// Método que irá preencher a tabela conforme os parâmetros de captura do arquivo.
        /// </summary>
        /// <returns>Retorna tabela enviada no arquivo</returns>
        public DataTable PreencheTabela()
        {
            DataTable dt = new DataTable();

            string[] linhas = fileContent.Split(marcaLinha);

            if (linhas.Count() > 0 && linhas[0].Split(marcaColuna).Count() > 0)
            {
                for (int i = 0; i < linhas[0].Split(marcaColuna).Count(); i++)
                    dt.Columns.Add();

                foreach (string linha in fileContent.Split(marcaLinha))
                {
                    dt.Rows.Add(linha.Split(marcaColuna));
                }
            }

            return dt;
        }
    }
}
