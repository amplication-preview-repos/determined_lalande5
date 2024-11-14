using Microsoft.EntityFrameworkCore;
using Qualidade.APIs;
using Qualidade.APIs.Common;
using Qualidade.APIs.Dtos;
using Qualidade.APIs.Errors;
using Qualidade.APIs.Extensions;
using Qualidade.Infrastructure;
using Qualidade.Infrastructure.Models;

namespace Qualidade.APIs;

public abstract class ReclamacoesItemsServiceBase : IReclamacoesItemsService
{
    protected readonly QualidadeDbContext _context;

    public ReclamacoesItemsServiceBase(QualidadeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Reclamacoes
    /// </summary>
    public async Task<Reclamacoes> CreateReclamacoes(ReclamacoesCreateInput createDto)
    {
        var reclamacoes = new ReclamacoesDbModel
        {
            CreatedAt = createDto.CreatedAt,
            Data = createDto.Data,
            Status = createDto.Status,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            reclamacoes.Id = createDto.Id;
        }

        _context.ReclamacoesItems.Add(reclamacoes);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ReclamacoesDbModel>(reclamacoes.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Reclamacoes
    /// </summary>
    public async Task DeleteReclamacoes(ReclamacoesWhereUniqueInput uniqueId)
    {
        var reclamacoes = await _context.ReclamacoesItems.FindAsync(uniqueId.Id);
        if (reclamacoes == null)
        {
            throw new NotFoundException();
        }

        _context.ReclamacoesItems.Remove(reclamacoes);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many ReclamacoesItems
    /// </summary>
    public async Task<List<Reclamacoes>> ReclamacoesItems(ReclamacoesFindManyArgs findManyArgs)
    {
        var reclamacoesItems = await _context
            .ReclamacoesItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return reclamacoesItems.ConvertAll(reclamacoes => reclamacoes.ToDto());
    }

    /// <summary>
    /// Meta data about Reclamacoes records
    /// </summary>
    public async Task<MetadataDto> ReclamacoesItemsMeta(ReclamacoesFindManyArgs findManyArgs)
    {
        var count = await _context.ReclamacoesItems.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Reclamacoes
    /// </summary>
    public async Task<Reclamacoes> Reclamacoes(ReclamacoesWhereUniqueInput uniqueId)
    {
        var reclamacoesItems = await this.ReclamacoesItems(
            new ReclamacoesFindManyArgs { Where = new ReclamacoesWhereInput { Id = uniqueId.Id } }
        );
        var reclamacoes = reclamacoesItems.FirstOrDefault();
        if (reclamacoes == null)
        {
            throw new NotFoundException();
        }

        return reclamacoes;
    }

    /// <summary>
    /// Update one Reclamacoes
    /// </summary>
    public async Task UpdateReclamacoes(
        ReclamacoesWhereUniqueInput uniqueId,
        ReclamacoesUpdateInput updateDto
    )
    {
        var reclamacoes = updateDto.ToModel(uniqueId);

        _context.Entry(reclamacoes).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ReclamacoesItems.Any(e => e.Id == reclamacoes.Id))
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
