using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.ModuloSite.Processos;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.Constantes;

public partial class colegioExibirImagem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            try
            {

                imgPrincipal.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?imgId=" + Request.QueryString["id"].ToString();

            }
            catch
            {
                Response.Redirect(BasicoConstantes.PAGINA_PRINCIPAL);
            }

        }
    }
}
