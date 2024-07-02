using HouseRentingSystem.Infrastructer.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Infrastructer.Data.SeedDb
{
    public class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            var data = new SeedData();
            builder.HasData(new Agent[]
            {
                data.Agent
            });
        }
    }
}
