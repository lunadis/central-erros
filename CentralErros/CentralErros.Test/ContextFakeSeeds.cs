using CentralErros.Data;
using CentralErros.Domain.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentralErros.Test.Domain
{
    public static class ContextFakeSeeds
    {
        public static Contexto SeedAplicacao(Contexto contexto)
        {
            if (contexto.Aplicacao.Count() > 1) 
                return contexto;
            var aplicacoes = new List<Aplicacao>()
            {
                new Aplicacao(){Descricao = "Ponto de venda Fronte de caixa", Nome = "PDV"},
                new Aplicacao(){Descricao = "Sistema de retaguarda", Nome = "Painel Executivo"},
                new Aplicacao(){Descricao = "Sistema de gestão de projeções", Nome = "Painel de desempenho"},
            };

            contexto.Aplicacao.AddRange(aplicacoes);
            contexto.SaveChanges();

            aplicacoes.ForEach(x =>
            {
                contexto.Entry<Aplicacao>(x).State = EntityState.Detached;
            });

            return contexto;

        }

        public static Contexto SeedUsuario(Contexto contexto)
        {

            throw new NotImplementedException();
        }
    }
}
