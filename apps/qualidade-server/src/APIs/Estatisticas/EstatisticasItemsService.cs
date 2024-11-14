using Qualidade.Infrastructure;

namespace Qualidade.APIs;

public class EstatisticasItemsService : EstatisticasItemsServiceBase
{
    public EstatisticasItemsService(QualidadeDbContext context)
        : base(context) { }
}
