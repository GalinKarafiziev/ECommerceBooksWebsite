

namespace ECommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Manga",
                    Url = "manga"
                },
                new Category
                {
                    Id = 2,
                    Name = "Comics",
                    Url = "comics"
                },
                new Category
                {
                    Id = 3,
                    Name = "Books",
                    Url = "books"
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Attack on Titan, Vol. 1",
                    Description = "Several hundred years ago, humans were almost exterminated by giants. A small percentage of humanity survived by barricading themselves in a city protected by walls even taller than the tallest giants. Now the city has not seen a giant for over 100 years, before Elen and Mikasa witness the walls destruction by a super-giant.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91M9VaZWxOL.jpg",
                    Price = 9.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Kimetsu no Yaiba, Vol. 1",
                    Description = "Learning to destroy demons won’t be easy, and Tanjiro barely knows where to start. The surprise appearance of another boy named Giyu, who seems to know what’s going on, might provide some answers—but only if Tanjiro can stop Giyu from killing his sister first!",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81ZNkhqRvVL.jpg",
                    Price = 9.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Jujutsu Kaisen, Vol. 1",
                    Description = "To gain the power he needs to save his friend from a cursed spirit, Yuji Itadori swallows a piece of a demon, only to find himself caught in the midst of a horrific war of the supernatural!",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51zXJBloNpL._SX331_BO1,204,203,200_.jpg",
                    Price = 9.99m,
                    CategoryId = 1
                }
                );
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
