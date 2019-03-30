using CaelumEstoque.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CaelumEstoque.DAO
{
    public class EstoqueContext : DbContext
    {
        public EstoqueContext() : base("name=EstoqueContext")
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<CategoriaDoProduto> Categorias { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CategoriaDoProduto>()
                .HasMany(q => q.Produto)
                .WithRequired(q => q.Categoria)
                .HasForeignKey(q => q.CategoriaId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);


        }


    }
}