namespace Pharmacy.Domain.Entites;

public class SaleItem : BaseEntity
{
    public int SaleId { get; set; }
    public Sale Sale { get; set; }
    public int MedicineId { get; set; }
    public Medicine Medicine { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
}
