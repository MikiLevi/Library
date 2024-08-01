using Microsoft.EntityFrameworkCore;
using TorahLibrary.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TorahLibrary.DAL
{
    public class DataLayer : DbContext
    {
        public DataLayer(string connectionString) : base(GetOptinos(connectionString))
        {
            Database.EnsureCreated();
            //Data.Get.SaveChanges();
            Seed();
        }
        private void Seed()
        {
            if (Libraries.Count() > 0)
            {
                return;
            }

            Libraries lib = new Libraries();
            lib.Name = "אמונה וביטחון";
            Libraries.Add(lib);
            SaveChanges();
        }
                            
        public DbSet<Libraries> Libraries { get; set; }

        public DbSet<Shelves> Shelv { get; set; }

        public DbSet<Books> Books { get; set; }

        private static DbContextOptions GetOptinos(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions
                .UseSqlServer(new DbContextOptionsBuilder(),
                 connectionString).Options;
        }
    }
}
