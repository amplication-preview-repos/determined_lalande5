using Qualidade.Infrastructure;

namespace Qualidade.APIs;

public class RncsService : RncsServiceBase
{
    public RncsService(QualidadeDbContext context)
        : base(context) { }
}
