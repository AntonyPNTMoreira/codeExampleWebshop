using Howest.DeVarens.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Howest.DeVarens.Web.Data.Seeding
{
    public class Seeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category()
               {
                   Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                   Name = "Houtbewerking",
                   Description = "Het maken van figuren in hout.",
                   CreationDate = DateTime.Now
               },
                new Category()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "Schilderen",
                    Description = "Kunst door middel van verf op canvas.",
                    CreationDate = DateTime.Now
                },
                new Category()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "Metaalbewerking",
                    Description = "Het bijeenlassen van metalen onderdelen.",
                    CreationDate = DateTime.Now
                }
            );

            modelBuilder.Entity<FormOfEducation>().HasData(
                new FormOfEducation()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "Opleidingsvorm 1",
                    Description = "Opleidingsvorm 1 richt zich op jongeren met een matige" +
                    " tot ernstige verstandelijke beperking (type 2)," +
                    " al dan niet gecombineerd met een motorische beperking (type 4).",
                    DisplayOrder = 1,
                    CreationDate = DateTime.Now
                },
                new FormOfEducation()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "Opleidingsvorm 2",
                    Description = "Opleidingsvorm 2 geeft een algemene en sociale vorming" +
                    " en een arbeidstraining met het oog op de integratie in een beschermd" +
                    " arbeids- en werkmilieu (maatwerkbedrijf).",
                    DisplayOrder = 2,
                    CreationDate = DateTime.Now
                },
                new FormOfEducation()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "Opleidingsvorm 3",
                    Description = "In opleidingsvorm 3 krijgen de leerlingen een algemene," +
                    " sociale en beroepsgerichte vorming met als einddoel een tewerkstelling" +
                    " in het gewone arbeidsmilieu. Dit voor leerlingen" +
                    " met type basisaanbod, 3, 4 en 9.",
                    DisplayOrder = 3,
                    CreationDate = DateTime.Now
                },
                new FormOfEducation()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Name = "Opleidingsvorm 4",
                    Description = "Opleidingsvorm 4 behandelt de leerstof en eindtermen" +
                    " van het gewoon onderwijs," +
                    " mét omkadering van buitengewoon onderwijs.",
                    DisplayOrder = 4,
                    CreationDate = DateTime.Now
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product() 
                { 
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "Ironman",
                    Price = 16.99M,
                    Description = "Dit is de geweldige Ironman.",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    FormOfEducationId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    CreationDate = DateTime.Now
                },
                new Product()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "Dinosaurus",
                    Price = 79.99M,
                    Description = "Dit is een grote dinosaurus.",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    FormOfEducationId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    CreationDate = DateTime.Now
                },
                new Product()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "Houten kunstwerk",
                    Price = 29.99M,
                    Description = "Dit is een houten kunstwerk.",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    FormOfEducationId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    CreationDate = DateTime.Now
                },
                new Product()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Name = "Schilderij",
                    Price = 199.99M,
                    Description = "Dit is een schilderij.",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    FormOfEducationId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    CreationDate = DateTime.Now
                }
            );

            modelBuilder.Entity<Media>().HasData(
                new Media()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Title = "Ironman",
                    Path = "ironman.png",
                    ProductId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    CreationDate = DateTime.Now
                },
                new Media()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Title = "Dinosaurus",
                    Path = "dinosaurus.jpg",
                    ProductId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    CreationDate = DateTime.Now
                },
                new Media()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Title = "Hout",
                    Path = "hout.jpg",
                    ProductId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    CreationDate = DateTime.Now
                },
                new Media()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Title = "Hout",
                    Path = "hout2.jpg",
                    ProductId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    CreationDate = DateTime.Now
                },
                new Media()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Title = "Schilderij",
                    Path = "schilderij.jpg",
                    ProductId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    CreationDate = DateTime.Now
                }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order()
                {
                    Id= Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    ShippingDate = null,
                    IsOpen = true,
                    CreationDate = DateTime.Now

                },
                new Order()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    ShippingDate = new DateTime(2022, 6, 6),
                    IsOpen = false,
                    CreationDate = DateTime.Now
                }
            );

            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    OrderId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Quantity = 1,
                    ProductId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    ProductPrice = 16.99M,
                    CreationDate = DateTime.Now
                },
                new OrderItem()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    OrderId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Quantity = 3,
                    ProductId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    ProductPrice = 79.99M,
                    CreationDate = DateTime.Now
                },
                new OrderItem()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    OrderId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Quantity = 2,
                    ProductId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    ProductPrice = 29.99M,
                    CreationDate = DateTime.Now
                }
            );
        }

    }
}
