using Microsoft.AspNetCore.Mvc;

namespace Qualidade.APIs;

[ApiController()]
public class ReclamacoesItemsController : ReclamacoesItemsControllerBase
{
    public ReclamacoesItemsController(IReclamacoesItemsService service)
        : base(service) { }
}
