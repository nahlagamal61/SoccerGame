namespace BaseLibrary.Repositories
{
    using BaseLibrary.BaseEntities;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBaseRepository<T> where T : BaseEntity
    {
        public DbContext DbContext { get; }
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
        Task<T> EditAsync(T entity);
        Task DeleteAsync(Guid id);
    }
}
