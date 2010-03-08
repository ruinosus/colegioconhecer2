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
using Negocios.ModuloSite.Constantes;
using Negocios.ModuloBasico.Constantes;

public partial class colegioPost : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["id"] != null && Request.QueryString["tela"] != null)
        {
            try
            {
                IPostagemProcesso processo = PostagemProcesso.Instance;
                Postagem postagem = new Postagem();
                postagem.ID = Convert.ToInt32(Request.QueryString["id"]);
                postagem.Pagina = Convert.ToInt32(Request.QueryString["tela"]);
                List<Postagem> resultado = processo.Consultar(postagem, TipoPesquisa.E);

                if (resultado.Count > 0)
                {
                    lblArtigoUnico1.Text = resultado[0].Corpo;
                    lblTituloMeio1.Text = resultado[0].Titulo;
                    TipoPagina tipoPagina = (TipoPagina)resultado[0].Pagina;
                    switch (tipoPagina)
                    {
                        case TipoPagina.NaoAlterar:
                            {

                                break;
                            }
                        case TipoPagina.Colegio:
                            {
                                lkbVoltar.PostBackUrl = "~/default.aspx";
                                lkbVoltar.Text = "Voltar para Colegio";
                                break;
                            }
                        case TipoPagina.EducacaoInfantil:
                            {
                                lkbVoltar.PostBackUrl = "~/colegioInfantil.aspx";
                                lkbVoltar.Text = "Voltar para Educação Infantil";
                                break;
                            }
                        case TipoPagina.FundamentalI:
                            {
                                lkbVoltar.PostBackUrl = "~/colegioFundamental1.aspx";
                                lkbVoltar.Text = "Voltar para Fundamental 1";
                                break;
                            }
                        case TipoPagina.FundamentalII:
                            {
                                lkbVoltar.PostBackUrl = "~/colegioFundamental2.aspx";
                                lkbVoltar.Text = "Voltar para Fundamental 2";
                                break;
                            }
                        case TipoPagina.Atividades:
                            {
                                lkbVoltar.PostBackUrl = "~/colegioAtividades.aspx";
                                lkbVoltar.Text = "Voltar para Atividades";
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
            }
            catch
            {
                Response.Redirect(BasicoConstantes.PAGINA_PRINCIPAL);
            }
            
            
        }
        
    }

   
}
