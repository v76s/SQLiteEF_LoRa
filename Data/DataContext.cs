using Microsoft.EntityFrameworkCore;
using SQLiteEF_LoRa.Models;

namespace SQLiteEF_LoRa.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected DataContext()
        {
        }

        public DbSet<LoRaCommModel> tbLoRaComm
            => Set<LoRaCommModel>();
    }
}
