namespace Ecomm.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Products> ProductsC { get; set; }
        public DbSet<Category> CategorysC { get; set; }

        //help provide seed data for migrations or seeding a database with data outside of a migration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                { 
                    Id = 1,
                    Name = "Hat",
                    Url = "hat"
                },
                new Category
                {
                    Id = 2,
                    Name = "Cap",
                    Url = "cap"
                },
                new Category
                {
                    Id = 3,
                    Name = "Balaclava",
                    Url = "balaclava"
                }
                );

            modelBuilder.Entity<Products>().HasData(
                    new Products
                    {
                        Id = 1,
                        Title = "Uni Pork Pie Wool Hat",
                        Description = "70% wool / 30% polyester. The Pork Pie from Stetson deliberately dispenses with elaborate details.",
                        ImageUrl = "https://hatroom.pl/images/zoom/802970.jpg",
                        Price = 99.99m,
                        CategoryId = 1
                    },
                    new Products
                    {
                        Id = 2,
                        Title = "Chapeau Urban Trilby Grey",
                        Description = "50% wool / 50% polyester. Fully lined. Unisex model.",
                        ImageUrl = "https://www.crafters.fr/images/stories/virtuemart/tt2016/PS_B635_GREY.jpg",
                        Price = 75.5m,
                        CategoryId = 1
                    },
                    new Products
                    {
                        Id = 3,
                        Title = "Chapeau Panama Natural",
                        Description = "89% paper fiber / 11% polyester - 6cm brim - Supplied with removable black fabric strip.",
                        ImageUrl = "https://images.crafters.fr/bo/16951_60b0a8a70fd08_PS_KP068_NATURAL.png",
                        Price = 59.99m,
                        CategoryId = 1
                    },
                    new Products
                    {
                        Id=4,
                        Title = "Baseline Hemp",
                        Description = "Warm evenings, ice cream and a baseball cap. And there goes summer! Go for a workout in the sunshine while wearing your adidas cap. AEROREADY wicks away sweat, keeping you feeling fresh on the pitch. The curved visor protects your eyes and the 3 stripes emphasise the sporty character. This product is made from Primegreen, a line of high-quality recycled materials.",
                        ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQE2qQNtsSrONpGXAw7D5I_1zT7Tflso4MGVhTYzgAM4bvMD56OC1i4rCktunQC2wmo9-Q&usqp=CAU",
                        Price = 112.99m,
                        CategoryId = 2
                    },
                    new Products
                    {
                        Id = 5,
                        Title = "Bontrager Thermal",
                        Description = "Lower your head and keep pedaling through chilly weather. The Thermal Cycling Cap is an essential piece of cold weather cycling gear. Packed with the versatility of a visor and ear flaps, this cap features thermal fabric to keep you riding in the great outdoors all year long.",
                        ImageUrl = "https://trek.scene7.com/is/image/TrekBicycleProducts/ThermalCyclingCap_25037_A_Primary?$responsive-pjpg$&cache=on,on&wid=1920&hei=1440",
                        Price = 39.99m,
                        CategoryId = 2
                    },
                    new Products
                    {
                        Id = 6,
                        Title = "Polo Ralph Lauren",
                        Description = "Cap is made from 100% cotton with a contemporary style and includes a Rip-strap size adjuster. A comfortable and stylish cap that is available in various colours.",
                        ImageUrl = "https://futbokraina.com.ua/image/cache/new/catalog/GS/kepki/black-63745.webp",
                        Price = 200m,
                        CategoryId = 2
                    },
                    new Products
                    {
                        Id = 7,
                        Title = "Horn Decor",
                        Description = "A unique balaclava specially designed for winter sports. Made with flat seam technology, it will ensure comfort even during long hours of use. The ergonomic cut created separately for men and women ensures a better fit of the balaclava to the face. ",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2022/09/09/1662702772ca0fdc2c0a9f9aefc547f60ea2c8582c_thumbnail_600x.webp",
                        Price = 99.99m,
                        CategoryId = 3
                    },
                    new Products
                    {
                        Id = 8,
                        Title = "Gang Bang Balaclava",
                        Description = "Provide a great protection for your face,ear and neck in the bad weather. Good for bicycle riding,skiing, or other outdoor sports. Soft and comfortable. Breathable material allows easy breath but ultra protection ldeal for the use when riding,skiing, and other outdoor sports.",
                        ImageUrl = "https://cdn.shopify.com/s/files/1/0634/1335/4713/products/Funny-Knitted-Face-Mask_1_900x.jpg?v=1666779905",
                        Price = 70m,
                        CategoryId = 3
                    }
                );
        }
    }
}
