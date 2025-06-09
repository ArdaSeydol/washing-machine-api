namespace GroupA.Models;

public class Customer
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? PhoneNumber { get; set; }

    public ICollection<PurchaseHistory> PurchaseHistories { get; set; }
}