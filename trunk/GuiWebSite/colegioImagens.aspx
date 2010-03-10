<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="colegioImagens.aspx.cs" Inherits="colegioImagens" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="corpo" runat="Server">
    <div id="conteudoCorpo">
        <div class="unico">
            <div class="unico_artigos_detalhe_superior">
                <!-- Inicio da Curva de Estilo do Arquivo a Esquerda -->
                <div class="unico_artigos_detalhe_superior_esquerda">
                </div>
                <div class="unico_artigos_detalhe_superior_meio">
                </div>
                <div class="unico_artigos_detalhe_superior_direita">
                </div>
            </div>
            <!-- Fim esquerda_artigos_detalhe_superior -->
            <!-- Inicio do Artigo 1 a Esquerda da Página -->
            <div class="unico_artigos3">
                <!-- INICIO DA DIV ESQUERDA INTERNA -->
                <div class="unico_artigos_texto_indexImgEsquerda">
                    <div class="unico_artigos_texto_indexImg2">
                        <table width="180" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td colspan="2">
                                    <asp:ImageButton ID="imbMenu1" runat="server" ImageUrl="App_Themes/Default/Imagens/menuEsquerda3.png"
                                        Width="150" Height="45" hspace="0" vspace="10" />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:DropDownList ID="ddlOpcoes" runat="server" Width="200px" AutoPostBack="True"
                                        OnSelectedIndexChanged="ddlOpcoes_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label>
                                        <asp:RadioButton ID="rdbInfantil" runat="server" GroupName="rdb" AutoPostBack="True"
                                            OnCheckedChanged="rdbInfantil_CheckedChanged" Checked="True" />
                                    </label>
                                </td>
                                <td>
                                    <asp:ImageButton ID="imbMenu2" runat="server" ImageUrl="App_Themes/Default/Imagens/menu_edInfantil.png"
                                        Width="72" Height="25" hspace="10" vspace="10" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label>
                                        <asp:RadioButton ID="rdbFund1" runat="server" GroupName="rdb" AutoPostBack="True"
                                            OnCheckedChanged="rdbFund1_CheckedChanged" />
                                    </label>
                                </td>
                                <td>
                                    <asp:ImageButton ID="imbMenu3" runat="server" ImageUrl="App_Themes/Default/Imagens/menu_edFund1.png"
                                        Width="110" Height="25" hspace="10" vspace="10" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label>
                                        <asp:RadioButton ID="rdbFund2" runat="server" GroupName="rdb" AutoPostBack="True"
                                            OnCheckedChanged="rdbFund2_CheckedChanged" />
                                    </label>
                                </td>
                                <td>
                                    <asp:ImageButton ID="imbMenu4" runat="server" ImageUrl="App_Themes/Default/Imagens/menu_edFund2.png"
                                        Width="118" Height="25" hspace="10" vspace="10" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label>
                                        <asp:RadioButton ID="rdbMedio" runat="server" GroupName="rdb" Enabled="False" />
                                    </label>
                                </td>
                                <td>
                                    <asp:ImageButton ID="imbMenu5" runat="server" ImageUrl="App_Themes/Default/Imagens/menu_Medio.png"
                                        Width="52" Height="25" hspace="10" vspace="10" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div class="unico_artigos_texto_indexImg">
                        <div class="esquerda_informacoes_colegio2">
                            <p align="center">
                                <span class="unico_informacoes_colegio">Rua Zezito Costa Rego, n&ordm; 130.
                                    <br />
                                    Cidade Universitária. Recife - PE
                                    <br />
                                    81. 3271.0233
                                    <br />
                                    www.colegioconhecer.com.br </span>
                            </p>
                        </div>
                    </div>
                </div>
                <asp:UpdatePanel ID="updImgDestaque" runat="server">
                    <ContentTemplate>
                        <!-- FIM DA DIV ESQUERDA INTERNA -->
                        <div class="unico_artigos_texto_indexImgMeio">
                            <asp:ImageButton ID="imbDestaque" runat="server" ImageUrl="App_Themes/Default/Imagens/imagem_MOD_imagens_maior.png"
                                Width="340" Height="326" Visible="False" onclick="imbDestaque_Click" /></div>
                        <!-- INICIO DA DIV MEIO INTERNA -->
                    </ContentTemplate>
                </asp:UpdatePanel>
                <div class="unico_artigos_texto_indexImgDireita">
                    <asp:GridView runat="server" ID="grdImagem" PageSize="3" AutoGenerateColumns="False"
                        AllowPaging="True" EnableTheming="false" ShowHeader="False" BackColor="White"
                        BorderColor="White" BorderStyle="None" BorderWidth="0px" GridLines="None" OnPageIndexChanging="grdImagem_PageIndexChanging">
                        <RowStyle BorderColor="White" BorderStyle="None" BorderWidth="0px" />
                        <EmptyDataRowStyle BorderColor="White" BorderStyle="None" BorderWidth="0px" />
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <div class="unico_artigos_texto_grid_divImg">
                                        <div class="unico_artigos_texto_index2_atv_dv2">
                                            <asp:ImageButton OnClick="ImagemClik" PostagemID='<%# Eval("PostagemEsquerdaUm.ID") %>'
                                                ID="imgEsquerda" runat="server" Width="80" Height="77" ImageUrl='<%# GetImageUrl(Eval("PostagemEsquerdaUm.ID")) %>'
                                                alt="thumbnail" hspace="0" vspace="0" border="0" class="thumbnail" Visible='<%# GetImage(Eval("PostagemEsquerdaUm.ImagemI")) %>' />
                                            <p>
                                                <span class="style4Atividades">
                                                    <asp:Label ID="DescricaoImgDetalheEsquerda" runat="server" Text='<%# Eval("PostagemEsquerdaUm.Titulo") %>' /></span></p>
                                        </div>
                                    </div>
                                    <div class="unico_artigos_texto_grid_divImg">
                                        <div class="unico_artigos_texto_index2_atv_dv2">
                                            <asp:ImageButton OnClick="ImagemClik" ID="ImgMeio" PostagemID='<%# Eval("PostagemMeioUm.ID") %>'
                                                runat="server" Width="80" Height="77" ImageUrl='<%# GetImageUrl(Eval("PostagemMeioUm.ID")) %>'
                                                alt="thumbnail" hspace="0" vspace="0" border="0" class="thumbnail" Visible='<%# GetImage(Eval("PostagemMeioUm.ImagemI")) %>' />
                                            <p>
                                                <span class="style4Atividades">
                                                    <asp:Label ID="DescricaoImgDetalheMeio" runat="server" Text='<%# Eval("PostagemMeioUm.Titulo") %>' /></span></p>
                                        </div>
                                    </div>
                                    <div class="unico_artigos_texto_grid_divImg">
                                        <div class="unico_artigos_texto_index2_atv_dv2">
                                            <asp:ImageButton OnClick="ImagemClik" ID="Image1" PostagemID='<%# Eval("PostagemDireitaUm.ID") %>'
                                                runat="server" Width="80" Height="77" ImageUrl='<%# GetImageUrl(Eval("PostagemDireitaUm.ID")) %>'
                                                alt="thumbnail" hspace="0" vspace="0" border="0" class="thumbnail" Visible='<%# GetImage(Eval("PostagemDireitaUm.ImagemI")) %>' />
                                            <p>
                                                <span class="style4Atividades">
                                                    <asp:Label ID="DescricaoImgDetalhe7" runat="server" Text='<%# Eval("PostagemDireitaUm.Titulo") %>' /></span></p>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BorderColor="White" BorderStyle="None" BorderWidth="0px" />
                        <PagerStyle BackColor="White" BorderColor="White" BorderStyle="None" BorderWidth="0px" />
                        <SelectedRowStyle BorderColor="White" BorderStyle="None" BorderWidth="0px" />
                        <HeaderStyle BorderColor="White" BorderStyle="None" BorderWidth="0px" />
                        <EditRowStyle BorderColor="White" BorderStyle="None" BorderWidth="0px" />
                        <AlternatingRowStyle BorderColor="White" BorderStyle="None" BorderWidth="0px" />
                    </asp:GridView>
                </div>
                <!-- FIM DA DIV MEIO INTERNA -->
            </div>
        </div>
        <!-- Fim esquerda -->
    </div>
</asp:Content>
