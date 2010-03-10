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

    List<PostagemExibicao> postagens;

    public List<PostagemExibicao> PostagensLista
    {
        get
        {
            if (Session["PostagemExibicaoList"] != null)
                postagens = (List<PostagemExibicao>)Session["PostagemExibicaoList"];

            return postagens;
        }
        set
        {
            Session.Add("PostagemExibicaoList", value);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Limpar();
        if (!IsPostBack)
        {
            VerificaSelecao();
        }
    }

    private void Limpar()
    {

        imbDestaque.Visible = false;
        //Session.Remove("PostagemIDSelecionado");
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

        CarregarImagensEventos();
    }

    private void CarregarImagensEventos()
    {

        IPostagemProcesso processo = PostagemProcesso.Instance;
        List<Postagem> posts = (List<Postagem>)ddlOpcoes.DataSource;
        PostagensLista = processo.Consultar(posts);
        grdImagem.DataSource = PostagensLista;
        grdImagem.DataBind();


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
            return "~/ModuloAuxiliar/Handler.ashx?postId=" + (int)id;
        }
        else return "";
    }

    protected void ImagemClik(object sender, EventArgs e)
    {
        ImageButton img = (ImageButton)sender;
        
        if (img != null)
        {
            int PostagemID = int.Parse(img.Attributes["PostagemID"].ToString());

            Postagem post = new Postagem();
            post.ID = PostagemID;

            IPostagemProcesso processo = PostagemProcesso.Instance;

            List<Postagem> resultado = processo.Consultar(post, TipoPesquisa.E);

            if (resultado.Count > 0)
            {
                
                imbDestaque.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + resultado[0].ID;
                Session.Add("PostagemIDSelecionado", resultado[0].ID.ToString());
                imbDestaque.Visible = true;
            }

        }

    }

    protected bool GetImage(object imagem)
    {
        byte[] imagemTeste = (byte[])imagem;
        if (imagemTeste != null && imagemTeste.Length != 0)        
            return true;
        return false;
    }
    protected void grdImagem_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdImagem.DataSource = PostagensLista;
        if (grdImagem.DataSource != null)
        {
            grdImagem.PageIndex = e.NewPageIndex;
            grdImagem.DataBind();
        }
    }
    protected void ddlOpcoes_SelectedIndexChanged(object sender, EventArgs e)
    {
        //CarregarImagensEventos();
    }
    protected void imbDestaque_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["PostagemIDSelecionado"] != null)
        {
            Response.Redirect("colegioImagensDetalhe.aspx", false);
        }

    }
}
