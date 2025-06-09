using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GroupA.Models;

[Table("PurchaseHistory")]
[PrimaryKey(nameof(AvailableProgramId), nameof(CustomerId))]

public class PurchaseHistory
{
    public int AvailableProgramId { get; set; }
    [ForeignKey(nameof(AvailableProgramId))]
    public AvailableProgram AvailableProgram { get; set; } = null!;

    public int CustomerId { get; set; }
    [ForeignKey(nameof(CustomerId))]
    public Customer Customer { get; set; } = null!;

    public DateTime PurchaseDate { get; set; }
    public int? Rating { get; set; }
}