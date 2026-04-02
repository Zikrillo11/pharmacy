using Microsoft.EntityFrameworkCore;
using Pharmacy.Domain.Entites;

namespace Pharmcy.DAL.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {   
    }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Medicine> Medicines { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleItem> SaleItems { get; set; }
    public DbSet<StockHistory> StockHistories { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }

}
