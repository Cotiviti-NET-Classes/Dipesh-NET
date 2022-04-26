using Microsoft.EntityFrameworkCore;
using MVCApp.Models;

public class HrDbContext : DbContext
{
    public HrDbContext(DbContextOptions<HrDbContext> options) : base(options)
    {

    }

    public DbSet<Employee> Employees { get; set; }
}