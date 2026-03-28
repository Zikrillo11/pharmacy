namespace Pharmacy.Domain.Entites;

public class Supplier : BaseEntity
{
    public string CompanyName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public ICollection<Medicine> Medicines { get; set; }
}
