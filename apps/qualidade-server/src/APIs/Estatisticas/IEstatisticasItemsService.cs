using Qualidade.APIs.Common;
using Qualidade.APIs.Dtos;

namespace Qualidade.APIs;

public interface IEstatisticasItemsService
{
    /// <summary>
    /// Create one Estatisticas
    /// </summary>
    public Task<Estatisticas> CreateEstatisticas(EstatisticasCreateInput estatisticas);

    /// <summary>
    /// Delete one Estatisticas
    /// </summary>
    public Task DeleteEstatisticas(EstatisticasWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many EstatisticasItems
    /// </summary>
    public Task<List<Estatisticas>> EstatisticasItems(EstatisticasFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Estatisticas records
    /// </summary>
    public Task<MetadataDto> EstatisticasItemsMeta(EstatisticasFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Estatisticas
    /// </summary>
    public Task<Estatisticas> Estatisticas(EstatisticasWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Estatisticas
    /// </summary>
    public Task UpdateEstatisticas(
        EstatisticasWhereUniqueInput uniqueId,
        EstatisticasUpdateInput updateDto
    );
}
