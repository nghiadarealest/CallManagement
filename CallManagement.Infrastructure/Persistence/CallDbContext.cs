using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using CallManagement.Domain.Entities;

namespace CallManagement.Infrastructure.Persistence;

public class CallDbContext : DbContext
{
    public CallDbContext(DbContextOptions<CallDbContext> options) : base(options) { }

    public DbSet<Call> Calls => Set<Call>();
}

