using Microsoft.EntityFrameworkCore;
using Vesper_Task_MMC.Models;

namespace Vesper_Task_MMC.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Cart>Carts { get; set; }  
    }
}
