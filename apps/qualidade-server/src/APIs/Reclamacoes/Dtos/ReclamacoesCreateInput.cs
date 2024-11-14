namespace Qualidade.APIs.Dtos;

public class ReclamacoesCreateInput
{
    public DateTime CreatedAt { get; set; }

    public DateTime? Data { get; set; }

    public string? Id { get; set; }

    public string? Status { get; set; }

    public DateTime UpdatedAt { get; set; }
}
