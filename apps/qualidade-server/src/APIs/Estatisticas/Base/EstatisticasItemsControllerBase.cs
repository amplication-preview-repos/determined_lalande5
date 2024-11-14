using Microsoft.AspNetCore.Mvc;
using Qualidade.APIs;
using Qualidade.APIs.Common;
using Qualidade.APIs.Dtos;
using Qualidade.APIs.Errors;

namespace Qualidade.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class EstatisticasItemsControllerBase : ControllerBase
{
    protected readonly IEstatisticasItemsService _service;

    public EstatisticasItemsControllerBase(IEstatisticasItemsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Estatisticas
    /// </summary>
    [HttpPost()]
    public async Task<ActionResult<Estatisticas>> CreateEstatisticas(EstatisticasCreateInput input)
    {
        var estatisticas = await _service.CreateEstatisticas(input);

        return CreatedAtAction(nameof(Estatisticas), new { id = estatisticas.Id }, estatisticas);
    }

    /// <summary>
    /// Delete one Estatisticas
    /// </summary>
    [HttpDelete("{Id}")]
    public async Task<ActionResult> DeleteEstatisticas(
        [FromRoute()] EstatisticasWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteEstatisticas(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many EstatisticasItems
    /// </summary>
    [HttpGet()]
    public async Task<ActionResult<List<Estatisticas>>> EstatisticasItems(
        [FromQuery()] EstatisticasFindManyArgs filter
    )
    {
        return Ok(await _service.EstatisticasItems(filter));
    }

    /// <summary>
    /// Meta data about Estatisticas records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> EstatisticasItemsMeta(
        [FromQuery()] EstatisticasFindManyArgs filter
    )
    {
        return Ok(await _service.EstatisticasItemsMeta(filter));
    }

    /// <summary>
    /// Get one Estatisticas
    /// </summary>
    [HttpGet("{Id}")]
    public async Task<ActionResult<Estatisticas>> Estatisticas(
        [FromRoute()] EstatisticasWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Estatisticas(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Estatisticas
    /// </summary>
    [HttpPatch("{Id}")]
    public async Task<ActionResult> UpdateEstatisticas(
        [FromRoute()] EstatisticasWhereUniqueInput uniqueId,
        [FromQuery()] EstatisticasUpdateInput estatisticasUpdateDto
    )
    {
        try
        {
            await _service.UpdateEstatisticas(uniqueId, estatisticasUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
