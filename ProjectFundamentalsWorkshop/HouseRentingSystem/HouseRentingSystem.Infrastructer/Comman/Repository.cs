using HouseRentingSystem.Infrastructer.Data;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Infrastructer.Comman
{
    public class Repository : IRepository
    {
        private readonly DbContext dbContext;
        public Repository(HouseRentingDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        private DbSet<T> DbSet<T>() where T : class 
        {
            return dbContext.Set<T>();
        }
        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>();

        }

        public IQueryable<T> AllReadOnly<T>() where T : class
        {
            return DbSet<T>()
                .AsNoTracking();
        }
    }
}
