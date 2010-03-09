﻿using System;
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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            VerificaSelecao();
            if (!string.IsNullOrEmpty(ddlOpcoes.SelectedValue))
            {
                IImagemProcesso processo = ImagemProcesso.Instance;

                //List<ImagemExibicao> resultado = processo.Consultar(int.Parse(ddlOpcoes.SelectedValue));
                List<ImagemExibicao> resultado = processo.Consultar(4);
                grdImagem.DataSource = resultado;
                grdImagem.DataBind();
            }
            
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

    private List<Postagem> PesquisaEventos(TipoPostagem tipoPostagem)
    {
        IPostagemProcesso processo = PostagemProcesso.Instance;
        Postagem post = new Postagem();
        post.Tipo = (int)tipoPostagem;
        List<Postagem> postagemList = processo.Consultar(post,TipoPesquisa.E);
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
        if (id != null && ((int)id)!=0)
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
}
