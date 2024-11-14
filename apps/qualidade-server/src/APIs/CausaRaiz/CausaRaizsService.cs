using Qualidade.Infrastructure;

namespace Qualidade.APIs;

public class CausaRaizsService : CausaRaizsServiceBase
{
    public CausaRaizsService(QualidadeDbContext context)
        : base(context) { }
}
