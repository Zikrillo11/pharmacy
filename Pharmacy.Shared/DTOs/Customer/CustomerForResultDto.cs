namespace Pharmacy.Shared.DTOs.Customer;

public class CustomerForResultDto
{
    public long Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime? CreatedAt { get; set; }
}
