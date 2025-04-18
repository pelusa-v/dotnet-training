using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SampleUniversityCore.Application.Repositories;
using SampleUniversityCore.Domain.Common;

namespace SampleUniversityCore.Persistence.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    private readonly SampleUniversityDbContext _context;
    public const int _defaultResultsSize = 10;
    public const int _defaultOffset = 0;

    public BaseRepository(SampleUniversityDbContext context)
    {
        _context = context;
    }

    public virtual async Task Create(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public virtual async Task Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public virtual async Task<T?> Get(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public virtual async Task<int> Count(Expression<Func<T, bool>> filter)
    {
        return await _context.Set<T>().Where(filter).CountAsync();
    }

    public virtual async Task<int> Count()
    {
        return await _context.Set<T>().CountAsync();
    }

    public virtual async Task<IEnumerable<T>> List(int resultsSize = _defaultResultsSize, int offset = _defaultOffset)
    {
        return await _context.Set<T>()
            .Skip(offset)
            .Take(resultsSize)
            .ToListAsync();
    }

    public virtual async Task<IEnumerable<T>> List()
    {
        return await _context.Set<T>()
            .ToListAsync();
    }

    public virtual async Task<IEnumerable<T>> Search(Expression<Func<T, bool>> filter, int resultsSize = _defaultResultsSize, int offset = _defaultOffset)
    {
        return await _context.Set<T>()
            .Where(filter)
            .Skip(offset)
            .Take(resultsSize)
            .ToListAsync();
    }

    public virtual async Task Update(T entity)
    {
        entity.UpdatedAt = DateTime.Now;
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public virtual async Task<bool> Exist(Expression<Func<T, bool>> filter)
    {
        return await _context.Set<T>().AnyAsync(filter);
    }

    public virtual async Task<IEnumerable<T>> Search(Expression<Func<T, bool>> filter)
    {
        return await _context.Set<T>()
            .Where(filter)
            .ToListAsync();
    }

    public virtual async Task<T?> Find(Expression<Func<T, bool>> filter)
    {
        return await _context.Set<T>()
            .Where(filter)
            .FirstOrDefaultAsync();
    }
}
