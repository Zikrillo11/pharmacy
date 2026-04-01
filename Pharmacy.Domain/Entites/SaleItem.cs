using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Domain.Entites;

[Table("Saleltems")]
public class SaleItem : BaseEntity
{
    [Column("sale_id")]
    public required int SaleId { get; set; }
    public Sale Sale { get; set; }

    [Column("medicine_id")]
    public int MedicineId { get; set; }
    public Medicine Medicine { get; set; }

    [Column("quantity")]
    public required int Quantity { get; set; }

    [Column("unit_price")]
    public decimal UnitPrice { get; set; }

    [Column("total_price")]
    public decimal TotalPrice { get; set; }
}
