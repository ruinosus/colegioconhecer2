﻿using System;
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
        private float altura;
        private float comprimento;
        private bool possuiImagem;

        public MapeamentoImagens()
        { 
        }

        public MapeamentoImagens(int localPostagem, int tipoPostagem, int paginaPostagem, float altura, float comprimento, bool possuiImagem)
        {
            this.altura = altura;
            this.comprimento = comprimento;
            this.localPostagem = localPostagem;
            this.tipoPostagem = tipoPostagem;
            this.paginaPostagem = paginaPostagem;
            this.possuiImagem = possuiImagem;
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

        public float Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public float Comprimento
        {
            get { return comprimento; }
            set { comprimento = value; }
        }

        public bool PossuiImagem
        {
            get { return possuiImagem; }
            set { possuiImagem = value; }
        }
    }
}
