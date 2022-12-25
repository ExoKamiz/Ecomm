namespace Ecomm.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Products> ProductsC { get; set; }

        //help provide seed data for migrations or seeding a database with data outside of a migration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(
                    new Products
                    {
                        Id = 1,
                        Title = "Uni Pork Pie Wool Hat",
                        Description = "70% wool / 30% polyester. The Pork Pie from Stetson deliberately dispenses with elaborate details.",
                        ImageUrl = "https://hatroom.pl/images/zoom/802970.jpg",
                        Price = 99.99m
                    },
                    new Products
                    {
                        Id = 2,
                        Title = "Chapeau Urban Trilby Grey",
                        Description = "50% wool / 50% polyester. Fully lined. Unisex model.",
                        ImageUrl = "https://www.crafters.fr/images/stories/virtuemart/tt2016/PS_B635_GREY.jpg",
                        Price = 75.5m
                    },
                    new Products
                    {
                        Id = 3,
                        Title = "Chapeau Panama Natural",
                        Description = "89% paper fiber / 11% polyester - 6cm brim - Supplied with removable black fabric strip.",
                        ImageUrl = "https://images.crafters.fr/bo/16951_60b0a8a70fd08_PS_KP068_NATURAL.png",
                        Price = 59.99m
                    }
                );
        }
    }
}
