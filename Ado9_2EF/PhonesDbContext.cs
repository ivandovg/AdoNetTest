using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado9_2EF
{
    internal class PhonesDbContext: DbContext
    {

        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Phone> Phones { get; set; }

        public PhonesDbContext():base("PhonesDbConnection") { }
        public PhonesDbContext(string connectionString):base(connectionString) { }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            //builder.Entity<Manufacturer>()
            //    .ToTable("Manufacturers")
            //    .HasKey(m => m.Id);

            // установка внешнего ключа "ManufacturerId" для таблицы "Phone"
            //builder.Entity<Phone>()
            //    .HasRequired(p => p.Manufacturer)
            //    .WithRequiredDependent()
            //    .Map(m => m.MapKey("ManufacturerId"));

            builder.Configurations.Add(new ManufacturerConfiguration());
            builder.Configurations.Add(new PhoneConfiguration());

            //base.OnModelCreating(builder);
        }

        public string GetTablesQuery()
        {
            string sql = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
            var result = Database.SqlQuery<string>(sql);
            StringBuilder r = new StringBuilder();
            foreach (string s in result)
            {
                r.AppendLine(s);
            }
            return r.ToString();
        }
    }

    internal class Manufacturer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public decimal Capital { get; set; }
        public string Owner { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }

        public string NameAndOwner
        {
            get => $"{FullName} ({Owner})";
        }
    }

    internal class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal MemorySize { get; set; }
        public string Color { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string OSName { get; set; }
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
