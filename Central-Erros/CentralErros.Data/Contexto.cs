using System;
using Microsoft.EntityFrameworkCore;
using CentralErros.Domain.Models;
using CentralErros.Data.Map;


namespace CentralErros.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Aviso> Aviso { get; set; }

        public DbSet<Aplicacao> Aplicacao { get; set; }

        public DbSet<Log> Log { get; set; }

        public DbSet<TipoLog> TipoLog { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<UsuarioAplicacao> UsuarioAplicacao { get; set; }

        public DbSet<UsuarioAviso> UsuarioAviso { get; set; }


        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AplicacaoMap());
            modelBuilder.ApplyConfiguration(new AvisoMap());
            modelBuilder.ApplyConfiguration(new LogMap());
            modelBuilder.ApplyConfiguration(new TipoLogMap());
            modelBuilder.ApplyConfiguration(new UsuarioAplicacaoMap());
            modelBuilder.ApplyConfiguration(new UsuarioAvisoMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
