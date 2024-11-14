using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qualidade.Infrastructure.Models;

[Table("CausaRaizs")]
public class CausaRaizDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? Descricao { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? SetorResponsavel { get; set; }

    [StringLength(1000)]
    public string? Solucao { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
