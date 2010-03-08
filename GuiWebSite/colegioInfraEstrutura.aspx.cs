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

public partial class colegioInfraEstrutura : System.Web.UI.Page
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
            PostagemExibicao postagemExibicao = processo.Consultar(TipoPagina.InfraEstrutura);

            if (postagemExibicao.PostagemEsquerdaUm != null)
            {
                if (postagemExibicao.PostagemEsquerdaUm.ImagemI != null &&
                    postagemExibicao.PostagemEsquerdaUm.ImagemI.Length > 0)
                {
                    imgInfra1.Visible = true;
                    imgInfra1.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemEsquerdaUm.ID;
                }
            }

            if (postagemExibicao.PostagemEsquerdaDois != null)
            {
                if (postagemExibicao.PostagemEsquerdaDois.ImagemI != null &&
                    postagemExibicao.PostagemEsquerdaDois.ImagemI.Length > 0)
                {
                    imgInfra2.Visible = true;
                    imgInfra2.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemEsquerdaDois.ID;
                }
            }

            if (postagemExibicao.PostagemEsquerdaTres != null)
            {
                if (postagemExibicao.PostagemEsquerdaTres.ImagemI != null &&
                    postagemExibicao.PostagemEsquerdaTres.ImagemI.Length > 0)
                {
                    imgInfra3.Visible = true;
                    imgInfra3.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemEsquerdaTres.ID;
                }
            }

            if (postagemExibicao.PostagemMeioUm != null)
            {
                if (postagemExibicao.PostagemMeioUm.ImagemI != null &&
                    postagemExibicao.PostagemMeioUm.ImagemI.Length > 0)
                {
                    imgInfra4.Visible = true;
                    imgInfra4.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemMeioUm.ID;
                }
            }
        }
    }
}
