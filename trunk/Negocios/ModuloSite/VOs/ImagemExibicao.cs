using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloSite.VOs
{
    public class ImagemExibicao
    {

        #region Atributos
        private Imagem imagemEsquerda;
        private Imagem imagemEsquerdaMeio;
        private Imagem imagemMeio;
        private Imagem imagemDireitaMeio; 
        private Imagem imagemDireita; 
        #endregion

        #region Propriedades
        public Imagem ImagemEsquerda
        {

            get
            {
                if (imagemEsquerda == null)
                    imagemEsquerda = new Imagem();
                return imagemEsquerda;
            }

            set { imagemEsquerda = value; }
        }

        public Imagem ImagemEsquerdaMeio
        {

            get
            {
                if (imagemEsquerdaMeio == null)
                    imagemEsquerdaMeio = new Imagem();
                return imagemEsquerdaMeio;
            }

            set { imagemEsquerdaMeio = value; }
        }

        public Imagem ImagemMeio
        {

            get
            {
                if (imagemMeio == null)
                    imagemMeio = new Imagem();
                return imagemMeio;
            }

            set { imagemMeio = value; }
        }

        public Imagem ImagemDireitaMeio
        {

            get
            {
                if (imagemDireitaMeio == null)
                    imagemDireitaMeio = new Imagem();
                return imagemDireitaMeio;
            }

            set { imagemDireitaMeio = value; }
        } 

        public Imagem ImagemDireita
        {

            get
            {
                if (imagemDireita == null)
                    imagemDireita = new Imagem();
                return imagemDireita;
            }

            set { imagemDireita = value; }
        } 
        #endregion
    }
}
