using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Domain.Entites;

[Table("Supplier")]
public class Supplier : BaseEntity
{
    [Column("company_name")]
    public required string CompanyName { get; set; }
    [Column("phone_number"), MaxLength(13)]
    public required string PhoneNumber { get; set; }
    [Column("address")]
    public required string Address { get; set; }
    public ICollection<Medicine> Medicines { get; set; }
}
