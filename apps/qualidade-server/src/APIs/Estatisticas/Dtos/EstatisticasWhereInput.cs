namespace Qualidade.APIs.Dtos;

public class EstatisticasWhereInput
{
    public DateTime? CreatedAt { get; set; }

    public string? Id { get; set; }

    public string? Tipo { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public double? Valor { get; set; }
}
