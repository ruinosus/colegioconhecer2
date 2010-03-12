using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.ModuloSite.VOs;
using Negocios.ModuloSite.Processos;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloBasico.Enums;

public partial class colegioImagensDetalhe : System.Web.UI.Page
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
        lblDescricao.Text = string.Empty;
        lblTituloDescricao.Text = string.Empty;
                

        if (Session["PostagemIDSelecionado"] == null)
        {
            Response.Redirect("colegioImagens.aspx", true);
        }

        if (!IsPostBack)
        {
            CarregarImagensEventos(int.Parse(Session["PostagemIDSelecionado"].ToString()));
        }
    }

    private void CarregarImagensEventos(int id)
    {
        IImagemProcesso processo = ImagemProcesso.Instance;

        ImagensLista = processo.Consultar(id);
        grdImagem.DataSource = ImagensLista;
        grdImagem.DataBind();

    }

    protected string GetImageUrl(object id)
    {
        if (id != null && ((int)id) != 0)
        {
            return "~/ModuloAuxiliar/Handler.ashx?imgId=" + (int)id;
        }
        else return "";
    }

    protected void descricaoClick(object sender, EventArgs e)
    {
        LinkButton lkb = (LinkButton)sender;

        if (lkb != null)
        {
            int ImagemID = int.Parse(lkb.Attributes["ImagemID"].ToString());

            Imagem imagem = new Imagem();
            imagem.ID = ImagemID;

            IImagemProcesso processo = ImagemProcesso.Instance;

            List<Imagem> resultado = processo.Consultar(imagem, TipoPesquisa.E);

            if (resultado.Count > 0)
            {
                if (resultado[0].Corpo.Length > 330)
                {
                    lblDescricao.Text = resultado[0].Corpo.Substring(0, 330);
                }
                else
                {
                    lblDescricao.Text = resultado[0].Corpo;
                }
                if (resultado[0].Titulo.Length > 18)
                {
                    lblTituloDescricao.Text = resultado[0].Titulo.Substring(0, 18);
                }
                else 
                {
                    lblTituloDescricao.Text = resultado[0].Titulo;
                }
                
            }

        }
    }

    protected void imgClick(object sender, EventArgs e)
    {
        ImageButton img = (ImageButton)sender;

        if (img != null)
        {
            int ImagemID = int.Parse(img.Attributes["ImagemID"].ToString());

            Response.Redirect("colegioExibirImagem.aspx?id=" + ImagemID);


        }
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
}
