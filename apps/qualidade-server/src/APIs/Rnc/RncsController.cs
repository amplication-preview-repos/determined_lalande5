using Microsoft.AspNetCore.Mvc;

namespace Qualidade.APIs;

[ApiController()]
public class RncsController : RncsControllerBase
{
    public RncsController(IRncsService service)
        : base(service) { }
}
