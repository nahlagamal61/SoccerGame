namespace BaseLibrary.Repositories
{
    using BaseLibrary.BaseEntities;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public DbContext DbContext { get; }
        protected readonly DbSet<T> _table;

        public BaseRepository(DbContext dbContext)
        {
            DbContext = dbContext;
            _table = DbContext.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
            var addedEntity = (await _table.AddAsync(entity)).Entity;
            return addedEntity;
        }

        public async Task DeleteAsync(Guid id)
        {
            T entity = await GetByIdAsync(id);

            if (entity != null)
                _table.Remove(entity);

        }

        public async Task<T> EditAsync(T entity)
        {
            var isExist = await _table.AnyAsync(e => e.Id == entity.Id);
            if (!isExist)
                return null;
            return _table.Update(entity).Entity;
        }

        public async Task<List<T>> GetAllAsync() =>
            await _table.ToListAsync();

        public async Task<T> GetByIdAsync(Guid id) =>
            await _table.FirstOrDefaultAsync(t => t.Id == id);



    }
}
