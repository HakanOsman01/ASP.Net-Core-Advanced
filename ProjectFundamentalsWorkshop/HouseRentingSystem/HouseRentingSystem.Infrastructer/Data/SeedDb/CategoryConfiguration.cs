using HouseRentingSystem.Infrastructer.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace HouseRentingSystem.Infrastructer.Data.SeedDb
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var data = new SeedData();
            builder.HasData(new Category[]
            {
                data.SingleCategory,
                data.DuplexCategory,
                data.CottageCategory
            });

        }
    }
}
