using Microsoft.AspNetCore.Mvc;
using Qualidade.APIs;
using Qualidade.APIs.Common;
using Qualidade.APIs.Dtos;
using Qualidade.APIs.Errors;

namespace Qualidade.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class RncsControllerBase : ControllerBase
{
    protected readonly IRncsService _service;

    public RncsControllerBase(IRncsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one RNC
    /// </summary>
    [HttpPost()]
    public async Task<ActionResult<Rnc>> CreateRnc(RncCreateInput input)
    {
        var rnc = await _service.CreateRnc(input);

        return CreatedAtAction(nameof(Rnc), new { id = rnc.Id }, rnc);
    }

    /// <summary>
    /// Delete one RNC
    /// </summary>
    [HttpDelete("{Id}")]
    public async Task<ActionResult> DeleteRnc([FromRoute()] RncWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteRnc(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many RNCS
    /// </summary>
    [HttpGet()]
    public async Task<ActionResult<List<Rnc>>> Rncs([FromQuery()] RncFindManyArgs filter)
    {
        return Ok(await _service.Rncs(filter));
    }

    /// <summary>
    /// Meta data about RNC records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> RncsMeta([FromQuery()] RncFindManyArgs filter)
    {
        return Ok(await _service.RncsMeta(filter));
    }

    /// <summary>
    /// Get one RNC
    /// </summary>
    [HttpGet("{Id}")]
    public async Task<ActionResult<Rnc>> Rnc([FromRoute()] RncWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Rnc(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one RNC
    /// </summary>
    [HttpPatch("{Id}")]
    public async Task<ActionResult> UpdateRnc(
        [FromRoute()] RncWhereUniqueInput uniqueId,
        [FromQuery()] RncUpdateInput rncUpdateDto
    )
    {
        try
        {
            await _service.UpdateRnc(uniqueId, rncUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
