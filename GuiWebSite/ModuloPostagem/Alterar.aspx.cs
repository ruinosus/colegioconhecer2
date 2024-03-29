﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.ModuloSite.Processos;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloSite.Constantes;

public partial class ModuloPostagem_Alterar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
        if (!IsPostBack)
        {
            ClasseAuxiliar.CarregarComboEnum<TipoPagina>(ddlTipoPagina);
            ClasseAuxiliar.CarregarComboEnum<TipoPostagem>(ddlTipoPostagem);
            ClasseAuxiliar.CarregarComboEnum<LocalPostagem>(ddlLocalPostagem);

            ddlLocalPostagem.Enabled = false;
            ddlTipoPagina.Enabled = false;
            ddlTipoPostagem.Enabled = false;

            LimparCampos();
            CarregarDados();
            AlterarCenario();
        }
    }

    private void CarregarDados()
    {
        if (Session["PostagemAlterar"] != null)
        {
            Postagem postagem = (Postagem)Session["PostagemAlterar"];

            ddlTipoPagina.SelectedValue = ((int)postagem.Pagina).ToString();
            ddlTipoPostagem.SelectedValue = ((int)postagem.Tipo).ToString();
            ddlLocalPostagem.SelectedValue = ((int)postagem.Local).ToString();
            txtCorpo.Text= postagem.Corpo;
            txtTitulo.Text = postagem.Titulo;
        }
    }

    protected void AtualizarCenarioInfra()
    {
        txtCorpo.Enabled = false;
        txtSubTitulo.Enabled = false;
        txtTitulo.Enabled = false;
    }

    protected void AtualizarCenarioAtividade()
    {
        txtSubTitulo.Enabled = false;
    }

    protected void AtualizarCenarioHistorico()
    {
        txtSubTitulo.Enabled = false;
        fupImgPostagem.Enabled = false;
    }

    protected void AlterarCenario()
    {

        TipoPostagem tipo = (TipoPostagem)int.Parse(ddlTipoPostagem.SelectedValue);
        switch (tipo)
        {
            case TipoPostagem.NaoAlterar:
                {
                    ddlTipoPagina.Visible = true;
                    ddlTipoPostagem.Visible = true;
                    ddlLocalPostagem.Visible = true;
                    ddlLocalPostagem.Enabled = false;
                    ddlTipoPagina.Enabled = false;
                    ddlTipoPostagem.Enabled = false;
                    break;
                }
            case TipoPostagem.Postagem:
                {
                    AtualizarCenarioTipoPagina();
                    break;
                }
            case TipoPostagem.EventoEducacaoInfantil:
                {
                    AtualizarCenarioParaEventos();
                    break;
                }
            case TipoPostagem.EventoEnsinoFundamentalI:
                {
                    AtualizarCenarioParaEventos();
                    break;
                }
            case TipoPostagem.EventoEnsinoFundamentalII:
                {
                    AtualizarCenarioParaEventos();
                    break;
                }
            default:
                {
                    ddlTipoPagina.Visible = true;
                    ddlTipoPostagem.Visible = true;
                    ddlLocalPostagem.Visible = true;
                    ddlLocalPostagem.Enabled = false;
                    ddlTipoPagina.Enabled = false;
                    ddlTipoPostagem.Enabled = false;
                    break;
                }
        }
    }

    protected void AtualizarCenarioTipoPagina()
    {
        TipoPagina tipoPagina = (TipoPagina)int.Parse(ddlTipoPagina.SelectedValue);

        switch (tipoPagina)
        {
            case TipoPagina.InfraEstrutura:
                {
                    AtualizarCenarioInfra();
                    break;
                }
            case TipoPagina.Atividades:
                {
                    AtualizarCenarioAtividade();
                    break;
                }
            case TipoPagina.Historico:
                {
                    AtualizarCenarioHistorico();
                    break;
                }
            default:
                {
                    AtualizarCenarioParaPostagem();
                    break;
                }
        }
    }

    protected void CarregarComboTipoPagina(object sender, EventArgs e)
    {
        lblTipoPagina.Visible = true;
        ddlTipoPagina.Visible = true;

        TipoPagina tipoPagina = (TipoPagina)int.Parse(ddlTipoPagina.SelectedValue);

        switch (tipoPagina)
        {
            case TipoPagina.Colegio:
                {
                    ClasseAuxiliar.CarregarComboEnum<LocalPostagemDefault>(ddlLocalPostagem);
                    lblLocalPostagem.Visible = true;
                    ddlLocalPostagem.Visible = true;
                    break;
                }
            case TipoPagina.FundamentalI:
                {
                    ClasseAuxiliar.CarregarComboEnum<LocalPostagemFundamental>(ddlLocalPostagem);
                    lblLocalPostagem.Visible = true;
                    ddlLocalPostagem.Visible = true;
                    break;
                }
            case TipoPagina.FundamentalII:
                {
                    ClasseAuxiliar.CarregarComboEnum<LocalPostagemFundamental>(ddlLocalPostagem);
                    lblLocalPostagem.Visible = true;
                    ddlLocalPostagem.Visible = true;
                    break;
                }
            case TipoPagina.EducacaoInfantil:
                {
                    ClasseAuxiliar.CarregarComboEnum<LocalPostagemInfantil>(ddlLocalPostagem);
                    lblLocalPostagem.Visible = true;
                    ddlLocalPostagem.Visible = true;
                    break;
                }
            case TipoPagina.InfraEstrutura:
                {
                    AtualizarCenarioInfra();
                    ClasseAuxiliar.CarregarComboEnum<LocalPostagemInfra>(ddlLocalPostagem);
                    lblLocalPostagem.Visible = true;
                    ddlLocalPostagem.Visible = true;
                    break;
                }
            case TipoPagina.Atividades:
                {
                    AtualizarCenarioAtividade();
                    ClasseAuxiliar.CarregarComboEnum<LocalPostagemAtividade>(ddlLocalPostagem);
                    lblLocalPostagem.Visible = true;
                    ddlLocalPostagem.Visible = true;
                    break;
                }
            case TipoPagina.Historico:
                {
                    AtualizarCenarioHistorico();
                    ClasseAuxiliar.CarregarComboEnum<LocalPostagemHistorico>(ddlLocalPostagem);
                    lblLocalPostagem.Visible = true;
                    ddlLocalPostagem.Visible = true;
                    break;
                }
        }
    }

    protected void AtualizarCenarioParaEventos()
    {
        txtCorpo.Visible = false;
        txtSubTitulo.Visible = false;
        lblCorpo.Visible = false;
        lblSubTitulo.Visible = false;
        ddlLocalPostagem.Visible = false;
        lblLocalPostagem.Visible = false;
        lblTipoPagina.Visible = false;
        ddlTipoPagina.Visible = false;
    }

    protected void AtualizarCenarioParaPostagem()
    {
        txtCorpo.Visible = true;
        txtSubTitulo.Visible = false;
        lblCorpo.Visible = true;
        lblSubTitulo.Visible = false;
    }

    protected void CarregarComboTipoPostagem(object sender, EventArgs e)
    {
        lblTipoPostagem.Visible = true;
        ddlTipoPostagem.Visible = true;
        TipoPostagem tipo = (TipoPostagem)int.Parse(ddlTipoPostagem.SelectedValue);

        switch (tipo)
        {
            case TipoPostagem.Postagem:
                {
                    AtualizarCenarioParaPostagem();
                    ClasseAuxiliar.CarregarComboEnum<TipoPagina>(ddlTipoPagina);
                    CarregarComboTipoPagina(null, null);
                    break;
                }
            case TipoPostagem.EventoEducacaoInfantil:
                {
                    AtualizarCenarioParaEventos();
                    break;
                }
            case TipoPostagem.EventoEnsinoFundamentalI:
                {
                    AtualizarCenarioParaEventos();
                    break;
                }
            case TipoPostagem.EventoEnsinoFundamentalII:
                {
                    AtualizarCenarioParaEventos();
                    break;
                }
            default:
                {
                    lblTipoPagina.Visible = true;
                    ddlTipoPagina.Visible = true;
                    lblLocalPostagem.Visible = true;
                    ddlLocalPostagem.Visible = true;
                    break;
                }
        }
    }

    #region Métodos Privados



    protected void Confirmar(object sender, EventArgs e)
    {
        try
        {
            IPostagemProcesso processo = PostagemProcesso.Instance;

            if (((TipoPostagem)int.Parse(ddlTipoPostagem.SelectedValue)) == TipoPostagem.NaoAlterar)
                throw new Exception("Informe o tipo da postagem.");

            if ((((TipoPostagem)int.Parse(ddlTipoPostagem.SelectedValue)) != TipoPostagem.NaoAlterar) &&
                ((TipoPostagem)int.Parse(ddlTipoPostagem.SelectedValue)) == TipoPostagem.Postagem)
            {

                if (((TipoPagina)int.Parse(ddlTipoPagina.SelectedValue)) == TipoPagina.NaoAlterar)
                    throw new Exception("Informe o tipo da página.");
                if (((TipoPostagem)int.Parse(ddlTipoPostagem.SelectedValue)) == TipoPostagem.NaoAlterar)
                    throw new Exception("Informe o tipo da postagem.");
            }

            if ((((TipoPostagem)int.Parse(ddlTipoPostagem.SelectedValue)) == TipoPostagem.EventoEducacaoInfantil ||
                ((TipoPostagem)int.Parse(ddlTipoPostagem.SelectedValue)) == TipoPostagem.EventoEnsinoFundamentalI ||
                ((TipoPostagem)int.Parse(ddlTipoPostagem.SelectedValue)) == TipoPostagem.EventoEnsinoFundamentalII) &&
                fupImgPostagem.HasFile == false)
            {
                throw new Exception("Insira uma imagem para ser capa do evento.");
            }

            Postagem postagem = new Postagem();

            postagem = (Postagem)Session["PostagemAlterar"];
            postagem.Titulo = txtTitulo.Text;
            postagem.Corpo = txtCorpo.Text;


            if ((int)TipoPostagem.Postagem == int.Parse(ddlTipoPostagem.SelectedValue))
            {
                postagem.Local = int.Parse(ddlLocalPostagem.SelectedValue);
                postagem.Tipo = int.Parse(ddlTipoPostagem.SelectedValue);
                postagem.Pagina = int.Parse(ddlTipoPagina.SelectedValue);
            }
            else
            {
                postagem.Local = 1;
                postagem.Tipo = int.Parse(ddlTipoPostagem.SelectedValue);
                postagem.Pagina = 1;
            }

            if (fupImgPostagem.HasFile)
            {
                MapeamentoImagens imagemMapeada = ClasseAuxiliar.obterImagemMapeada(postagem);

                HttpPostedFile myFile = fupImgPostagem.PostedFile;
                System.Drawing.Image fullSizeImg = System.Drawing.Image.FromStream(myFile.InputStream);
                System.Drawing.Image imagemReduzida = ClasseAuxiliar.ConverteImagem(myFile, fullSizeImg, imagemMapeada);

                postagem.ImagemI = ClasseAuxiliar.ImageToByteArray(myFile, imagemReduzida);
            }

            processo.Alterar(postagem);
            processo.Confirmar();
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.POSTAGEM_ALTERADA;
            cvaAvisoDeInformacao.IsValid = false;
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;

        }
    }

    protected void Cancelar(object sender, EventArgs e)
    {
        Response.Redirect("Consultar.aspx", false);
    }

    protected void LimparCampos(object sender, EventArgs e)
    {
        LimparCampos();
    }

    private void LimparCampos()
    {

        txtCorpo.Text = string.Empty;
        txtTitulo.Text = string.Empty;
        ddlLocalPostagem.SelectedIndex = 0;
        ddlTipoPagina.SelectedIndex = 0;
    }
    #endregion
}
