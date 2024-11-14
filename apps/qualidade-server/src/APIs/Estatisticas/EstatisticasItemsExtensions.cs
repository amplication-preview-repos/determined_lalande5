using Qualidade.APIs.Dtos;
using Qualidade.Infrastructure.Models;

namespace Qualidade.APIs.Extensions;

public static class EstatisticasItemsExtensions
{
    public static Estatisticas ToDto(this EstatisticasDbModel model)
    {
        return new Estatisticas
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            Tipo = model.Tipo,
            UpdatedAt = model.UpdatedAt,
            Valor = model.Valor,
        };
    }

    public static EstatisticasDbModel ToModel(
        this EstatisticasUpdateInput updateDto,
        EstatisticasWhereUniqueInput uniqueId
    )
    {
        var estatisticas = new EstatisticasDbModel
        {
            Id = uniqueId.Id,
            Tipo = updateDto.Tipo,
            Valor = updateDto.Valor
        };

        if (updateDto.CreatedAt != null)
        {
            estatisticas.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            estatisticas.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return estatisticas;
    }
}
