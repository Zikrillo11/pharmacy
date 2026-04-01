using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Domain.Entites;

[Table("SaleItems")]
public class SaleItem : BaseEntity
{
    [Column("sale_id")]
    public required int SaleId { get; set; }
    public Sale Sale { get; set; }

    [Column("medicine_id")]
    public required int MedicineId { get; set; }
    public Medicine Medicine { get; set; }
    [Column("quantity")]
    public required int Quantity { get; set; }
    [Column("unit_price")]
    public required decimal UnitPrice { get; set; }
    [Column("total_price")]
    public required decimal TotalPrice { get; set; }
}
