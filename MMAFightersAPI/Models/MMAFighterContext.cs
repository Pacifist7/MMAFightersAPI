using Microsoft.EntityFrameworkCore;
//using System.Diagnostics.CodeAnalysis;

namespace MMAFightersAPI.Models
{
    public class MMAFighterContext : DbContext
    {
        public MMAFighterContext(DbContextOptions<MMAFighterContext> options) : base(options)
        {

        }

        public DbSet<MMAFighter> MMAFighters { get; set; } = null!;
    }
}
