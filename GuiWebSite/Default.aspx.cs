﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.ModuloSite.Processos;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloSite.VOs;

public partial class Default : System.Web.UI.Page
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
            PostagemExibicao postagemExibicao = processo.Consultar(TipoPagina.Colegio);
            if (postagemExibicao.PostagemEsquerdaUm != null)
            {
                if (postagemExibicao.PostagemEsquerdaUm.Corpo.Length > 300)
                {
                    lblTextoArtigoEsquerda1.Text = postagemExibicao.PostagemEsquerdaUm.Corpo.Substring(0, 300);
                }
                else
                {
                    lblTextoArtigoEsquerda1.Text = postagemExibicao.PostagemEsquerdaUm.Corpo;
                }
                lblTextoArtigoEsquerda1.Text = lblTextoArtigoEsquerda1.Text + " " + postagemExibicao.PostagemEsquerdaUm.LerMais;

                if (postagemExibicao.PostagemEsquerdaUm.Titulo.Length > 20)
                {
                    lblTituloEsquerda1.Text = postagemExibicao.PostagemEsquerdaUm.Titulo.Substring(0, 20);
                }
                else
                {
                    lblTituloEsquerda1.Text = postagemExibicao.PostagemEsquerdaUm.Titulo;
                }
            }

            if (postagemExibicao.PostagemEsquerdaDois != null)
            {
                if (postagemExibicao.PostagemEsquerdaDois.Corpo.Length > 220)
                {
                    lblTextoArtigoEsquerda2.Text = postagemExibicao.PostagemEsquerdaDois.Corpo.Substring(0, 220);
                }
                else
                {
                    lblTextoArtigoEsquerda2.Text = postagemExibicao.PostagemEsquerdaDois.Corpo;
                }
                lblTextoArtigoEsquerda2.Text = lblTextoArtigoEsquerda2.Text + " " + postagemExibicao.PostagemEsquerdaDois.LerMais;


                if (postagemExibicao.PostagemEsquerdaDois.Titulo.Length > 20)
                {
                    lblTituloEsquerda2.Text = postagemExibicao.PostagemEsquerdaDois.Titulo.Substring(0, 20);
                }
                else
                {
                    lblTituloEsquerda2.Text = postagemExibicao.PostagemEsquerdaDois.Titulo;
                }
            }

            if (postagemExibicao.PostagemMeioUm != null)
            {
                if (postagemExibicao.PostagemMeioUm.ImagemI != null &&
                    postagemExibicao.PostagemMeioUm.ImagemI.Length > 0)
                {
                    imgArtigoMeio1.Visible = true;
                    imgArtigoMeio1.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemMeioUm.ID;
                }
                else
                {
                    imgArtigoMeio1.Visible = false;
                }

                if (postagemExibicao.PostagemMeioUm.Corpo.Length > 440)
                {
                    lblTextoArtigoMeio1.Text = postagemExibicao.PostagemMeioUm.Corpo.Substring(0, 440);
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

            if (postagemExibicao.PostagemDireitaUm != null)
            {
                if (postagemExibicao.PostagemDireitaUm.ImagemI != null &&
                    postagemExibicao.PostagemDireitaUm.ImagemI.Length > 0)
                {
                    imgArtigoDireita1.Visible = true;
                    imgArtigoDireita1.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemDireitaUm.ID;
                }
                else
                {
                    imgArtigoDireita1.Visible = false;
                }


                if (postagemExibicao.PostagemDireitaUm.Corpo.Length > 360)
                {
                    lblTextoArtigoDireita1.Text = postagemExibicao.PostagemDireitaUm.Corpo.Substring(0, 360);
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
