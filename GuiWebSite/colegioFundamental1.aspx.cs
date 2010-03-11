using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.ModuloSite.Processos;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloSite.VOs;

public partial class colegioFundamental1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregarTela();
        }
    }


    private void CarregarTela()
    {
        IPostagemProcesso processo = PostagemProcesso.Instance;
        List<Postagem> PostagemList = processo.Consultar();

        if (PostagemList.Count > 0)
        {
            PostagemExibicao postagemExibicao = processo.Consultar(TipoPagina.FundamentalI);

            if (postagemExibicao.PostagemMeioUm != null)
            {
                if (postagemExibicao.PostagemMeioUm.ImagemI != null &&
                    postagemExibicao.PostagemMeioUm.ImagemI.Length > 0)
                {
                    imgArtigo1Meio.Visible = true;
                    imgArtigo1Meio.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemMeioUm.ID;
                }

                if (postagemExibicao.PostagemMeioUm.Corpo.Length > 90)
                {
                    lblTextoArtigoMeio1.Text = postagemExibicao.PostagemMeioUm.Corpo.Substring(0, 90);
                }
                else
                {
                    lblTextoArtigoMeio1.Text = postagemExibicao.PostagemMeioUm.Corpo;
                }
                lblTextoArtigoMeio1.Text = lblTextoArtigoMeio1.Text + " " + postagemExibicao.PostagemMeioUm.LerMais;


                if (postagemExibicao.PostagemMeioUm.Titulo.Length > 20)
                {
                    lblTituloMeio1.Text = postagemExibicao.PostagemMeioUm.Titulo.Substring(0, 20);
                }
                else
                {
                    lblTituloMeio1.Text = postagemExibicao.PostagemMeioUm.Titulo;
                }
            }

            if (postagemExibicao.PostagemMeioDois != null)
            {
                if (postagemExibicao.PostagemMeioDois.ImagemI != null &&
                    postagemExibicao.PostagemMeioDois.ImagemI.Length > 0)
                {
                    imgArtigo2Meio.Visible = true;
                    imgArtigo2Meio.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemMeioDois.ID;
                }

                if (postagemExibicao.PostagemMeioDois.Corpo.Length > 240)
                {
                    lblTextoArtigoMeio2.Text = postagemExibicao.PostagemMeioDois.Corpo.Substring(0, 240);
                }
                else
                {
                    lblTextoArtigoMeio2.Text = postagemExibicao.PostagemMeioDois.Corpo;
                }
                lblTextoArtigoMeio2.Text = lblTextoArtigoMeio2.Text + " " + postagemExibicao.PostagemMeioDois.LerMais;


            }

            if (postagemExibicao.PostagemDireitaUm != null)
            {
                if (postagemExibicao.PostagemDireitaUm.ImagemI != null &&
                    postagemExibicao.PostagemDireitaUm.ImagemI.Length > 0)
                {
                    imgArtigo1Direita.Visible = true;
                    imgArtigo1Direita.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemDireitaUm.ID;
                }

                if (postagemExibicao.PostagemDireitaUm.Corpo.Length > 660)
                {
                    lblTextoArtigoDireita1.Text = postagemExibicao.PostagemDireitaUm.Corpo.Substring(0, 660);
                }
                else
                {
                    lblTextoArtigoDireita1.Text = postagemExibicao.PostagemDireitaUm.Corpo;
                }
                lblTextoArtigoDireita1.Text = lblTextoArtigoDireita1.Text + " " + postagemExibicao.PostagemDireitaUm.LerMais;


                if (postagemExibicao.PostagemDireitaUm.Titulo.Length > 20)
                {
                    lblTituloDireita1.Text = postagemExibicao.PostagemDireitaUm.Titulo.Substring(0, 20);
                }
                else
                {
                    lblTituloDireita1.Text = postagemExibicao.PostagemDireitaUm.Titulo;
                }
            }

        }
    }
}
