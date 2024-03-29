﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserPermissionLicensesTask.Model;

namespace UserPermissionLicensesTask.Migrations
{
    [DbContext(typeof(UserDB))]
    partial class UserDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UserPermissionLicensesTask.Model.Licenses", b =>
                {
                    b.Property<int>("Licenses_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("per_IDID");

                    b.Property<int?>("user_IDID");

                    b.HasKey("Licenses_ID");

                    b.HasIndex("per_IDID");

                    b.HasIndex("user_IDID");

                    b.ToTable("licenses");
                });

            modelBuilder.Entity("UserPermissionLicensesTask.Model.Permissions", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Permission_Title");

                    b.HasKey("ID");

                    b.ToTable("permissions");
                });

            modelBuilder.Entity("UserPermissionLicensesTask.Model.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("F_Name");

                    b.Property<string>("L_Name");

                    b.HasKey("ID");

                    b.ToTable("users");
                });

            modelBuilder.Entity("UserPermissionLicensesTask.Model.Licenses", b =>
                {
                    b.HasOne("UserPermissionLicensesTask.Model.Permissions", "per_ID")
                        .WithMany()
                        .HasForeignKey("per_IDID");

                    b.HasOne("UserPermissionLicensesTask.Model.Users", "user_ID")
                        .WithMany()
                        .HasForeignKey("user_IDID");
                });
#pragma warning restore 612, 618
        }
    }
}
