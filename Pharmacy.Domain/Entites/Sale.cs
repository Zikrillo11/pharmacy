using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Domain.Entites;

[Table("Sales")]
public class Sale : BaseEntity
{
    [Column("customer_id")]
    public required int CustomerId { get; set; }
    public Customer Customer { get; set; }
    [Column("total_amount")]
    public decimal TotalAmount { get; set; }
    public DateTime SaleDate { get; set; } = DateTime.Now;
    public ICollection<SaleItem> SaleItems { get; set; }
}
