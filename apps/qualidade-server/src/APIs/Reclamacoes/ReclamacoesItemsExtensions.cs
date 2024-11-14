using Qualidade.APIs.Dtos;
using Qualidade.Infrastructure.Models;

namespace Qualidade.APIs.Extensions;

public static class ReclamacoesItemsExtensions
{
    public static Reclamacoes ToDto(this ReclamacoesDbModel model)
    {
        return new Reclamacoes
        {
            CreatedAt = model.CreatedAt,
            Data = model.Data,
            Id = model.Id,
            Status = model.Status,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ReclamacoesDbModel ToModel(
        this ReclamacoesUpdateInput updateDto,
        ReclamacoesWhereUniqueInput uniqueId
    )
    {
        var reclamacoes = new ReclamacoesDbModel
        {
            Id = uniqueId.Id,
            Data = updateDto.Data,
            Status = updateDto.Status
        };

        if (updateDto.CreatedAt != null)
        {
            reclamacoes.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            reclamacoes.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return reclamacoes;
    }
}
