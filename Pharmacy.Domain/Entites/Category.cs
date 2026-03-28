using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy.Domain.Entites;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Medicine> Medicines { get; set; }
}
