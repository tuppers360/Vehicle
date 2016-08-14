using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using VehicleHub.Persistance;

namespace VehicleHub.Migrations
{
    [DbContext(typeof(VehicleDbContext))]
    [Migration("20160812195837_AddMileageToDomain")]
    partial class AddMileageToDomain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VehicleHub.Models.Mileage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("MileageDate");

                    b.Property<string>("RecordedMileage");

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("Mileages");
                });

            modelBuilder.Entity("VehicleHub.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Make");

                    b.Property<int>("Marked");

                    b.Property<string>("Model");

                    b.Property<string>("Registration");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("VehicleHub.Models.Mileage", b =>
                {
                    b.HasOne("VehicleHub.Models.Vehicle", "Vehicle")
                        .WithMany("Mileages")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
