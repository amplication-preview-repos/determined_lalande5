using Microsoft.EntityFrameworkCore;
using Qualidade.APIs;
using Qualidade.APIs.Common;
using Qualidade.APIs.Dtos;
using Qualidade.APIs.Errors;
using Qualidade.APIs.Extensions;
using Qualidade.Infrastructure;
using Qualidade.Infrastructure.Models;

namespace Qualidade.APIs;

public abstract class CausaRaizsServiceBase : ICausaRaizsService
{
    protected readonly QualidadeDbContext _context;

    public CausaRaizsServiceBase(QualidadeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one CausaRaiz
    /// </summary>
    public async Task<CausaRaiz> CreateCausaRaiz(CausaRaizCreateInput createDto)
    {
        var causaRaiz = new CausaRaizDbModel
        {
            CreatedAt = createDto.CreatedAt,
            Descricao = createDto.Descricao,
            SetorResponsavel = createDto.SetorResponsavel,
            Solucao = createDto.Solucao,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            causaRaiz.Id = createDto.Id;
        }

        _context.CausaRaizs.Add(causaRaiz);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<CausaRaizDbModel>(causaRaiz.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one CausaRaiz
    /// </summary>
    public async Task DeleteCausaRaiz(CausaRaizWhereUniqueInput uniqueId)
    {
        var causaRaiz = await _context.CausaRaizs.FindAsync(uniqueId.Id);
        if (causaRaiz == null)
        {
            throw new NotFoundException();
        }

        _context.CausaRaizs.Remove(causaRaiz);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many CausaRaizs
    /// </summary>
    public async Task<List<CausaRaiz>> CausaRaizs(CausaRaizFindManyArgs findManyArgs)
    {
        var causaRaizs = await _context
            .CausaRaizs.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return causaRaizs.ConvertAll(causaRaiz => causaRaiz.ToDto());
    }

    /// <summary>
    /// Meta data about CausaRaiz records
    /// </summary>
    public async Task<MetadataDto> CausaRaizsMeta(CausaRaizFindManyArgs findManyArgs)
    {
        var count = await _context.CausaRaizs.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one CausaRaiz
    /// </summary>
    public async Task<CausaRaiz> CausaRaiz(CausaRaizWhereUniqueInput uniqueId)
    {
        var causaRaizs = await this.CausaRaizs(
            new CausaRaizFindManyArgs { Where = new CausaRaizWhereInput { Id = uniqueId.Id } }
        );
        var causaRaiz = causaRaizs.FirstOrDefault();
        if (causaRaiz == null)
        {
            throw new NotFoundException();
        }

        return causaRaiz;
    }

    /// <summary>
    /// Update one CausaRaiz
    /// </summary>
    public async Task UpdateCausaRaiz(
        CausaRaizWhereUniqueInput uniqueId,
        CausaRaizUpdateInput updateDto
    )
    {
        var causaRaiz = updateDto.ToModel(uniqueId);

        _context.Entry(causaRaiz).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.CausaRaizs.Any(e => e.Id == causaRaiz.Id))
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
