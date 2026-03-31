using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Domain.Entites;

[Table("Medicines")]
public class Medicine : BaseEntity
{
    [Column("name")]
    public required string Name { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("manufacturer")]
    public required string Manufacturer { get; set; }

    [Column("price")]
    public required decimal Price { get; set; }

    [Column("quantity_in_stock")]
    public required int QuantityInStock { get; set; }
    public DateTime ExpiryDate { get; set; }

    [Column("barcode")]
    public required string Barcode { get; set; }

    [Column("category_id")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    [Column("supplier_id")]
    public int SupplierId { get; set; }
    public Supplier Supplier { get; set; }
    public ICollection<SaleItem> SaleItems { get; set; }
}
