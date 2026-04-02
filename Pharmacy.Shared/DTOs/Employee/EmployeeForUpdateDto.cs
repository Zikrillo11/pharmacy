namespace Pharmacy.Shared.DTOs.Employee;

public class EmployeeForUpdateDto
{
    public required string FullName { get; set; }
    public required string Position { get; set; }
    public required string PhoneNumber { get; set; }
    public decimal Salary { get; set; }
}
