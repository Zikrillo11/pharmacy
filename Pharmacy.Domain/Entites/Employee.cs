namespace Pharmacy.Domain.Entites;

public class Employee : BaseEntity
{
    public string FullName { get; set; }
    public string Position { get; set; }
    public string PhoneNumber { get; set; }
    public decimal Salary { get; set; }
}
