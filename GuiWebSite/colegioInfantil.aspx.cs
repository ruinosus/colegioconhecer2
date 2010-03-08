using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.ModuloSite.Processos;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloSite.VOs;
using Negocios.ModuloBasico.Enums;

public partial class colegioInfantil : System.Web.UI.Page
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
            PostagemExibicao postagemExibicao = processo.Consultar(TipoPagina.EducacaoInfantil);

            if (postagemExibicao.PostagemMeioUm != null)
            {
                if (postagemExibicao.PostagemMeioUm.Corpo.Length > 240)
                {
                    lblTextoArtigoMeio1.Text = postagemExibicao.PostagemMeioUm.Corpo.Substring(0, 240);
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
                if (postagemExibicao.PostagemMeioDois.Corpo.Length > 250)
                {
                    lblTextoArtigoMeio2.Text = postagemExibicao.PostagemMeioDois.Corpo.Substring(0, 250);
                }
                else
                {
                    lblTextoArtigoMeio2.Text = postagemExibicao.PostagemMeioDois.Corpo;
                }
                lblTextoArtigoMeio2.Text = lblTextoArtigoMeio2.Text + " " + postagemExibicao.PostagemMeioDois.LerMais;


                if (postagemExibicao.PostagemMeioDois.Titulo.Length > 20)
                {
                    lblTituloMeio2.Text = postagemExibicao.PostagemMeioDois.Titulo.Substring(0, 20);
                }
                else
                {
                    lblTituloMeio2.Text = postagemExibicao.PostagemMeioDois.Titulo;
                }
            }

            if (postagemExibicao.PostagemMeioTres != null)
            {
                if (postagemExibicao.PostagemMeioTres.Corpo.Length > 255)
                {
                    lblTextoArtigoMeio3.Text = postagemExibicao.PostagemMeioTres.Corpo.Substring(0, 255);
                }
                else
                {
                    lblTextoArtigoMeio3.Text = postagemExibicao.PostagemMeioTres.Corpo;
                }
                lblTextoArtigoMeio3.Text = lblTextoArtigoMeio3.Text + " " + postagemExibicao.PostagemMeioTres.LerMais;


                if (postagemExibicao.PostagemMeioTres.Titulo.Length > 20)
                {
                    lblTituloMeio3.Text = postagemExibicao.PostagemMeioTres.Titulo.Substring(0, 20);
                }
                else
                {
                    lblTituloMeio3.Text = postagemExibicao.PostagemMeioTres.Titulo;
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
                if (postagemExibicao.PostagemDireitaUm.Corpo.Length > 770)
                {
                    lblTextoArtigoDireita1.Text = postagemExibicao.PostagemDireitaUm.Corpo.Substring(0, 770);
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
