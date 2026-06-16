using Microsoft.EntityFrameworkCore;

public class ProcurementContext(DbContextOptions<ProcurementContext> options) : DbContext(options)
{
    public DbSet<Procurement.Models.EmployeeBelonging> EmployeeBelonging { get; set; } = default!;
}
