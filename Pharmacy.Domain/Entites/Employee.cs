using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Domain.Entites;

[Table("Employees")]
public class Employee : BaseEntity
{
    [Column("full_name")]
    public required string FullName { get; set; }

    [Column("position")]
    public required string Position { get; set; }

    [Column("phone_number")]
    public required string PhoneNumber { get; set; }
    [Column("salary")]
    public required decimal Salary { get; set; }
}
