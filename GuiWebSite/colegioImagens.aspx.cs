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

public partial class colegioImagens : System.Web.UI.Page
{

    List<ImagemExibicao> imagens;

    public List<ImagemExibicao> ImagensLista
    {
        get
        {
            if (Session["ImagemExibicaoList"] != null)
                imagens = (List<ImagemExibicao>)Session["ImagemExibicaoList"];

            return imagens;
        }
        set
        {
            Session.Add("ImagemExibicaoList", value);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            VerificaSelecao();
        }
    }

    protected void VerificaSelecao()
    {
        if (rdbInfantil.Checked == true)
        {
            CarregarComboEventos(TipoPostagem.EventoEducacaoInfantil);
        }
        if (rdbFund1.Checked == true)
        {
            CarregarComboEventos(TipoPostagem.EventoEnsinoFundamentalI);
        }
        if (rdbFund2.Checked == true)
        {
            CarregarComboEventos(TipoPostagem.EventoEnsinoFundamentalII);
        }
    }

    private void CarregarImagensEventos()
    {
        if (!string.IsNullOrEmpty(ddlOpcoes.SelectedValue) && int.Parse(ddlOpcoes.SelectedValue)!=0)
        {
            IImagemProcesso processo = ImagemProcesso.Instance;

            ImagensLista = processo.Consultar(int.Parse(ddlOpcoes.SelectedValue));
            grdImagem.DataSource = ImagensLista;
            grdImagem.DataBind();
        }
        else
        {
            ImagensLista = new List<ImagemExibicao>();
            grdImagem.DataSource = ImagensLista;
            grdImagem.DataBind();
        }
    }

    private List<Postagem> PesquisaEventos(TipoPostagem tipoPostagem)
    {
        IPostagemProcesso processo = PostagemProcesso.Instance;
        Postagem post = new Postagem();
        post.Tipo = (int)tipoPostagem;
        List<Postagem> postagemList = processo.Consultar(post, TipoPesquisa.E);
        Postagem postInicial = new Postagem();
        postInicial.Titulo = "Selecione...";
        postagemList.Insert(0, postInicial);
        return postagemList;
    }

    private void CarregarComboEventos(TipoPostagem tipoPostagem)
    {
        ddlOpcoes.DataSource = PesquisaEventos(tipoPostagem);
        ddlOpcoes.DataValueField = "ID";
        ddlOpcoes.DataTextField = "Titulo";
        ddlOpcoes.DataBind();
    }


    protected void rdbInfantil_CheckedChanged(object sender, EventArgs e)
    {
        VerificaSelecao();
    }
    protected void rdbFund1_CheckedChanged(object sender, EventArgs e)
    {
        VerificaSelecao();
    }
    protected void rdbFund2_CheckedChanged(object sender, EventArgs e)
    {
        VerificaSelecao();
    }

    protected string GetImageUrl(object id)
    {
        if (id != null && ((int)id) != 0)
        {
            return "~/ModuloAuxiliar/Handler.ashx?imgId=" + (int)id;
        }
        else return "";
    }

    protected bool GetImage(object id)
    {
        if (id != null && ((int)id) != 0)
            return true;
        return false;
    }
    protected void grdImagem_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdImagem.DataSource = ImagensLista;
        if (grdImagem.DataSource != null)
        {
            grdImagem.PageIndex = e.NewPageIndex;
            grdImagem.DataBind();
        }
    }
    protected void ddlOpcoes_SelectedIndexChanged(object sender, EventArgs e)
    {
        CarregarImagensEventos();
    }
}
