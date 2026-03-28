namespace Pharmacy.Domain.Entites;

public class Sale : BaseEntity
{
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public decimal TotalAmount { get; set; }
    public DateTime SaleDate { get; set; } = DateTime.Now;
    public ICollection<SaleItem> SaleItems { get; set; }
}
