using BlazorApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp.Server.Configurations
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                 new Customer
                 {
                     Id = new Guid("4832b897-b0d4-48ad-83cd-791fccfd6110"),
                     CompanyName = "Hp",
                     ContactName = "Fotis",
                     Address = "Random st 123",
                     City = "Volos",
                     Region = "Magn",
                     PostalCode = "12345",
                     Country = "Greece",
                     Phone = "695 123 1234"
                 },

                new Customer
                {
                    Id = new Guid("4832b897-b0d4-48ad-83cd-791fccfd6112"),
                    CompanyName = "Asus",
                    ContactName = "Giannis",
                    Address = "Random st 13",
                    City = "Volos",
                    Region = "Magn",
                    PostalCode = "12345",
                    Country = "Greece",
                    Phone = "695 123 1235"
                },
                 new Customer
                 {
                     Id = new Guid("4832b897-b0d4-48ad-83cd-791fccfd6410"),
                     CompanyName = "NoCompny",
                     ContactName = "tasos",
                     Address = "Random st 124",
                     City = "Volos",
                     Region = "Magn",
                     PostalCode = "12345",
                     Country = "Greece",
                     Phone = "695 123 1224"
                 }
                );
        }
    }
}
