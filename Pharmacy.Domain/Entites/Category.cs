using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Domain.Entites;

[Table("Categories")]
public class Category : BaseEntity
{
    [Column("name")]
    public required string Name { get; set; }
    public ICollection<Medicine> Medicines { get; set; }
}
