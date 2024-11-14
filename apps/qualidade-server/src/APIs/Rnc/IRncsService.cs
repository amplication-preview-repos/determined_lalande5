using Qualidade.APIs.Common;
using Qualidade.APIs.Dtos;

namespace Qualidade.APIs;

public interface IRncsService
{
    /// <summary>
    /// Create one RNC
    /// </summary>
    public Task<Rnc> CreateRnc(RncCreateInput rnc);

    /// <summary>
    /// Delete one RNC
    /// </summary>
    public Task DeleteRnc(RncWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many RNCS
    /// </summary>
    public Task<List<Rnc>> Rncs(RncFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about RNC records
    /// </summary>
    public Task<MetadataDto> RncsMeta(RncFindManyArgs findManyArgs);

    /// <summary>
    /// Get one RNC
    /// </summary>
    public Task<Rnc> Rnc(RncWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one RNC
    /// </summary>
    public Task UpdateRnc(RncWhereUniqueInput uniqueId, RncUpdateInput updateDto);
}
