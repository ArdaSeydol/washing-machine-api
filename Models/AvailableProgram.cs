using System.ComponentModel.DataAnnotations.Schema;

namespace GroupA.Models;

public class AvailableProgram
{
    public int AvailableProgramId { get; set; }

    public int WashingMachineId { get; set; }
    [ForeignKey(nameof(WashingMachineId))]
    public WashingMachine WashingMachine { get; set; } = null!;

    public int ProgramId { get; set; }
    [ForeignKey(nameof(ProgramId))]
    public qPogram Program { get; set; } = null!;

    public decimal Price { get; set; }

    public ICollection<PurchaseHistory> PurchaseHistories { get; set; }
}

