using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Domain.Entites;

[Table("Customers")]
public class Customer : BaseEntity
{
    [Column("full_name")]
    public required string FullName { get; set; }

    [Column("phone_number"), MaxLength(13)]
    public required string PhoneNumber { get; set; }
    public ICollection<Sale> Sales { get; set; }
}
