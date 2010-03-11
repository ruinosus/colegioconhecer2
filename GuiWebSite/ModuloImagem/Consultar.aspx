<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Consultar.aspx.cs" Inherits="ModuloPostagem_Consultar" %>

<%@ Register Src="~/ModuloImagem/ImagemSelecionar.ascx" TagName="ImagemSelecionar"
    TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="corpo"  runat="Server">
            <div id="conteudoCorpo">
    <div id="AvisoDeErro1" style="text-align: center;">
        <asp:ValidationSummary ID="vsuAvisoDeErro" Visible="false" runat="server" ValidationGroup="AvisoDeErro">
        </asp:ValidationSummary>
        <asp:ValidationSummary ID="vsuAvisoDeInformacao" runat="server" ValidationGroup="AvisoDeInformacao"
            ForeColor="#14A351" Visible="false"></asp:ValidationSummary>
        <asp:CustomValidator ID="cvaAvisoDeErro" runat="server" ValidationGroup="AvisoDeErro"
            Visible="false"></asp:CustomValidator>
        <asp:CustomValidator ID="cvaAvisoDeInformacao" runat="server" ValidationGroup="AvisoDeInformacao"
            ForeColor="#14A351" Visible="False"></asp:CustomValidator>
    </div>
        <uc1:ImagemSelecionar ID="ImagemSelecionar1" runat="server" />
        <table width="100%">
            <tr align="center">
                <td>
                    <table>
                        <tr>
                            <td>
                                <asp:Button ID="btnIncluir" runat="server" CssClass="botao" Font-Bold="True" ForeColor="#0033CC" Text="Incluir" PostBackUrl="~/ModuloImagem/Incluir.aspx" />
                                <asp:Button ID="btnAlterar" runat="server" CssClass="botao" Font-Bold="True" ForeColor="#0033CC" Text="Alterar" OnClick="btnAlterar_Click" />
                                <asp:Button ID="btnExcluir" runat="server" CssClass="botao" Font-Bold="True" ForeColor="#0033CC" Text="Excluir" OnClick="btnExcluir_Click" />
                                
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
