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

    public async Task<T> Get(int id)
    {
        return await Query.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<T> GetWithIncludes(int id)
    {
        return await QueryWithIncludes.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IReadOnlyCollection<T>> GetList(IReadOnlyCollection<int> idList)
    {
        return await Query.Where(x => idList.Contains(x.Id)).ToListAsync();
    }

    public async Task<IReadOnlyCollection<T>> GetAll()
    {
        return await QueryWithIncludes.ToListAsync();
    }

    public async Task<T> Add(T entity)
    {
        entity.CreatedOn = DateTime.UtcNow;
        await Collections.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<T> Update(T entity)
    {
        entity.LastModifiedOn = DateTime.UtcNow;
        Collections.Update(entity);
        await _context.SaveChangesAsync();
        _context.Entry(entity).State = EntityState.Detached; // Detach to avoid tracking issues
        return entity;
    }

    public async Task Remove(int id)
    {
        var entity = await Get(id);
        _context.Remove(entity);
    }

    public async Task RemoveRange(IReadOnlyCollection<int> idList)
    {
        var entities = await GetList(idList);
        _context.RemoveRange(entities);
    } 
}
