// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkingProject11.Models;

namespace ParkingProject1.Migrations
{
    [DbContext(typeof(ParkingDbContext))]
    [Migration("20220129115013_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ParkingProject11.Models.Area", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Id");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("ParkingProject11.Models.BusySlots", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AreaId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("PeriodId")
                        .HasColumnType("bigint");

                    b.Property<long?>("SlotId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PeriodId");

                    b.HasIndex("SlotId");

                    b.ToTable("BusySlots");
                });

            modelBuilder.Entity("ParkingProject11.Models.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("NationalIDPhoto")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ParkingProject11.Models.FeedBacks", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Seen")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("FeedBacks");
                });

            modelBuilder.Entity("ParkingProject11.Models.Period", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("From")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("To")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Periods");
                });

            modelBuilder.Entity("ParkingProject11.Models.Reservations", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AreaId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("SlotId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalCost")
                        .HasColumnType("int");

                    b.Property<int>("TotalHours")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SlotId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("ParkingProject11.Models.Slot", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AreaId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<long>("Number")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.ToTable("Slots");
                });

            modelBuilder.Entity("ParkingProject11.Models.BusySlots", b =>
                {
                    b.HasOne("ParkingProject11.Models.Area", "Area")
                        .WithMany("BusySlots")
                        .HasForeignKey("AreaId");

                    b.HasOne("ParkingProject11.Models.Customer", "Customer")
                        .WithMany("BusySlots")
                        .HasForeignKey("CustomerId");

                    b.HasOne("ParkingProject11.Models.Period", "Period")
                        .WithMany()
                        .HasForeignKey("PeriodId");

                    b.HasOne("ParkingProject11.Models.Slot", "Slot")
                        .WithMany("BusySlots")
                        .HasForeignKey("SlotId");

                    b.Navigation("Area");

                    b.Navigation("Customer");

                    b.Navigation("Period");

                    b.Navigation("Slot");
                });

            modelBuilder.Entity("ParkingProject11.Models.FeedBacks", b =>
                {
                    b.HasOne("ParkingProject11.Models.Customer", "Customer")
                        .WithMany("FeedBacks")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ParkingProject11.Models.Reservations", b =>
                {
                    b.HasOne("ParkingProject11.Models.Area", "Area")
                        .WithMany("Reservations")
                        .HasForeignKey("AreaId");

                    b.HasOne("ParkingProject11.Models.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId");

                    b.HasOne("ParkingProject11.Models.Slot", "Slot")
                        .WithMany("Reservations")
                        .HasForeignKey("SlotId");

                    b.Navigation("Area");

                    b.Navigation("Customer");

                    b.Navigation("Slot");
                });

            modelBuilder.Entity("ParkingProject11.Models.Slot", b =>
                {
                    b.HasOne("ParkingProject11.Models.Area", "Area")
                        .WithMany("Slots")
                        .HasForeignKey("AreaId");

                    b.Navigation("Area");
                });

            modelBuilder.Entity("ParkingProject11.Models.Area", b =>
                {
                    b.Navigation("BusySlots");

                    b.Navigation("Reservations");

                    b.Navigation("Slots");
                });

            modelBuilder.Entity("ParkingProject11.Models.Customer", b =>
                {
                    b.Navigation("BusySlots");

                    b.Navigation("FeedBacks");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("ParkingProject11.Models.Slot", b =>
                {
                    b.Navigation("BusySlots");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
