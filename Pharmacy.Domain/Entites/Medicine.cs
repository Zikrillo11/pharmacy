namespace Pharmacy.Domain.Entites;

public class Medicine : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Manufacturer { get; set; }
    public decimal Price { get; set; }
    public int QuantityInStock { get; set; }
    public DateTime ExpiryDate { get; set; }
    public string Barcode { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public int SupplierId { get; set; }
    public Supplier Supplier { get; set; }
    public ICollection<SaleItem> SaleItems { get; set; }
}
