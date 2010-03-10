using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloSite.Repositorios;
using Negocios.ModuloSite.Fabricas;
using Negocios.ModuloSite.VOs;

namespace Negocios.ModuloSite.Processos
{
    public class PostagemProcesso : Negocios.ModuloBasico.Singleton.Singleton<PostagemProcesso>, IPostagemProcesso
    {
        #region Atributos
        private IPostagemRepositorio postagemRepositorio = null;
        #endregion

        #region Construtor
        public PostagemProcesso()
        {
            postagemRepositorio = PostagemFabrica.IPostagemInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Postagem postagem)
        {
            try
            {
                this.postagemRepositorio.Incluir(postagem);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Postagem postagem)
        {
            try
            {
                this.postagemRepositorio.Excluir(postagem);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.postagemRepositorio.Excluir(postagem);
        }

        public void VerificaSeJaExiste(Postagem postagem)
        {
            List<Postagem> resultadoConsulta = new List<Postagem>();
            resultadoConsulta = Consultar();

            foreach (Postagem p in resultadoConsulta)
            {
                if (p.Local == postagem.Local &&
                    p.Pagina == postagem.Pagina &&
                    p.Tipo == postagem.Tipo)
                {
                    Excluir(p);
                }
            }
        }

        public void Alterar(Postagem postagem)
        {
            this.postagemRepositorio.Alterar(postagem);
        }

        public List<Postagem> Consultar(Postagem postagem, TipoPesquisa tipoPesquisa)
        {
            List<Postagem> postagemList = this.postagemRepositorio.Consultar(postagem, tipoPesquisa);

            foreach (Postagem post in postagemList)
            {
                post.LerMais = "<a href=\"colegioPost.aspx?id=" + post.ID + "&tela=" + ((int)post.Pagina) + "\"> Ler Mais...</a>";
                post.LinkBotao = "colegioPost.aspx?id=" + post.ID + "&tela=" + ((int)post.Pagina) + "";
            }
            return postagemList;
        }

        public List<Postagem> Consultar()
        {
            List<Postagem> postagemList = postagemRepositorio.Consultar();

            foreach (Postagem post in postagemList)
            {
                post.LerMais = "<a href=\"colegioPost.aspx?id=" + post.ID + "&tela=" + ((int)post.Pagina) + "\"> Ler Mais...</a>";
                post.LinkBotao = "colegioPost.aspx?id=" + post.ID + "&tela=" + ((int)post.Pagina) + "";
            }

            return postagemList;
        }

        public PostagemExibicao Consultar(TipoPagina tipo)
        {
            PostagemExibicao resultado = new PostagemExibicao();
            List<Postagem> PostagemList = Consultar();
            #region Direita
            resultado.PostagemDireitaUm = (from p in PostagemList
                                           where p.Pagina == (int)tipo && p.Local == (int)LocalPostagem.DireitaUm
                                           && p.Tipo == (int)TipoPostagem.Postagem
                                           select p).SingleOrDefault();
            resultado.PostagemDireitaTres = (from p in PostagemList
                                             where p.Pagina == (int)tipo && p.Local == (int)LocalPostagem.DireitaTres
                                             && p.Tipo == (int)TipoPostagem.Postagem
                                             select p).SingleOrDefault();
            resultado.PostagemDireitaDois = (from p in PostagemList
                                             where p.Pagina == (int)tipo && p.Local == (int)LocalPostagem.DireitaDois
                                             && p.Tipo == (int)TipoPostagem.Postagem
                                             select p).SingleOrDefault();
            #endregion

            #region Esquerda

            resultado.PostagemEsquerdaDois = (from p in PostagemList
                                              where p.Pagina == (int)tipo && p.Local == (int)LocalPostagem.EsquerdaDois
                                              && p.Tipo == (int)TipoPostagem.Postagem
                                              select p).SingleOrDefault();
            resultado.PostagemEsquerdaTres = (from p in PostagemList
                                              where p.Pagina == (int)tipo && p.Local == (int)LocalPostagem.EsquerdaTres
                                              && p.Tipo == (int)TipoPostagem.Postagem
                                              select p).SingleOrDefault();
            resultado.PostagemEsquerdaUm = (from p in PostagemList
                                            where p.Pagina == (int)tipo && p.Local == (int)LocalPostagem.EsquerdaUm
                                            && p.Tipo == (int)TipoPostagem.Postagem
                                            select p).SingleOrDefault();

            #endregion

            #region Meio

            resultado.PostagemMeioDois = (from p in PostagemList
                                          where p.Pagina == (int)tipo && p.Local == (int)LocalPostagem.MeioDois
                                          && p.Tipo == (int)TipoPostagem.Postagem
                                          select p).SingleOrDefault();
            resultado.PostagemMeioTres = (from p in PostagemList
                                          where p.Pagina == (int)tipo && p.Local == (int)LocalPostagem.MeioTres
                                          && p.Tipo == (int)TipoPostagem.Postagem
                                          select p).SingleOrDefault();
            resultado.PostagemMeioUm = (from p in PostagemList
                                        where p.Pagina == (int)tipo && p.Local == (int)LocalPostagem.MeioUm
                                        && p.Tipo == (int)TipoPostagem.Postagem
                                        select p).SingleOrDefault();

            #endregion
            return resultado;
        }

        public List<PostagemExibicao> Consultar(List<Postagem> postagensLista)
        {
            List<PostagemExibicao> resultado = new List<PostagemExibicao>();
            List<Postagem> postagens = postagensLista;


            bool continua = true;
            PostagemExibicao postagemExibicao;
            if (postagens.Count > 0)
                postagens.RemoveAt(0);

            while (continua)
            {
                postagemExibicao = new PostagemExibicao();
                if (postagens.Count >= 3)
                {
                    postagemExibicao.PostagemMeioUm = postagens[1];
                    postagemExibicao.PostagemDireitaUm = postagens[2];
                    postagemExibicao.PostagemEsquerdaUm = postagens[0];


                    postagens.RemoveAt(2);
                    postagens.RemoveAt(1);
                    postagens.RemoveAt(0);

                    resultado.Add(postagemExibicao);
                }
                else if (postagens.Count == 2)
                {
                    postagemExibicao.PostagemMeioUm = postagens[1];
                    postagemExibicao.PostagemEsquerdaUm = postagens[0];
                    postagens.RemoveAt(1);
                    postagens.RemoveAt(0);

                    resultado.Add(postagemExibicao);
                }
                else if (postagens.Count == 1)
                {
                    postagemExibicao.PostagemEsquerdaUm = postagens[0];
                    resultado.Add(postagemExibicao);
                    postagens.RemoveAt(0);


                }
                else
                {
                    continua = false;
                }

            }

            return resultado;


        }



        public void Confirmar()
        {
            postagemRepositorio.Confirmar();
        }

        #endregion
    }

}