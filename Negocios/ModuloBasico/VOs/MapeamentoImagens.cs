using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.ModuloBasico.VOs
{
    public class MapeamentoImagens
    {
        private int localPostagem;
        private int tipoPostagem;
        private int paginaPostagem;
        private int altura;
        private int comprimento;

        public MapeamentoImagens()
        { 
        }

        public MapeamentoImagens(int localPostagem, int tipoPostagem, int paginaPostagem, int altura, int comprimento)
        {
            this.altura = altura;
            this.comprimento = comprimento;
            this.localPostagem = localPostagem;
            this.tipoPostagem = tipoPostagem;
            this.paginaPostagem = paginaPostagem;
        }

        public int LocalPostagem
        {
            get { return localPostagem; }
            set { localPostagem = value; }
        }

        public int TipoPostagem
        {
            get { return tipoPostagem; }
            set { tipoPostagem = value; }
        }

        public int PaginaPostagem
        {
            get { return paginaPostagem; }
            set { paginaPostagem = value; }
        }

        public int Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public int Comprimento
        {
            get { return comprimento; }
            set { comprimento = value; }
        }
    }
}
