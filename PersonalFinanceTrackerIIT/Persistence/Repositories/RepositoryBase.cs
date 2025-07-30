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
        return await Query.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<T> GetWithIncludes(int id)
    {
        return await QueryWithIncludes.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IReadOnlyCollection<T>> GetList(IReadOnlyCollection<int> idList)
    {
        return await Query.AsNoTracking().Where(x => idList.Contains(x.Id)).ToListAsync();
    }

    public async Task<IReadOnlyCollection<T>> GetAll()
    {
        return await QueryWithIncludes.AsNoTracking().ToListAsync();
    }

    public async Task<T> Add(T entity)
    {
        entity.CreatedOn = DateTime.Now;
        await Collections.AddAsync(entity);
        await _context.SaveChangesAsync();
        _context.Entry(entity).State = EntityState.Detached;
        return entity;
    }

    public async Task<T> Update(T entity)
    {
        entity.LastModifiedOn = DateTime.Now;

        var trackedEntity = _context.ChangeTracker.Entries<T>()
            .FirstOrDefault(e => e.Entity.Equals(entity));

        if (trackedEntity == null)
        {
            Collections.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        else
        {
            trackedEntity.CurrentValues.SetValues(entity);
        }

        await _context.SaveChangesAsync();

        _context.Entry(entity).State = EntityState.Detached;

        return entity;
    }

    public async Task Remove(int id)
    {
        var entity = await Get(id);
        _context.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveRange(IReadOnlyCollection<int> idList)
    {
        var entities = await GetList(idList);
        _context.RemoveRange(entities);
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
