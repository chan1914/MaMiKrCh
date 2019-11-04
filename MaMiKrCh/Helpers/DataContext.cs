using Microsoft.EntityFrameworkCore;
using MaMiKrCh.Entities;

namespace MaMiKrCh.Helpers
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<User> Users { get; set; }
	}
}
