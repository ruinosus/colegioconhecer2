﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="colegioFundamental1.aspx.cs" Inherits="colegioFundamental1" %>

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
              <div class="esquerda_artigos_imagem_menu1"><asp:ImageButton ID="imbFund1_1" runat="server" ImageUrl="App_Themes/Default/Imagens/menuEsquerda1.png"
                                                        width="150" height="55" hspace="0" vspace="0" border="0" /></div>
              <div class="esquerda_artigos_imagem_menu1"><asp:ImageButton ID="imbFund1_2" runat="server" ImageUrl="App_Themes/Default/Imagens/menuEsquerda2.png"
                                                        width="150" height="55" hspace="0" vspace="0" border="0" /></div>
              <div class="esquerda_artigos_imagem_menu2"><asp:ImageButton ID="imbFund1_3" 
                      runat="server" ImageUrl="App_Themes/Default/Imagens/menuEsquerda3.png"
                                                        width="150" height="45" hspace="0" 
                      vspace="0" border="0" PostBackUrl="~/colegioImagens.aspx" /></div>
              <div class="esquerda_artigos_imagem_menu2"><asp:ImageButton ID="imbFund1_4" runat="server" ImageUrl="App_Themes/Default/Imagens/menuEsquerda4.png"
                                                        width="150" height="45" hspace="0" vspace="0" border="0" /></div>
              <div class="esquerda_artigos_imagem_menu"><asp:ImageButton ID="imbFund1_5" runat="server" ImageUrl="App_Themes/Default/Imagens/menuEsquerda5.png"
                                                        width="150" height="35" hspace="0" vspace="0" border="0" /></div>
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
        
        
        <!-- Inicio do Conteúdo do Meio da Página -->
        
                <div class="meio2"><!-- Inicio do Conteúdo Meio da Página -->
        
        	<div class="meio_artigos_detalhe_superior2"><!-- Inicio da Curva de Estilo do Arquivo a Meio -->
        		<div class="meio_artigos_detalhe_superior_esquerda"></div>
            	<div class="meio_artigos_detalhe_superior_meio2"></div>
            	<div class="meio_artigos_detalhe_superior_direita"></div>
            </div><!-- Fim meio_artigos_detalhe_superior -->
            
        	<div class="meio_artigos"><!-- Inicio do Artigo 1 a Meio da Página -->
            
              <div class="meio_artigos_titulo">
                	<p><span class="style1Fund2"><asp:Label ID="lblTituloMeio1" runat="server" Text="CURIOSIDADES" /> 
                	<asp:Image ID="imgTituloMeio1"  runat="server" ImageUrl="App_Themes/Default/Imagens/boneco_vermelho.png" width="28" height="25" /></span>
                	<asp:Image ID="imgBarraArtigoMeio1" runat="server" ImageUrl="App_Themes/Default/Imagens/barraArtigoEsquerda_cor4.png" Width="320" Height="6" />    </p>                
              </div>
                
              <div class="meio_artigos_texto_index3">
              	<div class="meio_artigos_texto_index3_div1"><asp:Image ID="imgArtigo1Meio" 
                        runat="server" Width="150" Height="80" Visible="False" /> </div>
              	<div class="meio_artigos_texto_index3_div2"><p><asp:Label ID="lblTextoArtigoMeio1" runat="server" /></p></div>
              </div>
              
              <div class="meio_artigos_titulo">
                	<p><span class="style2Fund2"><asp:Label ID="lblTituloMeio2" runat="server" Text="POR DENTRO" /> 
                	<asp:Image ID="imgTituloMeio2"  runat="server" ImageUrl="App_Themes/Default/Imagens/boneco_azul.png" width="23" height="25" /></span>
                	<asp:Image ID="imgBarraArtigoMeio2" runat="server" ImageUrl="App_Themes/Default/Imagens/barraArtigoEsquerda_cor5.png" Width="320" Height="6" />    </p>                
              </div>
                
              <div class="meio_artigos_texto_index3">
              	<div class="meio_artigos_texto_index4_div1"><p><asp:Label ID="lblTextoArtigoMeio2" runat="server" /></p></div>
              	<div class="meio_artigos_texto_index4_div2"><asp:Image ID="imgArtigo2Meio" 
                        runat="server" Width="150" Height="160" Visible="False" /></div>
              </div>
              
              
            
            </div><!-- Fim meio_artigos -->
            
             <div class="meio_artigos_detalhe_inferior2"><!-- Fim da Curva de Estilo do Arquivo a Meio -->
        		<div class="meio_artigos_detalhe_inferior_esquerda"></div>
            	<div class="meio_artigos_detalhe_inferior_meio2"></div>
            	<div class="meio_artigos_detalhe_inferior_direita"></div>
            </div><!-- Fim meio_artigos_detalhe_inferior -->
            
        </div><!-- Fim Meio -->
                
        
        <!-- Inicio do Conteúdo da Direita da Página -->
        
                <div class="direita2"><!-- Inicio do Conteúdo Direita da Página -->
        
        	<div class="direita_artigos_detalhe_superior2"><!-- Inicio da Curva de Estilo do Arquivo a Direita -->
        		<div class="direita_artigos_detalhe_superior_esquerda"></div>
            	<div class="direita_artigos_detalhe_superior_meio2"></div>
            	<div class="direita_artigos_detalhe_superior_direita"></div>
            </div><!-- Fim direita_artigos_detalhe_superior -->
            
        	<div class="direita_artigos"><!-- Inicio do Artigo 1 a Direita da Página -->
            
 
              <div class="meio_artigos_titulo">
                	<p><span class="style0Fund2"><asp:Label ID="lblTituloDireita1" runat="server" Text="TÍTULO 02" /> 
                	<asp:Image ID="imgTituloDireita1"  runat="server" ImageUrl="App_Themes/Default/Imagens/boneco_verde.png" width="35" height="25" /></span>
                	<asp:Image ID="imgBarraArtigoDireita1" runat="server" ImageUrl="App_Themes/Default/Imagens/barraArtigoEsquerda.png" Width="410" Height="6" />    </p>                
              </div>
                
              	<div class="direita_artigos_texto_index2"><p><asp:Label ID="lblTextoArtigoDireita1" runat="server" /></p></div>
              	<div class="direita_artigos_imagem_index2"><asp:Image ID="imgArtigo1Direita" 
                        runat="server" Width="390" Height="130" Visible="False" /></div>

            </div><!-- Fim direita_artigos -->
            
             <div class="direita_artigos_detalhe_inferior2"><!-- Fim da Curva de Estilo do Arquivo a Direita -->
        		<div class="direita_artigos_detalhe_inferior_esquerda"></div>
            	<div class="direita_artigos_detalhe_inferior_meio2"></div>
            	<div class="direita_artigos_detalhe_inferior_direita"></div>
            </div><!-- Fim direita_artigos_detalhe_inferior -->
            
        </div><!-- Fim Direita -->

</div><!-- Fim Conteúdo -->
</asp:Content>