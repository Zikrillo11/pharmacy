using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Domain.Entites;

[Table("StockHistory")]
public class StockHistory : BaseEntity
{
    [Column("medicine_id")]
    public required int MedicineId { get; set; }
    public Medicine Medicine { get; set; }
    [Column("quantity_changed")]
    public required int QuantityChanged { get; set; }
    [Column("action_type")]
    public required string ActionType { get; set; }
    public DateTime ActionDate { get; set; } = DateTime.Now;
}
