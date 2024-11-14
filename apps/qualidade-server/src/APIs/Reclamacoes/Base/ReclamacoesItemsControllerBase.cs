using Microsoft.AspNetCore.Mvc;
using Qualidade.APIs;
using Qualidade.APIs.Common;
using Qualidade.APIs.Dtos;
using Qualidade.APIs.Errors;

namespace Qualidade.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ReclamacoesItemsControllerBase : ControllerBase
{
    protected readonly IReclamacoesItemsService _service;

    public ReclamacoesItemsControllerBase(IReclamacoesItemsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Reclamacoes
    /// </summary>
    [HttpPost()]
    public async Task<ActionResult<Reclamacoes>> CreateReclamacoes(ReclamacoesCreateInput input)
    {
        var reclamacoes = await _service.CreateReclamacoes(input);

        return CreatedAtAction(nameof(Reclamacoes), new { id = reclamacoes.Id }, reclamacoes);
    }

    /// <summary>
    /// Delete one Reclamacoes
    /// </summary>
    [HttpDelete("{Id}")]
    public async Task<ActionResult> DeleteReclamacoes(
        [FromRoute()] ReclamacoesWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteReclamacoes(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ReclamacoesItems
    /// </summary>
    [HttpGet()]
    public async Task<ActionResult<List<Reclamacoes>>> ReclamacoesItems(
        [FromQuery()] ReclamacoesFindManyArgs filter
    )
    {
        return Ok(await _service.ReclamacoesItems(filter));
    }

    /// <summary>
    /// Meta data about Reclamacoes records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ReclamacoesItemsMeta(
        [FromQuery()] ReclamacoesFindManyArgs filter
    )
    {
        return Ok(await _service.ReclamacoesItemsMeta(filter));
    }

    /// <summary>
    /// Get one Reclamacoes
    /// </summary>
    [HttpGet("{Id}")]
    public async Task<ActionResult<Reclamacoes>> Reclamacoes(
        [FromRoute()] ReclamacoesWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Reclamacoes(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Reclamacoes
    /// </summary>
    [HttpPatch("{Id}")]
    public async Task<ActionResult> UpdateReclamacoes(
        [FromRoute()] ReclamacoesWhereUniqueInput uniqueId,
        [FromQuery()] ReclamacoesUpdateInput reclamacoesUpdateDto
    )
    {
        try
        {
            await _service.UpdateReclamacoes(uniqueId, reclamacoesUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
