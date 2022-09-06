namespace BaseLibrary.UnitOfWorks
{
    using BaseLibrary.BaseEntities;
    using BaseLibrary.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BaseUnitOfWork<T> : IBaseUnitOfWork<T> where T : BaseEntity
    {
        private readonly IBaseRepository<T> repository;

        public BaseUnitOfWork(IBaseRepository<T> repository )
        {
            this.repository = repository;
        }

        public async Task<T> CreateAsync(T entity)
        {
            await repository.AddAsync(entity);
            repository.DbContext.SaveChanges();
            return entity;
        }
        public async Task DeleteAsync(Guid id) {
            await repository.DeleteAsync(id);
            repository.DbContext.SaveChanges();        
        }

        public async Task<List<T>> ReadAsync() =>
            await repository.GetAllAsync();

        public async Task<T> ReadByIdAsync(Guid id) =>
           await repository.GetByIdAsync(id);

        public Task<T> UpdateAsync(T entity)
        {
            var editedEntity = repository.EditAsync(entity);
            repository.DbContext.SaveChanges();
            return editedEntity;
        }


    }
}
