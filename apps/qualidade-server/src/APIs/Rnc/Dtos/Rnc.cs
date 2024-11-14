using Qualidade.Core.Enums;

namespace Qualidade.APIs.Dtos;

public class Rnc
{
    public string? Cliente { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? DetalhesDaReclamacao { get; set; }

    public string Id { get; set; }

    public bool? IniciarColetaDeMaterial { get; set; }

    public StatusEnum? Status { get; set; }

    public string? TTulo { get; set; }

    public DateTime UpdatedAt { get; set; }
}
