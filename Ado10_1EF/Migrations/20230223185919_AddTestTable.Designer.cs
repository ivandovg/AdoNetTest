// <auto-generated />
using System;
using Ado10_1EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ado10_1EF.Migrations
{
    [DbContext(typeof(GymDbContext))]
    [Migration("20230223185919_AddTestTable")]
    partial class AddTestTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ado10_1EF.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birth")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsTrainer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Peoples", null, t =>
                        {
                            t.HasCheckConstraint("CK_Firstname", "(Firstname <> '')");
                        });
                });

            modelBuilder.Entity("Ado10_1EF.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TestName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Ado10_1EF.Training", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOf")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<bool>("WithTrainer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Trainings", (string)null);
                });

            modelBuilder.Entity("Ado10_1EF.Training", b =>
                {
                    b.HasOne("Ado10_1EF.Person", "Person")
                        .WithMany("TrainingDays")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Ado10_1EF.Person", b =>
                {
                    b.Navigation("TrainingDays");
                });
#pragma warning restore 612, 618
        }
    }
}
