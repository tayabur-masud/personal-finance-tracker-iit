using Microsoft.EntityFrameworkCore;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Persistence.Repositories;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
{
    private readonly ApplicationDbContext _context;

    protected RepositoryBase(ApplicationDbContext context)
    {
        _context = context;
    }

    private DbSet<T> Collections => _context.Set<T>();

    protected IQueryable<T> Query => _context.Set<T>().AsQueryable();

    protected virtual IQueryable<T> QueryWithIncludes => Query;

    public T Get(int id)
    {
        return Query.FirstOrDefault(x => x.Id == id);
    }

    public T GetWithIncludes(int id)
    {
        return QueryWithIncludes.FirstOrDefault(x => x.Id == id);
    }

    public IReadOnlyCollection<T> GetList(IReadOnlyCollection<int> idList)
    {
        return Query.Where(x => idList.Contains(x.Id)).ToList();
    }

    public IReadOnlyCollection<T> GetAll()
    {
        return QueryWithIncludes.ToList();
    }

    public T Add(T entity)
    {
        entity.CreatedOn = DateTime.UtcNow;
        Collections.Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public T Update(T entity)
    {
        entity.LastModifiedOn = DateTime.UtcNow;
        Collections.Update(entity);
        _context.SaveChanges();
        return entity;
    }

    public void Remove(int id)
    {
        var entity = Get(id);
        _context.Remove(entity);
    }

    public void RemoveRange(IReadOnlyCollection<int> idList)
    {
        var entities = GetList(idList);
        _context.RemoveRange(entities);
    } 
}
