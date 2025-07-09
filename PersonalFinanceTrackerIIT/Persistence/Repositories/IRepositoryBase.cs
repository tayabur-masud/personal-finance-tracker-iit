using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Persistence.Repositories;

public interface IRepositoryBase<T> where T : BaseEntity
{
    T Get(int id);

    T GetWithIncludes(int id);

    IReadOnlyCollection<T> GetList(IReadOnlyCollection<int> idList);

    IReadOnlyCollection<T> GetAll();

    T Add(T entity);

    T Update(T entity);

    void Remove(int id);

    void RemoveRange(IReadOnlyCollection<int> idList);
}
