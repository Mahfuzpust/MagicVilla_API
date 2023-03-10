// <auto-generated />
using System;
using MagicVilla_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230201132753_AddVillaNumber")]
    partial class AddVillaNumber
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_API.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ocupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreateDate = new DateTime(2023, 2, 1, 19, 27, 53, 231, DateTimeKind.Local).AddTicks(1135),
                            Details = "As we all know, a paragraph is a",
                            ImgUrl = "https://www.google.com/search?q=jpg+image&rlz=1C1BNSD_en&oq=jpg+image&aqs=chrome..69i57j0i512l9.12808j0j7&sourceid=chrome&ie=UTF-8#imgrc=McVf5uszvVk5SM",
                            Name = "White Villa",
                            Ocupancy = 550,
                            Rate = 10.0,
                            Sqft = 50,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreateDate = new DateTime(2023, 2, 1, 19, 27, 53, 231, DateTimeKind.Local).AddTicks(1145),
                            Details = " for better understanding, and to make a",
                            ImgUrl = "https://www.google.com/search?q=jpg+image&rlz=1C1BNSD_en&oq=jpg+image&aqs=chrome..69i57j0i512l9.12808j0j7&sourceid=chrome&ie=UTF-8#imgrc=ShQnriFk8AK93M",
                            Name = "new to Villa",
                            Ocupancy = 500,
                            Rate = 0.0,
                            Sqft = 500,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreateDate = new DateTime(2023, 2, 1, 19, 27, 53, 231, DateTimeKind.Local).AddTicks(1147),
                            Details = "As we all know, a paragraph is a",
                            ImgUrl = "https://www.google.com/search?q=jpg+image&rlz=1C1BNSD_en&oq=jpg+image&aqs=chrome..69i57j0i512l9.12808j0j7&sourceid=chrome&ie=UTF-8#imgrc=V-JSYbzQMO6IvM",
                            Name = "Master Villa",
                            Ocupancy = 550,
                            Rate = 15.0,
                            Sqft = 55,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreateDate = new DateTime(2023, 2, 1, 19, 27, 53, 231, DateTimeKind.Local).AddTicks(1148),
                            Details = "As we all know, a paragraph is a",
                            ImgUrl = "https://www.google.com/search?q=jpg+image&rlz=1C1BNSD_en&oq=jpg+image&aqs=chrome..69i57j0i512l9.12808j0j7&sourceid=chrome&ie=UTF-8#imgrc=4_CKrxwlMJxE5M",
                            Name = "Gren Villa",
                            Ocupancy = 100,
                            Rate = 70.0,
                            Sqft = 10,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreateDate = new DateTime(2023, 2, 1, 19, 27, 53, 231, DateTimeKind.Local).AddTicks(1150),
                            Details = "As we all know, a paragraph is a",
                            ImgUrl = "https://www.google.com/search?q=jpg+image&rlz=1C1BNSD_en&oq=jpg+image&aqs=chrome..69i57j0i512l9.12808j0j7&sourceid=chrome&ie=UTF-8#imgrc=hTEa-1tbJvTjZM",
                            Name = "Diamond Villa",
                            Ocupancy = 100,
                            Rate = 40.0,
                            Sqft = 45,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MagicVilla_API.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("VillaNo");

                    b.ToTable("VillaNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}
