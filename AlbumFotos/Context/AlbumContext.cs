using AlbumFotos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AlbumFotos.Context
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Albuns { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
        public AlbumContext(DbContextOptions<AlbumContext> options) : base(options) { }

    }
}
