namespace HouseRentingSystem.Infrastructer.Comman
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class;
        IQueryable<T> AllReadOnly<T>() where T : class;

    }
}
