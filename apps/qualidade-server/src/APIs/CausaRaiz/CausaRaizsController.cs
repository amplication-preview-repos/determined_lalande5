using Microsoft.AspNetCore.Mvc;

namespace Qualidade.APIs;

[ApiController()]
public class CausaRaizsController : CausaRaizsControllerBase
{
    public CausaRaizsController(ICausaRaizsService service)
        : base(service) { }
}
