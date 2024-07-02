using HouseRentingSystem.Infrastructer.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Infrastructer.Data.SeedDb
{
    public class HouseConfiguration : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
             builder.HasOne(c => c.Category)
                .WithMany(c => c.Houses)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Agent)
                .WithMany(a => a.Houses)
                .HasForeignKey(f => f.AgentId)
                .OnDelete(DeleteBehavior.Restrict);
            var data = new SeedData();
            builder.HasData(new House[]
            {
                data.ThirdHouse,
                data.SecondHouse,
                data.FirstHouse,
            });

        }
    }
}
