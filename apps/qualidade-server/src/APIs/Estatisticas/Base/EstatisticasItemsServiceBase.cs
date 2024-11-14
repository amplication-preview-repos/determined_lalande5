using Microsoft.EntityFrameworkCore;
using Qualidade.APIs;
using Qualidade.APIs.Common;
using Qualidade.APIs.Dtos;
using Qualidade.APIs.Errors;
using Qualidade.APIs.Extensions;
using Qualidade.Infrastructure;
using Qualidade.Infrastructure.Models;

namespace Qualidade.APIs;

public abstract class EstatisticasItemsServiceBase : IEstatisticasItemsService
{
    protected readonly QualidadeDbContext _context;

    public EstatisticasItemsServiceBase(QualidadeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Estatisticas
    /// </summary>
    public async Task<Estatisticas> CreateEstatisticas(EstatisticasCreateInput createDto)
    {
        var estatisticas = new EstatisticasDbModel
        {
            CreatedAt = createDto.CreatedAt,
            Tipo = createDto.Tipo,
            UpdatedAt = createDto.UpdatedAt,
            Valor = createDto.Valor
        };

        if (createDto.Id != null)
        {
            estatisticas.Id = createDto.Id;
        }

        _context.EstatisticasItems.Add(estatisticas);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<EstatisticasDbModel>(estatisticas.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Estatisticas
    /// </summary>
    public async Task DeleteEstatisticas(EstatisticasWhereUniqueInput uniqueId)
    {
        var estatisticas = await _context.EstatisticasItems.FindAsync(uniqueId.Id);
        if (estatisticas == null)
        {
            throw new NotFoundException();
        }

        _context.EstatisticasItems.Remove(estatisticas);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many EstatisticasItems
    /// </summary>
    public async Task<List<Estatisticas>> EstatisticasItems(EstatisticasFindManyArgs findManyArgs)
    {
        var estatisticasItems = await _context
            .EstatisticasItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return estatisticasItems.ConvertAll(estatisticas => estatisticas.ToDto());
    }

    /// <summary>
    /// Meta data about Estatisticas records
    /// </summary>
    public async Task<MetadataDto> EstatisticasItemsMeta(EstatisticasFindManyArgs findManyArgs)
    {
        var count = await _context.EstatisticasItems.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Estatisticas
    /// </summary>
    public async Task<Estatisticas> Estatisticas(EstatisticasWhereUniqueInput uniqueId)
    {
        var estatisticasItems = await this.EstatisticasItems(
            new EstatisticasFindManyArgs { Where = new EstatisticasWhereInput { Id = uniqueId.Id } }
        );
        var estatisticas = estatisticasItems.FirstOrDefault();
        if (estatisticas == null)
        {
            throw new NotFoundException();
        }

        return estatisticas;
    }

    /// <summary>
    /// Update one Estatisticas
    /// </summary>
    public async Task UpdateEstatisticas(
        EstatisticasWhereUniqueInput uniqueId,
        EstatisticasUpdateInput updateDto
    )
    {
        var estatisticas = updateDto.ToModel(uniqueId);

        _context.Entry(estatisticas).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.EstatisticasItems.Any(e => e.Id == estatisticas.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }
}
