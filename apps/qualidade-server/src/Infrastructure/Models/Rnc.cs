using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Qualidade.Core.Enums;

namespace Qualidade.Infrastructure.Models;

[Table("Rncs")]
public class RncDbModel
{
    [StringLength(1000)]
    public string? Cliente { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DetalhesDaReclamacao { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    public bool? IniciarColetaDeMaterial { get; set; }

    public StatusEnum? Status { get; set; }

    [StringLength(1000)]
    public string? TTulo { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
