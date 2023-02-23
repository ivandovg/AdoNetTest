using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado10_1EF
{
    internal class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Peoples"); //.HasKey(p => p.Id);
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Firstname)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);

            builder.Property(p => p.Lastname)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);

            builder.Property(p => p.Birth)
                .IsRequired()
                .HasDefaultValueSql("getdate()");

            builder.Property(p => p.IsTrainer)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(p => p.Weight)
                .IsRequired(false);

            builder.Property(p => p.Email)
                .IsRequired(false);

            builder.ToTable(t => t.HasCheckConstraint("CK_Firstname", "(Firstname <> '')"));
        }
    }

    internal class TrainingConfiguration : IEntityTypeConfiguration<Training>
    {
        public void Configure(EntityTypeBuilder<Training> builder)
        {
            builder.ToTable("Trainings").HasKey(p => p.Id);
            builder.Property(p => p.DateOf)
                .IsRequired()
                .HasDefaultValueSql("getdate()");

            builder.Property(p => p.WithTrainer)
                .IsRequired()
                .HasDefaultValue(false);
        }
    }

    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Trainings").HasKey(p => p.Id);
            builder.Property(p => p.TestName)
                .IsRequired()
                .HasDefaultValueSql("noname");
        }
    }
}
