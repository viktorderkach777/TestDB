﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestDB;

namespace TestDB.Migrations
{
    [DbContext(typeof(reactBdNewContext))]
    [Migration("20190801104257_viktordb3")]
    partial class viktordb3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("TestDB.AspNetRoleClaims", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("TestDB.AspNetRoles", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("(\"NormalizedName\" IS NOT NULL)");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("TestDB.AspNetUserClaims", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("TestDB.AspNetUserLogins", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("TestDB.AspNetUserRoles", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("TestDB.AspNetUserTokens", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TestDB.AspNetUsers", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AvatarUrl")
                        .HasColumnName("AvatarURL");

                    b.Property<DateTime?>("BirthDate");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecondName");

                    b.Property<string>("SecurityStamp");

                    b.Property<DateTime?>("SignUpTime");

                    b.Property<string>("ThirdName");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("(\"NormalizedUserName\" IS NOT NULL)");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("TestDB.Comments", b =>
                {
                    b.Property<string>("Id");

                    b.Property<DateTime>("CreatingDate");

                    b.Property<string>("HotelId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("Message")
                        .IsRequired();

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TestDB.Countries", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("TestDB.HotelImages", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("HotelId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("HotelImageUrl");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelImages");
                });

            modelBuilder.Entity("TestDB.HotelParameters", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Description");

                    b.Property<string>("HotelId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelParameters");
                });

            modelBuilder.Entity("TestDB.HotelSubParameters", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("HotelParameterId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<bool?>("IsFree");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("HotelParameterId");

                    b.ToTable("HotelSubParameters");
                });

            modelBuilder.Entity("TestDB.Hotels", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal?>("Price")
                        .HasColumnType("money");

                    b.Property<double?>("Rate");

                    b.Property<string>("RegionId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<int?>("RoomsCount");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("TestDB.Orders", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("TourId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TestDB.Regions", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("CountryId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("TestDB.Tours", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int?>("DaysCount");

                    b.Property<DateTime?>("FromData");

                    b.Property<string>("HotelId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<decimal?>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Tours");
                });

            modelBuilder.Entity("TestDB.AspNetRoleClaims", b =>
                {
                    b.HasOne("TestDB.AspNetRoles", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TestDB.AspNetUserClaims", b =>
                {
                    b.HasOne("TestDB.AspNetUsers", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TestDB.AspNetUserLogins", b =>
                {
                    b.HasOne("TestDB.AspNetUsers", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TestDB.AspNetUserRoles", b =>
                {
                    b.HasOne("TestDB.AspNetRoles", "Role")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TestDB.AspNetUsers", "User")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TestDB.AspNetUserTokens", b =>
                {
                    b.HasOne("TestDB.AspNetUsers", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TestDB.Comments", b =>
                {
                    b.HasOne("TestDB.Hotels", "Hotel")
                        .WithMany("Comments")
                        .HasForeignKey("HotelId")
                        .HasConstraintName("FK_Comments_Hotels");

                    b.HasOne("TestDB.AspNetUsers", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Comments_AspNetUsers");
                });

            modelBuilder.Entity("TestDB.HotelImages", b =>
                {
                    b.HasOne("TestDB.Hotels", "Hotel")
                        .WithMany("HotelImages")
                        .HasForeignKey("HotelId")
                        .HasConstraintName("FK_HotelImages_Hotels");
                });

            modelBuilder.Entity("TestDB.HotelParameters", b =>
                {
                    b.HasOne("TestDB.Hotels", "Hotel")
                        .WithMany("HotelParameters")
                        .HasForeignKey("HotelId")
                        .HasConstraintName("FK_HotelParameters_Hotels");
                });

            modelBuilder.Entity("TestDB.HotelSubParameters", b =>
                {
                    b.HasOne("TestDB.HotelParameters", "HotelParameter")
                        .WithMany("HotelSubParameters")
                        .HasForeignKey("HotelParameterId")
                        .HasConstraintName("FK_HotelSubParameters_HotelParameters");
                });

            modelBuilder.Entity("TestDB.Hotels", b =>
                {
                    b.HasOne("TestDB.Regions", "Region")
                        .WithMany("Hotels")
                        .HasForeignKey("RegionId")
                        .HasConstraintName("FK_Hotels_Regions");
                });

            modelBuilder.Entity("TestDB.Orders", b =>
                {
                    b.HasOne("TestDB.Tours", "Tour")
                        .WithMany("Orders")
                        .HasForeignKey("TourId")
                        .HasConstraintName("FK_Orders_Tours");

                    b.HasOne("TestDB.AspNetUsers", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Orders_AspNetUsers");
                });

            modelBuilder.Entity("TestDB.Regions", b =>
                {
                    b.HasOne("TestDB.Countries", "Country")
                        .WithMany("Regions")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK_Regions_Countries");
                });

            modelBuilder.Entity("TestDB.Tours", b =>
                {
                    b.HasOne("TestDB.Hotels", "Hotel")
                        .WithMany("Tours")
                        .HasForeignKey("HotelId")
                        .HasConstraintName("FK_Tours_Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}
