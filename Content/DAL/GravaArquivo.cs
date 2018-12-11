using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.IO;

namespace CapturaArquivoWeb
{
    public class GravaArquivo
    {
        private string connString;

        /// <summary>
        /// Construtor Padrão
        /// </summary>
        public GravaArquivo()
        {
            string server = "NT01214\\MSSQLSERVER2017";
            string user = "sa";
            string pwd = "masterkey";
            connString = string.Format("Data Source={0};Persist Security Info=True;User ID={1};Password={2}", server, user, pwd);
        }

        /// <summary>
        /// Método para executar procedures
        /// </summary>
        /// <param name="pTabela"></param>
        /// <param name="pDados"></param>
        public void GravarDados(string pTabela, DataSet pDs)
        {
            using (SqlConnection conn =
                 new SqlConnection(connString))
            {
                SqlCommand sqlCommando = new SqlCommand();
                sqlCommando.Connection = conn;
                sqlCommando.CommandType = System.Data.CommandType.StoredProcedure;

                conn.Open();

                if (pDs != null && pDs.Tables != null && pDs.Tables.Count > 0)
                {

                    if (pDs.Tables[0].Columns != null && pDs.Tables[0].Rows.Count > 0)
                    {
                        int fim = pDs.Tables[0].Columns.Count;

                        for (int row = 0; row < pDs.Tables[0].Rows.Count; row++)
                        {
                            switch (pTabela)
                            {
                                case "Cliente":
                                    sqlCommando = new SqlCommand("EXEC [dbo].SP_IncCLiente_V1", conn);
                                    break;
                                case "Produto":
                                    sqlCommando = new SqlCommand("EXEC [dbo].SP_IncProd_V1", conn);
                                    break;
                            }

                            for (int i = 0; i < fim; i++)
                            {
                                string value = string.Concat(" ", pDs.Tables[0].Rows[row][string.Concat("Column", i + 1)]);

                                value = value == "true" ? "1" : (value == "false" ? "0" : value);

                                sqlCommando.CommandText += string.Concat(" ", quotedString(pDs.Tables[0].Rows[row][string.Concat("Column", i + 1)].ToString()));
                                if ((i + 1) < fim)
                                    sqlCommando.CommandText += ",";
                            }

                            sqlCommando.ExecuteNonQuery();
                        }
                    }
                }

                conn.Close();

            }
        }

        private string quotedString(string value)
        {
            return string.Concat("'", value, "'");
        }
    }
}
