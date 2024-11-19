﻿// <auto-generated />
using System;
using Lab6.DbUtils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Lab6.Migrations
{
    [DbContext(typeof(ProductServicingContext))]
    [Migration("20241119203509_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Lab6.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AddressId"));

                    b.Property<string>("AddressDetails")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("AddressTypeCode")
                        .HasColumnType("integer");

                    b.Property<int>("CompanyId")
                        .HasColumnType("integer");

                    b.HasKey("AddressId");

                    b.HasIndex("AddressTypeCode");

                    b.HasIndex("CompanyId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            AddressId = 1,
                            AddressDetails = "123 Tech Street",
                            AddressTypeCode = 1,
                            CompanyId = 1
                        },
                        new
                        {
                            AddressId = 2,
                            AddressDetails = "456 Business Ave",
                            AddressTypeCode = 2,
                            CompanyId = 2
                        });
                });

            modelBuilder.Entity("Lab6.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CompanyId"));

                    b.Property<string>("CompanyDetails")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            CompanyId = 1,
                            CompanyDetails = "Leading tech solutions",
                            CompanyName = "TechCorp"
                        },
                        new
                        {
                            CompanyId = 2,
                            CompanyDetails = "Software development specialists",
                            CompanyName = "SoftSolutions"
                        });
                });

            modelBuilder.Entity("Lab6.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CustomerId"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<string>("CustomerDetails")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CustomerTypeCode")
                        .HasColumnType("integer");

                    b.Property<int>("EndUserId")
                        .HasColumnType("integer");

                    b.HasKey("CustomerId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CustomerTypeCode");

                    b.HasIndex("EndUserId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Lab6.Models.CustomerMachine", b =>
                {
                    b.Property<int>("MachineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MachineId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<int>("DistributorId")
                        .HasColumnType("integer");

                    b.Property<string>("InstallationLocationAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MachineDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MachineName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MachineOtherDetails")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MachineType")
                        .HasColumnType("integer");

                    b.HasKey("MachineId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DistributorId");

                    b.HasIndex("MachineType");

                    b.ToTable("CustomerMachines");

                    b.HasData(
                        new
                        {
                            MachineId = 1,
                            CustomerId = 1,
                            DistributorId = 1,
                            InstallationLocationAddress = "123 Tech Street",
                            MachineDescription = "High-speed office printer",
                            MachineName = "Office Printer",
                            MachineOtherDetails = "Requires monthly maintenance",
                            MachineType = 1
                        },
                        new
                        {
                            MachineId = 2,
                            CustomerId = 2,
                            DistributorId = 2,
                            InstallationLocationAddress = "456 Business Ave",
                            MachineDescription = "High-resolution scanner",
                            MachineName = "Office Scanner",
                            MachineOtherDetails = "Requires quarterly maintenance",
                            MachineType = 2
                        });
                });

            modelBuilder.Entity("Lab6.Models.Distributor", b =>
                {
                    b.Property<int>("DistributorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DistributorId"));

                    b.Property<string>("DistributorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OtherDistributorDetails")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ServiceVendorId")
                        .HasColumnType("integer");

                    b.HasKey("DistributorId");

                    b.HasIndex("ServiceVendorId");

                    b.ToTable("Distributors");

                    b.HasData(
                        new
                        {
                            DistributorId = 1,
                            DistributorName = "Tech Distributors",
                            OtherDistributorDetails = "Expert in tech distribution",
                            ServiceVendorId = 1
                        },
                        new
                        {
                            DistributorId = 2,
                            DistributorName = "Global Distributors",
                            OtherDistributorDetails = "Worldwide distribution network",
                            ServiceVendorId = 2
                        });
                });

            modelBuilder.Entity("Lab6.Models.EndUser", b =>
                {
                    b.Property<int>("EndUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EndUserId"));

                    b.Property<string>("EndUserDetails")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EndUserId");

                    b.ToTable("EndUser");

                    b.HasData(
                        new
                        {
                            EndUserId = 1,
                            EndUserDetails = "John Doe"
                        },
                        new
                        {
                            EndUserId = 2,
                            EndUserDetails = "Jane Smith"
                        });
                });

            modelBuilder.Entity("Lab6.Models.RefAddressType", b =>
                {
                    b.Property<int>("AddressTypeCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AddressTypeCode"));

                    b.Property<string>("AddressTypeDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AddressTypeCode");

                    b.ToTable("RefAddressType");

                    b.HasData(
                        new
                        {
                            AddressTypeCode = 1,
                            AddressTypeDescription = "Home"
                        },
                        new
                        {
                            AddressTypeCode = 2,
                            AddressTypeDescription = "Office"
                        });
                });

            modelBuilder.Entity("Lab6.Models.RefCustomerType", b =>
                {
                    b.Property<int>("CustomerTypeCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CustomerTypeCode"));

                    b.Property<string>("CustomerTypeDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CustomerTypeCode");

                    b.ToTable("RefCustomerTypes");

                    b.HasData(
                        new
                        {
                            CustomerTypeCode = 1,
                            CustomerTypeDescription = "Regular"
                        },
                        new
                        {
                            CustomerTypeCode = 2,
                            CustomerTypeDescription = "Premium"
                        });
                });

            modelBuilder.Entity("Lab6.Models.RefMachineType", b =>
                {
                    b.Property<int>("MachineType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MachineType"));

                    b.Property<string>("MachineTypeDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("MachineType");

                    b.ToTable("RefMachineTypes");

                    b.HasData(
                        new
                        {
                            MachineType = 1,
                            MachineTypeDescription = "Printer"
                        },
                        new
                        {
                            MachineType = 2,
                            MachineTypeDescription = "Scanner"
                        });
                });

            modelBuilder.Entity("Lab6.Models.RefServiceType", b =>
                {
                    b.Property<int>("ServiceTypeCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ServiceTypeCode"));

                    b.Property<string>("ServiceTypeDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ServiceTypeCode");

                    b.ToTable("RefServiceTypes");

                    b.HasData(
                        new
                        {
                            ServiceTypeCode = 1,
                            ServiceTypeDescription = "Maintenance"
                        },
                        new
                        {
                            ServiceTypeCode = 2,
                            ServiceTypeDescription = "Repair"
                        });
                });

            modelBuilder.Entity("Lab6.Models.Service", b =>
                {
                    b.Property<int>("ServiceTypeCode")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateOfService")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DistributorId")
                        .HasColumnType("integer");

                    b.Property<string>("OtherServiceDetails")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ServiceVendorId")
                        .HasColumnType("integer");

                    b.HasKey("ServiceTypeCode");

                    b.HasIndex("DistributorId");

                    b.HasIndex("ServiceVendorId");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            ServiceTypeCode = 1,
                            DateOfService = new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistributorId = 1,
                            OtherServiceDetails = "Routine maintenance",
                            ServiceVendorId = 1
                        },
                        new
                        {
                            ServiceTypeCode = 2,
                            DateOfService = new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistributorId = 2,
                            OtherServiceDetails = "Urgent repair",
                            ServiceVendorId = 2
                        });
                });

            modelBuilder.Entity("Lab6.Models.ServiceVendor", b =>
                {
                    b.Property<int>("ServiceVendorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ServiceVendorId"));

                    b.Property<string>("ServiceVendorDetails")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ServiceVendorId");

                    b.ToTable("ServiceVendors");

                    b.HasData(
                        new
                        {
                            ServiceVendorId = 1,
                            ServiceVendorDetails = "FastTech Service"
                        },
                        new
                        {
                            ServiceVendorId = 2,
                            ServiceVendorDetails = "GlobalTech Service"
                        });
                });

            modelBuilder.Entity("Lab6.Models.Address", b =>
                {
                    b.HasOne("Lab6.Models.RefAddressType", "AddressType")
                        .WithMany("Addresses")
                        .HasForeignKey("AddressTypeCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Lab6.Models.Company", "Company")
                        .WithMany("Addresses")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddressType");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Lab6.Models.Customer", b =>
                {
                    b.HasOne("Lab6.Models.Company", "Company")
                        .WithMany("Customers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab6.Models.RefCustomerType", "CustomerType")
                        .WithMany("Customers")
                        .HasForeignKey("CustomerTypeCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Lab6.Models.EndUser", "EndUser")
                        .WithMany("Customers")
                        .HasForeignKey("EndUserId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("CustomerType");

                    b.Navigation("EndUser");
                });

            modelBuilder.Entity("Lab6.Models.CustomerMachine", b =>
                {
                    b.HasOne("Lab6.Models.Customer", "Customer")
                        .WithMany("CustomerMachines")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab6.Models.Distributor", "Distributor")
                        .WithMany("CustomerMachines")
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Lab6.Models.RefMachineType", "MachineTypeNavigation")
                        .WithMany("CustomerMachines")
                        .HasForeignKey("MachineType")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Distributor");

                    b.Navigation("MachineTypeNavigation");
                });

            modelBuilder.Entity("Lab6.Models.Distributor", b =>
                {
                    b.HasOne("Lab6.Models.ServiceVendor", "ServiceVendor")
                        .WithMany("Distributors")
                        .HasForeignKey("ServiceVendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServiceVendor");
                });

            modelBuilder.Entity("Lab6.Models.Service", b =>
                {
                    b.HasOne("Lab6.Models.Distributor", "Distributor")
                        .WithMany()
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab6.Models.RefServiceType", "ServiceType")
                        .WithMany("Services")
                        .HasForeignKey("ServiceTypeCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Lab6.Models.ServiceVendor", "ServiceVendor")
                        .WithMany("Services")
                        .HasForeignKey("ServiceVendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distributor");

                    b.Navigation("ServiceType");

                    b.Navigation("ServiceVendor");
                });

            modelBuilder.Entity("Lab6.Models.Company", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Lab6.Models.Customer", b =>
                {
                    b.Navigation("CustomerMachines");
                });

            modelBuilder.Entity("Lab6.Models.Distributor", b =>
                {
                    b.Navigation("CustomerMachines");
                });

            modelBuilder.Entity("Lab6.Models.EndUser", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Lab6.Models.RefAddressType", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("Lab6.Models.RefCustomerType", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Lab6.Models.RefMachineType", b =>
                {
                    b.Navigation("CustomerMachines");
                });

            modelBuilder.Entity("Lab6.Models.RefServiceType", b =>
                {
                    b.Navigation("Services");
                });

            modelBuilder.Entity("Lab6.Models.ServiceVendor", b =>
                {
                    b.Navigation("Distributors");

                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
