using Qualidade.Infrastructure;

namespace Qualidade.APIs;

public class ReclamacoesItemsService : ReclamacoesItemsServiceBase
{
    public ReclamacoesItemsService(QualidadeDbContext context)
        : base(context) { }
}
