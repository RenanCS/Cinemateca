using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Cinemateca.Models;

namespace Cinemateca.Context
{
    public class CinefolanciaContext : DbContext
    {
        public DbSet<Filme> Filmes { get; set; }

        public  DbSet<Avaliacao> Avaliacoes { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

    }
}