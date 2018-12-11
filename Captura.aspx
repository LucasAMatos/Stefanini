<%@ Page Title="Captura de Arquivo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Captura.aspx.cs" Inherits="CapturaArquivoWeb.Captura" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <div>
        <table Width="450px">
            <tr>
                <td colspan="6">
                     <span Width="253px">Resultado da captura</span>
                </td>
            </tr>
            <tr>
                <td colspan="6">

                    <asp:GridView ID="dgvResultado" runat="server" Width="450px" Height="250px" ShowHeader="False">
                    </asp:GridView>

                </td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:FileUpload ID="fulPesquisar" runat="server" Width="450px" OnLoad="fulPesquisar_Load" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnCarregar" runat="server" Text="Carregar" Width="80px" OnClick="btnCarregar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnGravar" runat="server" Text="Gravar" Width="80px" OnClick="btnGravar_Click" />
                </td>
                <td>
                    <asp:Button ID="BtnSair" runat="server" Text="Sair" Width="80px" />
                </td>
            </tr>
        </tabl>
    </div>
    </div>
</asp:Content>
