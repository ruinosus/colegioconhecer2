using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloSite.VOs
{
    public class ImagemExibicao
    {
        private Imagem imagemEsquerda;
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

        private Imagem imagemMeio;
        public Imagem ImagemMeio
        {

            get
            {
                if (imagemMeio == null)
                    imagemMeio = new Imagem();
                return imagemMeio;
            }

            set { imagemMeio = value;   }
        }

        private Imagem imagemDireita;
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
    }
}
