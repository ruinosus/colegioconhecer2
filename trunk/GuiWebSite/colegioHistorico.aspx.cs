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

public partial class colegioHistorico : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        IPostagemProcesso processo = PostagemProcesso.Instance;
        List<Postagem> PostagemList = processo.Consultar();

        if (PostagemList.Count > 0)
        {
            PostagemExibicao postagemExibicao = processo.Consultar(TipoPagina.Historico);
            if (postagemExibicao.PostagemEsquerdaUm != null)
            {
                imgHistorico1.PostBackUrl = postagemExibicao.PostagemEsquerdaUm.LinkBotao;
            }

            if (postagemExibicao.PostagemEsquerdaDois != null)
            {
                imgHistorico2.PostBackUrl = postagemExibicao.PostagemEsquerdaDois.LinkBotao;
            }

            if (postagemExibicao.PostagemEsquerdaTres != null)
            {
                imgHistorico3.PostBackUrl = postagemExibicao.PostagemEsquerdaTres.LinkBotao;
            }
        }
    }
}
