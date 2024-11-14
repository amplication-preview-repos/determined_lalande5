using Qualidade.APIs.Common;
using Qualidade.APIs.Dtos;

namespace Qualidade.APIs;

public interface IReclamacoesItemsService
{
    /// <summary>
    /// Create one Reclamacoes
    /// </summary>
    public Task<Reclamacoes> CreateReclamacoes(ReclamacoesCreateInput reclamacoes);

    /// <summary>
    /// Delete one Reclamacoes
    /// </summary>
    public Task DeleteReclamacoes(ReclamacoesWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many ReclamacoesItems
    /// </summary>
    public Task<List<Reclamacoes>> ReclamacoesItems(ReclamacoesFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Reclamacoes records
    /// </summary>
    public Task<MetadataDto> ReclamacoesItemsMeta(ReclamacoesFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Reclamacoes
    /// </summary>
    public Task<Reclamacoes> Reclamacoes(ReclamacoesWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Reclamacoes
    /// </summary>
    public Task UpdateReclamacoes(
        ReclamacoesWhereUniqueInput uniqueId,
        ReclamacoesUpdateInput updateDto
    );
}
