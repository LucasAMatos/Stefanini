using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.IO;
using System.Windows;
using System.Web.UI.WebControls;

namespace CapturaArquivoWeb
{
    public partial class Captura : Page
    {
        public string Tipo
        {
            get
            {
                return Request.Params["Tipo"].ToString();
            }
        }

        protected string fileContent
        {
            get
            {
                return Session["fileContent"].ToString();
            }
            set
            {
                Session["fileContent"] = value;
            }
        }

        protected DataSet dsCaptura
        {
            get
            {
                return (DataSet)Session["dsCaptura"];
            }
            set
            {
                Session["dsCaptura"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Title = string.Concat("Captura de ", Tipo);
        }

        protected void fulPesquisar_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnCarregar_Click(object sender, EventArgs e)
        {
            //Read the contents of the file into a stream
            var fileStream = fulPesquisar.FileContent;
            using (StreamReader reader = new StreamReader(fileStream))
            {
                fileContent = reader.ReadToEnd();
            }

            LeituraArquivo pLeituraArquivo = new LeituraArquivo();
            if (!string.IsNullOrEmpty(fileContent))
                dsCaptura = pLeituraArquivo.PreencheTabela(fileContent);
            dgvResultado.DataSource = dsCaptura;
            dgvResultado.DataBind();
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                GravaArquivo grArq = new GravaArquivo();
                grArq.GravarDados(Tipo, dsCaptura);
                Response.Write("<script>alert('Captura Realizada com sucesso.');</script>");
            }
            catch (Exception E)
            {
                Response.Write("<script>alert('Houve Erro na captura. Favor validar com o suporte.');</script>");
            }
        }

    }
}

