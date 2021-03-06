// <auto-generated />
using ECommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220331123143_Categories")]
    partial class Categories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ECommerce.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Manga",
                            Url = "manga"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Comics",
                            Url = "comics"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Books",
                            Url = "books"
                        });
                });

            modelBuilder.Entity("ECommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Several hundred years ago, humans were almost exterminated by giants. A small percentage of humanity survived by barricading themselves in a city protected by walls even taller than the tallest giants. Now the city has not seen a giant for over 100 years, before Elen and Mikasa witness the walls destruction by a super-giant.",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91M9VaZWxOL.jpg",
                            Price = 9.99m,
                            Title = "Attack on Titan, Vol. 1"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Learning to destroy demons won’t be easy, and Tanjiro barely knows where to start. The surprise appearance of another boy named Giyu, who seems to know what’s going on, might provide some answers—but only if Tanjiro can stop Giyu from killing his sister first!",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81ZNkhqRvVL.jpg",
                            Price = 9.99m,
                            Title = "Kimetsu no Yaiba, Vol. 1"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "To gain the power he needs to save his friend from a cursed spirit, Yuji Itadori swallows a piece of a demon, only to find himself caught in the midst of a horrific war of the supernatural!",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51zXJBloNpL._SX331_BO1,204,203,200_.jpg",
                            Price = 9.99m,
                            Title = "Jujutsu Kaisen, Vol. 1"
                        });
                });

            modelBuilder.Entity("ECommerce.Shared.Product", b =>
                {
                    b.HasOne("ECommerce.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
