using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Threading.Tasks;

namespace CapturaArquivoWeb
{
    /// <summary>
    /// Classe de captura de arquivo
    /// </summary>
    public class LeituraArquivo
    {
        private string filtro;
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
            marcaLinha = ';';
            marcaColuna = ',';
        }

        /// <summary>
        /// Método que irá preencher a tabela conforme os parâmetros de captura do arquivo.
        /// </summary>
        /// <returns>Retorna tabela enviada no arquivo</returns>
        public DataSet PreencheTabela(string fileContent)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            string[] linhas = fileContent.Split(marcaLinha);

            if (linhas.Count() > 0 && linhas[0].Split(marcaColuna).Count() > 0)
            {
                for (int i = 0; i < linhas[0].Split(marcaColuna).Count(); i++)
                    ds.Tables[0].Columns.Add(string.Concat("Column", i + 1));

                foreach (string linha in fileContent.Split(marcaLinha))
                {
                    ds.Tables[0].Rows.Add(linha.Split(marcaColuna));
                }
            }

            return ds;
        }
    }
}
