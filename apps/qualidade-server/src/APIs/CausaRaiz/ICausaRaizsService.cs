using Qualidade.APIs.Common;
using Qualidade.APIs.Dtos;

namespace Qualidade.APIs;

public interface ICausaRaizsService
{
    /// <summary>
    /// Create one CausaRaiz
    /// </summary>
    public Task<CausaRaiz> CreateCausaRaiz(CausaRaizCreateInput causaraiz);

    /// <summary>
    /// Delete one CausaRaiz
    /// </summary>
    public Task DeleteCausaRaiz(CausaRaizWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many CausaRaizs
    /// </summary>
    public Task<List<CausaRaiz>> CausaRaizs(CausaRaizFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about CausaRaiz records
    /// </summary>
    public Task<MetadataDto> CausaRaizsMeta(CausaRaizFindManyArgs findManyArgs);

    /// <summary>
    /// Get one CausaRaiz
    /// </summary>
    public Task<CausaRaiz> CausaRaiz(CausaRaizWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one CausaRaiz
    /// </summary>
    public Task UpdateCausaRaiz(CausaRaizWhereUniqueInput uniqueId, CausaRaizUpdateInput updateDto);
}
