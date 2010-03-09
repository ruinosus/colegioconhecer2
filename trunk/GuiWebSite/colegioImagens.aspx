<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="colegioImagens.aspx.cs" Inherits="colegioImagens" %>

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
                                    <asp:DropDownList ID="ddlOpcoes" runat="server" Width="200px">
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
                <!-- FIM DA DIV ESQUERDA INTERNA -->
                <div class="unico_artigos_texto_indexImgMeio">
                    <asp:ImageButton ID="imbDestaque" runat="server" ImageUrl="App_Themes/Default/Imagens/imagem_MOD_imagens_maior.png"
                        Width="340" Height="326" /></div>
                <!-- INICIO DA DIV MEIO INTERNA -->
                <div class="unico_artigos_texto_indexImgDireita">
                    <asp:GridView runat="server" ID="grdImagem" PageSize="3" 
                        AutoGenerateColumns="False">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <div class="unico_artigos_texto_index2_divImg">
                                        <div class="unico_artigos_texto_index2_atv_dv2">
                                        <asp:Image ID="imgEsquerda" runat="server" Width="80" Height="77" ImageUrl='<%# GetImageUrl(Eval("ImagemEsquerda.ID")) %>'
                                        alt="thumbnail" hspace="0" vspace="0" border="0" class="thumbnail" Visible='<%# GetImage(Eval("ImagemEsquerda.ID")) %>' />
                                    
                                            
                                            <p>
                                                <span class="style4Atividades">
                                                    <asp:Label ID="DescricaoImgDetalheEsquerda" runat="server" /></span></p>
                                        </div>
                                    </div>
                                    <div class="unico_artigos_texto_index2_divImg">
                                        <div class="unico_artigos_texto_index2_atv_dv2">
                                            <asp:Image ID="ImgMeio" runat="server" Width="80" Height="77" ImageUrl='<%# GetImageUrl(Eval("ImagemEsquerda.ID")) %>'
                                        alt="thumbnail" hspace="0" vspace="0" border="0" class="thumbnail" Visible='<%# GetImage(Eval("ImagemEsquerda.ID")) %>' />
                                    
                                            <p>
                                                <span class="style4Atividades">
                                                    <asp:Label ID="DescricaoImgDetalheMeio" runat="server" /></span></p>
                                        </div>
                                    </div>
                                    <div class="unico_artigos_texto_index2_divImg">
                                        <div class="unico_artigos_texto_index2_atv_dv2">
                                            <asp:Image ID="Image1" runat="server" Width="80" Height="77" ImageUrl='<%# GetImageUrl(Eval("ImagemDireita.ID")) %>'
                                        alt="thumbnail" hspace="0" vspace="0" border="0" class="thumbnail" Visible='<%# GetImage(Eval("ImagemDireita.ID")) %>' />
                                    
                                            <p>
                                                <span class="style4Atividades">
                                                    <asp:Label ID="DescricaoImgDetalhe7" runat="server" /></span></p>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
                <!-- FIM DA DIV MEIO INTERNA -->
            </div>
        </div>
        <!-- Fim esquerda -->
    </div>
</asp:Content>
