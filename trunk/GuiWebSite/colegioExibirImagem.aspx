<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="colegioExibirImagem.aspx.cs" Inherits="colegioExibirImagem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="corpo" Runat="Server">
<center>
  <asp:Image  ID="imgPrincipal" BackColor="" BorderColor=""  runat="server" Width="800" Height="600" 
                                        alt="thumbnail" hspace="0" vspace="0" border="0" class="thumbnail"  /><br />
                                          <asp:LinkButton PostBackUrl="~/colegioImagensDetalhe.aspx"    ID="DescricaoImgDetalheEsquerda" BackColor="" BorderColor=""  runat="server" Text="Voltar" Font-Names="Arial" ForeColor="#0033CC" Font-Size="9px" />

</center>
</asp:Content>

