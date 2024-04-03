using VP_Lab_8.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace VP_Lab_8.Server.DataAccess
{
    public class DomainModelSqlContext : DbContext
    {
        public DomainModelSqlContext(DbContextOptions<DomainModelSqlContext> options) : base(options)
        {
        }
        public DbSet<Persons> Info { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder); 
		}

		public override int SaveChanges()
		{
			return base.SaveChanges();
		}
	}
}
