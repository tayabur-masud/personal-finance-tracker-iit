using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Persistence.Repositories;

public interface IRepositoryBase<T> where T : BaseEntity
{
    Task<T> Get(int id);

    Task<T> GetWithIncludes(int id);

    Task<IReadOnlyCollection<T>> GetList(IReadOnlyCollection<int> idList);

    Task<IReadOnlyCollection<T>> GetAll();

    Task<T> Add(T entity);

    Task<T> Update(T entity);

    Task Remove(int id);

    Task RemoveRange(IReadOnlyCollection<int> idList);
}
