using Microsoft.EntityFrameworkCore;
using Qualidade.APIs;
using Qualidade.APIs.Common;
using Qualidade.APIs.Dtos;
using Qualidade.APIs.Errors;
using Qualidade.APIs.Extensions;
using Qualidade.Infrastructure;
using Qualidade.Infrastructure.Models;

namespace Qualidade.APIs;

public abstract class RncsServiceBase : IRncsService
{
    protected readonly QualidadeDbContext _context;

    public RncsServiceBase(QualidadeDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one RNC
    /// </summary>
    public async Task<Rnc> CreateRnc(RncCreateInput createDto)
    {
        var rnc = new RncDbModel
        {
            Cliente = createDto.Cliente,
            CreatedAt = createDto.CreatedAt,
            DetalhesDaReclamacao = createDto.DetalhesDaReclamacao,
            IniciarColetaDeMaterial = createDto.IniciarColetaDeMaterial,
            Status = createDto.Status,
            TTulo = createDto.TTulo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            rnc.Id = createDto.Id;
        }

        _context.Rncs.Add(rnc);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<RncDbModel>(rnc.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one RNC
    /// </summary>
    public async Task DeleteRnc(RncWhereUniqueInput uniqueId)
    {
        var rnc = await _context.Rncs.FindAsync(uniqueId.Id);
        if (rnc == null)
        {
            throw new NotFoundException();
        }

        _context.Rncs.Remove(rnc);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many RNCS
    /// </summary>
    public async Task<List<Rnc>> Rncs(RncFindManyArgs findManyArgs)
    {
        var rncs = await _context
            .Rncs.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return rncs.ConvertAll(rnc => rnc.ToDto());
    }

    /// <summary>
    /// Meta data about RNC records
    /// </summary>
    public async Task<MetadataDto> RncsMeta(RncFindManyArgs findManyArgs)
    {
        var count = await _context.Rncs.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one RNC
    /// </summary>
    public async Task<Rnc> Rnc(RncWhereUniqueInput uniqueId)
    {
        var rncs = await this.Rncs(
            new RncFindManyArgs { Where = new RncWhereInput { Id = uniqueId.Id } }
        );
        var rnc = rncs.FirstOrDefault();
        if (rnc == null)
        {
            throw new NotFoundException();
        }

        return rnc;
    }

    /// <summary>
    /// Update one RNC
    /// </summary>
    public async Task UpdateRnc(RncWhereUniqueInput uniqueId, RncUpdateInput updateDto)
    {
        var rnc = updateDto.ToModel(uniqueId);

        _context.Entry(rnc).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Rncs.Any(e => e.Id == rnc.Id))
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
