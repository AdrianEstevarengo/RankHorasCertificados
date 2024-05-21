using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RankHorasCertificados.Models;

namespace RankHorasCertificados.Data
{
    public class RankHorasCertificadosContext : DbContext
    {
        public RankHorasCertificadosContext (DbContextOptions<RankHorasCertificadosContext> options)
            : base(options)
        {
        }

        public DbSet<RankHorasCertificados.Models.UsuarioModel> UsuarioModel { get; set; } = default!;

        public DbSet<RankHorasCertificados.Models.CursoModel>? Curso { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioModel>()
                .HasMany(u => u.Cursos) 
                .WithOne(c => c.UsuarioModel) 
                .HasForeignKey(c => c.UsuarioId); 
        }
    }
}
