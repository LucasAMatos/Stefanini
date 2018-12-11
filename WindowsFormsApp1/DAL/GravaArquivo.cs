using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ProgramaCadastro
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
        public void GravarDados(string pTabela, DataTable pDados)
        {
            string caminhoArquivo = string.Concat(Application.StartupPath.Replace("\\bin\\Debug", string.Empty, "\\Procedures\\"));

            using (SqlConnection conn =
                 new SqlConnection(connString))
            {
                SqlCommand sqlCommando = new SqlCommand();
                sqlCommando.Connection = conn;
                sqlCommando.CommandType = System.Data.CommandType.StoredProcedure;
                

                if (pTabela == "CLIENTE")

                    switch (pTabela)
                    {
                        case "CLIENTE":
                            SqlCommand command = new SqlCommand("[dbo].SP_IncCLiente_V1", conn);
                            sqlCommando.Parameters.AddWithValue();
                            sqlCommando.Parameters.AddWithValue();
                            sqlCommando.Parameters.AddWithValue();
                            sqlCommando.Parameters.AddWithValue();
                            sqlCommando.Parameters.AddWithValue();
                            sqlCommando.Parameters.AddWithValue();
                            break;
                        case "PRODUTO":
                            SqlCommand command = new SqlCommand("[dbo].SP_IncProd_V1", conn);
                            sqlCommando.Parameters.AddWithValue();
                            sqlCommando.Parameters.AddWithValue();
                            sqlCommando.Parameters.AddWithValue();
                            break;
                    }

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
        }



        /// <summary>
        /// Criado apenas para poder testar adequadamente o programa
        /// </summary>
        /// <returns></returns>
        public int CriarProcedures()
        {
            SqlConnection conn = new SqlConnection(connString);
            int intReturn;

            using (conn)
            {
                SqlCommand sqlCommando = new SqlCommand();
                sqlCommando.Connection = conn;
                string caminhoArquivo = Application.StartupPath.Replace("\\bin\\Debug", string.Empty);
                sqlCommando.CommandText = File.ReadAllText(string.Concat(caminhoArquivo, "\\Procedures\\Criacao de Tabelas.sql"));
                sqlCommando.CommandType = System.Data.CommandType.Text;

                conn.Open();

                intReturn = (int)sqlCommando.ExecuteNonQuery();

                if (intReturn < 0)
                {
                    conn.Close();
                    return intReturn;
                }
                sqlCommando.CommandText = File.ReadAllText(string.Concat(caminhoArquivo, "\\Procedures\\SP_IncCliente.sql"));
                sqlCommando.CommandType = System.Data.CommandType.Text;

                intReturn = (int)sqlCommando.ExecuteNonQuery();


                if (intReturn < 0)
                {
                    conn.Close();
                    return intReturn;
                }

                sqlCommando.CommandText = File.ReadAllText(string.Concat(caminhoArquivo, "\\Procedures\\SP_IncProd.sql"));
                sqlCommando.CommandType = System.Data.CommandType.Text;

                intReturn = (int)sqlCommando.ExecuteNonQuery();

                conn.Close();
            }

            return intReturn;
        }
    }
}