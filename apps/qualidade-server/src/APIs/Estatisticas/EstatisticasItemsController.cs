using Microsoft.AspNetCore.Mvc;

namespace Qualidade.APIs;

[ApiController()]
public class EstatisticasItemsController : EstatisticasItemsControllerBase
{
    public EstatisticasItemsController(IEstatisticasItemsService service)
        : base(service) { }
}
