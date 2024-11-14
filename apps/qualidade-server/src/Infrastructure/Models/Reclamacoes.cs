using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qualidade.Infrastructure.Models;

[Table("Reclamacoes")]
public class ReclamacoesDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? Data { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? Status { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
