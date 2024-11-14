namespace Qualidade.APIs.Dtos;

public class CausaRaizCreateInput
{
    public DateTime CreatedAt { get; set; }

    public string? Descricao { get; set; }

    public string? Id { get; set; }

    public string? SetorResponsavel { get; set; }

    public string? Solucao { get; set; }

    public DateTime UpdatedAt { get; set; }
}
