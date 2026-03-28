namespace Pharmacy.Domain.Entites;

public class Customer : BaseEntity
{
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public ICollection<Sale> Sales { get; set; }
}
