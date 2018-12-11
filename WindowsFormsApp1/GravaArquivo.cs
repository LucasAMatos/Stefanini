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

        public GravaArquivo()
        {
            string server = "NT01214\\MSSQLSERVER2017";
            string user = "sa";
            string pwd = "masterkey";
            connString = string.Format("Data Source={0};Persist Security Info=True;User ID={1};Password={2}", server, user, pwd);
        }

        public void GravarDados(string pTabela, DataTable pDados)
        {
            using (SqlConnection conn =
                 new SqlConnection(connString))
            {
                conn.Open();

                if (pTabela == "CLIENTE")
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
                sqlCommando.CommandText = File.ReadAllText(string.Concat(caminhoArquivo, "\\Procedures\\Criação de Tabelas.sql"));
                sqlCommando.CommandType = System.Data.CommandType.Text;

                conn.Open();

                intReturn = (int)sqlCommando.ExecuteNonQuery();

                if (intReturn < 0)
                {
                    conn.Close();
                    return intReturn;
                }
                caminhoArquivo = Application.StartupPath.Replace("\\bin\\Debug", string.Empty);
                sqlCommando.CommandText = File.ReadAllText(string.Concat(caminhoArquivo, "\\Procedures\\SP_IncCliente.sql"));
                sqlCommando.CommandType = System.Data.CommandType.Text;

                intReturn = (int)sqlCommando.ExecuteNonQuery();


                if (intReturn < 0)
                {
                    conn.Close();
                    return intReturn;
                }
                caminhoArquivo = Application.StartupPath.Replace("\\bin\\Debug", string.Empty);
                sqlCommando.CommandText = File.ReadAllText(string.Concat(caminhoArquivo, "\\Procedures\\SP_IncProd.sql"));
                sqlCommando.CommandType = System.Data.CommandType.Text;
                
                intReturn = (int)sqlCommando.ExecuteNonQuery();

                conn.Close();
            }

            return intReturn;
        }
    }
}