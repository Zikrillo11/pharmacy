namespace Pharmacy.Domain.Entites;

public class StockHistory : BaseEntity
{
    public int MedicineId { get; set; }
    public Medicine Medicine { get; set; }
    public int QuantityChanged { get; set; }
    public string ActionType { get; set; }
    public DateTime ActionDate { get; set; } = DateTime.Now;
}
