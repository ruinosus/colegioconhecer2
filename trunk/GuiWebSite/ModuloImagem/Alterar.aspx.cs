using System;
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
            
            LimparCampos();
           CarregarDados();
        }
    }




    #region Métodos Privados

    private void CarregarDados()
    {
        if (Session["ImagemAlterar"] != null)
        {
            Imagem imagem = (Imagem)Session["ImagemAlterar"];

            
            txtCorpo.Text = imagem.Corpo;

            txtSubTitulo.Text = imagem.SubTitulo;
            txtTitulo.Text = imagem.Titulo;
          
        }
    }

    protected void Confirmar(object sender, EventArgs e)
    {
        try
        {
            IImagemProcesso processo = ImagemProcesso.Instance;

            Imagem imagem = new Imagem();

            imagem = (Imagem)Session["ImagemAlterar"];
            imagem.PostagemID = ((Postagem)Session["PostagemIncluirImagem"]).ID;
            imagem.Titulo = txtTitulo.Text;
            imagem.SubTitulo = txtSubTitulo.Text;

            imagem.Corpo = txtCorpo.Text;


            if (fupImg.HasFile)
            {
                HttpPostedFile myFile = fupImg.PostedFile;

                System.Drawing.Image fullSizeImg = System.Drawing.Image.FromStream(myFile.InputStream);

                System.Drawing.Image.GetThumbnailImageAbort dummyCallBack = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);

                System.Drawing.Image thumbNailImg = fullSizeImg.GetThumbnailImage(200, 200, dummyCallBack, IntPtr.Zero);

                imagem.ImagemI = ClasseAuxiliar.ImageToByteArray(thumbNailImg);
            }

            processo.Alterar(imagem);
            processo.Confirmar();
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.IMAGEM_ALTERADA;
            cvaAvisoDeInformacao.IsValid = false;
            //LimparCampos();
            //CarregarComboLocal(null, null);
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;

        }
    }

    public bool ThumbnailCallback()
    {
        return false;
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
        txtSubTitulo.Text = string.Empty;

    }
    #endregion
}
