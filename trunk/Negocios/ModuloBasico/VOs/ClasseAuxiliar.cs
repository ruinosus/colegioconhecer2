using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.ComponentModel;
using System.Reflection;
using System.IO;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloBasico.Constantes;
using System.Drawing.Imaging;
using System.Drawing;
using System.Drawing.Drawing2D;

/// <summary>
/// Summary description for ClasseAuxiliar
/// </summary>
public partial class ClasseAuxiliar
{

    private static Usuario usuarioLogado;

    /// <summary>
    /// Propriedade que representa um Usuario no sistema.
    /// </summary>
    public static Usuario UsuarioLogado
    {
        get
        {
            if (System.Web.HttpContext.Current.Session["UsuarioLogado"] != null)
                usuarioLogado = (Usuario)System.Web.HttpContext.Current.Session["UsuarioLogado"];
            else
                usuarioLogado = null;

            return usuarioLogado;
        }
        private set { usuarioLogado = value; }
    }

    /// <summary>
    /// Verifica se o Usuario está logado na aplicação.
    /// </summary>
    public static void ValidarUsuarioLogado()
    {
        if (UsuarioLogado == null)
            System.Web.HttpContext.Current.Response.Redirect(BasicoConstantes.PAGINA_PRINCIPAL, false);

    }

    /// <summary>
    /// Método responsável por montar um combo com um Enum.
    /// </summary>
    /// <typeparam name="T">Enum a ser exibido no combo.</typeparam>
    /// <param name="cbo">combo para montatem</param>
    public static void CarregarComboEnum<T>(DropDownList cbo)
    {
        cbo.Items.Clear();

        Type objType = typeof(T);
        FieldInfo[] propriedades = objType.GetFields();

        foreach (FieldInfo objField in propriedades)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])objField.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
                cbo.Items.Add(new ListItem(attributes[0].Description, objField.GetRawConstantValue().ToString()));
        }
    }


    /// <summary>
    /// Método responsável por converter uma imagem em um array de bytes.
    /// </summary>
    /// <param name="imageIn">Imagem a ser convertida.</param>
    /// <returns>Array de Bytes que formam a imagem.</returns>
    public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
    {   
        MemoryStream ms = new MemoryStream();

            System.Drawing.Imaging.ImageCodecInfo[] info = ImageCodecInfo.GetImageEncoders();
            EncoderParameters encoderParameters;
            encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, 100L);
            imageIn.Save(ms, info[1], encoderParameters);

        return ms.ToArray();
    }

    /// <summary>
    /// Método responsável por converter uma imagem em um array de bytes.
    /// </summary>
    /// <param name="imageIn">Imagem a ser convertida.</param>
    /// <param name="file">Arquivo passado.</param>
    /// <returns>Array de Bytes que formam a imagem.</returns>
    public static byte[] ImageToByteArray(HttpPostedFile file, System.Drawing.Image imageIn)
    {
        MemoryStream ms = new MemoryStream();

        if (file.ContentType == "image/jpg" || file.ContentType == "image/jpeg" || file.ContentType == "image/pjpeg")
        {

            System.Drawing.Imaging.ImageCodecInfo[] info = ImageCodecInfo.GetImageEncoders();
            EncoderParameters encoderParameters;
            encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, 100L);
            imageIn.Save(ms, info[1], encoderParameters);
        }

        return ms.ToArray();
    }

    /// <summary>
    /// Método para converter as imagens
    /// </summary>
    /// <param name="imagemOriginal">imagemOriginal</param>
    /// <param name="imagemMapeada">imagemMapeada</param>
    /// <returns>Imagem convertida</returns>
    public static System.Drawing.Image ConverteImagem(HttpPostedFile file, System.Drawing.Image imagemOriginal, MapeamentoImagens imagemMapeada)
    {
        if (imagemMapeada.Comprimento == 0 || imagemMapeada.Altura == 0)
        {
            imagemMapeada.Comprimento = 800;
            imagemMapeada.Altura = 600;
        }
        Bitmap imagem = new Bitmap((int)imagemMapeada.Comprimento, (int)imagemMapeada.Altura, PixelFormat.Format24bppRgb);

        using (Graphics canvas = Graphics.FromImage(imagem))
        {
            canvas.SmoothingMode = SmoothingMode.AntiAlias;
            canvas.InterpolationMode = InterpolationMode.HighQualityBicubic;
            canvas.PixelOffsetMode = PixelOffsetMode.HighQuality;
            canvas.DrawImage(imagemOriginal, 0, 0, imagemMapeada.Comprimento, imagemMapeada.Altura);
            MemoryStream m = new MemoryStream();
            if (file.ContentType == "image/jpg" || file.ContentType == "image/jpeg" || file.ContentType == "image/pjpeg")
            {
                imagem.Save(m, ImageFormat.Jpeg);
            }
            if (file.ContentType == "image/gif" || file.ContentType == "image/gif")
            {
                imagem.Save(m, ImageFormat.Gif);
            }
            if (file.ContentType == "image/x-png" || file.ContentType == "image/png")
            {
                imagem.Save(m, ImageFormat.Png);
            }
            return imagem;
        }
    }
    
    /// <summary>
    /// Método responsável por converter um array de bytes em uma imagem.
    /// </summary>
    /// <param name="byteArrayIn">Array de bytes a ser convertido.</param>
    /// <returns>Imagem formada pelo array de bytes.</returns>
    public static System.Drawing.Image ByteArrayToImage(byte[] byteArrayIn)
    {
        MemoryStream ms = new MemoryStream(byteArrayIn);
        System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
        return returnImage;

    }

    public static List<MapeamentoImagens> listaMapeamento = new List<MapeamentoImagens>();

    public static void CarregarMapeamentos()
    {
        MapeamentoImagens mapeamento1 = new MapeamentoImagens(4, 1, 1, 130, 270);
        MapeamentoImagens mapeamento2 = new MapeamentoImagens(7, 1, 1, 290, 165);
        MapeamentoImagens mapeamento3 = new MapeamentoImagens(7, 1, 2, 390, 130);
        MapeamentoImagens mapeamento4 = new MapeamentoImagens(4, 1, 4, 150, 80);
        MapeamentoImagens mapeamento5 = new MapeamentoImagens(5, 1, 4, 235, 80);
        MapeamentoImagens mapeamento6 = new MapeamentoImagens(7, 1, 4, 390, 130);
        MapeamentoImagens mapeamento7 = new MapeamentoImagens(4, 1, 3, 150, 80);
        MapeamentoImagens mapeamento8 = new MapeamentoImagens(5, 1, 3, 150, 160);
        MapeamentoImagens mapeamento9 = new MapeamentoImagens(7, 1, 3, 390, 130);
        MapeamentoImagens mapeamento10 = new MapeamentoImagens(1, 1, 7, 160, 90);
        MapeamentoImagens mapeamento11 = new MapeamentoImagens(2, 1, 7, 160, 90);
        MapeamentoImagens mapeamento12 = new MapeamentoImagens(3, 1, 7, 160, 90);
        MapeamentoImagens mapeamento13 = new MapeamentoImagens(4, 1, 7, 160, 90);
        MapeamentoImagens mapeamento14 = new MapeamentoImagens(1, 1, 6, 100, 96);
        MapeamentoImagens mapeamento15 = new MapeamentoImagens(2, 1, 6, 100, 96);
        MapeamentoImagens mapeamento16 = new MapeamentoImagens(3, 1, 6, 100, 96);
        MapeamentoImagens mapeamento17 = new MapeamentoImagens(4, 1, 6, 100, 96);
        MapeamentoImagens mapeamento18 = new MapeamentoImagens(5, 1, 6, 100, 96);
        MapeamentoImagens mapeamento19 = new MapeamentoImagens(6, 1, 6, 100, 96);
        MapeamentoImagens mapeamento20 = new MapeamentoImagens(7, 1, 6, 100, 96);
        MapeamentoImagens mapeamento21 = new MapeamentoImagens(8, 1, 6, 100, 96);

        listaMapeamento.Add(mapeamento1);
        listaMapeamento.Add(mapeamento2);
        listaMapeamento.Add(mapeamento3);
        listaMapeamento.Add(mapeamento4);
        listaMapeamento.Add(mapeamento5);
        listaMapeamento.Add(mapeamento6);
        listaMapeamento.Add(mapeamento7);
        listaMapeamento.Add(mapeamento8);
        listaMapeamento.Add(mapeamento9);
        listaMapeamento.Add(mapeamento10);
        listaMapeamento.Add(mapeamento11);
        listaMapeamento.Add(mapeamento12);
        listaMapeamento.Add(mapeamento13);
        listaMapeamento.Add(mapeamento14);
        listaMapeamento.Add(mapeamento15);
        listaMapeamento.Add(mapeamento16);
        listaMapeamento.Add(mapeamento17);
        listaMapeamento.Add(mapeamento18);
        listaMapeamento.Add(mapeamento19);
        listaMapeamento.Add(mapeamento20);
        listaMapeamento.Add(mapeamento21);

    }

    public static MapeamentoImagens obterImagemMapeada(Postagem postagem)
    {
        ClasseAuxiliar.CarregarMapeamentos();
        MapeamentoImagens imagemMapeada = new MapeamentoImagens();

        foreach (MapeamentoImagens map in ClasseAuxiliar.listaMapeamento)
        {
            if (map.LocalPostagem == postagem.Local &&
                map.PaginaPostagem == postagem.Pagina &&
                map.TipoPostagem == postagem.Tipo)
            {
                imagemMapeada = map;
            }
        }

        return imagemMapeada;
    }


}
