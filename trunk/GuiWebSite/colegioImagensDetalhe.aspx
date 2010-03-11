<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="colegioImagensDetalhe.aspx.cs" Inherits="colegioImagensDetalhe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="corpo" runat="Server"> 
            <div id="conteudoCorpo">
             <div class="esquerda2">
        
        	<div class="esquerda_artigos_detalhe_superior2"><!-- Inicio da Curva de Estilo do Arquivo a Esquerda -->
        		<div class="esquerda_artigos_detalhe_superior_esquerda2"></div>
            	<div class="esquerda_artigos_detalhe_superior_meio2"></div>
            	<div class="esquerda_artigos_detalhe_superior_direita2"></div>
            </div><!-- Fim esquerda_artigos_detalhe_superior -->
            
            <!-- Inicio do Artigo 1 a Esquerda da Página -->
            
        	<div class="esquerda_artigos">
           
              <div class="esquerda_artigos_texto_index2">
              <p><asp:Label ID="lblTituloDescricao" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="14px" ForeColor="Black" /></p>
              <p><asp:Label ID="lblDescricao" runat="server" Font-Names="Arial" Font-Size="10px" ForeColor="#0033CC" /></p>

              </div>
              
        	</div>
            
            <!-- Fim esquerda_artigo 1 -->
            
            
             <div class="esquerda_artigos_detalhe_inferior2"><!-- Fim da Curva de Estilo do Arquivo a Esquerda -->
        		<div class="esquerda_artigos_detalhe_inferior_esquerda2"></div>
            	<div class="esquerda_artigos_detalhe_inferior_meio2"></div>
            	<div class="esquerda_artigos_detalhe_inferior_direita2"></div>
            </div><!-- Fim esquerda_artigos_detalhe_inferior -->
            
            <div class="esquerda_informacoes_colegio2">
            <p align="center">Rua Zezito Costa Rego, n&ordm; 130. 
              <br />
              Cidade Universitária. Recife - PE
              <br />
              81. 3271.0233  www.colegioconhecer.com.br            </p>
            </div>
            
        </div><!-- Fim esquerda -->
        
      <div class="unico2">
        
            
    <!-- Inicio do Artigo 1 a Esquerda da Página -->
            
        	<div class="unico_artigos2">
        	  <div class="unico_artigos_texto_index_atv2">
        	  
        	  <asp:GridView runat="server" ID="grdImagem" PageSize="2" 
                        AutoGenerateColumns="False" AllowPaging="True" EnableTheming="false" 
                        ShowHeader="False" 
                        BorderStyle="None" BorderWidth="0px" GridLines="None" 
                        onpageindexchanging="grdImagem_PageIndexChanging">
                        <RowStyle BorderColor="White" BorderStyle="None" BorderWidth="0px" />
                        <EmptyDataRowStyle BorderColor="White" BorderStyle="None" BorderWidth="0px" />
                            <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <div class="unico_artigos_texto_grid_divImg2">
                                        <div class="unico_artigos_texto_index2_atv_dv2_img">
                                        <asp:ImageButton OnClick="imgClick" ImagemID='<%# Eval("ImagemEsquerda.ID") %>' ID="imgEsquerda" BackColor="" BorderColor=""  runat="server" Width="80" Height="77" ImageUrl='<%# GetImageUrl(Eval("ImagemEsquerda.ID")) %>'
                                        alt="thumbnail" hspace="0" vspace="0" border="0" class="thumbnail" Visible='<%# GetImage(Eval("ImagemEsquerda.ID")) %>' />

                                                    <asp:Label ID="DescricaoImgDetalheEsquerda" BackColor="" BorderColor=""  runat="server" Text='<%# Eval("ImagemEsquerda.Titulo") %>' Font-Names="Arial" ForeColor="#0033CC" Font-Size="9px" />
                                        </div>
                                    </div>
                                    <div class="unico_artigos_texto_grid_divImg2">
                                        <div class="unico_artigos_texto_index2_atv_dv2_img">
                                            <asp:ImageButton OnClick="imgClick" ImagemID='<%# Eval("ImagemEsquerdaMeio.ID") %>' ID="ImgMeio" runat="server" Width="80" BackColor="" BorderColor=""  Height="77" ImageUrl='<%# GetImageUrl(Eval("ImagemEsquerdaMeio.ID")) %>'
                                        alt="thumbnail" hspace="0" vspace="0" border="0" class="thumbnail" Visible='<%# GetImage(Eval("ImagemEsquerdaMeio.ID")) %>' />

                                                    <asp:Label ID="DescricaoImgDetalheMeio" BackColor="" BorderColor=""  runat="server"  Text='<%# Eval("ImagemEsquerdaMeio.Titulo") %>' Font-Names="Arial" ForeColor="#0033CC" Font-Size="9px" />
                                        </div>
                                    </div>
                                    <div class="unico_artigos_texto_grid_divImg2">
                                        <div class="unico_artigos_texto_index2_atv_dv2_img">
                                            <asp:ImageButton OnClick="imgClick" ImagemID='<%# Eval("ImagemMeio.ID") %>' ID="Image1" runat="server" Width="80" BackColor="" BorderColor=""  Height="77" ImageUrl='<%# GetImageUrl(Eval("ImagemMeio.ID")) %>'
                                        alt="thumbnail" hspace="0" vspace="0" border="0" class="thumbnail" Visible='<%# GetImage(Eval("ImagemMeio.ID")) %>' />

                                                    <asp:Label ID="DescricaoImgDetalhe7" BackColor="" BorderColor=""  runat="server" Text='<%# Eval("ImagemMeio.Titulo") %>' Font-Names="Arial" ForeColor="#0033CC" Font-Size="9px" />
                                        </div>
                                    </div>
                                    <div class="unico_artigos_texto_grid_divImg2">
                                        <div class="unico_artigos_texto_index2_atv_dv2_img">
                                            <asp:ImageButton OnClick="imgClick" ImagemID='<%# Eval("ImagemDireitaMeio.ID") %>' ID="Image2" runat="server" Width="80" BackColor="" BorderColor=""  Height="77" ImageUrl='<%# GetImageUrl(Eval("ImagemDireitaMeio.ID")) %>'
                                        alt="thumbnail" hspace="0" vspace="0" border="0" class="thumbnail" Visible='<%# GetImage(Eval("ImagemDireitaMeio.ID")) %>' />

                                                    <asp:Label ID="Label1" BackColor="" BorderColor=""  runat="server" Text='<%# Eval("ImagemDireitaMeio.Titulo") %>' Font-Names="Arial" ForeColor="#0033CC" Font-Size="9px" />
                                        </div>
                                    </div>
                                    <div class="unico_artigos_texto_grid_divImg2">
                                        <div class="unico_artigos_texto_index2_atv_dv2_img">
                                            <asp:ImageButton OnClick="imgClick" ImagemID='<%# Eval("ImagemDireita.ID") %>' ID="Image3" runat="server" Width="80" Height="77" ImageUrl='<%# GetImageUrl(Eval("ImagemDireita.ID")) %>'
                                        alt="thumbnail" hspace="0" vspace="0" border="0" BackColor="" BorderColor=""  class="thumbnail" Visible='<%# GetImage(Eval("ImagemDireita.ID")) %>' />

                                                    <asp:Label ID="Label2" runat="server" BackColor="" BorderColor="" Text='<%# Eval("ImagemDireita.Titulo") %>'  Font-Names="Arial" ForeColor="#0033CC" Font-Size="9px" />
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BorderColor="" BorderStyle="None" BorderWidth="0px" />
                        <PagerStyle BackColor="" BorderColor="" BorderStyle="None" 
                            BorderWidth="0px" />
                        <SelectedRowStyle BorderColor="" BorderStyle="None" BorderWidth="0px" />
                        <HeaderStyle BorderColor="" BorderStyle="None" BorderWidth="0px" />
                        <EditRowStyle BorderColor="" BorderStyle="None" BorderWidth="0px" />
                        <AlternatingRowStyle BorderColor="" BorderStyle="None" BorderWidth="0px" />
                    </asp:GridView>
              
              	
                  
                
			  </div>
        	</div>
            
            <!-- Fim esquerda_artigo 1 -->   
            
      </div><!-- Fim esquerda -->

</div><!-- Fim Conteúdo -->
            </asp:Content>
