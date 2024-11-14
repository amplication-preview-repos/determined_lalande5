using Microsoft.AspNetCore.Mvc;
using Qualidade.APIs;
using Qualidade.APIs.Common;
using Qualidade.APIs.Dtos;
using Qualidade.APIs.Errors;

namespace Qualidade.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CausaRaizsControllerBase : ControllerBase
{
    protected readonly ICausaRaizsService _service;

    public CausaRaizsControllerBase(ICausaRaizsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one CausaRaiz
    /// </summary>
    [HttpPost()]
    public async Task<ActionResult<CausaRaiz>> CreateCausaRaiz(CausaRaizCreateInput input)
    {
        var causaRaiz = await _service.CreateCausaRaiz(input);

        return CreatedAtAction(nameof(CausaRaiz), new { id = causaRaiz.Id }, causaRaiz);
    }

    /// <summary>
    /// Delete one CausaRaiz
    /// </summary>
    [HttpDelete("{Id}")]
    public async Task<ActionResult> DeleteCausaRaiz(
        [FromRoute()] CausaRaizWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCausaRaiz(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many CausaRaizs
    /// </summary>
    [HttpGet()]
    public async Task<ActionResult<List<CausaRaiz>>> CausaRaizs(
        [FromQuery()] CausaRaizFindManyArgs filter
    )
    {
        return Ok(await _service.CausaRaizs(filter));
    }

    /// <summary>
    /// Meta data about CausaRaiz records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CausaRaizsMeta(
        [FromQuery()] CausaRaizFindManyArgs filter
    )
    {
        return Ok(await _service.CausaRaizsMeta(filter));
    }

    /// <summary>
    /// Get one CausaRaiz
    /// </summary>
    [HttpGet("{Id}")]
    public async Task<ActionResult<CausaRaiz>> CausaRaiz(
        [FromRoute()] CausaRaizWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CausaRaiz(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one CausaRaiz
    /// </summary>
    [HttpPatch("{Id}")]
    public async Task<ActionResult> UpdateCausaRaiz(
        [FromRoute()] CausaRaizWhereUniqueInput uniqueId,
        [FromQuery()] CausaRaizUpdateInput causaRaizUpdateDto
    )
    {
        try
        {
            await _service.UpdateCausaRaiz(uniqueId, causaRaizUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
