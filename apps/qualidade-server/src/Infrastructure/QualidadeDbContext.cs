using Microsoft.EntityFrameworkCore;
using Qualidade.Infrastructure.Models;

namespace Qualidade.Infrastructure;

public class QualidadeDbContext : DbContext
{
    public QualidadeDbContext(DbContextOptions<QualidadeDbContext> options)
        : base(options) { }

    public DbSet<RncDbModel> Rncs { get; set; }

    public DbSet<ReclamacoesDbModel> ReclamacoesItems { get; set; }

    public DbSet<EstatisticasDbModel> EstatisticasItems { get; set; }

    public DbSet<CausaRaizDbModel> CausaRaizs { get; set; }
}
