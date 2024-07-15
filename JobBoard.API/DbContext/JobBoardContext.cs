using JobBoard.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace JobBoard.API;

public class JobBoardContext : DbContext
{
    public JobBoardContext(DbContextOptions<JobBoardContext> options)
        : base(options) { }

    public DbSet<Company> Companies { get; set; }
    public DbSet<JobOpening> JobOpenings { get; set; }
}
