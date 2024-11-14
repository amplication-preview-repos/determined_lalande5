using Qualidade.APIs.Dtos;
using Qualidade.Infrastructure.Models;

namespace Qualidade.APIs.Extensions;

public static class RncsExtensions
{
    public static Rnc ToDto(this RncDbModel model)
    {
        return new Rnc
        {
            Cliente = model.Cliente,
            CreatedAt = model.CreatedAt,
            DetalhesDaReclamacao = model.DetalhesDaReclamacao,
            Id = model.Id,
            IniciarColetaDeMaterial = model.IniciarColetaDeMaterial,
            Status = model.Status,
            TTulo = model.TTulo,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static RncDbModel ToModel(this RncUpdateInput updateDto, RncWhereUniqueInput uniqueId)
    {
        var rnc = new RncDbModel
        {
            Id = uniqueId.Id,
            Cliente = updateDto.Cliente,
            DetalhesDaReclamacao = updateDto.DetalhesDaReclamacao,
            IniciarColetaDeMaterial = updateDto.IniciarColetaDeMaterial,
            Status = updateDto.Status,
            TTulo = updateDto.TTulo
        };

        if (updateDto.CreatedAt != null)
        {
            rnc.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            rnc.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return rnc;
    }
}
