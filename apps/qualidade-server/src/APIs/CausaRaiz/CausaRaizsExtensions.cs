using Qualidade.APIs.Dtos;
using Qualidade.Infrastructure.Models;

namespace Qualidade.APIs.Extensions;

public static class CausaRaizsExtensions
{
    public static CausaRaiz ToDto(this CausaRaizDbModel model)
    {
        return new CausaRaiz
        {
            CreatedAt = model.CreatedAt,
            Descricao = model.Descricao,
            Id = model.Id,
            SetorResponsavel = model.SetorResponsavel,
            Solucao = model.Solucao,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static CausaRaizDbModel ToModel(
        this CausaRaizUpdateInput updateDto,
        CausaRaizWhereUniqueInput uniqueId
    )
    {
        var causaRaiz = new CausaRaizDbModel
        {
            Id = uniqueId.Id,
            Descricao = updateDto.Descricao,
            SetorResponsavel = updateDto.SetorResponsavel,
            Solucao = updateDto.Solucao
        };

        if (updateDto.CreatedAt != null)
        {
            causaRaiz.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            causaRaiz.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return causaRaiz;
    }
}
