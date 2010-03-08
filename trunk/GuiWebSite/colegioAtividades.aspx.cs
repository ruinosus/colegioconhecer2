using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloSite.Processos;
using Negocios.ModuloSite.VOs;
using Negocios.ModuloBasico.Enums;

public partial class colegioAtividades : System.Web.UI.Page
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
            PostagemExibicao postagemExibicao = processo.Consultar(TipoPagina.Atividades);
            if (postagemExibicao.PostagemEsquerdaUm != null)
            {
                if (postagemExibicao.PostagemEsquerdaUm.Titulo.Length > 20)
                {
                    DescricaoImgAtv1.Text = postagemExibicao.PostagemEsquerdaUm.Titulo.Substring(0, 20);
                    DescricaoImgAtv1.Visible = true;
                }
                else
                {
                    DescricaoImgAtv1.Text = postagemExibicao.PostagemEsquerdaUm.Titulo;
                    DescricaoImgAtv1.Visible = true;
                }
                if (postagemExibicao.PostagemEsquerdaUm.ImagemI != null &&
                    postagemExibicao.PostagemEsquerdaUm.ImagemI.Length > 0)
                {
                    imbAtividade1.Visible = true;
                    imbAtividade1.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemEsquerdaUm.ID;
                    imbAtividade1.PostBackUrl = postagemExibicao.PostagemEsquerdaUm.LinkBotao;
                }
            }

            if (postagemExibicao.PostagemEsquerdaDois != null)
            {
                if (postagemExibicao.PostagemEsquerdaDois.Titulo.Length > 20)
                {
                    DescricaoImgAtv2.Text = postagemExibicao.PostagemEsquerdaDois.Titulo.Substring(0, 20);
                    DescricaoImgAtv2.Visible = true;
                }
                else
                {
                    DescricaoImgAtv2.Text = postagemExibicao.PostagemEsquerdaDois.Titulo;
                    DescricaoImgAtv2.Visible = true;
                }
                if (postagemExibicao.PostagemEsquerdaDois.ImagemI != null &&
                    postagemExibicao.PostagemEsquerdaDois.ImagemI.Length > 0)
                {
                    imbAtividade2.Visible = true;
                    imbAtividade2.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemEsquerdaDois.ID;
                    imbAtividade2.PostBackUrl = postagemExibicao.PostagemEsquerdaDois.LinkBotao;
                }
            }

            if (postagemExibicao.PostagemEsquerdaTres != null)
            {
                if (postagemExibicao.PostagemEsquerdaTres.Titulo.Length > 20)
                {
                    DescricaoImgAtv3.Text = postagemExibicao.PostagemEsquerdaTres.Titulo.Substring(0, 20);
                    DescricaoImgAtv3.Visible = true;
                }
                else
                {
                    DescricaoImgAtv3.Text = postagemExibicao.PostagemEsquerdaTres.Titulo;
                    DescricaoImgAtv3.Visible = true;
                }
                if (postagemExibicao.PostagemEsquerdaTres.ImagemI != null &&
                    postagemExibicao.PostagemEsquerdaTres.ImagemI.Length > 0)
                {
                    imbAtividade3.Visible = true;
                    imbAtividade3.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemEsquerdaTres.ID;
                    imbAtividade3.PostBackUrl = postagemExibicao.PostagemEsquerdaTres.LinkBotao;
                }
            }

            if (postagemExibicao.PostagemMeioUm != null)
            {
                if (postagemExibicao.PostagemMeioUm.Titulo.Length > 20)
                {
                    DescricaoImgAtv4.Text = postagemExibicao.PostagemMeioUm.Titulo.Substring(0, 20);
                    DescricaoImgAtv4.Visible = true;
                }
                else
                {
                    DescricaoImgAtv4.Text = postagemExibicao.PostagemMeioUm.Titulo;
                    DescricaoImgAtv4.Visible = true;
                }
                if (postagemExibicao.PostagemMeioUm.ImagemI != null &&
                    postagemExibicao.PostagemMeioUm.ImagemI.Length > 0)
                {
                    imbAtividade4.Visible = true;
                    imbAtividade4.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemMeioUm.ID;
                    imbAtividade4.PostBackUrl = postagemExibicao.PostagemMeioUm.LinkBotao;
                }
            }

            if (postagemExibicao.PostagemMeioDois != null)
            {
                if (postagemExibicao.PostagemMeioDois.Titulo.Length > 20)
                {
                    DescricaoImgAtv5.Text = postagemExibicao.PostagemMeioDois.Titulo.Substring(0, 20);
                    DescricaoImgAtv5.Visible = true;
                }
                else
                {
                    DescricaoImgAtv5.Text = postagemExibicao.PostagemMeioDois.Titulo;
                    DescricaoImgAtv5.Visible = true;
                }
                if (postagemExibicao.PostagemMeioDois.ImagemI != null &&
                    postagemExibicao.PostagemMeioDois.ImagemI.Length > 0)
                {
                    imbAtividade5.Visible = true;
                    imbAtividade5.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemMeioDois.ID;
                    imbAtividade5.PostBackUrl = postagemExibicao.PostagemMeioDois.LinkBotao;
                }
            }

            if (postagemExibicao.PostagemMeioTres != null)
            {
                if (postagemExibicao.PostagemMeioTres.Titulo.Length > 20)
                {
                    DescricaoImgAtv6.Text = postagemExibicao.PostagemMeioTres.Titulo.Substring(0, 20);
                    DescricaoImgAtv6.Visible = true;
                }
                else
                {
                    DescricaoImgAtv6.Text = postagemExibicao.PostagemMeioTres.Titulo;
                    DescricaoImgAtv6.Visible = true;
                }
                if (postagemExibicao.PostagemMeioTres.ImagemI != null &&
                    postagemExibicao.PostagemMeioTres.ImagemI.Length > 0)
                {
                    imbAtividade6.Visible = true;
                    imbAtividade6.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemMeioTres.ID;
                    imbAtividade6.PostBackUrl = postagemExibicao.PostagemMeioTres.LinkBotao;
                }
            }

            if (postagemExibicao.PostagemDireitaUm != null)
            {
                if (postagemExibicao.PostagemDireitaUm.Titulo.Length > 20)
                {
                    DescricaoImgAtv7.Text = postagemExibicao.PostagemDireitaUm.Titulo.Substring(0, 20);
                    DescricaoImgAtv7.Visible = true;
                }
                else
                {
                    DescricaoImgAtv7.Text = postagemExibicao.PostagemDireitaUm.Titulo;
                    DescricaoImgAtv7.Visible = true;
                }
                if (postagemExibicao.PostagemDireitaUm.ImagemI != null &&
                    postagemExibicao.PostagemDireitaUm.ImagemI.Length > 0)
                {
                    imbAtividade7.Visible = true;
                    imbAtividade7.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemDireitaUm.ID;
                    imbAtividade7.PostBackUrl = postagemExibicao.PostagemDireitaUm.LinkBotao;
                }
            }

            if (postagemExibicao.PostagemDireitaDois != null)
            {
                if (postagemExibicao.PostagemDireitaDois.Titulo.Length > 20)
                {
                    DescricaoImgAtv8.Text = postagemExibicao.PostagemDireitaDois.Titulo.Substring(0, 20);
                    DescricaoImgAtv8.Visible = true;
                }
                else
                {
                    DescricaoImgAtv8.Text = postagemExibicao.PostagemDireitaDois.Titulo;
                    DescricaoImgAtv8.Visible = true;
                }
                if (postagemExibicao.PostagemDireitaDois.ImagemI != null &&
                    postagemExibicao.PostagemDireitaDois.ImagemI.Length > 0)
                {
                    imbAtividade8.Visible = true;
                    imbAtividade8.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemDireitaDois.ID;
                    imbAtividade8.PostBackUrl = postagemExibicao.PostagemDireitaDois.LinkBotao;
                }
            }
        }
    }
}
