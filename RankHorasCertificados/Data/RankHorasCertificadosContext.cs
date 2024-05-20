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

        public DbSet<RankHorasCertificados.Models.Curso>? Curso { get; set; }
    }
}
